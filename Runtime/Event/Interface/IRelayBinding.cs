namespace AIO.UEngine
{
    public interface IRelayBinding
    {
        /// <summary>
        /// 侦听器是否已经订阅
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// 启用绑定是否应将侦听器添加到中继，是否已经添加到其他地方
        /// </summary>
        bool AllowDuplicates { get; set; }

        /// <summary>
        /// 调用此实例的对象。
        /// </summary>
        /// <remarks>如果为空，则判断为静态函数</remarks>
        object Caller { get; }

        /// <summary>
        /// 当前有多少个绑定的中继持久侦听器
        /// </summary>
        uint ListenerCount { get; }

        /// <summary>
        /// 启用或禁用绑定的中继上的侦听器。
        /// </summary>
        /// <returns><c>True</c> 如果侦听器成功启用/禁用，否则为 <c>false</c></returns>
        bool Enable(bool enable);
    }
}