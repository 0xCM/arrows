//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitRef
    {
        public static Span<T> ShiftR<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> offsets, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(src).ShiftR(offsets, int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(src).ShiftR(offsets, uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(src).ShiftR(offsets, int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(src).ShiftR(offsets, uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(src).ShiftR(offsets, int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(src).ShiftR(offsets, uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(src).ShiftR(offsets, int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(src).ShiftR(offsets, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        public static Span<T> ShiftR<T>(ReadOnlySpan<T> src, int offset, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(src).ShiftR(offset, int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(src).ShiftR(offset, uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(src).ShiftR(offset, int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(src).ShiftR(offset, uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(src).ShiftR(offset, int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(src).ShiftR(offset, uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(src).ShiftR(offset, int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(src).ShiftR(offset, uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        public static Span<T> shiftr<T>(ReadOnlySpan<T> src, int offset)
            where T : struct
            => ShiftR(src, offset, span<T>(src.Length));
 
        [MethodImpl(Inline)]
        public static Span<T> ShiftR<T>(Span<T> src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(src).ShiftR(offset);
            else if(typeof(T) == typeof(byte))
                uint8(src).ShiftR(offset);
            else if(typeof(T) == typeof(short))
                int16(src).ShiftR(offset);
            else if(typeof(T) == typeof(ushort))
                uint16(src).ShiftR(offset);
            else if(typeof(T) == typeof(int))
                int32(src).ShiftR(offset);
            else if(typeof(T) == typeof(uint))
                uint32(src).ShiftR(offset);
            else if(typeof(T) == typeof(long))
                int64(src).ShiftR(offset);
            else if(typeof(T) == typeof(ulong))
                uint64(src).ShiftR(offset);
            else
                throw unsupported<T>();
            return src;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> shiftr<T>(ref Span<T> src, Span<int> offsets)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(src).ShiftR(offsets);
            else if(typeof(T) == typeof(byte))
                uint8(src).ShiftR(offsets);
            else if(typeof(T) == typeof(short))
                int16(src).ShiftR(offsets);
            else if(typeof(T) == typeof(ushort))
                uint16(src).ShiftR(offsets);
            else if(typeof(T) == typeof(int))
                int32(src).ShiftR(offsets);
            else if(typeof(T) == typeof(uint))
                uint32(src).ShiftR(offsets);
            else if(typeof(T) == typeof(long))
                int64(src).ShiftR(offsets);
            else if(typeof(T) == typeof(ulong))
                uint64(src).ShiftR(offsets);
            else
                throw unsupported<T>();
            return ref src;
        }

        static Span<sbyte> ShiftR(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<byte> ShiftR(this ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<short> ShiftR(this ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<ushort> ShiftR(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<int> ShiftR(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<uint> ShiftR(this ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<long> ShiftR(this ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<ulong> ShiftR(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }
 
        static Span<sbyte> ShiftR(this ReadOnlySpan<sbyte> lhs, int rhs, Span<sbyte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        static Span<byte> ShiftR(this ReadOnlySpan<byte> lhs, int rhs, Span<byte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        static Span<short> ShiftR(this ReadOnlySpan<short> lhs, int rhs, Span<short> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        static Span<ushort> ShiftR(this ReadOnlySpan<ushort> lhs, int rhs, Span<ushort> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        static Span<int> ShiftR(this ReadOnlySpan<int> lhs, int rhs, Span<int> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        static Span<uint> ShiftR(this ReadOnlySpan<uint> lhs, int rhs, Span<uint> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        static Span<long> ShiftR(this ReadOnlySpan<long> lhs, int rhs, Span<long> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        static Span<ulong> ShiftR(this ReadOnlySpan<ulong> lhs, int rhs, Span<ulong> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }


        static Span<sbyte> ShiftR(this Span<sbyte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        static Span<byte> ShiftR(this Span<byte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        static Span<short> ShiftR(this Span<short> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        static Span<ushort> ShiftR(this Span<ushort> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        static Span<int> ShiftR(this Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        static Span<uint> ShiftR(this Span<uint> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        static Span<long> ShiftR(this Span<long> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        static Span<ulong> ShiftR(this Span<ulong> lhs, int rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

 
         static Span<sbyte> ShiftR(this Span<sbyte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        static Span<byte> ShiftR(this Span<byte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        static Span<short> ShiftR(this Span<short> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        static Span<ushort> ShiftR(this Span<ushort> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        static Span<int> ShiftR(this Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        static Span<uint> ShiftR(this Span<uint> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        static Span<long> ShiftR(this Span<long> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        static Span<ulong> ShiftR(this Span<ulong> lhs, ReadOnlySpan<int> rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        [MethodImpl(Inline)]
        static sbyte shiftr(sbyte lhs, int rhs)
            => (sbyte)(lhs >> rhs);

        [MethodImpl(Inline)]
        static byte shiftr(byte lhs, int rhs)
            => (byte)(lhs >> rhs);

        [MethodImpl(Inline)]
        static short shiftr(short lhs, int rhs)
            => (short)(lhs >> rhs);

        [MethodImpl(Inline)]
        static ushort shiftr(ushort lhs, int rhs)
            => (ushort)(lhs >> rhs);

        [MethodImpl(Inline)]
        static int shiftr(int lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        static uint shiftr(uint lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        static long shiftr(long lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        static ulong shiftr(ulong lhs, int rhs)
            => lhs >> rhs;


    }

}