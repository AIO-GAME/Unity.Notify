// ReSharper disable InconsistentNaming
// ReSharper disable All
/*|✩ - - - - - - - - - - |||
|||✩ Automatic Generate  |||
|||✩ - - - - - - - - - - |*/

using System;
using AIO.UEngine;
using System.Collections.Generic;

namespace AIO
{
    partial class EventSystem
    {

        #region Event

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE>(TE key, Action action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener(int key, Action action, bool allowDuplicates = false)
        {
            RelayAction relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction;
            else RelayParams[key] = relay = new RelayAction();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener(string key, Action action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE>(object caller, TE key, Action action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener(object caller, int key, Action action, bool allowDuplicates = false)
        {
            RelayAction relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction;
            else RelayParams[key] = relay = new RelayAction();
            if (relay.AddListener(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener(object caller, string key, Action action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE>(TE key, Action action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce(int key, Action action, bool allowDuplicates = false)
        {
            RelayAction relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction;
            else RelayParams[key] = relay = new RelayAction();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce(string key, Action action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE>(object caller, TE key, Action action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce(object caller, int key, Action action, bool allowDuplicates = false)
        {
            RelayAction relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction;
            else RelayParams[key] = relay = new RelayAction();
            if (relay.AddOnce(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce(object caller, string key, Action action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion

        #region Event<T1>

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1>(TE key, Action<T1> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1>(int key, Action<T1> action, bool allowDuplicates = false)
        {
            RelayAction<T1> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1>;
            else RelayParams[key] = relay = new RelayAction<T1>();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1>(string key, Action<T1> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1>(object caller, TE key, Action<T1> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1>(object caller, int key, Action<T1> action, bool allowDuplicates = false)
        {
            RelayAction<T1> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1>;
            else RelayParams[key] = relay = new RelayAction<T1>();
            if (relay.AddListener(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1>(object caller, string key, Action<T1> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1>(TE key, Action<T1> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1>(int key, Action<T1> action, bool allowDuplicates = false)
        {
            RelayAction<T1> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1>;
            else RelayParams[key] = relay = new RelayAction<T1>();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1>(string key, Action<T1> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1>(object caller, TE key, Action<T1> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1>(object caller, int key, Action<T1> action, bool allowDuplicates = false)
        {
            RelayAction<T1> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1>;
            else RelayParams[key] = relay = new RelayAction<T1>();
            if (relay.AddOnce(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1>(object caller, string key, Action<T1> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion

        #region Event<T1, T2>

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2>(TE key, Action<T1, T2> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2>(int key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2>;
            else RelayParams[key] = relay = new RelayAction<T1, T2>();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2>(string key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2>(object caller, TE key, Action<T1, T2> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2>(object caller, int key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2>;
            else RelayParams[key] = relay = new RelayAction<T1, T2>();
            if (relay.AddListener(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2>(object caller, string key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2>(TE key, Action<T1, T2> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2>(int key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2>;
            else RelayParams[key] = relay = new RelayAction<T1, T2>();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2>(string key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2>(object caller, TE key, Action<T1, T2> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2>(object caller, int key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2>;
            else RelayParams[key] = relay = new RelayAction<T1, T2>();
            if (relay.AddOnce(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2>(object caller, string key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion

        #region Event<T1, T2, T3>

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3>(TE key, Action<T1, T2, T3> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3>(int key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3>();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3>(string key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3>(object caller, TE key, Action<T1, T2, T3> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3>(object caller, int key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3>();
            if (relay.AddListener(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3>(object caller, string key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3>(TE key, Action<T1, T2, T3> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3>(int key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3>();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3>(string key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3>(object caller, TE key, Action<T1, T2, T3> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3>(object caller, int key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3>();
            if (relay.AddOnce(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3>(object caller, string key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion

        #region Event<T1, T2, T3, T4>

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4>(TE key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4>(int key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4>();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4>(string key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4>(object caller, TE key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4>(object caller, int key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4>();
            if (relay.AddListener(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4>(object caller, string key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4>(TE key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4>(int key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4>();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4>(string key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4>(object caller, TE key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4>(object caller, int key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4>();
            if (relay.AddOnce(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4>(object caller, string key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion

        #region Event<T1, T2, T3, T4, T5>

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4, T5>(TE key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5>(int key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5>();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5>(string key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4, T5>(object caller, TE key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5>(object caller, int key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5>();
            if (relay.AddListener(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5>(object caller, string key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4, T5>(TE key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5>(int key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5>();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5>(string key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4, T5>(object caller, TE key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5>(object caller, int key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5>();
            if (relay.AddOnce(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5>(object caller, string key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion

        #region Event<T1, T2, T3, T4, T5, T6>

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4, T5, T6>(TE key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6>(int key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6>();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6>(string key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4, T5, T6>(object caller, TE key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6>(object caller, int key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6>();
            if (relay.AddListener(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6>(object caller, string key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4, T5, T6>(TE key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6>(int key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6>();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6>(string key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4, T5, T6>(object caller, TE key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6>(object caller, int key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6>();
            if (relay.AddOnce(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6>(object caller, string key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7>

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4, T5, T6, T7>(TE key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(int key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7>();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(string key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4, T5, T6, T7>(object caller, TE key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(object caller, int key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7>();
            if (relay.AddListener(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(object caller, string key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4, T5, T6, T7>(TE key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7>(int key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7>();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7>(string key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4, T5, T6, T7>(object caller, TE key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7>(object caller, int key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7>();
            if (relay.AddOnce(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7>(object caller, string key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7, T8>

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4, T5, T6, T7, T8>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(string key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4, T5, T6, T7, T8>(object caller, TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(object caller, int key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>();
            if (relay.AddListener(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(object caller, string key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4, T5, T6, T7, T8>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8>(string key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4, T5, T6, T7, T8>(object caller, TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8>(object caller, int key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>();
            if (relay.AddOnce(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8>(object caller, string key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7, T8, T9>

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<TE, T1, T2, T3, T4, T5, T6, T7, T8, T9>(object caller, TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false) where TE : Enum
        {
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object caller, int key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
            if (relay.AddListener(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object caller, string key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<TE, T1, T2, T3, T4, T5, T6, T7, T8, T9>(object caller, TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false) where TE : Enum
        {
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object caller, int key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
            if (relay.AddOnce(action, caller, allowDuplicates))
            {
                if (ListenersByCaller.TryGetValue(caller, out var list))
                {
                    if (!list.Contains(key)) list.Add(key);
                }
                else ListenersByCaller[caller] = new List<int> { key };
            }
        }

        /// <summary>
        /// 添加一次性事件侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object caller, string key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion
    }
}
