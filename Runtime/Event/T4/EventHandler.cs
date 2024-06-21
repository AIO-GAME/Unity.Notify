// ReSharper disable InconsistentNaming
// ReSharper disable All
/*|✩ - - - - - - - - - - |||
|||✩ Automatic Generate  |||
|||✩ - - - - - - - - - - |*/

using System;

namespace AIO.UEngine
{
    #region EventHandler

    public abstract class EventHandler : IEventHandler
    {
        public abstract int Key { get; }

        public EventHandler() { EventSystem.AddListener(Key, Invoke); }

        protected abstract void Invoke();

        #region Overrides of Object

        public sealed override bool Equals(object obj) => obj is EventHandler handler && handler.Key == Key;

        public sealed override string ToString() => string.Concat
            (Key, ":(",
             "No Parameters",
             ")");

        public sealed override int GetHashCode() => Key.GetHashCode();

        #endregion
    }

    #endregion

    #region EventHandler<T1>

    public abstract class EventHandler<T1> : IEventHandler
    {
        public abstract int Key { get; }

        public EventHandler() { EventSystem.AddListener<T1>(Key, Invoke); }

        protected abstract void Invoke(T1 t1);

        #region Overrides of Object

        public sealed override bool Equals(object obj) => obj is EventHandler<T1> handler && handler.Key == Key;

        public sealed override string ToString() => string.Concat
            (Key, ":(",
             typeof(T1).Name,
             ")");

        public sealed override int GetHashCode() => Key.GetHashCode()
                                                  ^ typeof(T1).GetHashCode();

        #endregion
    }

    #endregion

    #region EventHandler<T1, T2>

    public abstract class EventHandler<T1, T2> : IEventHandler
    {
        public abstract int Key { get; }

        public EventHandler() { EventSystem.AddListener<T1, T2>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2);

        #region Overrides of Object

        public sealed override bool Equals(object obj) => obj is EventHandler<T1, T2> handler && handler.Key == Key;

        public sealed override string ToString() => string.Concat
            (Key, ":(",
             typeof(T1).Name,
             typeof(T2).Name,
             ")");

        public sealed override int GetHashCode() => Key.GetHashCode()
                                                  ^ typeof(T1).GetHashCode()
                                                  ^ typeof(T2).GetHashCode();

        #endregion
    }

    #endregion

    #region EventHandler<T1, T2, T3>

    public abstract class EventHandler<T1, T2, T3> : IEventHandler
    {
        public abstract int Key { get; }

        public EventHandler() { EventSystem.AddListener<T1, T2, T3>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3);

        #region Overrides of Object

        public sealed override bool Equals(object obj) => obj is EventHandler<T1, T2, T3> handler && handler.Key == Key;

        public sealed override string ToString() => string.Concat
            (Key, ":(",
             typeof(T1).Name,
             typeof(T2).Name,
             typeof(T3).Name,
             ")");

        public sealed override int GetHashCode() => Key.GetHashCode()
                                                  ^ typeof(T1).GetHashCode()
                                                  ^ typeof(T2).GetHashCode()
                                                  ^ typeof(T3).GetHashCode();

        #endregion
    }

    #endregion

    #region EventHandler<T1, T2, T3, T4>

    public abstract class EventHandler<T1, T2, T3, T4> : IEventHandler
    {
        public abstract int Key { get; }

        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4);

        #region Overrides of Object

        public sealed override bool Equals(object obj) => obj is EventHandler<T1, T2, T3, T4> handler && handler.Key == Key;

        public sealed override string ToString() => string.Concat
            (Key, ":(",
             typeof(T1).Name,
             typeof(T2).Name,
             typeof(T3).Name,
             typeof(T4).Name,
             ")");

        public sealed override int GetHashCode() => Key.GetHashCode()
                                                  ^ typeof(T1).GetHashCode()
                                                  ^ typeof(T2).GetHashCode()
                                                  ^ typeof(T3).GetHashCode()
                                                  ^ typeof(T4).GetHashCode();

        #endregion
    }

    #endregion

    #region EventHandler<T1, T2, T3, T4, T5>

    public abstract class EventHandler<T1, T2, T3, T4, T5> : IEventHandler
    {
        public abstract int Key { get; }

        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4, T5>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);

        #region Overrides of Object

        public sealed override bool Equals(object obj) => obj is EventHandler<T1, T2, T3, T4, T5> handler && handler.Key == Key;

        public sealed override string ToString() => string.Concat
            (Key, ":(",
             typeof(T1).Name,
             typeof(T2).Name,
             typeof(T3).Name,
             typeof(T4).Name,
             typeof(T5).Name,
             ")");

        public sealed override int GetHashCode() => Key.GetHashCode()
                                                  ^ typeof(T1).GetHashCode()
                                                  ^ typeof(T2).GetHashCode()
                                                  ^ typeof(T3).GetHashCode()
                                                  ^ typeof(T4).GetHashCode()
                                                  ^ typeof(T5).GetHashCode();

        #endregion
    }

    #endregion

    #region EventHandler<T1, T2, T3, T4, T5, T6>

    public abstract class EventHandler<T1, T2, T3, T4, T5, T6> : IEventHandler
    {
        public abstract int Key { get; }

        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4, T5, T6>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);

        #region Overrides of Object

        public sealed override bool Equals(object obj) => obj is EventHandler<T1, T2, T3, T4, T5, T6> handler && handler.Key == Key;

        public sealed override string ToString() => string.Concat
            (Key, ":(",
             typeof(T1).Name,
             typeof(T2).Name,
             typeof(T3).Name,
             typeof(T4).Name,
             typeof(T5).Name,
             typeof(T6).Name,
             ")");

        public sealed override int GetHashCode() => Key.GetHashCode()
                                                  ^ typeof(T1).GetHashCode()
                                                  ^ typeof(T2).GetHashCode()
                                                  ^ typeof(T3).GetHashCode()
                                                  ^ typeof(T4).GetHashCode()
                                                  ^ typeof(T5).GetHashCode()
                                                  ^ typeof(T6).GetHashCode();

        #endregion
    }

    #endregion

    #region EventHandler<T1, T2, T3, T4, T5, T6, T7>

    public abstract class EventHandler<T1, T2, T3, T4, T5, T6, T7> : IEventHandler
    {
        public abstract int Key { get; }

        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4, T5, T6, T7>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7);

        #region Overrides of Object

        public sealed override bool Equals(object obj) => obj is EventHandler<T1, T2, T3, T4, T5, T6, T7> handler && handler.Key == Key;

        public sealed override string ToString() => string.Concat
            (Key, ":(",
             typeof(T1).Name,
             typeof(T2).Name,
             typeof(T3).Name,
             typeof(T4).Name,
             typeof(T5).Name,
             typeof(T6).Name,
             typeof(T7).Name,
             ")");

        public sealed override int GetHashCode() => Key.GetHashCode()
                                                  ^ typeof(T1).GetHashCode()
                                                  ^ typeof(T2).GetHashCode()
                                                  ^ typeof(T3).GetHashCode()
                                                  ^ typeof(T4).GetHashCode()
                                                  ^ typeof(T5).GetHashCode()
                                                  ^ typeof(T6).GetHashCode()
                                                  ^ typeof(T7).GetHashCode();

        #endregion
    }

    #endregion

    #region EventHandler<T1, T2, T3, T4, T5, T6, T7, T8>

    public abstract class EventHandler<T1, T2, T3, T4, T5, T6, T7, T8> : IEventHandler
    {
        public abstract int Key { get; }

        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);

        #region Overrides of Object

        public sealed override bool Equals(object obj) => obj is EventHandler<T1, T2, T3, T4, T5, T6, T7, T8> handler && handler.Key == Key;

        public sealed override string ToString() => string.Concat
            (Key, ":(",
             typeof(T1).Name,
             typeof(T2).Name,
             typeof(T3).Name,
             typeof(T4).Name,
             typeof(T5).Name,
             typeof(T6).Name,
             typeof(T7).Name,
             typeof(T8).Name,
             ")");

        public sealed override int GetHashCode() => Key.GetHashCode()
                                                  ^ typeof(T1).GetHashCode()
                                                  ^ typeof(T2).GetHashCode()
                                                  ^ typeof(T3).GetHashCode()
                                                  ^ typeof(T4).GetHashCode()
                                                  ^ typeof(T5).GetHashCode()
                                                  ^ typeof(T6).GetHashCode()
                                                  ^ typeof(T7).GetHashCode()
                                                  ^ typeof(T8).GetHashCode();

        #endregion
    }

    #endregion

    #region EventHandler<T1, T2, T3, T4, T5, T6, T7, T8, T9>

    public abstract class EventHandler<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEventHandler
    {
        public abstract int Key { get; }

        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9);

        #region Overrides of Object

        public sealed override bool Equals(object obj) => obj is EventHandler<T1, T2, T3, T4, T5, T6, T7, T8, T9> handler && handler.Key == Key;

        public sealed override string ToString() => string.Concat
            (Key, ":(",
             typeof(T1).Name,
             typeof(T2).Name,
             typeof(T3).Name,
             typeof(T4).Name,
             typeof(T5).Name,
             typeof(T6).Name,
             typeof(T7).Name,
             typeof(T8).Name,
             typeof(T9).Name,
             ")");

        public sealed override int GetHashCode() => Key.GetHashCode()
                                                  ^ typeof(T1).GetHashCode()
                                                  ^ typeof(T2).GetHashCode()
                                                  ^ typeof(T3).GetHashCode()
                                                  ^ typeof(T4).GetHashCode()
                                                  ^ typeof(T5).GetHashCode()
                                                  ^ typeof(T6).GetHashCode()
                                                  ^ typeof(T7).GetHashCode()
                                                  ^ typeof(T8).GetHashCode()
                                                  ^ typeof(T9).GetHashCode();

        #endregion
    }

    #endregion
}
