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
        [MethodImpl(Inline)]
        public static T xor<T>(T lhs, T rhs)
            where T : struct
                => gmath.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, in T rhs)
            where T : struct
                => ref gmath.xor(ref lhs,in rhs);

        [MethodImpl(Inline)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported<T>();
            return  dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => xor(lhs,rhs, span<T>(length(lhs,rhs)));        

        [MethodImpl(Inline)]
        public static Memory<T> xor<T>(Memory<T> lhs, ReadOnlyMemory<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(in lhs), int8(in rhs));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.xor(int16(in lhs), int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(in lhs), uint16(in rhs));
            else if(typeof(T) == typeof(int))
                math.xor(int32(in lhs), int32(in rhs));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(in lhs), uint32(in rhs));
            else if(typeof(T) == typeof(long))
                math.xor(int64(in lhs), int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(in lhs), uint64(in rhs));
            else
                throw unsupported<T>();
            return lhs;
        }


        [MethodImpl(Inline)]
        public static Span<T> xor<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> xor<T>(Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }
 
        [MethodImpl(Inline)]
        public static Vec128<T> xor<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.xor(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.xor(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.xor(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.xor(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.xor(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.xor(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.xor(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.xor(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.xor(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.xor(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> xor<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.xor(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.xor(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.xor(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.xor(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.xor(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.xor(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.xor(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.xor(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.xor(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.xor(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }
         
    }
}