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
    using static AsInX;

    partial class gbits
    {
        [MethodImpl(Inline)]
        public static T flip<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte) ~int8(src));  
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte) ~uint8(src));  
            else if(typeof(T) == typeof(short))
                return generic<T>((short) ~int16(src));  
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort) ~uint16(src));  
            else if(typeof(T) == typeof(int))
                return generic<T>(~int32(src));  
            else if(typeof(T) == typeof(uint))
                return generic<T>(~uint32(src));  
            else if(typeof(T) == typeof(long))
                return generic<T>(~int64(src));  
            else if(typeof(T) == typeof(ulong))
                return generic<T>(~uint64(src));  
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T flip<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.flip(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                math.flip(ref uint8(ref src));
            else if(typeof(T) == typeof(short))
                math.flip(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                math.flip(ref uint16(ref src));
            else if(typeof(T) == typeof(int))
                math.flip(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                math.flip(ref uint32(ref src));
            else if(typeof(T) == typeof(long))
                math.flip(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                math.flip(ref uint64(ref src));
            else            
                throw unsupported<T>();
            return ref src;
        }           

        [MethodImpl(Inline)]
        public static Vec128<T> flip<T>(in Vec128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.flip(in int8(in src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.flip(in uint8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.flip(in int16(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.flip(in uint16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.flip(in int32(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.flip(in uint32(in src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.flip(in int64(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.flip(in uint64(in src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void flip<T>(in Vec128<T> src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.flip(in int8(in src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                Bits.flip(in uint8(in src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                Bits.flip(in int16(in src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                Bits.flip(in uint16(in src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.flip(in int32(in src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.flip(in uint32(in src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.flip(in int64(in src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.flip(in uint64(in src), ref uint64(ref dst));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> flip<T>(in Vec256<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.flip(in int8(in src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.flip(in uint8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.flip(in int16(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.flip(in uint16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.flip(in int32(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.flip(in uint32(in src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.flip(in int64(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.flip(in uint64(in src)));
            else 
                throw unsupported<T>();
        }
 
         [MethodImpl(Inline)]
        public static void flip<T>(in Vec256<T> src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.flip(in int8(in src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                Bits.flip(in uint8(in src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                Bits.flip(in int16(in src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                Bits.flip(in uint16(in src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.flip(in int32(in src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.flip(in uint32(in src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.flip(in int64(in src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.flip(in uint64(in src), ref uint64(ref dst));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static ref readonly Span<T> flip<T>(in ReadOnlySpan<T> src, in Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.flip(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                Bits.flip(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                Bits.flip(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                Bits.flip(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                Bits.flip(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                Bits.flip(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                Bits.flip(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                Bits.flip(uint64(src), uint64(dst));
            else
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static ref readonly Span<T> flip<T>(in Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.flip(int8(io), int8(io));
            else if(typeof(T) == typeof(byte))
                Bits.flip(uint8(io), uint8(io));
            else if(typeof(T) == typeof(short))
                Bits.flip(int16(io), int16(io));
            else if(typeof(T) == typeof(ushort))
                Bits.flip(uint16(io), uint16(io));
            else if(typeof(T) == typeof(int))
                Bits.flip(int32(io), int32(io));
            else if(typeof(T) == typeof(uint))
                Bits.flip(uint32(io), uint32(io));
            else if(typeof(T) == typeof(long))
                Bits.flip(int64(io), int64(io));
            else if(typeof(T) == typeof(ulong))
                Bits.flip(uint64(io), uint64(io));
            else
                throw unsupported<T>();
            return ref io;
        }
 
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static ref readonly Memory<T> flip<T>(in Memory<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.flip(int8(io), int8(io));
            else if(typeof(T) == typeof(byte))
                Bits.flip(uint8(io), uint8(io));
            else if(typeof(T) == typeof(short))
                Bits.flip(int16(io), int16(io));
            else if(typeof(T) == typeof(ushort))
                Bits.flip(uint16(io), uint16(io));
            else if(typeof(T) == typeof(int))
                Bits.flip(int32(io), int32(io));
            else if(typeof(T) == typeof(uint))
                Bits.flip(uint32(io), uint32(io));
            else if(typeof(T) == typeof(long))
                Bits.flip(int64(io), int64(io));
            else if(typeof(T) == typeof(ulong))
                Bits.flip(uint64(io), uint64(io));
            else
                throw unsupported<T>();
            return ref io;
        }

    }
}