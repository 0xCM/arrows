//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class math
    {

        [MethodImpl(Inline)]
        public static ref ulong log2(ref ulong dst, ref ulong x, ulong power)
        {
            if(x >= 1ul << (int)power)
            {
                x >>= (int)power;
                dst |= power;
            }
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ulong log2(ulong src)
        {
            var x = 0ul;
            var y = src;
            log2(ref x, ref y, Pow2.T05);
            log2(ref x, ref y, Pow2.T04);
            log2(ref x, ref y, Pow2.T03);
            log2(ref x, ref y, Pow2.T02);
            log2(ref x, ref y, Pow2.T01);
            
            if(y >= 1 << 1)
                x |= 1;
            return x;
        }

        [MethodImpl(Inline)]
        public static ulong log2(int src)
            => log2((ulong)src);

        [MethodImpl(Inline)]
        public static ulong log2(uint src)
            => log2((ulong)src);
    }

}