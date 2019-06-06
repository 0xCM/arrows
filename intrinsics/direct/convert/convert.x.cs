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

     
    using static zfunc;

    public static class VecConvertX
    {

        [MethodImpl(Inline)]
        public static Vec128<ulong> ToVec128(this in UInt128 src)
            => Vec128.define(src.lo, src.hi);

        [MethodImpl(Inline)]
        public static UInt128 ToUInt128(this in Vec128<ulong> src)
            => new UInt128(src[0], src[1]);



        // file:///J:/lang/areas/numerics/Lemire%20-%20Fast%20Random%20Integer%20Generation%20in%20an%20Interval.pdf        
        public static ulong NextInteger(this IRandomSource rng, ulong max) 
        {
            var x = rng.NextInteger();
            dinx.mul(x, max, out UInt128 m);
            ulong l = m.lo;
            if (l < max) 
            {
                ulong t = ~max % max;
                while (l < t) 
                {
                    x = rng.NextInteger();
                    m = dinx.mul(x, max, out UInt128 z);
                    l = m.lo;                    
                }
            }
        
            var vec = dinx.shiftrw(m.ToVec128(), 8);
            return vec.ToUInt128().lo;
        }

        public static IEnumerable<ulong> Integers(this IRandomSource rng, ulong max)
        {
            while(true)
                yield return rng.NextInteger(max);
        }
    }



}