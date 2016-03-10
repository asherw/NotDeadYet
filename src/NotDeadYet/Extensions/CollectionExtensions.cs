using System;
using System.Collections.Generic;

namespace NotDeadYet.Extensions
{
    public static class CollectionExtensions
    {
        public static IEnumerable<T> Do<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
                yield return item;
            }
        }

        public static void Done<T>(this IEnumerable<T> items)
        {
            var enumerator = items.GetEnumerator();
            while (enumerator.MoveNext())
            {
                // just force enumeration; that's all.
            }
        }
    }
}
