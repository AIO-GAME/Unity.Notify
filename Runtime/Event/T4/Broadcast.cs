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
        #region Broadcast

        public static void Broadcast(int key, bool immediately = false)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (!(value is RelayAction relay)) return;
            if (immediately) relay.Dispatch();
            else Runner.StartCoroutine(relay.Dispatch);
        }

        #endregion

        #region Broadcast<T1>

        public static void Broadcast<T1>(int key, T1 t1, bool immediately = false)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (!(value is RelayAction<T1> relay)) return;
            if (immediately) relay.Dispatch(t1);
            else Runner.StartCoroutine(relay.Dispatch, t1);
        }

        #endregion

        #region Broadcast<T1, T2>

        public static void Broadcast<T1, T2>(int key, T1 t1, T2 t2, bool immediately = false)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (!(value is RelayAction<T1, T2> relay)) return;
            if (immediately) relay.Dispatch(t1, t2);
            else Runner.StartCoroutine(relay.Dispatch, t1, t2);
        }

        #endregion

        #region Broadcast<T1, T2, T3>

        public static void Broadcast<T1, T2, T3>(int key, T1 t1, T2 t2, T3 t3, bool immediately = false)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (!(value is RelayAction<T1, T2, T3> relay)) return;
            if (immediately) relay.Dispatch(t1, t2, t3);
            else Runner.StartCoroutine(relay.Dispatch, t1, t2, t3);
        }

        #endregion

        #region Broadcast<T1, T2, T3, T4>

        public static void Broadcast<T1, T2, T3, T4>(int key, T1 t1, T2 t2, T3 t3, T4 t4, bool immediately = false)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (!(value is RelayAction<T1, T2, T3, T4> relay)) return;
            if (immediately) relay.Dispatch(t1, t2, t3, t4);
            else Runner.StartCoroutine(relay.Dispatch, t1, t2, t3, t4);
        }

        #endregion

        #region Broadcast<T1, T2, T3, T4, T5>

        public static void Broadcast<T1, T2, T3, T4, T5>(int key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, bool immediately = false)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (!(value is RelayAction<T1, T2, T3, T4, T5> relay)) return;
            if (immediately) relay.Dispatch(t1, t2, t3, t4, t5);
            else Runner.StartCoroutine(relay.Dispatch, t1, t2, t3, t4, t5);
        }

        #endregion

        #region Broadcast<T1, T2, T3, T4, T5, T6>

        public static void Broadcast<T1, T2, T3, T4, T5, T6>(int key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, bool immediately = false)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (!(value is RelayAction<T1, T2, T3, T4, T5, T6> relay)) return;
            if (immediately) relay.Dispatch(t1, t2, t3, t4, t5, t6);
            else Runner.StartCoroutine(relay.Dispatch, t1, t2, t3, t4, t5, t6);
        }

        #endregion

        #region Broadcast<T1, T2, T3, T4, T5, T6, T7>

        public static void Broadcast<T1, T2, T3, T4, T5, T6, T7>(int key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, bool immediately = false)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (!(value is RelayAction<T1, T2, T3, T4, T5, T6, T7> relay)) return;
            if (immediately) relay.Dispatch(t1, t2, t3, t4, t5, t6, t7);
            else Runner.StartCoroutine(relay.Dispatch, t1, t2, t3, t4, t5, t6, t7);
        }

        #endregion

        #region Broadcast<T1, T2, T3, T4, T5, T6, T7, T8>

        public static void Broadcast<T1, T2, T3, T4, T5, T6, T7, T8>(int key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, bool immediately = false)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (!(value is RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> relay)) return;
            if (immediately) relay.Dispatch(t1, t2, t3, t4, t5, t6, t7, t8);
            else Runner.StartCoroutine(relay.Dispatch, t1, t2, t3, t4, t5, t6, t7, t8);
        }

        #endregion

        #region Broadcast<T1, T2, T3, T4, T5, T6, T7, T8, T9>

        public static void Broadcast<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, bool immediately = false)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (!(value is RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> relay)) return;
            if (immediately) relay.Dispatch(t1, t2, t3, t4, t5, t6, t7, t8, t9);
            else Runner.StartCoroutine(relay.Dispatch, t1, t2, t3, t4, t5, t6, t7, t8, t9);
        }

        #endregion

        #region Broadcast

        public static void Broadcast(string key, bool immediately = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            Broadcast(key.GetHashCode(), immediately);
        }

        public static void Broadcast<T1>(string key, T1 t1, bool immediately = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            var value = key.GetHashCode()
                    + typeof(T1).GetHashCode() * 3;
            Broadcast(value, t1, immediately);
        }

        public static void Broadcast<T1, T2>(string key, T1 t1, T2 t2, bool immediately = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            var value = key.GetHashCode()
                    + typeof(T1).GetHashCode() * 3
                    + typeof(T2).GetHashCode() * 3;
            Broadcast(value, t1, t2, immediately);
        }

        public static void Broadcast<T1, T2, T3>(string key, T1 t1, T2 t2, T3 t3, bool immediately = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            var value = key.GetHashCode()
                    + typeof(T1).GetHashCode() * 3
                    + typeof(T2).GetHashCode() * 3
                    + typeof(T3).GetHashCode() * 3;
            Broadcast(value, t1, t2, t3, immediately);
        }

        public static void Broadcast<T1, T2, T3, T4>(string key, T1 t1, T2 t2, T3 t3, T4 t4, bool immediately = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            var value = key.GetHashCode()
                    + typeof(T1).GetHashCode() * 3
                    + typeof(T2).GetHashCode() * 3
                    + typeof(T3).GetHashCode() * 3
                    + typeof(T4).GetHashCode() * 3;
            Broadcast(value, t1, t2, t3, t4, immediately);
        }

        public static void Broadcast<T1, T2, T3, T4, T5>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, bool immediately = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            var value = key.GetHashCode()
                    + typeof(T1).GetHashCode() * 3
                    + typeof(T2).GetHashCode() * 3
                    + typeof(T3).GetHashCode() * 3
                    + typeof(T4).GetHashCode() * 3
                    + typeof(T5).GetHashCode() * 3;
            Broadcast(value, t1, t2, t3, t4, t5, immediately);
        }

        public static void Broadcast<T1, T2, T3, T4, T5, T6>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, bool immediately = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            var value = key.GetHashCode()
                    + typeof(T1).GetHashCode() * 3
                    + typeof(T2).GetHashCode() * 3
                    + typeof(T3).GetHashCode() * 3
                    + typeof(T4).GetHashCode() * 3
                    + typeof(T5).GetHashCode() * 3
                    + typeof(T6).GetHashCode() * 3;
            Broadcast(value, t1, t2, t3, t4, t5, t6, immediately);
        }

        public static void Broadcast<T1, T2, T3, T4, T5, T6, T7>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, bool immediately = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            var value = key.GetHashCode()
                    + typeof(T1).GetHashCode() * 3
                    + typeof(T2).GetHashCode() * 3
                    + typeof(T3).GetHashCode() * 3
                    + typeof(T4).GetHashCode() * 3
                    + typeof(T5).GetHashCode() * 3
                    + typeof(T6).GetHashCode() * 3
                    + typeof(T7).GetHashCode() * 3;
            Broadcast(value, t1, t2, t3, t4, t5, t6, t7, immediately);
        }

        public static void Broadcast<T1, T2, T3, T4, T5, T6, T7, T8>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, bool immediately = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            var value = key.GetHashCode()
                    + typeof(T1).GetHashCode() * 3
                    + typeof(T2).GetHashCode() * 3
                    + typeof(T3).GetHashCode() * 3
                    + typeof(T4).GetHashCode() * 3
                    + typeof(T5).GetHashCode() * 3
                    + typeof(T6).GetHashCode() * 3
                    + typeof(T7).GetHashCode() * 3
                    + typeof(T8).GetHashCode() * 3;
            Broadcast(value, t1, t2, t3, t4, t5, t6, t7, t8, immediately);
        }

        public static void Broadcast<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, bool immediately = false)
        {
            if (string.IsNullOrEmpty(key)) return;
            var value = key.GetHashCode()
                    + typeof(T1).GetHashCode() * 3
                    + typeof(T2).GetHashCode() * 3
                    + typeof(T3).GetHashCode() * 3
                    + typeof(T4).GetHashCode() * 3
                    + typeof(T5).GetHashCode() * 3
                    + typeof(T6).GetHashCode() * 3
                    + typeof(T7).GetHashCode() * 3
                    + typeof(T8).GetHashCode() * 3
                    + typeof(T9).GetHashCode() * 3;
            Broadcast(value, t1, t2, t3, t4, t5, t6, t7, t8, t9, immediately);
        }

        #endregion
    }
}