//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    using static As;

    partial class gmath
    {
        public static void init()
        {
            one<byte>();
            one<sbyte>();        
            one<short>();
            one<ushort>();
            one<int>();
            one<uint>();
            one<long>();
            one<ulong>();
            one<float>();
            one<double>();
            
        }

        public static IEnumerable<MethodInfo> BinOps()
        {
            var methods = 
                from m in typeof(gmath).DeclaredMethods().OpenGeneric().Public()
                 let p = m.GetParameters()
                 where p.Length == 2
                 let p0 = p[0]
                 let p1 = p[1]
                 where p0.ParameterType.IsGenericMethodParameter && p1.ParameterType.IsGenericMethodParameter
                 select m;

            return methods;                                 
        }

        public static IEnumerable<MethodInfo> UnaryOps()
        {
            var methods = 
                from m in typeof(gmath).DeclaredMethods().OpenGeneric().Public()
                 let p = m.GetParameters()
                 where p.Length == 1
                 let p0 = p[0]
                 where p0.ParameterType.IsGenericMethodParameter
                 select m;
            return methods;                                 
        }

        /// <summary>
        /// Determines whether a primal type is a floating point type, i.e. a 32-bit 
        /// or 64-bit float
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline)]
        public static bool isFloat<T>()
            where T : struct
                => typeof(T) == typeof(double) || typeof(T) == typeof(float);
    }
}