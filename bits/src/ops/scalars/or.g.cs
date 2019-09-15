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
        /// <summary>
        /// Computes the bitwise OR of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct
                => gmath.or(lhs,rhs);

        /// <summary>
        /// Computes the bitwise OR of two primal operands and stores the
        /// result in the left operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T or<T>(ref T lhs, in T rhs)
            where T : struct
                => ref gmath.or(ref lhs, in rhs);

        [MethodImpl(Inline)]
        public static BlockVector<T> or<T>(BlockVector<T> lhs, BlockVector<T> rhs)
            where T : struct
        {
            var dst = lhs.Replicate(true);
            gbits.or(lhs.Data, rhs.Data, dst.Data);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                or(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                or(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                or(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                or(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                or(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                or(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                or(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                or(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> or<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                or(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                or(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                or(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                or(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                or(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                or(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                or(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                or(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> or<T>(Span<T> lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                or(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                or(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                or(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                or(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                or(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                or(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                or(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                or(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

        static Span<sbyte> or(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<byte> or(Span<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<short> or(Span<short> lhs, ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<ushort> or(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<int> or(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<uint> or(Span<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<long> or(Span<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<ulong> or(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] |= rhs[i];
            return lhs;
        }

        static Span<sbyte> or(Span<sbyte> lhs, sbyte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<byte> or(Span<byte> lhs, byte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<short> or(Span<short> lhs, short rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<ushort> or(Span<ushort> lhs, ushort rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<int> or(Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<uint> or(Span<uint> lhs, uint rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<long> or(Span<long> lhs, long rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }

        static Span<ulong> or(Span<ulong> lhs, ulong rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] |= rhs;
            return lhs;
        }



        static Span<sbyte> or(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<byte> or(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<short> or(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<ushort> or(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<int> or(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<uint> or(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<long> or(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<ulong> or(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = lhs[i] | rhs[i];
            return dst;                
        }


        public static Span<sbyte> flip(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<byte> flip(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;
        }

        public static Span<short> flip(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<ushort> flip(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<int> flip(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<uint> flip(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<long> flip(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<ulong> flip(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<sbyte> flip(Span<sbyte> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        public static Span<byte> flip(Span<byte> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        public static Span<short> flip(Span<short> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        public static Span<ushort> flip(Span<ushort> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        public static Span<int> flip(Span<int> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        public static Span<uint> flip(Span<uint> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        public static Span<long> flip(Span<long> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        public static Span<ulong> flip(Span<ulong> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

    }
}