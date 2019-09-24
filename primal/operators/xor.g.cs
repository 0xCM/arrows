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
                return generic<T>((sbyte)(int8(lhs) ^ int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) ^ uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) ^ int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) ^ uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs) ^ int32(rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs) ^ uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs) ^ int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs) ^ uint64(rhs));
            else                            
                return default;
        }           

        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, T rhs)
            where T : struct
        {
            lhs = xor(lhs,rhs);
            return ref lhs;
        }
    }
}