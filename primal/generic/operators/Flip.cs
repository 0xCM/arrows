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
        public static T flip<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.flip(ref int8(ref src)));  
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.flip(ref uint8(ref src)));            
            else if(typeof(T) == typeof(short))
                return generic<T>(math.flip(ref int16(ref src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.flip(ref uint16(ref src)));            
            else if(typeof(T) == typeof(int))
                return generic<T>(math.flip(ref int32(ref src))); 
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.flip(ref uint32(ref src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.flip(ref int64(ref src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.flip(ref uint64(ref src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T flip<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref generic<T>(ref math.flip(ref int8(ref src)));
            else if(typeof(T) == typeof(byte))
                return ref generic<T>(ref math.flip(ref uint8(ref src)));
            else if(typeof(T) == typeof(short))
                return ref generic<T>(ref math.flip(ref int16(ref src)));
            else if(typeof(T) == typeof(ushort))
                return ref generic<T>(ref math.flip(ref uint16(ref src)));
            else if(typeof(T) == typeof(int))
                return ref generic<T>(ref math.flip(ref int32(ref src)));
            else if(typeof(T) == typeof(uint))
                return ref generic<T>(ref math.flip(ref uint32(ref src)));
            else if(typeof(T) == typeof(long))
                return ref generic<T>(ref math.flip(ref int64(ref src)));
            else if(typeof(T) == typeof(ulong))
                return ref generic<T>(ref math.flip(ref uint64(ref src)));
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.flip(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.flip(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.flip(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.flip(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.flip(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.flip(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.flip(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.flip(uint64(src), uint64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }

        public static ref Span<T> flip<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.flip(int8(io), int8(io));
            else if(typeof(T) == typeof(byte))
                math.flip(uint8(io), uint8(io));
            else if(typeof(T) == typeof(short))
                math.flip(int16(io), int16(io));
            else if(typeof(T) == typeof(ushort))
                math.flip(uint16(io), uint16(io));
            else if(typeof(T) == typeof(int))
                math.flip(int32(io), int32(io));
            else if(typeof(T) == typeof(uint))
                math.flip(uint32(io), uint32(io));
            else if(typeof(T) == typeof(long))
                math.flip(int64(io), int64(io));
            else if(typeof(T) == typeof(ulong))
                math.flip(uint64(io), uint64(io));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref io;
        }
    }
}