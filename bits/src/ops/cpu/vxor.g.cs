//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {                        

        [MethodImpl(Inline)]
        public static Vec128<T> vxor<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
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
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxor256u<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Avx2.Xor(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Avx2.Xor(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Avx2.Xor(uint32(lhs), uint32(rhs)));
            else
                return generic<T>(Avx2.Xor(uint64(lhs), uint64(rhs)));

        }

        [MethodImpl(Inline)]
        static Vector256<T> vxor256i<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Avx2.Xor(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Avx2.Xor(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Avx2.Xor(int32(lhs), int32(rhs)));
            else
                return generic<T>(Avx2.Xor(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxor<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || 
                typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
                    return vxor256u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) || typeof(T) == typeof(short) || 
                typeof(T) == typeof(int) || typeof(T) == typeof(long))
                    return vxor256i(lhs,rhs);
            else
                throw unsupported<T>();
        }
    }

}