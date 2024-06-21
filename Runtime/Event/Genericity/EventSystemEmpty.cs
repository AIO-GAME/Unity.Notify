using System;
using System.Collections.Generic;
using AIO.UEngine;
using EventArgs = System.EventArgs;

namespace AIO
{
    public static partial class EventSystem
    {
        #region AddOnce

        /// <summary>
        /// 添加一次性侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates"> 如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        public static void AddOnce(int key, Action<EventArgs> action, bool allowDuplicates = false)
        {
            RelayAction<EventArgs> relay = null;
            if (RelayParams.TryGetValue(key, out var value))
                relay = value as RelayAction<EventArgs>;
            if (relay == null) RelayParams[key] = relay = new RelayAction<EventArgs>();
            relay.AddOnce(action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        /// <typeparam name="TE"> 枚举类型 </typeparam>
        public static void AddOnce<TE>(TE key, Action<EventArgs> action, bool allowDuplicates = false)
        where TE : Enum => AddOnce(key.GetHashCode(), action, allowDuplicates);

        /// <summary>
        /// 添加一次性侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        public static void AddOnce(string key, Action<EventArgs> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加一次性侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        public static void AddOnce(object caller, int key, Action<EventArgs> action, bool allowDuplicates = false)
        {
            RelayAction<EventArgs> relay = null;
            if (RelayParams.TryGetValue(key, out var value))
                relay = value as RelayAction<EventArgs>;
            if (relay == null) RelayParams[key] = relay = new RelayAction<EventArgs>();
            if (!relay.AddOnce(action, caller, allowDuplicates)) return;
            if (ListenersByCaller.TryGetValue(caller, out var list))
            {
                if (!list.Contains(key)) list.Add(key);
            }
            else ListenersByCaller[caller] = new List<int> { key };
        }

        /// <summary>
        /// 添加一次性侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        /// <typeparam name="TE"> 枚举类型 </typeparam>
        public static void AddOnce<TE>(object caller, TE key, Action<EventArgs> action, bool allowDuplicates = false)
        where TE : Enum => AddOnce(caller, key.GetHashCode(), action, allowDuplicates);

        /// <summary>
        /// 添加一次性侦听器
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        public static void AddOnce(object caller, string key, Action<EventArgs> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }

        #endregion

        #region AddListener

        /// <summary>
        /// 添加持久侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        public static void AddListener(int key, Action<EventArgs> action, bool allowDuplicates = false)
        {
            RelayAction<EventArgs> relay = null;
            if (RelayParams.TryGetValue(key, out var value))
                relay = value as RelayAction<EventArgs>;
            if (relay == null) RelayParams[key] = relay = new RelayAction<EventArgs>();
            relay.AddListener(action, allowDuplicates);
        }

        /// <summary>
        /// 添加持久侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        /// <typeparam name="TE"> 枚举类型 </typeparam>
        public static void AddListener<TE>(TE key, Action<EventArgs> action, bool allowDuplicates = false)
        where TE : Enum => AddListener(key.GetHashCode(), action, allowDuplicates);

        /// <summary>
        /// 添加持久侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        public static void AddListener(string key, Action<EventArgs> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加持久侦听器。
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        /// <typeparam name="TE"> 枚举类型 </typeparam>
        public static void AddListener<TE>(object caller, TE key, Action<EventArgs> action, bool allowDuplicates = false)
        where TE : Enum => AddListener(caller, key.GetHashCode(), action, allowDuplicates);

        /// <summary>
        /// 添加持久侦听器。
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        public static void AddListener(object caller, string key, Action<EventArgs> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddListener(caller, key.GetHashCode(), action, allowDuplicates);
        }

        /// <summary>
        /// 添加持久侦听器。
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        public static void AddListener(object caller, int key, Action<EventArgs> action, bool allowDuplicates = false)
        {
            RelayAction<EventArgs> relay = null;
            if (RelayParams.TryGetValue(key, out var value))
                relay = value as RelayAction<EventArgs>;
            if (relay == null) RelayParams[key] = relay = new RelayAction<EventArgs>();
            if (!relay.AddListener(action, caller, allowDuplicates)) return;
            if (ListenersByCaller.TryGetValue(caller, out var list))
            {
                if (!list.Contains(key)) list.Add(key);
            }
            else ListenersByCaller[caller] = new List<int> { key };
        }

        #endregion

        #region RemoveListener

        /// <summary>
        /// 移除指定事件键值的 持久侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE>(TE key, Action<EventArgs> action) where TE : Enum { RemoveListener(key.GetHashCode(), action); }

        /// <summary>
        /// 移除指定事件键值的 持久侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener(int key, Action<EventArgs> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<EventArgs> relay) relay.RemoveListener(action);
        }

        /// <summary>
        /// 移除指定事件键值的 持久侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener(string key, Action<EventArgs> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性侦听器。
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        public static void RemoveListener(object caller)
        {
            if (!ListenersByCaller.TryGetValue(caller, out var list)) return;
            foreach (var key in list)
            {
                if (!RelayParams.TryGetValue(key, out var value)) return;
                if (value is IRelayLinkBase relay) relay.RemoveAll(caller, true, false);
            }
        }

        #endregion

        #region RemoveOnce

        /// <summary>
        /// 移除指定事件键值的 一次性侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE>(TE key, Action<EventArgs> action)
        where TE : Enum => RemoveOnce(key.GetHashCode(), action);

        /// <summary>
        /// 移除指定事件键值的 一次性侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce(int key, Action<EventArgs> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<EventArgs> relay) relay.RemoveOnce(action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce(string key, Action<EventArgs> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性侦听器。
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        public static void RemoveOnce(object caller)
        {
            if (!ListenersByCaller.TryGetValue(caller, out var list)) return;
            foreach (var key in list)
            {
                if (!RelayParams.TryGetValue(key, out var value)) return;
                if (value is IRelayLinkBase relay) relay.RemoveAll(caller, false, true);
            }
        }

        #endregion

        #region RemoveAllListener

        /// <summary>
        /// 移除所有侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="persistent"> 如果为 <c>true</c>, 移除持久侦听器。 </param>
        /// <param name="oneTime"> 如果为 <c>true</c>, 移除一次性侦听器。 </param>
        public static void RemoveAllListener(int key, bool persistent = true, bool oneTime = true)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is IRelayLinkBase relay) relay.RemoveAll(persistent, oneTime);
        }

        /// <summary>
        /// 移除所有侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="persistent"> 如果为 <c>true</c>, 移除持久侦听器。 </param>
        /// <param name="oneTime"> 如果为 <c>true</c>, 移除一次性侦听器。 </param>
        public static void RemoveAllListener<TE>(TE key, bool persistent = true, bool oneTime = true) where TE : Enum
        {
            RemoveAllListener(key.GetHashCode(), persistent, oneTime);
        }

        /// <summary>
        /// 移除所有侦听器。
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="persistent"> 如果为 <c>true</c>, 移除持久侦听器。 </param>
        /// <param name="oneTime"> 如果为 <c>true</c>, 移除一次性侦听器。 </param>
        public static void RemoveAllListener(string key, bool persistent = true, bool oneTime = true)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveAllListener(key.GetHashCode(), persistent, oneTime);
        }

        /// <summary>
        /// 移除所有侦听器。
        /// </summary>
        /// <param name="caller"> 调用者 </param>
        public static void RemoveAllListener(object caller)
        {
            if (!ListenersByCaller.TryGetValue(caller, out var list)) return;
            foreach (var key in list)
            {
                if (!RelayParams.TryGetValue(key, out var value)) return;
                if (value is IRelayLinkBase relay) relay.RemoveAll(caller, true, true);
            }

            list.Clear();
            ListenersByCaller.Remove(caller);
        }

        #endregion
    }
}
