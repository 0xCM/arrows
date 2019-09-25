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

    }
}