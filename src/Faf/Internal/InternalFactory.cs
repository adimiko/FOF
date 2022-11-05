using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Faf.Exceptions;

namespace Faf.Internal
{
    internal static class InternalFactory<TResult>
        where TResult : class
    {
        internal static TResult Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9, in T10 arg10, in T11 arg11, in T12 arg12, in T13 arg13, in T14 arg14, in T15 arg15, in T16 arg16)
        {
            if (CacheFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>.CompiledConstructors.TryGetValue(typeof(TResult), out var compiledConstructor))
            {
                return compiledConstructor(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            }

            Type[] parameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16) };

            Type[] constructorParameterTypes = parameterTypes.Where(t => t != typeof(IgnoredType)).ToArray();

            ConstructorInfo constructor = GetConstructor(constructorParameterTypes);
            ParameterExpression[] parameterExpressions = GetParameterExpressions(parameterTypes);

            var constructorParametersExpressions = parameterExpressions.Take(constructorParameterTypes.Length).ToArray();

            var constructorExpression = Expression.New(constructor, constructorParametersExpressions);

            var compiledConstructorExpression = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(constructorExpression, parameterExpressions).Compile();

            return CacheFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>.CompiledConstructors.GetOrAdd(typeof(TResult), compiledConstructorExpression).Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        private static ConstructorInfo GetConstructor(in Type[] constructorParameterTypes)
        {
            BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

            var constructorInfo = typeof(TResult).GetConstructor(bindingFlags, Type.DefaultBinder, constructorParameterTypes, null);

            return constructorInfo ?? throw new NotFoundConstructorException($"{typeof(TResult)} does not contain a constructor with the following parameter types: " + string.Join<Type>(", ", constructorParameterTypes));
        }

        private static ParameterExpression[] GetParameterExpressions(in Type[] constructorParameterTypes) => constructorParameterTypes.Select(x => Expression.Parameter(x)).ToArray();
    }
}