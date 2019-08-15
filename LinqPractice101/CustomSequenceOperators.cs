using System;
using System.Collections.Generic;

namespace LinqPractice101
{
    public static class CustomSequenceOperators
    {
        public static IEnumerable<T> Combine<T>(this IEnumerable<int> first, IEnumerable<int> second, Func<int, int, T> func)
        {
            using (IEnumerator<int> e1 = first.GetEnumerator(), e2 = second.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext())
                {
                    yield return func(e1.Current, e2.Current);
                }
            }
        }
    }
}