using System;

namespace AIO.UEngine
{
    public abstract class RelayLinkBase<TDelegate> : IRelayLinkBase<TDelegate>
    where TDelegate : class
    {
        protected RelayBase<TDelegate> Relay { get; }

        #region Constructors

        private RelayLinkBase() { } // Private empty constructor to force use of params

        public RelayLinkBase(RelayBase<TDelegate> relay) { Relay = relay; }

        #endregion

        #region IRelayLinkBase implementation

        #region Error

        /// <inheritdoc />
        public bool Contains(TDelegate listener, object caller) => Relay.Contains(listener, caller);

        /// <inheritdoc />
        public bool AddListener(TDelegate listener, object caller, bool allowDuplicates = false) => Relay.AddListener(listener, caller, allowDuplicates);

        /// <inheritdoc />
        public IRelayBinding BindListener(TDelegate listener, object caller, bool allowDuplicates = false) => AddListener(listener, caller, allowDuplicates)
            ? new RelayBinding<TDelegate>(this, listener, caller, allowDuplicates, true)
            : null;

        /// <inheritdoc />
        public bool AddOnce(TDelegate listener, object caller, bool allowDuplicates = false) => Relay.AddOnce(listener, caller, allowDuplicates);

        /// <inheritdoc />
        public bool RemoveListener(TDelegate listener, object caller) => Relay.RemoveListener(listener, caller);

        /// <inheritdoc />
        public bool RemoveOnce(TDelegate listener, object caller) => Relay.RemoveListener(listener, caller);

        /// <inheritdoc />
        public void RemoveAll(object caller, bool persistent = true, bool oneTime = true) => Relay.RemoveAll(caller, persistent, oneTime);

        #endregion

        /// <inheritdoc />
        public uint ListenerCount => Relay.ListenerCount;

        /// <inheritdoc />
        public uint OneTimeListenersCount => Relay.OneTimeListenersCount;

        /// <inheritdoc />
        public bool Contains(TDelegate listener) => Relay.Contains(listener);

        /// <inheritdoc />
        public bool AddListener(TDelegate listener, bool allowDuplicates = false) => Relay.AddListener(listener, allowDuplicates);

        /// <inheritdoc />
        public IRelayBinding BindListener(TDelegate listener, bool allowDuplicates = false) => Relay.BindListener(listener, allowDuplicates);

        /// <inheritdoc />
        public bool AddOnce(TDelegate listener, bool allowDuplicates = false) => Relay.AddOnce(listener, allowDuplicates);

        /// <inheritdoc />
        public bool RemoveListener(TDelegate listener) => Relay.RemoveListener(listener);

        /// <inheritdoc />
        public bool RemoveOnce(TDelegate listener) => Relay.RemoveOnce(listener);

        /// <inheritdoc />
        public void RemoveAll(bool persistent = true, bool oneTime = true) => Relay.RemoveAll(persistent, oneTime);

        #endregion
    }
}
