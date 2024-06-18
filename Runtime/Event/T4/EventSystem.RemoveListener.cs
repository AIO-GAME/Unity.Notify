// ReSharper disable InconsistentNaming
// ReSharper disable All
/*|✩ - - - - - - - - - - |||
|||✩ Automatic Generate  |||
|||✩ - - - - - - - - - - |*/

using System;

namespace AIO.UEngine
{
    partial class EventSystem
    {

        #region Event

        public static void RemoveListener<TE>(TE key, Action action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        public static void RemoveListener(int key, Action action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction relay) relay.RemoveListener(action);
        }

        public static void RemoveListener(string name, Action action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1>

        public static void RemoveListener<TE, T1>(TE key, Action<T1> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        public static void RemoveListener<T1>(int key, Action<T1> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<T1> relay) relay.RemoveListener(action);
        }

        public static void RemoveListener<T1>(string name, Action<T1> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2>

        public static void RemoveListener<TE, T1, T2>(TE key, Action<T1, T2> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        public static void RemoveListener<T1, T2>(int key, Action<T1, T2> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<T1, T2> relay) relay.RemoveListener(action);
        }

        public static void RemoveListener<T1, T2>(string name, Action<T1, T2> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3>

        public static void RemoveListener<TE, T1, T2, T3>(TE key, Action<T1, T2, T3> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        public static void RemoveListener<T1, T2, T3>(int key, Action<T1, T2, T3> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<T1, T2, T3> relay) relay.RemoveListener(action);
        }

        public static void RemoveListener<T1, T2, T3>(string name, Action<T1, T2, T3> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4>

        public static void RemoveListener<TE, T1, T2, T3, T4>(TE key, Action<T1, T2, T3, T4> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        public static void RemoveListener<T1, T2, T3, T4>(int key, Action<T1, T2, T3, T4> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<T1, T2, T3, T4> relay) relay.RemoveListener(action);
        }

        public static void RemoveListener<T1, T2, T3, T4>(string name, Action<T1, T2, T3, T4> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4, T5>

        public static void RemoveListener<TE, T1, T2, T3, T4, T5>(TE key, Action<T1, T2, T3, T4, T5> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        public static void RemoveListener<T1, T2, T3, T4, T5>(int key, Action<T1, T2, T3, T4, T5> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<T1, T2, T3, T4, T5> relay) relay.RemoveListener(action);
        }

        public static void RemoveListener<T1, T2, T3, T4, T5>(string name, Action<T1, T2, T3, T4, T5> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4, T5, T6>

        public static void RemoveListener<TE, T1, T2, T3, T4, T5, T6>(TE key, Action<T1, T2, T3, T4, T5, T6> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        public static void RemoveListener<T1, T2, T3, T4, T5, T6>(int key, Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<T1, T2, T3, T4, T5, T6> relay) relay.RemoveListener(action);
        }

        public static void RemoveListener<T1, T2, T3, T4, T5, T6>(string name, Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7>

        public static void RemoveListener<TE, T1, T2, T3, T4, T5, T6, T7>(TE key, Action<T1, T2, T3, T4, T5, T6, T7> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7>(int key, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<T1, T2, T3, T4, T5, T6, T7> relay) relay.RemoveListener(action);
        }

        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7>(string name, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7, T8>

        public static void RemoveListener<TE, T1, T2, T3, T4, T5, T6, T7, T8>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7, T8>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay) relay.RemoveListener(action);
        }

        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7, T8>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7, T8, T9>

        public static void RemoveListener<TE, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) where TE : Enum
        {
            RemoveListener(key.GetHashCode(), action);
        }

        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay) relay.RemoveListener(action);
        }

        public static void RemoveListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion
    }
}