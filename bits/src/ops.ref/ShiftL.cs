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

        /// <summary>
        /// Shifts each element in the source span by an amount specified in the offset span
        /// and stores the result in a caller-allocated target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offsets">The offset span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ShiftL<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> offsets, Span<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(src).ShiftL(offsets, int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(src).ShiftL(offsets, uint8(dst));
            else if (typeof(T) == typeof(short))
                int16(src).ShiftL(offsets, int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(src).ShiftL(offsets, uint16(dst));
            else if (typeof(T) == typeof(int))
                int32(src).ShiftL(offsets, int32(dst));
            else if (typeof(T) == typeof(uint))
                uint32(src).ShiftL(offsets, uint32(dst));
            else if (typeof(T) == typeof(long))
                int64(src).ShiftL(offsets, int64(dst));
            else if (typeof(T) == typeof(ulong))
                uint64(src).ShiftL(offsets, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        /// <summary>
        /// Shifts each element in the source span by an amount specified in the offset span
        /// and stores the result in a caller-allocated target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offsets">The offset span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ShiftL<T>(Span<T> src, ReadOnlySpan<int> offsets, Span<T> dst)
            where T : struct
            => ShiftL(src.ReadOnly(),offsets, dst);

        /// <summary>
        /// Shifts each element in the source span by a common offset
        /// and stores the result in a caller-allocated target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The offset value</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ShiftL<T>(ReadOnlySpan<T> src, int offset, Span<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(src).ShiftL(offset, int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(src).ShiftL(offset, uint8(dst));
            else if (typeof(T) == typeof(short))
                int16(src).ShiftL(offset, int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(src).ShiftL(offset, uint16(dst));
            else if (typeof(T) == typeof(int))
                int32(src).ShiftL(offset, int32(dst));
            else if (typeof(T) == typeof(uint))
                uint32(src).ShiftL(offset, uint32(dst));
            else if (typeof(T) == typeof(long))
                int64(src).ShiftL(offset, int64(dst));
            else if (typeof(T) == typeof(ulong))
                uint64(src).ShiftL(offset, uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        /// <summary>
        /// Shifts each element in the source span by a common offset
        /// and stores the result in a caller-allocated target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The offset value</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ShiftL<T>(Span<T> src, int offset, Span<T> dst)
            where T : struct
                => ShiftL(src.ReadOnly(), offset, dst);

        /// <summary>
        /// Shifts each element in the source span by a common offset and allocates a span
        /// into which the result is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The offset value</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ShiftL<T>(Span<T> src, int offset)
            where T : struct
                => ShiftL(src, offset, span<T>(src.Length));

        /// <summary>
        /// Shifts each element in the source span by a common offset and allocates a span
        /// into which the result is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The offset value</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ShiftL<T>(ReadOnlySpan<T> src, int offset)
            where T : struct
                => ShiftL(src, offset, span<T>(src.Length));

        static Span<sbyte> ShiftL(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<byte> ShiftL(this ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<short> ShiftL(this ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<ushort> ShiftL(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<int> ShiftL(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<uint> ShiftL(this ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<long> ShiftL(this ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<ulong> ShiftL(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }
 
        static Span<sbyte> ShiftL(this ReadOnlySpan<sbyte> lhs, int rhs, Span<sbyte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<byte> ShiftL(this ReadOnlySpan<byte> lhs, int rhs, Span<byte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<short> ShiftL(this ReadOnlySpan<short> lhs, int rhs, Span<short> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<ushort> ShiftL(this ReadOnlySpan<ushort> lhs, int rhs, Span<ushort> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<int> ShiftL(this ReadOnlySpan<int> lhs, int rhs, Span<int> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<uint> ShiftL(this ReadOnlySpan<uint> lhs, int rhs, Span<uint> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<long> ShiftL(this ReadOnlySpan<long> lhs, int rhs, Span<long> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<ulong> ShiftL(this ReadOnlySpan<ulong> lhs, int rhs, Span<ulong> dst)
        {            
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }


        [MethodImpl(Inline)]
        static sbyte shiftl(sbyte lhs, int rhs)
            => (sbyte)(lhs << rhs);

        [MethodImpl(Inline)]
        static byte shiftl(byte lhs, int rhs)
            => (byte)(lhs << rhs);

        [MethodImpl(Inline)]
        static short shiftl(short lhs, int rhs)
            => (short)(lhs << rhs);

        [MethodImpl(Inline)]
        static ushort shiftl(ushort lhs, int rhs)
            => (ushort)(lhs << rhs);

        [MethodImpl(Inline)]
        static int shiftl(int lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        static uint shiftl(uint lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        static long shiftl(long lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        static ulong shiftl(ulong lhs, int rhs)
            => lhs << rhs;


    }

}