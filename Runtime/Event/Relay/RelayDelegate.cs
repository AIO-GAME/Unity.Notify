using System;
using UnityEngine.Scripting;

namespace AIO.UEngine
{
    [Preserve]
    public interface IRelayLinkDelegate : IRelayLinkBase<Delegate> { }

    [Preserve]
    public class RelayDelegateLink : RelayLinkBase<Delegate>, IRelayLinkDelegate
    {
        public RelayDelegateLink(RelayBase<Delegate> relay) : base(relay) { }
    }

    [Preserve]
    public class RelayDelegate : RelayBase<Delegate>, IRelayLinkDelegate
    {
        [Preserve]
        private IRelayLinkDelegate link = null;

        [Preserve]
        public IRelayLinkDelegate Link
        {
            get
            {
                if (HasLink) return link;
                link    = new RelayDelegateLink(this);
                HasLink = true;
                return link;
            }
        }

        [Preserve]
        public void Dispatch()
        {
            for (var i = Count; i > 0; --i)
            {
                if (i > Count) throw IndexOutError;
                if (Listeners[i - 1] != null) Listeners[i - 1]?.DynamicInvoke();
                else RemoveAt(i - 1);
            }

            for (var i = OnceCount; i > 0; --i)
            {
                OnceCount = RemoveAt(ListenersOnce, OnceCount, i - 1);
                ListenersOnce[i - 1]?.DynamicInvoke();
            }
        }
    }
}