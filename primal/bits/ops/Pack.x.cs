//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    
    using static zfunc;


    partial class BitX
    {
        

        [MethodImpl(Optimize)]
        public static ref Span<byte> Pack(this ReadOnlySpan<Bit> src, out Span<byte> dst)
        {
            dst = span<byte>(src.Length/8);
            for(var i=0; i<src.Length; i++)
            for(var j=0; j < 8; j++)
               if(src[i]) Bits.enable(ref dst[i], j);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> Pack(this Span<Bit> src, out Span<byte> dst)
            => ref src.ToReadOnlySpan().Pack(out dst);


        [MethodImpl(Inline)]   
        public static ref T Pack<T>(this Span<byte> src, out T dst, int offset = 0)
            where T : struct
        {
            dst = Bytes.read<T>(src, offset);
            return ref dst;
        }

        public static Span<uint> Pack(this ReadOnlySpan<byte> src, Span<uint> dst)            
        {
            var srcIx = 0;
            var dstOffset = 0;
            var dstIx = 0;
            var srcSize = SizeOf<byte>.BitSize;
            var dstSize = SizeOf<uint>.BitSize;
            while(srcIx < src.Length && dstIx < dst.Length)
            {
                for(var i = 0; i< srcSize; i++)
                    if(gbits.test(src[srcIx], i))
                        gbits.enable(ref dst[dstIx], dstOffset + i);

                srcIx++;
                if((dstOffset + srcSize) >= dstSize)
                {
                    dstOffset = 0;
                    dstIx++;
                }
                else
                    dstOffset += srcSize;
            }
            return dst;

        }


    }

}