//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        
         public static ref T pack<T>(ReadOnlySpan<Bit> src, ref T dst)         
            where T : struct
        {
            var tSize = Unsafe.SizeOf<T>();
            Span<byte> bs = stackalloc byte[tSize];
            dst = MemoryMarshal.Cast<byte,T>(Bits.pack(src.Slice(0, tSize*8), bs)).First();
            return ref dst;
        }

         public static Span<T> pack<T>(ReadOnlySpan<Bit> src, Span<T> dst)         
            where T : struct
        {
            Bits.pack(src, dst.AsBytes());
            return dst;

        }
         public static Span<T> pack<S,T>(ReadOnlySpan<S> src, Span<T> dst)            
            where S : struct
            where T : struct
        {
            var srcIx = 0;
            var dstOffset = 0;
            var dstIx = 0;
            var srcSize = Unsafe.SizeOf<S>()*8;
            var dstSize = Unsafe.SizeOf<T>()*8;
            
            while(srcIx < src.Length && dstIx < dst.Length)
            {
                for(byte i = 0; i< srcSize; i++)
                    if(test(src[srcIx], i))
                       enable(ref dst[dstIx], dstOffset + i);

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