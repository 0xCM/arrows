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
        public static T sqrt<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return sqrtI8(src);
            else if(typeof(T) == typeof(byte))
                return sqrtU8(src);
            else if(typeof(T) == typeof(short))
                return sqrtI16(src);
            else if(typeof(T) == typeof(ushort))
                return sqrtU16(src);
            else if(typeof(T) == typeof(int))
                return sqrtI32(src);
            else if(typeof(T) == typeof(uint))
                return sqrtU32(src);
            else if(typeof(T) == typeof(long))
                return sqrtI64(src);
            else if(typeof(T) == typeof(ulong))
                return sqrtU64(src);
            else if(typeof(T) == typeof(float))
                return sqrtF32(src);
            else if(typeof(T) == typeof(double))
                return sqrtF64(src);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T sqrt<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.sqrt(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                math.sqrt(ref uint8(ref src));
            else if(typeof(T) == typeof(short))
                math.sqrt(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                math.sqrt(ref uint16(ref src));
            else if(typeof(T) == typeof(int))
                math.sqrt(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                math.sqrt(ref uint32(ref src));
            else if(typeof(T) == typeof(long))
                math.sqrt(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                math.sqrt(ref uint64(ref src));
            else if(typeof(T) == typeof(float))
                math.sqrt(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                math.sqrt(ref float64(ref src));
            else 
                throw unsupported<T>();
            return ref src;
        }           

        public static ref Span<T> sqrt<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.sqrt(int8(io));
            else if(typeof(T) == typeof(byte))
                math.sqrt(uint8(io));
            else if(typeof(T) == typeof(short))
                math.sqrt(int16(io));
            else if(typeof(T) == typeof(ushort))
                math.sqrt(uint16(io));
            else if(typeof(T) == typeof(int))
                math.sqrt(int32(io));
            else if(typeof(T) == typeof(uint))
                math.sqrt(uint32(io));
            else if(typeof(T) == typeof(long))
                math.sqrt(int64(io));
            else if(typeof(T) == typeof(ulong))
                math.sqrt(uint64(io));
            else if(typeof(T) == typeof(float))
                math.sqrt(float32(io));
            else if(typeof(T) == typeof(double))
                math.sqrt(float64(io));
            else
                 throw unsupported<T>();                
           
            return ref io;
        }

        [MethodImpl(Inline)]
        static T sqrtI8<T>(T src)
            => sqrtI8(ref src);

        [MethodImpl(Inline)]
        static T sqrtU8<T>(T src)
            => sqrtU8(ref src);

        [MethodImpl(Inline)]
        static T sqrtI16<T>(T src)
            => sqrtI16(ref src);

        [MethodImpl(Inline)]
        static T sqrtU16<T>(T src)
            => sqrtU16(ref src);

        [MethodImpl(Inline)]
        static T sqrtI32<T>(T src)
            => sqrtI32(ref src);
        
        [MethodImpl(Inline)]
        static T sqrtU32<T>(T src)
            => sqrtU32(ref src);

        [MethodImpl(Inline)]
        static T sqrtI64<T>(T src)
            => sqrtI64(ref src);

        [MethodImpl(Inline)]
        static T sqrtU64<T>(T src)
            => sqrtU64(ref src);

        [MethodImpl(Inline)]
        static T sqrtF32<T>(T src)
            => sqrtU32(ref src);

        [MethodImpl(Inline)]
        static T sqrtF64<T>(T src)
            => sqrtI64(ref src);


        [MethodImpl(Inline)]
        static ref T sqrtI8<T>(ref T src)
        {
            math.sqrt(ref int8(ref src));            
            return ref src;
        }            

        [MethodImpl(Inline)]
        static ref T sqrtU8<T>(ref T src)
        {
            math.sqrt(ref uint8(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtI16<T>(ref T src)
        {
            math.sqrt(ref int16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtU16<T>(ref T src)
        {
            math.sqrt(ref uint16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtI32<T>(ref T src)
        {
            math.sqrt(ref int32(ref src));            
            return ref src;
        }
        
        [MethodImpl(Inline)]
        static ref T sqrtU32<T>(ref T src)
        {
            math.sqrt(ref uint32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtI64<T>(ref T src)
        {
            math.sqrt(ref int64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtU64<T>(ref T src)
        {
            math.sqrt(ref uint64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtF32<T>(ref T src)
        {
            math.sqrt(ref float32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtF64<T>(ref T src)
        {
            math.sqrt(ref float64(ref src));            
            return ref src;
        }
    }
}