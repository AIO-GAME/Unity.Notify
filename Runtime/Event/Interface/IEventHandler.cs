using UnityEngine.Scripting;

namespace AIO.UEngine
{
    [Preserve]
    public interface IEventHandler
    {
        int Key { get; }
    }
}