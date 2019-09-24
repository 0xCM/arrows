//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Bits;

    partial class BitParts
    {        
        [MethodImpl(Inline)]
        static ref ulong uint64(ref BitBlock8 src)
            => ref Unsafe.As<BitBlock8,ulong>(ref src);

        [MethodImpl(Inline)]
        static ref ulong uint64c(in BitBlock8 src)
            => ref Unsafe.As<BitBlock8,ulong>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        static ref ulong uint64(ref BitBlock16 src, N0 lo)
            => ref Unsafe.As<BitBlock8,ulong>(ref src.Block8x0);

        [MethodImpl(Inline)]
        static ref ulong uint64(ref BitBlock16 src, N1 hi)
            => ref Unsafe.As<BitBlock8,ulong>(ref src.Block8x1);


        [MethodImpl(Inline)]
        public static byte pack8x1(BitBlock8 src)
        {            
            return (byte)Bits.gather(uint64(ref src), (ulong)BitMask64.Lsb8);
            
        }

        [MethodImpl(Inline)]
        public static ref ushort pack16x1(BitBlock16 src, ref ushort dst)
        {            
            dst |= (ushort)Bits.gather(uint64(ref src.Block8x0), (ulong)BitMask64.Lsb8);
            dst |= (ushort)(Bits.gather(uint64(ref src.Block8x1), (ulong)BitMask64.Lsb8) << 8);
            return ref dst;
        }

        public static ref uint pack32x1(in BitBlock32 src, ref uint dst)
        {            
            dst |= (uint)Bits.gather(uint64c(in src.Block8x0), (ulong)BitMask64.Lsb8);
            dst |= (uint)(Bits.gather(uint64c(in src.Block8x1), (ulong)BitMask64.Lsb8) << 8);
            dst |= (uint)(Bits.gather(uint64c(in src.Block8x2), (ulong)BitMask64.Lsb8) << 16);
            dst |= (uint)(Bits.gather(uint64c(in src.Block8x3), (ulong)BitMask64.Lsb8) << 24);            
            return ref dst;
        }


        public static ref BitBlock8 unpack8x1(byte src, ref BitBlock8 dst)
        {
            uint64(ref dst) = Bits.scatter((uint)src, (ulong)BitMask64.Lsb8);
            return ref dst;
        }

        public static Span<byte> unpack8x1(byte src, Span<byte> dst)
        {            
            BitConverter.GetBytes(Bits.scatter((uint)src, (ulong)BitMask64.Lsb8)).CopyTo(dst);
            return dst;            
        }

        public static Span<byte> unpack16x1(ushort src, Span<byte> dst)
        {
            (var lo, var hi) = Bits.split(src);
            unpack8x1(lo, dst);
            unpack8x1(hi, dst.Slice(7));
            return dst;
        }

        public static Span<byte> unpack32x1(uint src, Span<byte> dst)
        {
            (var lo, var hi) = Bits.split(src);
            unpack16x1(lo, dst);
            unpack16x1(hi, dst.Slice(15));
            return dst;
        }


        public static Span<byte> unpack64x1(ulong src, Span<byte> dst)
        {
            (var lo, var hi) = Bits.split(src);
            unpack32x1(lo, dst);
            unpack32x1(hi, dst.Slice(31));
            return dst;
        }


    }

}