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

        public static void AddListener<TE>(TE key, Action action) where TE : Enum
        {
            AddListener(key.GetHashCode(), action);
        }

        public static void AddListener(int key, Action action)
        {
            RelayAction relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction;
            else RelayParams[key] = relay = new RelayAction();
            relay?.AddListener(action);
        }

        public static void AddListener(string name, Action action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1>

        public static void AddListener<TE, T1>(TE key, Action<T1> action) where TE : Enum
        {
            AddListener(key.GetHashCode(), action);
        }

        public static void AddListener<T1>(int key, Action<T1> action)
        {
            RelayAction<T1> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1>;
            else RelayParams[key] = relay = new RelayAction<T1>();
            relay?.AddListener(action);
        }

        public static void AddListener<T1>(string name, Action<T1> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2>

        public static void AddListener<TE, T1, T2>(TE key, Action<T1, T2> action) where TE : Enum
        {
            AddListener(key.GetHashCode(), action);
        }

        public static void AddListener<T1, T2>(int key, Action<T1, T2> action)
        {
            RelayAction<T1, T2> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2>;
            else RelayParams[key] = relay = new RelayAction<T1, T2>();
            relay?.AddListener(action);
        }

        public static void AddListener<T1, T2>(string name, Action<T1, T2> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3>

        public static void AddListener<TE, T1, T2, T3>(TE key, Action<T1, T2, T3> action) where TE : Enum
        {
            AddListener(key.GetHashCode(), action);
        }

        public static void AddListener<T1, T2, T3>(int key, Action<T1, T2, T3> action)
        {
            RelayAction<T1, T2, T3> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3>();
            relay?.AddListener(action);
        }

        public static void AddListener<T1, T2, T3>(string name, Action<T1, T2, T3> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4>

        public static void AddListener<TE, T1, T2, T3, T4>(TE key, Action<T1, T2, T3, T4> action) where TE : Enum
        {
            AddListener(key.GetHashCode(), action);
        }

        public static void AddListener<T1, T2, T3, T4>(int key, Action<T1, T2, T3, T4> action)
        {
            RelayAction<T1, T2, T3, T4> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4>();
            relay?.AddListener(action);
        }

        public static void AddListener<T1, T2, T3, T4>(string name, Action<T1, T2, T3, T4> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4, T5>

        public static void AddListener<TE, T1, T2, T3, T4, T5>(TE key, Action<T1, T2, T3, T4, T5> action) where TE : Enum
        {
            AddListener(key.GetHashCode(), action);
        }

        public static void AddListener<T1, T2, T3, T4, T5>(int key, Action<T1, T2, T3, T4, T5> action)
        {
            RelayAction<T1, T2, T3, T4, T5> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5>();
            relay?.AddListener(action);
        }

        public static void AddListener<T1, T2, T3, T4, T5>(string name, Action<T1, T2, T3, T4, T5> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4, T5, T6>

        public static void AddListener<TE, T1, T2, T3, T4, T5, T6>(TE key, Action<T1, T2, T3, T4, T5, T6> action) where TE : Enum
        {
            AddListener(key.GetHashCode(), action);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6>(int key, Action<T1, T2, T3, T4, T5, T6> action)
        {
            RelayAction<T1, T2, T3, T4, T5, T6> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6>();
            relay?.AddListener(action);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6>(string name, Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7>

        public static void AddListener<TE, T1, T2, T3, T4, T5, T6, T7>(TE key, Action<T1, T2, T3, T4, T5, T6, T7> action) where TE : Enum
        {
            AddListener(key.GetHashCode(), action);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(int key, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7>();
            relay?.AddListener(action);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(string name, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7, T8>

        public static void AddListener<TE, T1, T2, T3, T4, T5, T6, T7, T8>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action) where TE : Enum
        {
            AddListener(key.GetHashCode(), action);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8>();
            relay?.AddListener(action);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion

        #region Event<T1, T2, T3, T4, T5, T6, T7, T8, T9>

        public static void AddListener<TE, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TE key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) where TE : Enum
        {
            AddListener(key.GetHashCode(), action);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int key, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>;
            else RelayParams[key] = relay = new RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
            relay?.AddListener(action);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion
    }
}