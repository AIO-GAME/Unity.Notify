using System;

namespace AIO.UEngine
{
    public abstract class RelayLinkBase<TDelegate> : IRelayLinkBase<TDelegate>
    where TDelegate : class
    {
        protected RelayBase<TDelegate> _Relay;

        #region Constructors

        private RelayLinkBase() { } // Private empty constructor to force use of params

        public RelayLinkBase(RelayBase<TDelegate> relay) { _Relay = relay; }

        #endregion

        #region IRelayLinkBase implementation

        #region Error

        /// <inheritdoc />
        public bool Contains(TDelegate listener, object caller) { return false; }

        /// <inheritdoc />
        public bool AddListener(TDelegate listener, object caller, bool allowDuplicates = false) { return false; }

        /// <inheritdoc />
        public IRelayBinding BindListener(TDelegate listener, object caller, bool allowDuplicates = false) => AddListener(listener, caller, allowDuplicates)
            ? new RelayBinding<TDelegate>(this, listener, caller, allowDuplicates, true)
            : null;

        /// <inheritdoc />
        public bool AddOnce(TDelegate listener, object caller, bool allowDuplicates = false) { throw new NotImplementedException(); }

        /// <inheritdoc />
        public bool RemoveListener(TDelegate listener, object caller) { throw new NotImplementedException(); }

        /// <inheritdoc />
        public bool RemoveOnce(TDelegate listener, object caller) { throw new NotImplementedException(); }

        /// <inheritdoc />
        public void RemoveAll(object caller, bool persistent = true, bool oneTime = true) { throw new NotImplementedException(); }

        #endregion

        /// <inheritdoc />
        public uint ListenerCount => _Relay.ListenerCount;

        /// <inheritdoc />
        public uint OneTimeListenersCount => _Relay.OneTimeListenersCount;

        /// <inheritdoc />
        public bool Contains(TDelegate listener) => _Relay.Contains(listener);

        /// <inheritdoc />
        public bool AddListener(TDelegate listener, bool allowDuplicates = false) => _Relay.AddListener(listener, allowDuplicates);

        /// <inheritdoc />
        public IRelayBinding BindListener(TDelegate listener, bool allowDuplicates = false) => _Relay.BindListener(listener, allowDuplicates);

        /// <inheritdoc />
        public bool AddOnce(TDelegate listener, bool allowDuplicates = false) => _Relay.AddOnce(listener, allowDuplicates);

        /// <inheritdoc />
        public bool RemoveListener(TDelegate listener) => _Relay.RemoveListener(listener);

        /// <inheritdoc />
        public bool RemoveOnce(TDelegate listener) => _Relay.RemoveOnce(listener);

        /// <inheritdoc />
        public void RemoveAll(bool persistent = true, bool oneTime = true) => _Relay.RemoveAll(persistent, oneTime);

        #endregion
    }
}