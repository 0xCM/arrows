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


    public static class BitReaderX
    {

        [MethodImpl(Inline)]
        public static void ReadBytes(this ushort src, ByteSize bytecount, Span<byte> dst, int offset)
        {
            if(bytecount == 1)
                src.Read1Byte(dst,offset);
            else
                src.Read2Bytes(dst,offset);                
        }

        [MethodImpl(Inline)]
        public static void ReadBytes(this uint src, ByteSize bytecount, Span<byte> dst, int offset)
        {
            if(bytecount == 1)
                src.Read1Byte(dst,offset);
            else if(bytecount == 2)
                src.Read2Bytes(dst,offset);
            else if(bytecount == 3)
                src.Read3Bytes(dst,offset);
            else 
                src.Read4Bytes(dst,offset);                
            
        }

        [MethodImpl(Inline)]
        public static void ReadBytes(this ulong src, ByteSize bytecount, Span<byte> dst, int offset)
        {
            if(bytecount <= 4)
                ((uint)src).ReadBytes(bytecount,dst,offset);
            else if(bytecount == 5)
                src.Read5Bytes(dst,offset);
            else if(bytecount == 6)
                src.Read6Bytes(dst,offset);
            else if(bytecount == 7)
                src.Read7Bytes(dst,offset);
            else
                src.Read8Bytes(dst,offset);                            
        }

        [MethodImpl(Inline)]
        public static void ReadBits(this byte src, uint i0, uint i1, Span<byte> dst, int offset)
            => Bits.bitrange(src, i0, i1).ReadBytes(ByteCount(i0,i1), dst,offset);

        [MethodImpl(Inline)]
        public static void ReadBits(this ushort src, uint i0, uint i1, Span<byte> dst, int offset)
            => Bits.bitrange(src, i0, i1).ReadBytes(ByteCount(i0,i1), dst,offset);

        [MethodImpl(Inline)]
        public static void ReadBits(this uint src, uint i0, uint i1, Span<byte> dst, int offset)
            => Bits.bitrange(src, i0, i1).ReadBytes(ByteCount(i0,i1), dst,offset);

        [MethodImpl(Inline)]
        public static void ReadBits(this ulong src, uint i0, uint i1, Span<byte> dst, int offset)
            => Bits.bitrange(src, i0, i1).ReadBytes(ByteCount(i0,i1), dst,offset);

        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this byte src, uint i0, uint i1)
        {
            var dst = Alloc(i0,i1);
            Bits.bitrange(src, i0, i1).ReadBytes(dst.Length, dst, 0);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this ushort src, uint i0, uint i1)
        {
            var dst = Alloc(i0,i1);
            Bits.bitrange(src, i0, i1).ReadBytes(dst.Length, dst, 0);
            return dst;
        }
        
        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this uint src, uint i0, uint i1)
        {
            var dst = Alloc(i0,i1);
            Bits.bitrange(src, i0, i1).ReadBytes(dst.Length, dst, 0);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this ulong src, uint i0, uint i1)
        {
            var dst = Alloc(i0,i1);
            Bits.bitrange(src, i0, i1).ReadBytes(dst.Length, dst, 0);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> ReadBits<T>(this T src, uint i0, uint i1)
            where T : struct
        {
            var size = Unsafe.SizeOf<T>();
            if(size == 1)
                return As.uint8(src).ReadBits(i0, i1);
            else if(size == 2)
                return As.uint16(src).ReadBits(i0, i1);
            else if(size == 3 || size == 4)
                return As.uint32(src).ReadBits(i0, i1);
            else if(size <= 8)
                return As.uint64(src).ReadBits(i0, i1);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static ByteSize ByteCount(uint i0, uint i1)
            => (i1 - i0 + 1).ByteCount();

        [MethodImpl(Inline)]
        static Span<byte> Alloc(uint i0, uint i1)        
            => new byte[ByteCount(i0,i1)];        

        [MethodImpl(Inline)]
        static ByteSize ByteCount(this uint bitcount)
            => (uint)(Mod<N8>.div(bitcount) + (Mod<N8>.mod(bitcount) == 0 ? 0 : 1));

        [MethodImpl(Inline)]
        static void CopyTo<T>(this T[] src, int srcOffset, int srcCount, Span<T> dst, int dstOffset)        
            => src.AsSpan().Slice(srcOffset, srcCount).CopyTo(dst, dstOffset);
        
        [MethodImpl(Inline)]
        static void Read1Byte(this ushort src, Span<byte> dst, int offset)
            => dst[offset] = (byte)src;

        [MethodImpl(Inline)]
        static void Read1Byte(this uint src, Span<byte> dst, int offset)        
            => dst[offset] = (byte)src;        

        [MethodImpl(Inline)]
        static void Read2Bytes(this ushort src, Span<byte> dst, int offset)
            => BitConverter.GetBytes((ushort)src).CopyTo(0,2, dst,offset);

        [MethodImpl(Inline)]
        static void Read2Bytes(this uint src, Span<byte> dst, int offset)
            => BitConverter.GetBytes((ushort)src).CopyTo(0, 2, dst,offset);        

        [MethodImpl(Inline)]
        static void Read3Bytes(this uint src, Span<byte> dst, int offset)
            => BitConverter.GetBytes((uint)src).CopyTo(0,3, dst, offset);
        
        [MethodImpl(Inline)]
        static void Read4Bytes(this uint src, Span<byte> dst, int offset)
            => BitConverter.GetBytes((uint)src).CopyTo(0,4,dst,offset);

        [MethodImpl(Inline)]
        static void Read5Bytes(this ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,5,dst,offset);

        [MethodImpl(Inline)]
        static void Read6Bytes(this ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,6,dst,offset);

        [MethodImpl(Inline)]
        static void Read7Bytes(this ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,7,dst,offset);

        [MethodImpl(Inline)]
        static void Read8Bytes(this ulong src, Span<byte> dst, int offset)
            => BitConverter.GetBytes(src).CopyTo(0,8,dst,offset);

    }

}