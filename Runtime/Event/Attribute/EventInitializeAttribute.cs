using System;
using UnityEngine.Scripting;

namespace AIO.UEngine
{
    /// <summary>
    /// 程序集属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    [Preserve]
    public class EventInitializeAttribute : PreserveAttribute { }
}
