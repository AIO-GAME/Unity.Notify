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
        public uint ListenerCount => Count;

        /// <inheritdoc />
        public uint OneTimeListenersCount => OnceCount;

        /// <summary>
        /// 是否有链接。
        /// </summary>
        protected bool HasLink = false;

        /// <summary>
        /// 持久监听器数组。
        /// </summary>
        protected TDelegate[] Listeners;

        /// <summary>
        /// 持久监听器数量。
        /// </summary>
        protected uint Count;

        /// <summary>
        /// 持久监听器容量。
        /// </summary>
        protected uint Cap = 1;

        /// <summary>
        /// 一次性监听器数组。
        /// </summary>
        protected TDelegate[] ListenersOnce;

        /// <summary>
        /// 一次性监听器数量。
        /// </summary>
        protected uint OnceCount;

        /// <summary>
        ///  一次性监听器容量。
        /// </summary>
        protected uint OnceCap;

        private Dictionary<object, IList<TDelegate>> ListenersByCaller;

        public RelayBase()
        {
            ListenersByCaller = new Dictionary<object, IList<TDelegate>>();
            ListenersOnce     = Array.Empty<TDelegate>();
            Listeners         = new TDelegate[1];
        }

        #region Error

        /// <inheritdoc />
        public bool Contains(TDelegate listener, object caller)
        {
            if (caller != null) return ListenersByCaller.TryGetValue(caller, out var list) && list.Contains(listener);
#if UNITY_EDITOR
            Debug.LogError($"RelayBase<{typeof(TDelegate).FullName}>.AddListener: Caller cannot be null.");
#endif
            return false;
        }

        /// <inheritdoc />
        public bool AddListener(TDelegate listener, object caller, bool allowDuplicates = false)
        {
            if (caller == null)
            {
#if UNITY_EDITOR
                Debug.LogError($"RelayBase<{typeof(TDelegate).FullName}>.AddListener: Caller cannot be null.");
#endif
                return false;
            }

            if (!AddListener(listener, allowDuplicates)) return false;
            if (!ListenersByCaller.TryGetValue(caller, out var list))
            {
                list                      = new List<TDelegate>();
                ListenersByCaller[caller] = list;
            }

            list.Add(listener);
            return true;
        }

        /// <inheritdoc />
        public IRelayBinding BindListener(TDelegate listener, object caller, bool allowDuplicates = false) => AddListener(listener, caller, allowDuplicates)
            ? new RelayBinding<TDelegate>(this, listener, caller, allowDuplicates, true)
            : null;

        /// <inheritdoc />
        public bool AddOnce(TDelegate listener, object caller, bool allowDuplicates = false)
        {
            if (caller == null)
            {
#if UNITY_EDITOR
                Debug.LogError($"RelayBase<{typeof(TDelegate).FullName}>.AddOnce: Caller cannot be null.");
#endif
                return false;
            }

            if (!AddOnce(listener, allowDuplicates)) return false;
            if (!ListenersByCaller.TryGetValue(caller, out var list))
            {
                list                      = new List<TDelegate>();
                ListenersByCaller[caller] = list;
            }

            list.Add(listener);
            return true;
        }

        /// <inheritdoc />
        public bool RemoveListener(TDelegate listener, object caller)
        {
            if (caller == null)
            {
#if UNITY_EDITOR
                Debug.LogError($"RelayBase<{typeof(TDelegate).FullName}>.RemoveListener: Caller cannot be null.");
#endif
                return false;
            }

            if (!ListenersByCaller.TryGetValue(caller, out var list)) return false;
            if (!list.Remove(listener)) return false;
            if (list.Count == 0) ListenersByCaller.Remove(caller);
            return RemoveListener(listener);
        }

        /// <inheritdoc />
        public bool RemoveOnce(TDelegate listener, object caller)
        {
            if (caller == null)
            {
#if UNITY_EDITOR
                Debug.LogError($"RelayBase<{typeof(TDelegate).FullName}>.RemoveOnce: Caller cannot be null.");
#endif
                return false;
            }

            if (!ListenersByCaller.TryGetValue(caller, out var list)) return false;
            if (!list.Remove(listener)) return false;
            if (list.Count == 0) ListenersByCaller.Remove(caller);
            return RemoveOnce(listener);
        }

        /// <inheritdoc />
        public void RemoveAll(object caller, bool persistent = true, bool oneTime = true)
        {
            if (caller == null)
            {
#if UNITY_EDITOR
                Debug.LogError($"RelayBase<{typeof(TDelegate).FullName}>.RemoveAll: Caller cannot be null.");
#endif
                return;
            }

            if (!ListenersByCaller.TryGetValue(caller, out var list)) return;

            if (persistent)
            {
                foreach (var item in list) RemoveListener(item);
            }

            if (oneTime && OnceCount > 0)
            {
                foreach (var item in list) RemoveOnce(item);
            }

            if (persistent && oneTime && OnceCount > 0)
            {
                list.Clear();
                ListenersByCaller.Remove(caller);
            }
        }

        #endregion

        #region API

        /// <inheritdoc />
        public bool Contains(TDelegate listener) => Contains(Listeners, Count, listener);

        /// <inheritdoc />
        public bool AddListener(TDelegate listener, bool allowDuplicates = false)
        {
            if (!allowDuplicates && Contains(Listeners, Count, listener)) return false;
            if (Count == Cap)
            {
                Cap       *= 2;
                Listeners =  Expand(Listeners, Cap, Count);
            }

            Listeners[Count++] = listener;
            return true;
        }

        /// <inheritdoc />
        public IRelayBinding BindListener(TDelegate listener, bool allowDuplicates = false) => AddListener(listener, allowDuplicates)
            ? new RelayBinding<TDelegate>(this, listener, allowDuplicates, true)
            : null;

        /// <inheritdoc />
        public bool AddOnce(TDelegate listener, bool allowDuplicates = false)
        {
            if (!allowDuplicates && Contains(ListenersOnce, OnceCount, listener)) return false;
            if (OnceCount == OnceCap)
            {
                if (OnceCap == 0) OnceCap =  1;
                else OnceCap              *= 2;
                ListenersOnce = Expand(ListenersOnce, OnceCap, OnceCount);
            }

            ListenersOnce[OnceCount] = listener;
            ++OnceCount;
            return true;
        }

        /// <inheritdoc />
        public bool RemoveListener(TDelegate listener)
        {
            var result = false;
            for (uint i = 0; i < Count; ++i)
            {
                if (!Listeners[i].Equals(listener)) continue;
                RemoveAt(i);
                result = true;
                break;
            }

            return result;
        }

        /// <inheritdoc />
        public bool RemoveOnce(TDelegate listener)
        {
            var result = false;
            for (uint i = 0; i < OnceCount; ++i)
            {
                if (!ListenersOnce[i].Equals(listener)) continue;
                RemoveOnceAt(i);
                result = true;
                break;
            }

            return result;
        }

        /// <inheritdoc />
        public void RemoveAll(bool persistent = true, bool oneTime = true)
        {
            if (persistent)
            { // 没有计数检查，因为数组始终存在，RemoveAll 预期用户知道有侦听器

                Array.Clear(Listeners, 0, (int)Cap);
                Count = 0;
            }

            if (!oneTime || OnceCount <= 0) return; // 计数检查，因为数组延迟实例化
            Array.Clear(ListenersOnce, 0, (int)OnceCap);
            OnceCount = 0;
        }

        #endregion

        #region Internal

        protected void RemoveAt(uint i) => Count = RemoveAt(Listeners, Count, i);

        protected void RemoveOnceAt(uint i) => OnceCount = RemoveAt(ListenersOnce, OnceCount, i);

        protected static uint RemoveAt(TDelegate[] arr, uint count, uint i)
        {
            --count;
            for (var j = i; j < count; ++j) arr[j] = arr[j + 1];
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

        /// <summary>
        ///  扩容数组。
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="cap">容量</param>
        /// <param name="count">大小</param>
        /// <returns>扩容后的数组</returns>
        private static TDelegate[] Expand(IReadOnlyList<TDelegate> arr, uint cap, uint count)
        {
            var newArr = new TDelegate[cap];
            for (var i = 0; i < count; ++i)
                newArr[i] = arr[i];
            return newArr;
        }

        #endregion
    }
}
