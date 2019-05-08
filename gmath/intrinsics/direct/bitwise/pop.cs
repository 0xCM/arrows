//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    
    using static global::mfunc;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static uint popcount(uint src)
            => Popcnt.PopCount(src);

        [MethodImpl(Inline)]
        public static ulong popcount(ulong src)
            => Popcnt.X64.PopCount(src);

        [MethodImpl(Inline)]
        public static uint[] popcounts(uint min, uint max)
        {
            var current = min;
            var i = 0;
            var dst = new uint[max - min + 1];
            while(current <= max)
                dst[i++] = popcount(current++);
            return dst;
        }

    }
}