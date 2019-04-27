//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Linq.Expressions;
    using System.IO;
    using System.Diagnostics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static zcore;
    
    partial class Reflections
    {
        static readonly ConcurrentDictionary<MethodInfo, Delegate> Delegates = new ConcurrentDictionary<MethodInfo, Delegate>();

        static Func<T,T,T> BuildBinaryOp<T>(this MethodInfo target)
        {
            var operand = typeof(T);                        
            var method = new DynamicMethod("Mul", operand, new Type[] { operand, operand }, operand.Module);            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldarg_1);
            gen.EmitCall(OpCodes.Call, target, null);
            gen.Emit(OpCodes.Ret);
            return (Func<T,T,T>) method.CreateDelegate(typeof(Func<T,T,T>));
        }
        
        [MethodImpl(Inline)]
        public static Func<T,T,T> ToBinaryOperator<T>(this MethodInfo target)
            => (Func<T,T,T>) Delegates.GetOrAdd(target, m => m.BuildBinaryOp<T>());

        /// <summary>
        /// Creates an instance of a type and casts the instance value as specified by a type parameter
        /// </summary>
        /// <typeparam name="T">The cast instance type</typeparam>
        /// <param name="t">The type for which an instance will be created</param>
        /// <param name="args">Arguments matched with/passed to an instance constructor defined by the type</param>
        [MethodImpl(Inline)]
        public static T CreateInstance<T>(this Type t, params object[] args)
            => (T)Activator.CreateInstance(t, args);

        /// <summary>
        /// Recursively close an IEnumerable generic type
        /// </summary>
        /// <param name="stype">The sequence type</param>
        /// <remarks>
        /// Adapted from https://blogs.msdn.microsoft.com/mattwar/2007/07/30/linq-building-an-iqueryable-provider-part-i/
        /// </remarks>
        public static Option<Type> CloseEnumerableType(this Type stype)
        {
            if (stype == typeof(string))
                return null;

            if (stype.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(stype.GetElementType());

            if (stype.IsGenericType)
            {
                foreach (var arg in stype.GetGenericArguments())
                {
                    var enumerable = typeof(IEnumerable<>).MakeGenericType(arg);
                    if (enumerable.IsAssignableFrom(stype))
                        return enumerable;
                }
            }

            var interfaces = stype.GetInterfaces();
            if (interfaces != null && interfaces.Length > 0)
            {
                foreach (var i in interfaces)
                {
                    var ienum = CloseEnumerableType(i);
                    if (ienum.Exists)
                        return ienum;
                }
            }

            if (stype.BaseType != null && stype.BaseType != typeof(object))
                return CloseEnumerableType(stype.BaseType);
            return null;
        }

    }

}