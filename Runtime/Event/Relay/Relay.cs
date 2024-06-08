/*
 * ######################################################################################
 * #                   Relay: Fast, light, GC-friendly signals/events.                  #
 * #                     (c) 2017-2019 Luke Thompson / Sigtrap Games                    #
 * #    Provided under MIT License. No warranty, it's all your own fault, blah blah.    #
 * #                   @six_ways    @sigtrapgames    github.com/sixways                 #
 * ######################################################################################
 *
 * ### Adding/removing listeners DURING DISPATCH: #######################################
 * #  Relay r;
 * #  r.AddListener(B);
 * #  A(){}
 * #  B(){
 * #    r.RemoveListener(B);     // [1] Fine
 * #    r.AddListener(A);        // [2] Fine
 * #    r.RemoveListener(A);     // [3] Bad
 * #    r.RemoveAll();           // [4] Bad
 * #  }
 * #
 * #  [1] A listener can safely REMOVE ITSELF from the Relay calling it.
 * #  [2] A listener can safely ADD NEW LISTENERS to the Relay calling it.
 * #         > New listeners will NOT be called until the next Dispatch.
 * #  [3] A listener should NOT REMOVE OTHER LISTENERS from the Relay calling it.
 * #  [4] A listener should NOT REMOVE ALL LISTENERS from the Relay calling it.
 * ######################################################################################
 *
 * ### Dispatch execution order: ########################################################
 * #  RELYNG ON DISPATCH ORDER WITH ANY EVENT SYSTEM IS AN ANTI-PATTERN!
 * #  Dispatch will be LIFO (i.e. in reverse) if the above rules are followed.
 * #    This is to allow:
 * #      > listener self-removal during dispatch without iterator skipping next listener
 * #      > addition of new listeners during dispatch without firing new listener
 * ######################################################################################
 */

using System;
using System.Collections.Generic;
using UnityEngine;

namespace AIO.UEngine
{
    /// <summary>
    /// 侦听器链接基类。
    /// </summary>
    /// <typeparam name="TDelegate"> 侦听器委托类型。 </typeparam>
    public abstract class RelayBase<TDelegate> : IRelayLinkBase<TDelegate>
    where TDelegate : class
    {
        protected static readonly IndexOutOfRangeException IndexOutError = new IndexOutOfRangeException
            ($"{typeof(RelayBase<TDelegate>).FullName} Fewer listeners than expected. See guidelines in Relay.cs on using RemoveListener and RemoveAll within Relay listeners.");

        /// <inheritdoc />
        public uint ListenerCount => _Count;

        /// <inheritdoc />
        public uint OneTimeListenersCount => _OnceCount;

        /// <summary>
        /// 是否有链接。
        /// </summary>
        protected bool HasLink = false;

        /// <summary>
        /// 持久监听器数组。
        /// </summary>
        protected TDelegate[] _Listeners = new TDelegate[1];

        protected uint _Count;
        protected uint _Cap = 1;

        /// <summary>
        /// 一次性监听器数组。
        /// </summary>
        protected TDelegate[] _ListenersOnce;

        protected uint _OnceCount;
        protected uint _OnceCap;

        #region Error

        /// <inheritdoc />
        public bool Contains(TDelegate listener, object caller) { return false; }

        /// <inheritdoc />
        public bool AddListener(TDelegate listener, object caller, bool allowDuplicates = false) { return false; }

        /// <inheritdoc />
        public IRelayBinding BindListener(TDelegate listener, object caller, bool allowDuplicates = false) => AddListener(listener, caller, allowDuplicates)
            ? new RelayBinding<TDelegate>(this, listener, caller, allowDuplicates, true)
            : null;

        /// <inheritdoc />
        public bool AddOnce(TDelegate listener, object caller, bool allowDuplicates = false) { throw new NotImplementedException(); }

        /// <inheritdoc />
        public bool RemoveListener(TDelegate listener, object caller) { throw new NotImplementedException(); }

        /// <inheritdoc />
        public bool RemoveOnce(TDelegate listener, object caller) { throw new NotImplementedException(); }

        /// <inheritdoc />
        public void RemoveAll(object caller, bool persistent = true, bool oneTime = true) { throw new NotImplementedException(); }

        #endregion

        #region API

        /// <inheritdoc />
        public bool Contains(TDelegate listener) => Contains(_Listeners, _Count, listener);

        /// <inheritdoc />
        public bool AddListener(TDelegate listener, bool allowDuplicates = false)
        {
            if (!allowDuplicates && Contains(_Listeners, _Count, listener)) return false;
            if (_Count == _Cap)
            {
                _Cap       *= 2;
                _Listeners =  Expand(_Listeners, _Cap, _Count);
            }

            _Listeners[_Count++] = listener;
            return true;
        }

        /// <inheritdoc />
        public IRelayBinding BindListener(TDelegate listener, bool allowDuplicates = false) => AddListener(listener, allowDuplicates)
            ? new RelayBinding<TDelegate>(this, listener, allowDuplicates, true)
            : null;

        /// <inheritdoc />
        public bool AddOnce(TDelegate listener, bool allowDuplicates = false)
        {
            if (!allowDuplicates && Contains(_ListenersOnce, _OnceCount, listener)) return false;
            if (_OnceCount == _OnceCap)
            {
                if (_OnceCap == 0) _OnceCap =  1;
                else _OnceCap               *= 2;
                _ListenersOnce = Expand(_ListenersOnce, _OnceCap, _OnceCount);
            }

            _ListenersOnce[_OnceCount] = listener;
            ++_OnceCount;
            return true;
        }

        /// <inheritdoc />
        public bool RemoveListener(TDelegate listener)
        {
            bool result = false;
            for (uint i = 0; i < _Count; ++i)
            {
                if (_Listeners[i].Equals(listener))
                {
                    RemoveAt(i);
                    result = true;
                    break;
                }
            }

            return result;
        }

        /// <inheritdoc />
        public bool RemoveOnce(TDelegate listener)
        {
            var result = false;
            for (uint i = 0; i < _OnceCount; ++i)
            {
                if (_ListenersOnce[i].Equals(listener))
                {
                    RemoveOnceAt(i);
                    result = true;
                    break;
                }
            }

            return result;
        }

        /// <inheritdoc />
        public void RemoveAll(bool persistent = true, bool oneTime = true)
        {
            if (persistent)
            { // 没有计数检查，因为数组始终存在，RemoveAll 预期用户知道有侦听器

                Array.Clear(_Listeners, 0, (int)_Cap);
                _Count = 0;
            }

            if (!oneTime || _OnceCount <= 0) return; // 计数检查，因为数组延迟实例化
            Array.Clear(_ListenersOnce, 0, (int)_OnceCap);
            _OnceCount = 0;
        }

        #endregion

        #region Internal

        protected void RemoveAt(uint i) => _Count = RemoveAt(_Listeners, _Count, i);

        protected void RemoveOnceAt(uint i) => _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i);

        protected static uint RemoveAt(TDelegate[] arr, uint count, uint i)
        {
            --count;
            for (var j = i; j < count; ++j)
            {
                arr[j] = arr[j + 1];
            }

            arr[count] = null;
            return count;
        }

        private static bool Contains(IReadOnlyList<TDelegate> arr, uint c, TDelegate d)
        {
            for (var i = 0; i < c; ++i)
            {
                if (!arr[i].Equals(d)) continue;
#if UNITY_EDITOR
                Debug.LogWarning($"RelayBase<{typeof(TDelegate).FullName}>.Contains: Listener already exists in Relay: {d}");
#endif
                return true;
            }

            return false;
        }

        private static TDelegate[] Expand(IReadOnlyList<TDelegate> arr, uint cap, uint count)
        {
            var newArr = new TDelegate[cap];
            for (var i = 0; i < count; ++i)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        }

        #endregion
    }
}