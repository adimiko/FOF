using FOF.Internal;

namespace FOF
{
    /// <summary>
    /// Factory can create an object using a public or a non-public constructor.
    /// </summary>
    /// <typeparam name="TResult">The type of creating object.</typeparam>
    public static class Factory<TResult>
        where TResult : class
    {
        public static TResult Create()
            => Create<IgnoredType>(null);

        public static TResult Create<T1>(in T1 arg1)
            => Create<T1, IgnoredType>(arg1, null);

        public static TResult Create<T1, T2>(in T1 arg1, in T2 arg2)
            => Create<T1, T2, IgnoredType>(arg1, arg2, null);

        public static TResult Create<T1, T2, T3>(in T1 arg1, in T2 arg2, in T3 arg3)
            => Create<T1, T2, T3, IgnoredType>(arg1, arg2, arg3, null);

        public static TResult Create<T1, T2, T3, T4>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4)
            => Create<T1, T2, T3, T4, IgnoredType>(arg1, arg2, arg3, arg4, null);

        public static TResult Create<T1, T2, T3, T4, T5>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5)
            => Create<T1, T2, T3, T4, T5, IgnoredType>(arg1, arg2, arg3, arg4, arg5, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6)
            => Create<T1, T2, T3, T4, T5, T6, IgnoredType>(arg1, arg2, arg3, arg4, arg5, arg6, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6, T7>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7)
            => Create<T1, T2, T3, T4, T5, T6, T7, IgnoredType>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6, T7, T8>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8)
            => Create<T1, T2, T3, T4, T5, T6, T7, T8, IgnoredType>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9)
            => Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, IgnoredType>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9, in T10 arg10)
            => Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, IgnoredType>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9, in T10 arg10, in T11 arg11)
            => Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, IgnoredType>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9, in T10 arg10, in T11 arg11, in T12 arg12)
            => Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, IgnoredType>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9, in T10 arg10, in T11 arg11, in T12 arg12, in T13 arg13)
            => Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, IgnoredType>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9, in T10 arg10, in T11 arg11, in T12 arg12, in T13 arg13, in T14 arg14)
            => Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, IgnoredType>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9, in T10 arg10, in T11 arg11, in T12 arg12, in T13 arg13, in T14 arg14, in T15 arg15)
            => Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, IgnoredType>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, null);

        public static TResult Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9, in T10 arg10, in T11 arg11, in T12 arg12, in T13 arg13, in T14 arg14, in T15 arg15, in T16 arg16)
            => InternalFactory<TResult>.Create(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
    }
}