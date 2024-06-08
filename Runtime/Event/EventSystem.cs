﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AIO.UEngine
{
    public static partial class EventSystem
    {
        private static readonly Dictionary<int, object> RelayParams = new Dictionary<int, object>();

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