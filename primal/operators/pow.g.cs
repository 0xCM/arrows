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
        public static T pow<T>(T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                return gfp.pow(b,exp);
            else
                return ipow(b,exp);
        }

        [MethodImpl(Inline)]
        public static T ipow<T>(T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.pow(ref int8(ref b), exp));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.pow(ref uint8(ref b), exp));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.pow(ref int16(ref b), exp));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.pow(ref uint16(ref b), exp));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.pow(ref int32(ref b), exp));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.pow(ref uint32(ref b), exp));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.pow(ref int64(ref b), exp));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.ipow(ref uint64(ref b), exp));
            else            
               throw unsupported<T>();
            
         }           

        [MethodImpl(Inline)]
        public static ref T ipow<T>(ref T b, uint exp)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.pow(ref int8(ref b), exp);
            else if(typeof(T) == typeof(byte))
                math.pow(ref uint8(ref b), exp);
            else if(typeof(T) == typeof(short))
                math.pow(ref int16(ref b), exp);
            else if(typeof(T) == typeof(ushort))
                math.pow(ref uint16(ref b), exp);
            else if(typeof(T) == typeof(int))
                math.pow(ref int32(ref b), exp);
            else if(typeof(T) == typeof(uint))
                math.pow(ref uint32(ref b), exp);
            else if(typeof(T) == typeof(long))
                math.pow(ref int64(ref b), exp);
            else if(typeof(T) == typeof(ulong))
                math.ipow(ref uint64(ref b), exp);
            else            
               throw unsupported<T>();
            
            return ref b;
         }           

 
        [MethodImpl(Inline)]
        public static bool isPow2<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.isPow2(int8(src));
            else if(typeof(T) == typeof(byte))
                return math.isPow2(uint8(src));
            else if(typeof(T) == typeof(short))
                return math.isPow2(int16(src));
            else if(typeof(T) == typeof(ushort))
                return math.isPow2(uint16(src));
            else if(typeof(T) == typeof(int))
                return math.isPow2(int32(src));
            else if(typeof(T) == typeof(uint))
                return math.isPow2(uint32(src));
            else if(typeof(T) == typeof(long))
                return math.isPow2(int64(src));
            else if(typeof(T) == typeof(ulong))
                return math.isPow2(uint64(src));
            else            
                throw unsupported<T>();
        }           

    }
}