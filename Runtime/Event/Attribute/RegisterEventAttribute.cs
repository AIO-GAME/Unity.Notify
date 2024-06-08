using System;

namespace AIO.UEngine
{
    /// <summary>
    /// 注册事件
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class RegisterEventAttribute : Attribute
    {
        public int Key { get; }

        public RegisterEventAttribute(string name) { Key = name.GetHashCode(); }

        public RegisterEventAttribute(int key) { Key = key; }

        public RegisterEventAttribute(Type type) { Key = type.GetHashCode(); }

        public RegisterEventAttribute(Enum value) { Key = value.GetHashCode(); }
    }
}