//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zcore;

    public static class DInXTiming 
    {   
        public static void Add<T>(string title, ref Duration total, int cycle, bool announce, T[] lhs, T[] rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.float64)
            {
                var xLhs = As.float64(lhs);
                var xRhs = As.float64(lhs);
                AddDirect(title, ref total, cycle, announce, xLhs, xRhs);
            }
        }

        public static void Add<T>(string title, ref Duration total, int cycle, bool announce, Vec128<T>[] lhs, Vec128<T>[] rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.float64)
            {
                var xLhs = As.float64(lhs);
                var xRhs = As.float64(lhs);
                AddDirect(title, ref total, cycle, announce, xLhs, xRhs);
            }
        }

        static void AddDirect(string title, ref Duration total, int cycle, bool announce, double[] lhs, double[] rhs)
        {
            var timing= Timing.begin(title, announce);                
            var dst = alloc<double>(length(lhs,rhs));            
            dinx.add(lhs, rhs, ref dst);                            
            Timing.end(ref total, timing, announce);
        }


        static void AddDirect(string title, ref Duration total, int cycle, bool announce, Vec128<double>[] lhs, Vec128<double>[] rhs)
        {
            var timing= Timing.begin(title, announce);                
            var len = length(lhs,rhs);
            for(var i = 0; i < len; i++)
                dinx.add(lhs[i], rhs[i]);                
            Timing.end(ref total, timing, announce);
        }
    }
}