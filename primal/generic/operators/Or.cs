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
        public static T or<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(lhs) | int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) | uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) | int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) | uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs) | int32(rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs) | uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs) | int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs) | uint64(rhs));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.or(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.or(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T or<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 math.or(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                 math.or(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                 math.or(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                 math.or(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                 math.or(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                 math.or(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                 math.or(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                 math.or(ref uint64(ref lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                 math.or(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 math.or(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }


        static sbyte or(sbyte x1, sbyte x2, params sbyte[] more)
        {
            var result = (sbyte)(x1 | x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        static byte or(byte x1, byte x2, params byte[] more)
        {
            var result = (byte)(x1 | x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }


        static short or(short x1, short x2, params short[] more)
        {
            short result = (short)(x1 | x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        static ushort or(ushort x1, ushort x2, params ushort[] more)
        {
            var result = (ushort)(x1 | x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }
        
        static int or(int x1, int x2, params int[] more)
        {
            var result = x1 | x2;
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        static uint or(uint x1, uint x2, params uint[] more)
        {
            var result = x1 | x2;
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        static long or(long x1, long x2, params long[] more)
        {
            var result = x1| x2;
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        public static ulong or(ulong x1, ulong x2, params ulong[] more)
        {
            var result = x1 | x2;
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

   }
}