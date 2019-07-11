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

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
         public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.flip(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.flip(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.flip(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.flip(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.flip(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.flip(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.flip(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.flip(uint64(src), uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

         [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static ref Span<T> flip<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.flip(int8(io), int8(io));
            else if(typeof(T) == typeof(byte))
                math.flip(uint8(io), uint8(io));
            else if(typeof(T) == typeof(short))
                math.flip(int16(io), int16(io));
            else if(typeof(T) == typeof(ushort))
                math.flip(uint16(io), uint16(io));
            else if(typeof(T) == typeof(int))
                math.flip(int32(io), int32(io));
            else if(typeof(T) == typeof(uint))
                math.flip(uint32(io), uint32(io));
            else if(typeof(T) == typeof(long))
                math.flip(int64(io), int64(io));
            else if(typeof(T) == typeof(ulong))
                math.flip(uint64(io), uint64(io));
            else
                throw unsupported<T>();
            return ref io;
        }
 

    }
}