using System;
using UnityEngine.Scripting;

namespace AIO.UEngine
{
    /// <summary>
    /// 注册事件
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)] [Preserve]
    public class RegisterEventAttribute : PreserveAttribute
    {
        public int Key { get; }

        public RegisterEventAttribute(string name) { Key = name.GetHashCode(); }

        public RegisterEventAttribute(int key) { Key = key; }

        public RegisterEventAttribute(byte key) { Key = key; }

        public RegisterEventAttribute(Type type) { Key = type.GetHashCode(); }

        public RegisterEventAttribute(Enum value) { Key = value.GetHashCode(); }
    }
}