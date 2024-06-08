using System;

namespace AIO.UEngine
{
    /// <summary>
    /// 程序集属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    public class EventInitializeAttribute : Attribute
    {
        public EventInitializeAttribute() { }
    }
}