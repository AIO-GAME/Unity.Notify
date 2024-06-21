// ReSharper disable InconsistentNaming
// ReSharper disable All
/*|✩ - - - - - - - - - - |||
|||✩ Automatic Generate  |||
|||✩ - - - - - - - - - - |*/

using System;
using AIO.UEngine;

namespace AIO
{
    partial class EventSystem
    {

        #region Event

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE>(TE key, Action action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener(int key, Action action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction).FullName, out var relay))
            {
                (relay as RelayAction)?.RemoveListener(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener(string key, Action action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE>(TE key, Action action) where TE : Enum
        {
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce(int key, Action action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction).FullName, out var relay))
            {
                (relay as RelayAction)?.RemoveOnce(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce(string key, Action action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }
        #endregion

        #region Event<T1>

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE, T1>(TE key, Action<T1> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1>(int key, Action<T1> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1>).FullName, out var relay))
            {
                (relay as RelayAction<T1>)?.RemoveListener(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1>(string key, Action<T1> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE, T1>(TE key, Action<T1> action) where TE : Enum
        {
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1>(int key, Action<T1> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1>).FullName, out var relay))
            {
                (relay as RelayAction<T1>)?.RemoveOnce(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1>(string key, Action<T1> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }
        #endregion

        #region Event<T1, T2>

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE, T1, T2>(TE key, Action<T1, T2> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2>(int key, Action<T1, T2> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2>)?.RemoveListener(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2>(string key, Action<T1, T2> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE, T1, T2>(TE key, Action<T1, T2> action) where TE : Enum
        {
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2>(int key, Action<T1, T2> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2>)?.RemoveOnce(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2>(string key, Action<T1, T2> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }
        #endregion

        #region Event<T1, T2, T3>

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE, T1, T2, T3>(TE key, Action<T1, T2, T3> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3>(int key, Action<T1, T2, T3> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3>)?.RemoveListener(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3>(string key, Action<T1, T2, T3> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE, T1, T2, T3>(TE key, Action<T1, T2, T3> action) where TE : Enum
        {
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3>(int key, Action<T1, T2, T3> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3>)?.RemoveOnce(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3>(string key, Action<T1, T2, T3> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }
        #endregion

        #region Event<T1, T2, T3, T4>

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE, T1, T2, T3, T4>(TE key, Action<T1, T2, T3, T4> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4>(int key, Action<T1, T2, T3, T4> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4>)?.RemoveListener(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4>(string key, Action<T1, T2, T3, T4> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE, T1, T2, T3, T4>(TE key, Action<T1, T2, T3, T4> action) where TE : Enum
        {
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4>(int key, Action<T1, T2, T3, T4> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4>)?.RemoveOnce(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4>(string key, Action<T1, T2, T3, T4> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }
        #endregion

        #region Event<T1, T2, T3, T4, T5>

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE, T1, T2, T3, T4, T5>(TE key, Action<T1, T2, T3, T4, T5> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4, T5>(int key, Action<T1, T2, T3, T4, T5> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4, T5>)?.RemoveListener(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4, T5>(string key, Action<T1, T2, T3, T4, T5> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE, T1, T2, T3, T4, T5>(TE key, Action<T1, T2, T3, T4, T5> action) where TE : Enum
        {
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4, T5>(int key, Action<T1, T2, T3, T4, T5> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4, T5>)?.RemoveOnce(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4, T5>(string key, Action<T1, T2, T3, T4, T5> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }
        #endregion

        #region Event<T1, T2, T3, T4, T5, T6>

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE, T1, T2, T3, T4, T5, T6>(TE key, Action<T1, T2, T3, T4, T5, T6> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4, T5, T6>(int key, Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4, T5, T6>)?.RemoveListener(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4, T5, T6>(string key, Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE, T1, T2, T3, T4, T5, T6>(TE key, Action<T1, T2, T3, T4, T5, T6> action) where TE : Enum
        {
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4, T5, T6>(int key, Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4, T5, T6>)?.RemoveOnce(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4, T5, T6>(string key, Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }
        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7>

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE, T1, T2, T3, T4, T5, T6, T7>(TE key, Action<T1, T2, T3, T4, T5, T6, T7> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7>(int key, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4, T5, T6, T7>)?.RemoveListener(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7>(string key, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE, T1, T2, T3, T4, T5, T6, T7>(TE key, Action<T1, T2, T3, T4, T5, T6, T7> action) where TE : Enum
        {
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4, T5, T6, T7>(int key, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4, T5, T6, T7>)?.RemoveOnce(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4, T5, T6, T7>(string key, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }
        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7, T8>

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE, T1, T2, T3, T4, T5, T6, T7, T8>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7, T8>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>)?.RemoveListener(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7, T8>(string key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE, T1, T2, T3, T4, T5, T6, T7, T8>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action) where TE : Enum
        {
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4, T5, T6, T7, T8>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>)?.RemoveOnce(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4, T5, T6, T7, T8>(string key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }
        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7, T8, T9>

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<TE, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>)?.RemoveListener(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveListener(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<TE, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) where TE : Enum
        {
            RemoveOnce(key.GetHashCode(), action);
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value.TryGetValue(typeof(RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>).FullName, out var relay))
            {
                (relay as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>)?.RemoveOnce(action);
            }
        }

        /// <summary>
        /// 移除指定事件键值的 一次性事件侦听器
        /// </summary>
        /// <param name="key"> 事件键值 </param>
        /// <param name="action"> 侦听器 </param>
        public static void RemoveOnce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (string.IsNullOrEmpty(key)) return;
            RemoveOnce(key.GetHashCode(), action);
        }
        #endregion
    }
}
