//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(lhs) & int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) & uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) & int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) & uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs) & int32(rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs) & uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs) & int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs) & uint64(rhs));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T and<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 math.and(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                 math.and(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                 math.and(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                 math.and(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                 math.and(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                 math.and(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                 math.and(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                 math.and(ref uint64(ref lhs), uint64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

    }
}