using System;
using System.Reflection;

namespace NotDeadYet.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsAssignableTo<TTarget>(this Type type)
        {
            return typeof(TTarget).IsAssignableFrom(type);
        }

        public static bool IsInstantiable(this Type type)
        {
#if NET40
            if (type.GetType().IsInterface) return false;
            if (type.GetType().IsAbstract) return false;
            if (type.GetType().ContainsGenericParameters) return false;
#else
            if (type.GetTypeInfo().IsInterface) return false;
            if (type.GetTypeInfo().IsAbstract) return false;
            if (type.GetTypeInfo().ContainsGenericParameters) return false;
#endif
            return true;
        }
    }
}
