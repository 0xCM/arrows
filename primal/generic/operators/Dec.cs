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

    partial class gmath
    {

        [MethodImpl(Inline)]
        public static T dec<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) - 1));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) - 1));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) - 1));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) - 1));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) - 1);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) - 1);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) - 1);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) - 1);
            else if(typeof(T) == typeof(float))
                return generic<T>(float32(src) - 1);
            else if(typeof(T) == typeof(double))
                return generic<T>(float64(src) - 1);
            else            
                 throw unsupported<T>();                
        }           

        [MethodImpl(Inline)]
        public static ref T dec<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.dec(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                math.dec(ref uint8(ref src));
            else if(typeof(T) == typeof(short))
                math.dec(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                math.dec(ref uint16(ref src));
            else if(typeof(T) == typeof(int))
                math.dec(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                math.dec(ref uint32(ref src));
            else if(typeof(T) == typeof(long))
                math.dec(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                math.dec(ref uint64(ref src));
            else if(typeof(T) == typeof(float))
                math.dec(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                math.dec(ref float64(ref src));
            else            
                throw unsupported<T>();
            return ref src;
        }           

    }
}