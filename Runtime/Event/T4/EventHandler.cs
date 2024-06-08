// ReSharper disable InconsistentNaming
// ReSharper disable All
/*|✩ - - - - - - - - - - |||
|||✩ Automatic Generate  |||
|||✩ - - - - - - - - - - |*/

using System;

namespace AIO.UEngine
{
    public abstract class EventHandler : IEventHandler
    {
        public abstract int Key { get; }
    
        public EventHandler() { EventSystem.AddListener(Key, Invoke); }

        protected abstract void Invoke();
    }

    public abstract class EventHandler<T1>  : IEventHandler
    {
        public abstract int Key { get; }
    
        public EventHandler() { EventSystem.AddListener<T1>(Key, Invoke); }

        protected abstract void Invoke(T1 t1);
    }

    public abstract class EventHandler<T1, T2>  : IEventHandler
    {
        public abstract int Key { get; }
    
        public EventHandler() { EventSystem.AddListener<T1, T2>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2);
    }

    public abstract class EventHandler<T1, T2, T3>  : IEventHandler
    {
        public abstract int Key { get; }
    
        public EventHandler() { EventSystem.AddListener<T1, T2, T3>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3);
    }

    public abstract class EventHandler<T1, T2, T3, T4>  : IEventHandler
    {
        public abstract int Key { get; }
    
        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4);
    }

    public abstract class EventHandler<T1, T2, T3, T4, T5>  : IEventHandler
    {
        public abstract int Key { get; }
    
        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4, T5>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
    }

    public abstract class EventHandler<T1, T2, T3, T4, T5, T6>  : IEventHandler
    {
        public abstract int Key { get; }
    
        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4, T5, T6>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
    }

    public abstract class EventHandler<T1, T2, T3, T4, T5, T6, T7>  : IEventHandler
    {
        public abstract int Key { get; }
    
        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4, T5, T6, T7>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7);
    }

    public abstract class EventHandler<T1, T2, T3, T4, T5, T6, T7, T8>  : IEventHandler
    {
        public abstract int Key { get; }
    
        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);
    }

    public abstract class EventHandler<T1, T2, T3, T4, T5, T6, T7, T8, T9>  : IEventHandler
    {
        public abstract int Key { get; }
    
        public EventHandler() { EventSystem.AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Key, Invoke); }

        protected abstract void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9);
    }

}