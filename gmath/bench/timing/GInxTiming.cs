//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;



    public static class GInXTiming
    {

        public static void Add<T>(string title, ref Duration total, int cycle, bool announce, T[] lhs, T[] rhs)
            where T : struct, IEquatable<T>
        {
            var timing = Timing.begin(title, announce); 
            var dst = alloc<T>(length(lhs,rhs));
            ginx.add(lhs, rhs, ref dst);                                    
            Timing.end(ref total, timing, announce);
        }

        public static void Add<T>(string title, ref Duration total, int cycle, bool announce, Vec128<T>[] lhs, Vec128<T>[] rhs)
            where T : struct, IEquatable<T>
        {            
            var timing = Timing.begin(title, announce);                
            var len = length(lhs,rhs);
            for(var i = 0; i < len; i++)
                ginx.add(lhs[i], rhs[i]);                                    
            Timing.end(ref total, timing, announce);

        }

    }

}