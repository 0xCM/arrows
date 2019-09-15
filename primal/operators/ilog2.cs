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
        public static ref ulong ilog2(ref ulong dst, ref ulong x, ulong power)
        {
            if(x >= 1ul << (int)power)
            {
                x >>= (int)power;
                dst |= power;
            }
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ulong ilog2(ulong src)
        {
            var x = 0ul;
            var y = src;
            ilog2(ref x, ref y, Pow2.T05);
            ilog2(ref x, ref y, Pow2.T04);
            ilog2(ref x, ref y, Pow2.T03);
            ilog2(ref x, ref y, Pow2.T02);
            ilog2(ref x, ref y, Pow2.T01);
            
            if(y >= 1 << 1)
                x |= 1;
            return x;
        }

        [MethodImpl(Inline)]
        public static ulong ilog2(int src)
            => ilog2((ulong)src);

        [MethodImpl(Inline)]
        public static ulong ilog2(uint src)
            => ilog2((ulong)src);
    }

}