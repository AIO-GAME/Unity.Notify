namespace AIO.UEngine
{
    /// <summary>
    /// 侦听器链接基类。
    /// </summary>
    /// <typeparam name="TDelegate"> 侦听器委托类型。 </typeparam>
    public interface IRelayLinkBase<in TDelegate>
    where TDelegate : class
    {
        /// <summary>
        /// 这个实例当前有多少个持久侦听器
        /// </summary>
        uint ListenerCount { get; }

        /// <summary>
        /// 这个实例当前有多少个一次性侦听器，在调度之后，所有当前的一次性侦听器都会自动删除。
        /// </summary>
        uint OneTimeListenersCount { get; }

        /// <summary>
        /// 判断是否已经是一个持久侦听器，不查询一次性侦听器。
        /// </summary>
        /// <param name="listener">监听器</param>
        /// <returns>如果是持久侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        bool Contains(TDelegate listener);

        /// <summary>
        /// 判断是否已经是一个持久侦听器，不查询一次性侦听器。
        /// </summary>
        /// <param name="listener">监听器</param>
        /// <param name="caller">调用者</param>
        /// <returns>如果是持久侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        bool Contains(TDelegate listener, object caller);
        
        /// <summary>
        /// 添加一个持久侦听器。
        /// </summary>
        /// <returns>如果成功添加侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        /// <param name="listener">监听器</param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在持久侦听器。</param>
        /// <returns>如果成功添加侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        bool AddListener(TDelegate listener, bool allowDuplicates = false);

        /// <summary>
        /// 添加一个持久侦听器。
        /// </summary>
        /// <param name="listener">监听器</param>
        /// <param name="caller">调用者</param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在持久侦听器。</param>
        /// <returns>如果成功添加侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        bool AddListener(TDelegate listener, object caller, bool allowDuplicates = false);

        /// <summary>
        /// 绑定一个持久侦听器，可以用来启用/禁用侦听器。
        /// </summary>
        /// <remarks>可以使用 <see cref="IRelayBinding"/> 实例来启用/禁用侦听器。</remarks>
        /// <returns>如果成功绑定侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        /// <param name="listener">监听器</param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在持久侦听器。</param>
        /// <returns>如果成功绑定侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        IRelayBinding BindListener(TDelegate listener, bool allowDuplicates = false);

        /// <summary>
        /// 添加一个一次性侦听器。
        /// </summary>
        /// <remarks>可以使用 <see cref="IRelayBinding"/> 实例来启用/禁用侦听器。</remarks>
        /// <returns>如果成功绑定侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        /// <param name="listener">监听器</param>
        /// <param name="caller">调用者</param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在持久侦听器。</param>
        /// <returns>如果成功绑定侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        IRelayBinding BindListener(TDelegate listener, object caller, bool allowDuplicates = false);

        /// <summary>
        /// 添加一个一次性侦听器。
        /// </summary>
        /// <remarks> 一次性侦听器在调度之后会自动删除。 </remarks>
        /// <param name="listener">监听器</param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        /// <returns>如果成功添加侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        bool AddOnce(TDelegate listener, bool allowDuplicates = false);

        /// <summary>
        /// 添加一个一次性侦听器。
        /// </summary>
        /// <remarks> 一次性侦听器在调度之后会自动删除。 </remarks>
        /// <param name="listener">监听器</param>
        /// <param name="caller">调用者</param>
        /// <param name="allowDuplicates">如果 <c>false</c>, 检查是否已经存在一次性侦听器。</param>
        /// <returns>如果成功添加侦听器 <c>True</c>，否则为 <c>false</c>。</returns>
        bool AddOnce(TDelegate listener, object caller, bool allowDuplicates = false);

        /// <summary>
        /// 移除一个持久侦听器。
        /// </summary>
        /// <returns>如果成功移除侦听器 <c>true</c>, otherwise <c>false</c>.</returns>
        /// <param name="listener">监听器</param>
        /// <returns>如果成功移除侦听器 <c>true</c>, otherwise <c>false</c>.</returns>
        bool RemoveListener(TDelegate listener);

        /// <summary>
        /// 移除一个持久侦听器。
        /// </summary>
        /// <param name="listener">监听器</param>
        /// <param name="caller">调用者</param>
        /// <returns>如果成功移除侦听器 <c>true</c>, otherwise <c>false</c>.</returns>
        bool RemoveListener(TDelegate listener, object caller);

        /// <summary>
        /// 移除一个一次性侦听器。
        /// </summary>
        /// <param name="listener">监听器</param>
        /// <returns>如果成功移除侦听器 <c>true</c>, otherwise <c>false</c>.</returns>
        bool RemoveOnce(TDelegate listener);

        /// <summary>
        /// 移除一个一次性侦听器。
        /// </summary>
        /// <param name="listener">监听器</param>
        /// <param name="caller">调用者</param>
        /// <returns>如果成功移除侦听器 <c>true</c>, otherwise <c>false</c>.</returns>
        bool RemoveOnce(TDelegate listener, object caller);

        /// <summary>
        /// 移除所有侦听器。
        /// </summary>
        /// <param name="persistent">如果为 <c>true</c>, 移除持久侦听器。</param>
        /// <param name="oneTime">如果为 <c>true</c>, 移除一次性侦听器。</param>
        /// <returns>如果成功移除侦听器 <c>true</c>, otherwise <c>false</c>.</returns>
        void RemoveAll(bool persistent = true, bool oneTime = true);

        /// <summary>
        /// 移除所有侦听器。
        /// </summary>
        /// <param name="caller">调用者</param>
        /// <param name="persistent">如果为 <c>true</c>, 移除持久侦听器。</param>
        /// <param name="oneTime">如果为 <c>true</c>, 移除一次性侦听器。</param>
        void RemoveAll(object caller, bool persistent = true, bool oneTime = true);
    }
}