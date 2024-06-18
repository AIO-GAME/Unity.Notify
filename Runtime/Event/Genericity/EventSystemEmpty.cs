using System;

namespace AIO.UEngine
{
    public static partial class EventSystem
    {
        #region Empty

        public static void AddListener(int key, Action<EventArgs> action)
        {
            RelayAction<EventArgs> relay;
            if (RelayParams.TryGetValue(key, out var value)) relay = value as RelayAction<EventArgs>;
            else RelayParams[key]                                  = relay = new RelayAction<EventArgs>();
            relay?.AddListener(action);
        }

        public static void RemoveListener(int key, Action action)
        {
            if (!RelayParams.TryGetValue(key, out var value)) return;
            if (value is RelayAction relay) relay.RemoveListener(action);
        }

        public static void RemoveListener(string name, Action action)
        {
            if (string.IsNullOrEmpty(name)) return;
            RemoveListener(name.GetHashCode(), action);
        }

        #endregion
    }
}