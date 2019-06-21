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
        public static Span<T> shiftr<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> offsets, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(src), offsets, int8(dst));
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(src), offsets, uint8(dst));
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(src), offsets, int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(src), offsets, uint16(dst));
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(src), offsets, int32(dst));
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(src), offsets, uint32(dst));
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(src), offsets, int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(src), offsets, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        public static Span<T> shiftr<T>(ReadOnlySpan<T> src, int offset, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(src), offset, int8(dst));
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(src), offset, uint8(dst));
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(src), offset, int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(src), offset, uint16(dst));
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(src), offset, int32(dst));
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(src), offset, uint32(dst));
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(src), offset, int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(src), offset, uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        public static Span<T> shiftr<T>(ReadOnlySpan<T> src, int offset)
            where T : struct
            => shiftr(src, offset, span<T>(src.Length));
 
        [MethodImpl(Inline)]
        public static ref Span<T> shiftr<T>(ref Span<T> src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(src), offset);
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(src), offset);
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(src), offset);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(src), offset);
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(src), offset);
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(src), offset);
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(src), offset);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> shiftr<T>(ref Span<T> src, Span<int> offsets)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(src), offsets);
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(src), offsets);
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(src), offsets);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(src), offsets);
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(src), offsets);
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(src), offsets);
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(src), offsets);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(src), offsets);
            else
                throw unsupported<T>();
            return ref src;
        }
 
        [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> offsets, Span<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(src), offsets, int8(dst));
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(src), offsets, uint8(dst));
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(src), offsets, int16(dst));
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(src), offsets, uint16(dst));
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(src), offsets, int32(dst));
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(src), offsets, uint32(dst));
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(src), offsets, int64(dst));
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(src), offsets, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> src, int offset, Span<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(src), offset, int8(dst));
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(src), offset, uint8(dst));
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(src), offset, int16(dst));
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(src), offset, uint16(dst));
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(src), offset, int32(dst));
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(src), offset, uint32(dst));
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(src), offset, int64(dst));
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(src), offset, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> src, int offset)
            where T : struct
            => shiftl(src, offset, span<T>(src.Length));

        [MethodImpl(Inline)]
        public static ref Span<T> shiftl<T>(ref Span<T> src, int offset)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(src), offset);
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(src), offset);
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(src), offset);
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(src), offset);
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(src), offset);
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(src), offset);
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(src), offset);
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(src), offset);
            else
                throw unsupported(PrimalKinds.kind<T>());
            return ref src;

        }

        [MethodImpl(Inline)]
        public static ref Span<T> shiftl<T>(ref Span<T> src, Span<int> offsets)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                math.shiftl(int8(src), offsets);
            else if (typeof(T) == typeof(byte))
                math.shiftl(uint8(src), offsets);
            else if (typeof(T) == typeof(short))
                math.shiftl(int16(src), offsets);
            else if (typeof(T) == typeof(ushort))
                math.shiftl(uint16(src), offsets);
            else if (typeof(T) == typeof(int))
                math.shiftl(int32(src), offsets);
            else if (typeof(T) == typeof(uint))
                math.shiftl(uint32(src), offsets);
            else if (typeof(T) == typeof(long))
                math.shiftl(int64(src), offsets);
            else if (typeof(T) == typeof(ulong))
                math.shiftl(uint64(src), offsets);
            else
                throw unsupported(PrimalKinds.kind<T>());
            return ref src;
        }


        public static ref Span<T> rotr<T>(ref Span<T> io, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var len = io.Length;
            for(var i=0; i<len; i++)
                io[i] = rotr(io[i],rhs[i]);
            return ref io;
        }

        public static ref Span<T> rotl<T>(ref Span<T> io, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var len = io.Length;
            for(var i=0; i<len; i++)
                io[i] = rotl(io[i],rhs[i]);
            return ref io;
        }

    }
}