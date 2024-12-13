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
        public static void AddListener(int key, Action action, bool allowDuplicates = false)
        {
            RelayAction relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction).FullName, out var obj) ? obj as RelayAction : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction).FullName] = relay = new RelayAction();
            relay.AddListener(action, allowDuplicates);
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
            RelayAction relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction).FullName, out var obj) ? obj as RelayAction : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction).FullName] = relay = new RelayAction();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener(Enum key, Action action, bool allowDuplicates = false)
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddListener(object caller, Enum key, Action action, bool allowDuplicates = false)
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
        public static void AddOnce(int key, Action action, bool allowDuplicates = false)
        {
            RelayAction relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction).FullName, out var obj) ? obj as RelayAction : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction).FullName] = relay = new RelayAction();
            relay.AddOnce(action, allowDuplicates);
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
            RelayAction relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction).FullName, out var obj) ? obj as RelayAction : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction).FullName] = relay = new RelayAction();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce(Enum key, Action action, bool allowDuplicates = false)
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddOnce(object caller, Enum key, Action action, bool allowDuplicates = false)
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
        public static void AddListener<T1>(int key, Action<T1> action, bool allowDuplicates = false)
        {
            RelayAction<T1> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1>).FullName, out var obj) ? obj as RelayAction<T1> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1>).FullName] = relay = new RelayAction<T1>();
            relay.AddListener(action, allowDuplicates);
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
            RelayAction<T1> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1>).FullName, out var obj) ? obj as RelayAction<T1> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1>).FullName] = relay = new RelayAction<T1>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1>(Enum key, Action<T1> action, bool allowDuplicates = false)
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddListener<T1>(object caller, Enum key, Action<T1> action, bool allowDuplicates = false)
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
        public static void AddOnce<T1>(int key, Action<T1> action, bool allowDuplicates = false)
        {
            RelayAction<T1> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1>).FullName, out var obj) ? obj as RelayAction<T1> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1>).FullName] = relay = new RelayAction<T1>();
            relay.AddOnce(action, allowDuplicates);
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
            RelayAction<T1> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1>).FullName, out var obj) ? obj as RelayAction<T1> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1>).FullName] = relay = new RelayAction<T1>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1>(Enum key, Action<T1> action, bool allowDuplicates = false)
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddOnce<T1>(object caller, Enum key, Action<T1> action, bool allowDuplicates = false)
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
        public static void AddListener<T1, T2>(int key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2>).FullName, out var obj) ? obj as RelayAction<T1, T2> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2>).FullName] = relay = new RelayAction<T1, T2>();
            relay.AddListener(action, allowDuplicates);
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
            RelayAction<T1, T2> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2>).FullName, out var obj) ? obj as RelayAction<T1, T2> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2>).FullName] = relay = new RelayAction<T1, T2>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2>(Enum key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddListener<T1, T2>(object caller, Enum key, Action<T1, T2> action, bool allowDuplicates = false)
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
        public static void AddOnce<T1, T2>(int key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2>).FullName, out var obj) ? obj as RelayAction<T1, T2> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2>).FullName] = relay = new RelayAction<T1, T2>();
            relay.AddOnce(action, allowDuplicates);
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
            RelayAction<T1, T2> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2>).FullName, out var obj) ? obj as RelayAction<T1, T2> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2>).FullName] = relay = new RelayAction<T1, T2>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2>(Enum key, Action<T1, T2> action, bool allowDuplicates = false)
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddOnce<T1, T2>(object caller, Enum key, Action<T1, T2> action, bool allowDuplicates = false)
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
        public static void AddListener<T1, T2, T3>(int key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3>).FullName] = relay = new RelayAction<T1, T2, T3>();
            relay.AddListener(action, allowDuplicates);
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
            RelayAction<T1, T2, T3> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3>).FullName] = relay = new RelayAction<T1, T2, T3>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3>(Enum key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddListener<T1, T2, T3>(object caller, Enum key, Action<T1, T2, T3> action, bool allowDuplicates = false)
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
        public static void AddOnce<T1, T2, T3>(int key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3>).FullName] = relay = new RelayAction<T1, T2, T3>();
            relay.AddOnce(action, allowDuplicates);
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
            RelayAction<T1, T2, T3> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3>).FullName] = relay = new RelayAction<T1, T2, T3>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3>(Enum key, Action<T1, T2, T3> action, bool allowDuplicates = false)
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddOnce<T1, T2, T3>(object caller, Enum key, Action<T1, T2, T3> action, bool allowDuplicates = false)
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
        public static void AddListener<T1, T2, T3, T4>(int key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4>).FullName] = relay = new RelayAction<T1, T2, T3, T4>();
            relay.AddListener(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4>).FullName] = relay = new RelayAction<T1, T2, T3, T4>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4>(Enum key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddListener<T1, T2, T3, T4>(object caller, Enum key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
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
        public static void AddOnce<T1, T2, T3, T4>(int key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4>).FullName] = relay = new RelayAction<T1, T2, T3, T4>();
            relay.AddOnce(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4>).FullName] = relay = new RelayAction<T1, T2, T3, T4>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4>(Enum key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddOnce<T1, T2, T3, T4>(object caller, Enum key, Action<T1, T2, T3, T4> action, bool allowDuplicates = false)
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
        public static void AddListener<T1, T2, T3, T4, T5>(int key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5>();
            relay.AddListener(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4, T5> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5>(Enum key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddListener<T1, T2, T3, T4, T5>(object caller, Enum key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
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
        public static void AddOnce<T1, T2, T3, T4, T5>(int key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5>();
            relay.AddOnce(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4, T5> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5>(Enum key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddOnce<T1, T2, T3, T4, T5>(object caller, Enum key, Action<T1, T2, T3, T4, T5> action, bool allowDuplicates = false)
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
        public static void AddListener<T1, T2, T3, T4, T5, T6>(int key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6>();
            relay.AddListener(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4, T5, T6> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6>(Enum key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddListener<T1, T2, T3, T4, T5, T6>(object caller, Enum key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
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
        public static void AddOnce<T1, T2, T3, T4, T5, T6>(int key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6>();
            relay.AddOnce(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4, T5, T6> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6>(Enum key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddOnce<T1, T2, T3, T4, T5, T6>(object caller, Enum key, Action<T1, T2, T3, T4, T5, T6> action, bool allowDuplicates = false)
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
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(int key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7>();
            relay.AddListener(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4, T5, T6, T7> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(Enum key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(object caller, Enum key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
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
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7>(int key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7>();
            relay.AddOnce(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4, T5, T6, T7> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7>(Enum key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7>(object caller, Enum key, Action<T1, T2, T3, T4, T5, T6, T7> action, bool allowDuplicates = false)
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
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>();
            relay.AddListener(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(Enum key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(object caller, Enum key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
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
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>();
            relay.AddOnce(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8>(Enum key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8>(object caller, Enum key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, bool allowDuplicates = false)
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
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
            relay.AddListener(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Enum key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            AddListener(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object caller, Enum key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
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
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) // 查找当前key的 事件列表
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null)
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
            relay.AddOnce(action, allowDuplicates);
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
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay = null;
            if (RelayParams.TryGetValue(key, out var dictionary)) 
                relay = dictionary.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>).FullName, out var obj) ? obj as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : null;
            else
                RelayParams[key] = new Dictionary<string, object>();

            if (relay == null) 
                RelayParams[key][typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>).FullName] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>();

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
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 则不允许重复添加 </param>
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Enum key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            AddOnce(key.GetHashCode(), action, allowDuplicates);
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
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object caller, Enum key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
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
        public static void AddOnce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object caller, string key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, bool allowDuplicates = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            AddOnce(caller, key.GetHashCode(), action, allowDuplicates);
        }
        #endregion
    }
}
