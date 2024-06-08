#region Implementation

namespace AIO.UEngine
{
    public class RelayBinding<TDelegate> : IRelayBinding
    where TDelegate : class
    {
        protected IRelayLinkBase<TDelegate> _Relay    { get; private set; }
        protected TDelegate                 _Listener { get; private set; }

        #region Constructors

        private RelayBinding() { } // 私有空构造函数，强制使用参数

        public RelayBinding(IRelayLinkBase<TDelegate> relay, TDelegate listener, object caller, bool allowDuplicates, bool isListening) : this()
        {
            _Relay          = relay;
            _Listener       = listener;
            AllowDuplicates = allowDuplicates;
            Enabled         = isListening;
            Caller          = caller;
        }

        public RelayBinding(IRelayLinkBase<TDelegate> relay, TDelegate listener, bool allowDuplicates, bool isListening) : this()
        {
            _Relay          = relay;
            _Listener       = listener;
            AllowDuplicates = allowDuplicates;
            Enabled         = isListening;
        }

        #endregion

        #region IRelayBinding implementation

        /// <inheritdoc />
        public bool Enabled { get; private set; }

        /// <inheritdoc />
        public bool AllowDuplicates { get; set; }

        /// <inheritdoc />
        public object Caller { get; }

        /// <inheritdoc />
        public uint ListenerCount => _Relay.ListenerCount;

        /// <inheritdoc />
        public bool Enable(bool enable)
        {
            if (enable)
            {
                if (Enabled) return false;
                if (!_Relay.AddListener(_Listener, AllowDuplicates)) return false;
                Enabled = true;
                return true;
            }

            if (!Enabled) return false;
            if (!_Relay.RemoveListener(_Listener)) return false;
            Enabled = false;
            return true;
        }

        #endregion
    }
}

#endregion