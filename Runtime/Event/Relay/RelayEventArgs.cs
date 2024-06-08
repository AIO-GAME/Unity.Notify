using System;

namespace AIO.UEngine
{
    public interface IRelayLinkEventArgs : IRelayLinkBase<Action> { }

    internal class RelayEventArgsLink : RelayLinkBase<Action>, IRelayLinkEventArgs
    {
        public RelayEventArgsLink(RelayBase<Action> relay) : base(relay) { }
    }

    public class RelayEventArgs : RelayBase<Action>, IRelayLinkEventArgs
    {
        private IRelayLinkEventArgs link = null;

        public IRelayLinkEventArgs Link
        {
            get
            {
                if (HasLink) return link;
                link    = new RelayEventArgsLink(this);
                HasLink = true;
                return link;
            }
        }

        public void Dispatch()
        {
            for (var i = _Count; i > 0; --i)
            {
                if (i > _Count) throw IndexOutError;
                if (_Listeners[i - 1] != null) _Listeners[i - 1]?.Invoke();
                else RemoveAt(i - 1);
            }

            for (var i = _OnceCount; i > 0; --i)
            {
                _OnceCount = RemoveAt(_ListenersOnce, _OnceCount, i - 1);
                _ListenersOnce[i - 1]?.Invoke();
            }
        }
    }

    /// <summary>
    /// 事件对象 用于派发事件传参数使用
    /// </summary>
    public class EventArgs
    {
        public static EventArgs Create(string type)              { return new EventArgs(type); }
        public static EventArgs Create(string type, object data) { return new EventArgs(type, data); }

        public static T Create<T>(string type)
        where T : EventArgs, new()
        {
            var eventArgs = Activator.CreateInstance<T>();

            if (eventArgs != null) eventArgs.Type = type;
            return eventArgs;
        }
        
        public static T Create<T>(string type, object data)
        where T : EventArgs, new()
        {
            var eventArgs = Activator.CreateInstance<T>();

            if (eventArgs != null)
            {
                eventArgs.Type = type;
                eventArgs.Data = data;
            }

            return eventArgs;
        }

        public EventArgs() { }

        public EventArgs(string type) { Type = type; }

        public EventArgs(string type, object data)
        {
            Type = type;
            Data = data;
        }

        /// <summary>
        /// 派发事件夹带的普通参数
        /// </summary>
        public object Data;

        /// <summary>
        /// 事件类型
        /// </summary>
        public string Type;

        /// <summary>
        /// 是否停止事件派发
        /// </summary>
        public bool IsPropagationImmediateStopped;

        /// <summary>
        /// 流转传递参数（用于高优先级往低优先级传递）
        /// </summary>
        public object TransmitData;

        /// <summary>
        /// 停止一个事件的派发
        /// </summary>
        public void StopImmediatePropagation() { IsPropagationImmediateStopped = true; }

        /// <summary>
        /// 设置流转数据
        /// </summary>
        /// <param name="data">需要流转的数据</param>
        public void SetTransmitData(object data) { TransmitData = data; }
    }
}