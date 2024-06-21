using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AIO.UEngine;

namespace AIO
{
    public static partial class EventSystem
    {
        private static readonly Dictionary<int, Dictionary<string, object>> RelayParams       = new Dictionary<int, Dictionary<string, object>>(8);
        private static readonly Dictionary<object, ICollection<int>>        ListenersByCaller = new Dictionary<object, ICollection<int>>(8);

        public static void Initialize()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies.Where(assembly => null != assembly.GetCustomAttribute<EventInitializeAttribute>()))
            {
                Register(assembly);
            }
        }

        public static void Register(Assembly assembly) { RegisterInternal(assembly); }

        private static void RegisterInternal(Assembly assembly)
        {
            var parent = typeof(IEventHandler);
            foreach (var type in from type in assembly.GetTypes() where type.IsClass where !type.IsAbstract where parent.IsAssignableFrom(type) select type)
            {
                Activator.CreateInstance(type);
            }
        }
    }
}
