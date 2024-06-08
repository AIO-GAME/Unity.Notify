using System;

namespace AIO.UEngine
{
    public interface IRelayLinkDelegate : IRelayLinkBase<Delegate> { }

    public class RelayDelegateLink : RelayLinkBase<Delegate>, IRelayLinkDelegate
    {
        public RelayDelegateLink(RelayBase<Delegate> relay) : base(relay) { }
    }

    public class RelayDelegate : RelayBase<Delegate>, IRelayLinkDelegate
    {
        private IRelayLinkDelegate link = null;

        public IRelayLinkDelegate Link
        {
            get
            {
                if (HasLink) return link;
                link     = new RelayDelegateLink(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch()
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1]?.DynamicInvoke();
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.DynamicInvoke();
            }
        }
    }
}