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
        [MethodImpl(Inline)]
        public static ref T pack<T>(in ReadOnlySpan<Bit> src, out T dst)
            where T : struct
        {
            dst = default;
            
            if(typeof(T) == typeof(sbyte))
                Bits.pack(in src, out int8(ref dst));
            else if(typeof(T) == typeof(byte))
                Bits.pack(in src, out uint8(ref dst));
            else if(typeof(T) == typeof(short))
                Bits.pack(in src, out int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                Bits.pack(in src, out uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.pack(in src, out int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.pack(in src, out uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.pack(in src, out int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.pack(in src, out uint64(ref dst));        
            else
                throw unsupported<T>();
            
            return ref dst;
        }

         public static Span<T> pack<S,T>(ReadOnlySpan<S> src, Span<T> dst)            
            where S : struct
            where T : struct
        {
            var srcIx = 0;
            var dstOffset = 0;
            var dstIx = 0;
            var srcSize = (int)SizeOf<S>.BitSize;
            var dstSize = (int)SizeOf<T>.BitSize;
            
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