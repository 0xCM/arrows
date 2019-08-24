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
    
    using static zfunc;

    partial class BitsX
    {        
        public static ref Span<byte> Pack(this ReadOnlySpan<Bit> src, out Span<byte> dst)
        {
            dst = span<byte>(src.Length/8);
            for(var i=0; i<src.Length; i++)
            for(var j=0; j < 8; j++)
               if(src[i]) BitMask.enable(ref dst[i], j);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> Pack(this Span<Bit> src, out Span<byte> dst)
            => ref src.ReadOnly().Pack(out dst);

        [MethodImpl(Inline)]   
        public static ref T Pack<T>(this Span<byte> src, out T dst, int offset = 0)
            where T : struct
        {
            dst = Bytes.read<T>(src, offset);
            return ref dst;
        }

        [MethodImpl(Inline)]   
        public static ref T Pack<T>(this ReadOnlySpan<byte> src, out T dst, int offset = 0)
            where T : struct
        {
            dst = Bytes.read<T>(src, offset);
            return ref dst;
        }

        [MethodImpl(Inline)]   
        public static Span<ushort> Pack(this ReadOnlySpan<byte> src, Span<ushort> dst)            
            => gbits.pack(src,dst);

        [MethodImpl(Inline)]   
        public static Span<uint> Pack(this ReadOnlySpan<byte> src, Span<uint> dst)            
            => gbits.pack(src,dst);

        [MethodImpl(Inline)]   
        public static Span<ulong> Pack(this ReadOnlySpan<byte> src, Span<ulong> dst)            
            => gbits.pack(src,dst);

        [MethodImpl(Inline)]   
        public static Span<uint> Pack(this ReadOnlySpan<ushort> src, Span<uint> dst)            
            => gbits.pack(src,dst);

        [MethodImpl(Inline)]   
        public static Span<ulong> Pack(this ReadOnlySpan<ushort> src, Span<ulong> dst)            
            => gbits.pack(src,dst);

        [MethodImpl(Inline)]   
        public static Span<ulong> Pack(this ReadOnlySpan<uint> src, Span<ulong> dst)            
            => gbits.pack(src,dst);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static Span<byte> Unpack<T>(this T src, out Span<byte> dst)
            where T : struct
                => dst = bytes(in src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> Unpack(this byte src, out Span<Bit> dst)
            => Bits.unpack(in src, out dst);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> Unpack(this ushort src, out Span<Bit> dst)
            => Bits.unpack(in src, out dst);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> Unpack(this int src, out Span<Bit> dst)
            => Bits.unpack(in src, out dst);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> Unpack(this ulong src, out Span<Bit> dst)
            => Bits.unpack(in src, out dst);

        public static Span<Bit> Unpack(this ReadOnlySpan<byte> src, out Span<Bit> dst)
        {            
            dst = span<Bit>(src.Length*8);
            var offset = 0;
            for(var i = 0; i<src.Length; i++, offset += 8)
                src[i].Unpack(out Span<Bit> _).CopyTo(dst.Slice(offset));
            return dst;
        }

        [MethodImpl(Inline)]        
        public static Span<Bit> Unpack(this Span<byte> src, out Span<Bit> dst)
            => src.ReadOnly().Unpack(out dst);

        [MethodImpl(Inline)]        
        public static Span<Bit> Unpack(this Span<ushort> src, out Span<Bit> dst)
            => src.AsBytes().Unpack(out dst);

        [MethodImpl(Inline)]        
        public static Span<Bit> Unpack(this Span<uint> src, out Span<Bit> dst)
            => src.AsBytes().Unpack(out dst);

        [MethodImpl(Inline)]        
        public static Span<Bit> Unpack(this Span<ulong> src, out Span<Bit> dst)
            => src.AsBytes().Unpack(out dst);


    }

}