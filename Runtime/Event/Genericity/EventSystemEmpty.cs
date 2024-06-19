using System;

namespace AIO.UEngine
{
    public static partial class EventSystem
    {
        #region Empty

        #region AddListener

        public static void AddListener<TE>(TE key, Action<EventArgs> action) where TE : Enum { AddListener(key.GetHashCode(), action); }

        public static void AddListener(int key, Action<EventArgs> action)
        {
            RelayAction<EventArgs> relay;
            if (RelayParams.TryGetValue(key, out var value))
                relay = value as RelayAction<EventArgs>;
            else
                RelayParams[key] = relay = new RelayAction<EventArgs>();
            relay?.AddListener(action);
        }

        public static void AddListener(string name, Action<EventArgs> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            AddListener(name.GetHashCode(), action);
        }

        #endregion

        #region RemoveListener

        public static void RemoveListener<TE>(TE key, Action<EventArgs> action) where TE : Enum { RemoveListener(key.GetHashCode(), action); }

        public static void RemoveListener(int key, Action<EventArgs> action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction<EventArgs> relay) relay.RemoveListener(action);
        }

        public static void RemoveListener(string name, Action<EventArgs> action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        public static void RemoveAllListener(int key, bool persistent = true, bool oneTime = true)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is IRelayLinkBase relayAction) relayAction.RemoveAll(persistent, oneTime);
        }

        public static void RemoveAllListener<TE>(TE key, bool persistent = true, bool oneTime = true) where TE : Enum
        {
            RemoveAllListener(key.GetHashCode(), persistent, oneTime);
        }

        public static void RemoveAllListener(string name, bool persistent = true, bool oneTime = true)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveAllListener(name.GetHashCode(), persistent, oneTime);
        }

        #endregion

        #endregion
    }
}
