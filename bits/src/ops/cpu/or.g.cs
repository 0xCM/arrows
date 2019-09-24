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

    using static As;
    using static zfunc;

    partial class gbits
    {

        [MethodImpl(Inline)]
        public static Vec256<T> or<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.or(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.or(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.or(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.or(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.or(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.or(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.or(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.or(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.or(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.or(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void or<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : unmanaged
        {
            if (typeof(T) == typeof(sbyte))
                Bits.or(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                Bits.or(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                Bits.or(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                Bits.or(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.or(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.or(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.or(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.or(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                Bits.or(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.or(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }
        
        [MethodImpl(Inline)]
        public static Vec128<T> or<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.or(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.or(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.or(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.or(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.or(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.or(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.or(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.or(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.or(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.or(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void or<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : unmanaged
        {
            if (typeof(T) == typeof(sbyte))
                Bits.or(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                Bits.or(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                Bits.or(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                Bits.or(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.or(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.or(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.or(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.or(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                Bits.or(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.or(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }         



    }

    

}