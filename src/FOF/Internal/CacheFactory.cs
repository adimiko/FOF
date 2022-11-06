using System;
using System.Collections.Concurrent;

namespace FOF.Internal
{
    internal static class CacheFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
        where TResult : class
    {
        internal static readonly ConcurrentDictionary<Type, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> CompiledConstructors = new ConcurrentDictionary<Type, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>();
    }
}