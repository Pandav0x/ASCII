using System;
using System.Collections.Generic;
using System.Linq;

namespace pulsee.engine.Utils
{
    static class Reflexion
    {
        public static List<Type> GetTypesImplementing<T>()
        {
            Type type = typeof(T);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract);

            return new List<Type>(types);
        }

        public static List<object> InstanciateFromTypeList(List<Type> typeList)
        {
            List<object> instances = new List<object>();

            foreach (Type t in typeList) {
                instances.Add(InstanciateFromType(t));
            }

            return instances;
        }

        public static object InstanciateFromType(Type type)
        {
            return Activator.CreateInstance(type);
        }

        public static List<object> GetInstancesImplementing<T>()
        {
            return InstanciateFromTypeList(GetTypesImplementing<T>());
        }
    }
}
