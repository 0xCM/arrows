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
        public static T flip<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.flip(int8(src)));  
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.flip(uint8(src)));  
            else if(typeof(T) == typeof(short))
                return generic<T>(math.flip(int16(src)));  
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.flip(uint16(src)));  
            else if(typeof(T) == typeof(int))
                return generic<T>(math.flip(int32(src)));  
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.flip(uint32(src)));  
            else if(typeof(T) == typeof(long))
                return generic<T>(math.flip(int64(src)));  
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.flip(uint64(src)));  
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T flip<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.flip(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                math.flip(ref uint8(ref src));
            else if(typeof(T) == typeof(short))
                math.flip(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                math.flip(ref uint16(ref src));
            else if(typeof(T) == typeof(int))
                math.flip(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                math.flip(ref uint32(ref src));
            else if(typeof(T) == typeof(long))
                math.flip(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                math.flip(ref uint64(ref src));
            else            
                throw unsupported<T>();
            return ref src;
        }           

        [MethodImpl(Inline)]
        public static ref T flip<T>(in T src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.flip(in int8(in src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                math.flip(in uint8(in src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                math.flip(in int16(in src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                math.flip(in uint16(in src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                math.flip(in int32(in src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                math.flip(in uint32(in src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                math.flip(in int64(in src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                math.flip(in uint64(in src), ref uint64(ref dst));
            else            
                throw unsupported<T>();
            return ref dst;
        }           


    }

}