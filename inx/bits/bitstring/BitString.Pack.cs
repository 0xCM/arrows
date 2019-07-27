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
    
    using static zfunc;
    using static As;
    using static Constants;

    partial struct BitString
    {
        /// <summary>
        /// Renders the bitstring as a packed primal value
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public T TakePrimalValue<T>(int offset = 0)
            where T : struct
                => Pack<T>(offset, Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        public Span<byte> PackedBits(int offset = 0, int? minlen = null)
            => PackedBits(bitseq, offset, minlen);

        static Span<byte> PackedBits(ReadOnlySpan<byte> src, int offset = 0, int? minlen = null)
        {            
            if(src.Length <= offset)
                return new byte[minlen ?? 1];

            var srcLen = (uint)(src.Length - offset);
            var dstLen = Mod<N8>.div(srcLen) + (Mod<N8>.mod(srcLen) == 0 ? 0 : 1);   
            if(minlen != null && dstLen < minlen)
                dstLen = minlen.Value;

            Span<byte> dst = new byte[dstLen];
            for(int i=0, j=0; j < dstLen; i+=8, j++)
            {
                ref var x = ref dst[j];
                for(var k=0; k<8; k++)
                {
                    var srcIx = i + k + offset;
                    if(srcIx < srcLen && src[srcIx] != 0)
                        Bits.enable(ref x, in k);
                }
            }
            return dst;
        }

        [MethodImpl(Inline)]
        T Pack<T>(int offset = 0, int? minlen = null)
            where T : struct
        {            
            var src = bitseq.ToReadOnlySpan();
            var packed = PackedBits(src,offset,minlen);
            return SpanConvert.TakeSingle<byte,T>(packed);
        }
    }
}