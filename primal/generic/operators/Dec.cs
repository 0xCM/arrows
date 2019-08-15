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

        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.dec(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.dec(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.dec(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.dec(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.dec(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.dec(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.dec(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.dec(uint64(src), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.dec(float32(src), float32(dst));
            else if(typeof(T) == typeof(double))
                math.dec(float64(src), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }
        
        [MethodImpl(Inline)]
        public static ref Span<T> dec<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.dec(int8(io));
            else if(typeof(T) == typeof(byte))
                math.dec(uint8(io));
            else if(typeof(T) == typeof(short))
                math.dec(int16(io));
            else if(typeof(T) == typeof(ushort))
                math.dec(uint16(io));
            else if(typeof(T) == typeof(int))
                math.dec(int32(io));
            else if(typeof(T) == typeof(uint))
                math.dec(uint32(io));
            else if(typeof(T) == typeof(long))
                math.dec(int64(io));
            else if(typeof(T) == typeof(ulong))
                math.dec(uint64(io));
            else if(typeof(T) == typeof(float))
                math.dec(float32(io));
            else if(typeof(T) == typeof(double))
                math.dec(float64(io));
            else
                 throw unsupported<T>();                
           
            return ref io;
        }


    }
}