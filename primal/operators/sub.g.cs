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
    using static AsIn;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(lhs) - int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) - uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) - int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) - uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs) - int32(rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs) - uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs) - int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs) - uint64(rhs));
            else if(typeof(T) == typeof(float))
                return generic<T>(float32(lhs) - float32(rhs));
            else if(typeof(T) == typeof(double))
                return generic<T>(float64(lhs) - float64(rhs));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T sub<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.sub(ref int8(ref lhs), int8(in rhs));
            else if(typeof(T) == typeof(byte))
                math.sub(ref uint8(ref lhs), uint8(in rhs));
            else if(typeof(T) == typeof(short))
                math.sub(ref int16(ref lhs), int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                math.sub(ref uint16(ref lhs), uint16(in rhs));
            else if(typeof(T) == typeof(int))
                math.sub(ref int32(ref lhs), int32(in rhs));
            else if(typeof(T) == typeof(uint))
                math.sub(ref uint32(ref lhs), uint32(in rhs));
            else if(typeof(T) == typeof(long))
                math.sub(ref int64(ref lhs), int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                math.sub(ref uint64(ref lhs), uint64(in rhs));
            else if(typeof(T) == typeof(float))
                math.sub(ref float32(ref lhs), float32(in rhs));
            else if(typeof(T) == typeof(double))
                math.sub(ref float64(ref lhs), float64(in rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }
    }
}
