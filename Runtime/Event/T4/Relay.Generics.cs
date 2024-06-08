// ReSharper disable InconsistentNaming
// ReSharper disable All
/*|✩ - - - - - - - - - - |||
|||✩ Automatic Generate  |||
|||✩ - - - - - - - - - - |*/

using System;

namespace AIO.UEngine
{
    #region T1
    
    /// <summary>
    /// Relay interface for T1 type.
    /// </summary>
    public interface IRelayLinkAction<T1> : IRelayLinkBase<Action<T1>> { }

    /// <summary>
    /// Relay class for T1 type.
    /// </summary>
    internal class RelayLinkAction<T1> : RelayLinkBase<Action<T1>>, IRelayLinkAction<T1>
    {
        public RelayLinkAction(RelayBase<Action<T1>> relay) : base(relay) { }
    }

    /// <summary>
    /// Relay class for T1 type.
    /// </summary>
    public class RelayAction<T1> : RelayBase<Action<T1>>, IRelayLinkAction<T1>
    {
        private IRelayLinkAction<T1> link = null;

        /// <summary>
        /// Get an IRelayLinkAction object that wraps this Relay without allowing Dispatch.
        /// Provides a safe interface for classes outside the Relay's "owner".
        /// </summary>
        public IRelayLinkAction<T1> Link
        {
            get
            {
                if (HasLink) return link;
                link     = new RelayLinkAction<T1>(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch(T1 t1)
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1](t1);
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
#if SIGTRAP_RELAY_DBG
				_RelayDebugger.DebugRemListener(this, _listenersOnce[i - 1]); // Remove first to prevent potential infinite loops
#endif
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke(t1);
            }
        }
    }

    #endregion

    #region T1, T2
    
    /// <summary>
    /// Relay interface for T1, T2 type.
    /// </summary>
    public interface IRelayLinkAction<T1, T2> : IRelayLinkBase<Action<T1, T2>> { }

    /// <summary>
    /// Relay class for T1, T2 type.
    /// </summary>
    internal class RelayLinkAction<T1, T2> : RelayLinkBase<Action<T1, T2>>, IRelayLinkAction<T1, T2>
    {
        public RelayLinkAction(RelayBase<Action<T1, T2>> relay) : base(relay) { }
    }

    /// <summary>
    /// Relay class for T1, T2 type.
    /// </summary>
    public class RelayAction<T1, T2> : RelayBase<Action<T1, T2>>, IRelayLinkAction<T1, T2>
    {
        private IRelayLinkAction<T1, T2> link = null;

        /// <summary>
        /// Get an IRelayLinkAction object that wraps this Relay without allowing Dispatch.
        /// Provides a safe interface for classes outside the Relay's "owner".
        /// </summary>
        public IRelayLinkAction<T1, T2> Link
        {
            get
            {
                if (HasLink) return link;
                link     = new RelayLinkAction<T1, T2>(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch(T1 t1, T2 t2)
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1](t1, t2);
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
#if SIGTRAP_RELAY_DBG
				_RelayDebugger.DebugRemListener(this, _listenersOnce[i - 1]); // Remove first to prevent potential infinite loops
#endif
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke(t1, t2);
            }
        }
    }

    #endregion

    #region T1, T2, T3
    
    /// <summary>
    /// Relay interface for T1, T2, T3 type.
    /// </summary>
    public interface IRelayLinkAction<T1, T2, T3> : IRelayLinkBase<Action<T1, T2, T3>> { }

    /// <summary>
    /// Relay class for T1, T2, T3 type.
    /// </summary>
    internal class RelayLinkAction<T1, T2, T3> : RelayLinkBase<Action<T1, T2, T3>>, IRelayLinkAction<T1, T2, T3>
    {
        public RelayLinkAction(RelayBase<Action<T1, T2, T3>> relay) : base(relay) { }
    }

    /// <summary>
    /// Relay class for T1, T2, T3 type.
    /// </summary>
    public class RelayAction<T1, T2, T3> : RelayBase<Action<T1, T2, T3>>, IRelayLinkAction<T1, T2, T3>
    {
        private IRelayLinkAction<T1, T2, T3> link = null;

        /// <summary>
        /// Get an IRelayLinkAction object that wraps this Relay without allowing Dispatch.
        /// Provides a safe interface for classes outside the Relay's "owner".
        /// </summary>
        public IRelayLinkAction<T1, T2, T3> Link
        {
            get
            {
                if (HasLink) return link;
                link     = new RelayLinkAction<T1, T2, T3>(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch(T1 t1, T2 t2, T3 t3)
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1](t1, t2, t3);
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
#if SIGTRAP_RELAY_DBG
				_RelayDebugger.DebugRemListener(this, _listenersOnce[i - 1]); // Remove first to prevent potential infinite loops
#endif
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke(t1, t2, t3);
            }
        }
    }

    #endregion

    #region T1, T2, T3, T4
    
    /// <summary>
    /// Relay interface for T1, T2, T3, T4 type.
    /// </summary>
    public interface IRelayLinkAction<T1, T2, T3, T4> : IRelayLinkBase<Action<T1, T2, T3, T4>> { }

    /// <summary>
    /// Relay class for T1, T2, T3, T4 type.
    /// </summary>
    internal class RelayLinkAction<T1, T2, T3, T4> : RelayLinkBase<Action<T1, T2, T3, T4>>, IRelayLinkAction<T1, T2, T3, T4>
    {
        public RelayLinkAction(RelayBase<Action<T1, T2, T3, T4>> relay) : base(relay) { }
    }

    /// <summary>
    /// Relay class for T1, T2, T3, T4 type.
    /// </summary>
    public class RelayAction<T1, T2, T3, T4> : RelayBase<Action<T1, T2, T3, T4>>, IRelayLinkAction<T1, T2, T3, T4>
    {
        private IRelayLinkAction<T1, T2, T3, T4> link = null;

        /// <summary>
        /// Get an IRelayLinkAction object that wraps this Relay without allowing Dispatch.
        /// Provides a safe interface for classes outside the Relay's "owner".
        /// </summary>
        public IRelayLinkAction<T1, T2, T3, T4> Link
        {
            get
            {
                if (HasLink) return link;
                link     = new RelayLinkAction<T1, T2, T3, T4>(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1](t1, t2, t3, t4);
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
#if SIGTRAP_RELAY_DBG
				_RelayDebugger.DebugRemListener(this, _listenersOnce[i - 1]); // Remove first to prevent potential infinite loops
#endif
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke(t1, t2, t3, t4);
            }
        }
    }

    #endregion

    #region T1, T2, T3, T4, T5
    
    /// <summary>
    /// Relay interface for T1, T2, T3, T4, T5 type.
    /// </summary>
    public interface IRelayLinkAction<T1, T2, T3, T4, T5> : IRelayLinkBase<Action<T1, T2, T3, T4, T5>> { }

    /// <summary>
    /// Relay class for T1, T2, T3, T4, T5 type.
    /// </summary>
    internal class RelayLinkAction<T1, T2, T3, T4, T5> : RelayLinkBase<Action<T1, T2, T3, T4, T5>>, IRelayLinkAction<T1, T2, T3, T4, T5>
    {
        public RelayLinkAction(RelayBase<Action<T1, T2, T3, T4, T5>> relay) : base(relay) { }
    }

    /// <summary>
    /// Relay class for T1, T2, T3, T4, T5 type.
    /// </summary>
    public class RelayAction<T1, T2, T3, T4, T5> : RelayBase<Action<T1, T2, T3, T4, T5>>, IRelayLinkAction<T1, T2, T3, T4, T5>
    {
        private IRelayLinkAction<T1, T2, T3, T4, T5> link = null;

        /// <summary>
        /// Get an IRelayLinkAction object that wraps this Relay without allowing Dispatch.
        /// Provides a safe interface for classes outside the Relay's "owner".
        /// </summary>
        public IRelayLinkAction<T1, T2, T3, T4, T5> Link
        {
            get
            {
                if (HasLink) return link;
                link     = new RelayLinkAction<T1, T2, T3, T4, T5>(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1](t1, t2, t3, t4, t5);
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
#if SIGTRAP_RELAY_DBG
				_RelayDebugger.DebugRemListener(this, _listenersOnce[i - 1]); // Remove first to prevent potential infinite loops
#endif
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke(t1, t2, t3, t4, t5);
            }
        }
    }

    #endregion

    #region T1, T2, T3, T4, T5, T6
    
    /// <summary>
    /// Relay interface for T1, T2, T3, T4, T5, T6 type.
    /// </summary>
    public interface IRelayLinkAction<T1, T2, T3, T4, T5, T6> : IRelayLinkBase<Action<T1, T2, T3, T4, T5, T6>> { }

    /// <summary>
    /// Relay class for T1, T2, T3, T4, T5, T6 type.
    /// </summary>
    internal class RelayLinkAction<T1, T2, T3, T4, T5, T6> : RelayLinkBase<Action<T1, T2, T3, T4, T5, T6>>, IRelayLinkAction<T1, T2, T3, T4, T5, T6>
    {
        public RelayLinkAction(RelayBase<Action<T1, T2, T3, T4, T5, T6>> relay) : base(relay) { }
    }

    /// <summary>
    /// Relay class for T1, T2, T3, T4, T5, T6 type.
    /// </summary>
    public class RelayAction<T1, T2, T3, T4, T5, T6> : RelayBase<Action<T1, T2, T3, T4, T5, T6>>, IRelayLinkAction<T1, T2, T3, T4, T5, T6>
    {
        private IRelayLinkAction<T1, T2, T3, T4, T5, T6> link = null;

        /// <summary>
        /// Get an IRelayLinkAction object that wraps this Relay without allowing Dispatch.
        /// Provides a safe interface for classes outside the Relay's "owner".
        /// </summary>
        public IRelayLinkAction<T1, T2, T3, T4, T5, T6> Link
        {
            get
            {
                if (HasLink) return link;
                link     = new RelayLinkAction<T1, T2, T3, T4, T5, T6>(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1](t1, t2, t3, t4, t5, t6);
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
#if SIGTRAP_RELAY_DBG
				_RelayDebugger.DebugRemListener(this, _listenersOnce[i - 1]); // Remove first to prevent potential infinite loops
#endif
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke(t1, t2, t3, t4, t5, t6);
            }
        }
    }

    #endregion

    #region T1, T2, T3, T4, T5, T6, T7
    
    /// <summary>
    /// Relay interface for T1, T2, T3, T4, T5, T6, T7 type.
    /// </summary>
    public interface IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7> : IRelayLinkBase<Action<T1, T2, T3, T4, T5, T6, T7>> { }

    /// <summary>
    /// Relay class for T1, T2, T3, T4, T5, T6, T7 type.
    /// </summary>
    internal class RelayLinkAction<T1, T2, T3, T4, T5, T6, T7> : RelayLinkBase<Action<T1, T2, T3, T4, T5, T6, T7>>, IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7>
    {
        public RelayLinkAction(RelayBase<Action<T1, T2, T3, T4, T5, T6, T7>> relay) : base(relay) { }
    }

    /// <summary>
    /// Relay class for T1, T2, T3, T4, T5, T6, T7 type.
    /// </summary>
    public class RelayAction<T1, T2, T3, T4, T5, T6, T7> : RelayBase<Action<T1, T2, T3, T4, T5, T6, T7>>, IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7>
    {
        private IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7> link = null;

        /// <summary>
        /// Get an IRelayLinkAction object that wraps this Relay without allowing Dispatch.
        /// Provides a safe interface for classes outside the Relay's "owner".
        /// </summary>
        public IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7> Link
        {
            get
            {
                if (HasLink) return link;
                link     = new RelayLinkAction<T1, T2, T3, T4, T5, T6, T7>(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1](t1, t2, t3, t4, t5, t6, t7);
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
#if SIGTRAP_RELAY_DBG
				_RelayDebugger.DebugRemListener(this, _listenersOnce[i - 1]); // Remove first to prevent potential infinite loops
#endif
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke(t1, t2, t3, t4, t5, t6, t7);
            }
        }
    }

    #endregion

    #region T1, T2, T3, T4, T5, T6, T7, T8
    
    /// <summary>
    /// Relay interface for T1, T2, T3, T4, T5, T6, T7, T8 type.
    /// </summary>
    public interface IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8> : IRelayLinkBase<Action<T1, T2, T3, T4, T5, T6, T7, T8>> { }

    /// <summary>
    /// Relay class for T1, T2, T3, T4, T5, T6, T7, T8 type.
    /// </summary>
    internal class RelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8> : RelayLinkBase<Action<T1, T2, T3, T4, T5, T6, T7, T8>>, IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public RelayLinkAction(RelayBase<Action<T1, T2, T3, T4, T5, T6, T7, T8>> relay) : base(relay) { }
    }

    /// <summary>
    /// Relay class for T1, T2, T3, T4, T5, T6, T7, T8 type.
    /// </summary>
    public class RelayAction<T1, T2, T3, T4, T5, T6, T7, T8> : RelayBase<Action<T1, T2, T3, T4, T5, T6, T7, T8>>, IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        private IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8> link = null;

        /// <summary>
        /// Get an IRelayLinkAction object that wraps this Relay without allowing Dispatch.
        /// Provides a safe interface for classes outside the Relay's "owner".
        /// </summary>
        public IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8> Link
        {
            get
            {
                if (HasLink) return link;
                link     = new RelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8>(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1](t1, t2, t3, t4, t5, t6, t7, t8);
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
#if SIGTRAP_RELAY_DBG
				_RelayDebugger.DebugRemListener(this, _listenersOnce[i - 1]); // Remove first to prevent potential infinite loops
#endif
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke(t1, t2, t3, t4, t5, t6, t7, t8);
            }
        }
    }

    #endregion

    #region T1, T2, T3, T4, T5, T6, T7, T8, T9
    
    /// <summary>
    /// Relay interface for T1, T2, T3, T4, T5, T6, T7, T8, T9 type.
    /// </summary>
    public interface IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IRelayLinkBase<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> { }

    /// <summary>
    /// Relay class for T1, T2, T3, T4, T5, T6, T7, T8, T9 type.
    /// </summary>
    internal class RelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : RelayLinkBase<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>, IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public RelayLinkAction(RelayBase<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> relay) : base(relay) { }
    }

    /// <summary>
    /// Relay class for T1, T2, T3, T4, T5, T6, T7, T8, T9 type.
    /// </summary>
    public class RelayAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : RelayBase<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>, IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        private IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> link = null;

        /// <summary>
        /// Get an IRelayLinkAction object that wraps this Relay without allowing Dispatch.
        /// Provides a safe interface for classes outside the Relay's "owner".
        /// </summary>
        public IRelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> Link
        {
            get
            {
                if (HasLink) return link;
                link     = new RelayLinkAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1](t1, t2, t3, t4, t5, t6, t7, t8, t9);
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
#if SIGTRAP_RELAY_DBG
				_RelayDebugger.DebugRemListener(this, _listenersOnce[i - 1]); // Remove first to prevent potential infinite loops
#endif
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9);
            }
        }
    }

    #endregion

    #region No Type

    /// <summary>
    /// Relay interface for no type.
    /// </summary>
    public interface IRelayLinkAction : IRelayLinkBase<Action> { }

    /// <summary>
    /// Relay class for no type.
    /// </summary>
    public class RelayLinkAction : RelayLinkBase<Action>, IRelayLinkAction
    {
        public RelayLinkAction(RelayBase<Action> relay) : base(relay) { }
    }

    public class RelayAction : RelayBase<Action>, IRelayLinkAction
    {
        private IRelayLinkAction link = null;

        /// <summary>
        /// Get an IRelayLinkAction object that wraps this Relay without allowing Dispatch.
        /// Provides a safe interface for classes outside the Relay's "owner".
        /// </summary>
        public IRelayLinkAction Link
        {
            get
            {
                if (HasLink) return link;
                link    = new RelayLinkAction(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch()
        {
            // Persistent listeners
            // Reversal allows self-removal during dispatch (doesn't skip next listener)
            // Reversal allows safe addition during dispatch (doesn't fire immediately)
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1]();
                else
                    RemoveAt(i - 1);
            }

            // One-time listeners - reversed for safe addition and auto-removal
            for (var i = _OnceCount; i > 0; --i)
            {
                // Remove first to prevent potential infinite loops
#if SIGTRAP_RELAY_DBG
				_RelayDebugger.DebugRemListener(this, _listenersOnce[i - 1]);
#endif
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke();
            }
        }
    }

    #endregion
}