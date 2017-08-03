using Bridge;
using System.Collections.Generic;

namespace System.Reflection
{
    public static class RuntimeReflectionExtensions
    {
        public static IEnumerable<PropertyInfo> GetRuntimeProperties(this Type type)
        {
            return default(IEnumerable<PropertyInfo>);
        }
        public static IEnumerable<EventInfo> GetRuntimeEvents(this Type type)
        {
            return default(IEnumerable<EventInfo>);
        }

        public static IEnumerable<MethodInfo> GetRuntimeMethods(this Type type)
        {
            return default(IEnumerable<MethodInfo>);
        }

        public static IEnumerable<FieldInfo> GetRuntimeFields(this Type type)
        {
            return default(IEnumerable<FieldInfo>);
        }

        public static PropertyInfo GetRuntimeProperty(this Type type, string name)
        {
            return default(PropertyInfo);
        }

        public static EventInfo GetRuntimeEvent(this Type type, string name)
        {
            return default(EventInfo);
        }

        public static MethodInfo GetRuntimeMethod(this Type type, string name, Type[] parameters)
        {
            return default(MethodInfo);
        }

        public static FieldInfo GetRuntimeField(this Type type, string name)
        {
            return default(FieldInfo);
        }

        public static MethodInfo GetRuntimeBaseDefinition(this MethodInfo method)
        {
            return default(MethodInfo);
        }

        public static InterfaceMapping GetRuntimeInterfaceMap(this TypeInfo typeInfo, Type interfaceType)
        {
            return default(InterfaceMapping);
        }

        public static MethodInfo GetMethodInfo(this Delegate del)
        {
            return default(MethodInfo);
        }
    }
}