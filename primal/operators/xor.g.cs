//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static AsIn;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T xor<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.xor(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.xor(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.xor(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.xor(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.xor(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.xor(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.xor(int64(lhs), int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.xor(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.xor(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.xor(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(ref int8(ref lhs), int8(in rhs));
            else if(typeof(T) == typeof(byte))
                math.xor(ref uint8(ref lhs), uint8(in rhs));
            else if(typeof(T) == typeof(short))
                math.xor(ref int16(ref lhs), int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                math.xor(ref uint16(ref lhs), uint16(in rhs));
            else if(typeof(T) == typeof(int))
                math.xor(ref int32(ref lhs), int32(in rhs));
            else if(typeof(T) == typeof(uint))
                math.xor(ref uint32(ref lhs), uint32(in rhs));
            else if(typeof(T) == typeof(long))
                math.xor(ref int64(ref lhs), int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                math.xor(ref uint64(ref lhs), uint64(in rhs));
            else if(typeof(T) == typeof(float))
                math.xor(ref float32(ref lhs), float32(in rhs));
            else if(typeof(T) == typeof(double))
                math.xor(ref float64(ref lhs), float64(in rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }
    }
}