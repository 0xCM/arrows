//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {                
        [MethodImpl(Inline)]
        public static ushort pack(byte x0, byte x1)
        {            
            return (ushort)(
              (ushort)x0 << 0 * 8
            | (ushort)x1 << 1 * 8
            );
        }


        [MethodImpl(Inline)]
        public static uint pack(byte x0, byte x1, byte x2, byte x3)
        {            
            return 
              (uint)x0 << 0 * 8
            | (uint)x1 << 1 * 8
            | (uint)x2 << 2 * 8
            | (uint)x3 << 3 * 8
            ;
        }


        [MethodImpl(Inline)]
        public static ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {            
            return 
              (ulong)x0 << 0 * 8
            | (ulong)x1 << 1 * 8
            | (ulong)x2 << 2 * 8
            | (ulong)x3 << 3 * 8
            | (ulong)x4 << 4 * 8
            | (ulong)x5 << 5 * 8
            | (ulong)x6 << 6 * 8
            | (ulong)x7 << 7 * 8
            ;
        }

        [MethodImpl(Inline)]
        public static uint pack(ushort x0, ushort x1)
        {            
            return 
              (uint)x0 << 0 * 16
            | (uint)x1 << 1 * 16
            ;
        }

        [MethodImpl(Inline)]
        public static ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)
            => (ulong)x0 << 0 * 16 | (ulong)x1 << 1 * 16 | (ulong)x0 << 2 * 16 | (ulong)x1 << 3 * 16;

        [MethodImpl(Inline)]
        public static (byte x0, byte x1) unpack(ushort x)
          => ((byte)(x >> 0*8), (byte)(x >> 1*8));


        [MethodImpl(Inline)]
        public static (byte x0, byte x1, byte x2, byte x3) unpack(uint x)
          => ((byte)(x >> 0*8), (byte)(x >> 1*8), (byte)(x >> 2*8), (byte)(x >> 3*8));

        [MethodImpl(Inline)]
        public static (byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7) unpack(ulong x)
        {            
          return (
            (byte)(x >> 0*8),
            (byte)(x >> 1*8),
            (byte)(x >> 2*8),
            (byte)(x >> 3*8),
            (byte)(x >> 4*8),
            (byte)(x >> 5*8),
            (byte)(x >> 6*8),
            (byte)(x >> 7*8));
        }

        /// <summary>
        /// Slelects a bit from each supplied byte according to the postion parameter and 
        /// packs these 8 bits into a single byte
        /// </summary>
        /// <param name="x00">The value to be packed into the least significant bit</param>
        /// <param name="x01">The second value</param>
        /// <param name="x02">The third value</param>
        /// <param name="x03">The fourth value</param>
        /// <param name="x04">The fifth value</param>
        /// <param name="x05">The sixth value</param>
        /// <param name="x06">The seventh value</param>
        /// <param name="x00">The value to be packed into the most significant bit</param>
        [MethodImpl(Inline)]
        public static ref byte pack(
          in byte x0, in byte x1, in byte x2, in byte x3, 
          in byte x4, in byte x5, in byte x6, in byte x7, 
          in byte pos, ref byte dst)
        {
          if(Bits.test(x0, pos)) Bits.enable(ref dst, 0);
          if(Bits.test(x1, pos)) Bits.enable(ref dst, 1);
          if(Bits.test(x2, pos)) Bits.enable(ref dst, 2);
          if(Bits.test(x3, pos)) Bits.enable(ref dst, 3);
          if(Bits.test(x4, pos)) Bits.enable(ref dst, 4);
          if(Bits.test(x5, pos)) Bits.enable(ref dst, 5);
          if(Bits.test(x6, pos)) Bits.enable(ref dst, 6);
          if(Bits.test(x7, pos)) Bits.enable(ref dst, 7);
          return ref dst;
        }


        [MethodImpl(Inline)]
        public static ulong pack(in uint x0, in uint x1)
              => (ulong)x0 | (ulong)x1 << 32;

        /// <summary>
        /// Packs bools into bytes
        /// </summary>
        /// <param name="src">The source values</param>
        /// <remarks>Adapted from https://stackoverflow.com/questions/713057/convert-bool-to-byte</remarks>
        public static byte[] pack(params bool[] src)
        {
            int srcLen = src.Length;
            int dstLen = srcLen >> 3;
            
            if ((srcLen & 0x07) != 0) 
                ++dstLen;

            var dst = new byte[dstLen];
            for (int i = 0; i < srcLen; i++)
                if (src[i])
                    dst[i >> 3] |= (byte)((byte)1 << (i & 0x07));
            
            return dst;
        }

        public static ref sbyte pack(in ReadOnlySpan<Bit> src, out sbyte dst)
        {
            dst = 0;
            var last = math.min(Pow2.T03, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (sbyte)(I32One << i);
            return ref dst;
        }

        public static ref byte pack(in ReadOnlySpan<Bit> src, out byte dst)
        {
            dst = 0;
            var last = math.min(Pow2.T03, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (byte)(I32One << i);
            return ref dst;
        }

        public static ref ushort pack(in ReadOnlySpan<Bit> src, out ushort dst)
        {
            dst = 0;
            var last = math.min(Pow2.T04, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (ushort)(I32One << i);
            return ref dst;
        }

        public static ref short pack(in ReadOnlySpan<Bit> src, out short dst)
        {
            dst = 0;
            var last = math.min(Pow2.T04, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (short)(I32One << i);
            return ref dst;
        }

        public static ref int pack(in ReadOnlySpan<Bit> src, out int dst)
        {
            dst = 0;
            var last = math.min(Pow2.T05, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1 << i);
            return ref dst;
        }

        public static ref uint pack(in ReadOnlySpan<Bit> src, out uint dst)
        {
            dst = 0;
            var last = math.min(Pow2.T05, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1u << i);
            return ref dst;
        }
        
        public static ref long pack(in ReadOnlySpan<Bit> src, out long dst)
        {
            dst = 0;
            var last = math.min(Pow2.T06, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1L << i);
            return ref dst;
        }

        public static ref ulong pack(in ReadOnlySpan<Bit> src, out ulong dst)
        {
            dst = 0;
            var last = math.min(Pow2.T06, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1ul << i);
            return ref dst;
        } 
 

        [MethodImpl(Inline)]
        static ref Bit test(in sbyte src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in byte src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in short src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in ushort src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in int src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != I32Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in uint src, in int pos, out Bit dst)
        {
            dst = (src & (1u << pos)) != U32Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in long src, in int pos, out Bit dst)
        {
            dst = (src & (1L << pos)) != I64Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in ulong src, in int pos, out Bit dst)
        {
            dst = (src & (1ul << pos)) != U64Zero;
            return ref dst;
        }

        public static Span<Bit> unpack(in sbyte src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T03];
            var last = Pow2.T03 - 1;
            for(var i = 0; i <= last; i++)
                test(in src, in i, out dst[last - i]);            
            return dst; 
        }

        public static Span<Bit> unpack(in byte src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T03];
            var last = Pow2.T03 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        public static Span<Bit> unpack(in ushort src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T04];
            var last = Pow2.T04 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }


        public static Span<Bit> unpack(in int src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T05];
            var last = Pow2.T05 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }


        public static Span<Bit> unpack(in long src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }        

        public static Span<Bit> unpack(in ulong src, out  Span<Bit> dst)
        {
            dst = new Bit[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                test(src, in i, out dst[last - i]);
            return dst; 
        }
 
        [MethodImpl(Inline)]
        public static Span<Bit> unpack(in float src, out Span<Bit> dst)
            => dst = unpack(BitConverter.SingleToInt32Bits(src), out dst);
        
        [MethodImpl(Inline)]
        public static Span<Bit> unpack(in double src, out Span<Bit> dst)
            => dst = unpack(BitConverter.DoubleToInt64Bits(src), out dst);
 
    }
}