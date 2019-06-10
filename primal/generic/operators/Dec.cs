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
        public static T dec<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.inc(ref int8(ref src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.inc(ref uint8(ref src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.inc(ref int16(ref src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.inc(ref uint16(ref src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.inc(ref int32(ref src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.inc(ref uint32(ref src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.inc(ref int64(ref src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.inc(ref uint64(ref src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.inc(ref float32(ref src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.inc(ref float64(ref src)));
            else            
                 throw unsupported<T>();                
        }           

        [MethodImpl(Inline)]
        public static ref T dec<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref decI8(ref src);
            else if(typeof(T) == typeof(byte))
                return ref decU8(ref src);
            else if(typeof(T) == typeof(short))
                return ref decI16(ref src);
            else if(typeof(T) == typeof(ushort))
                return ref decU16(ref src);
            else if(typeof(T) == typeof(int))
                return ref decI32(ref src);
            else if(typeof(T) == typeof(uint))
                return ref decU32(ref src);
            else if(typeof(T) == typeof(long))
                return ref decI64(ref src);
            else if(typeof(T) == typeof(ulong))
                return ref decU64(ref src);
            else if(typeof(T) == typeof(float))
                return ref decF32(ref src);
            else if(typeof(T) == typeof(double))
                return ref decF64(ref src);
            else            
                throw unsupported<T>();
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

        [MethodImpl(Inline)]
        static ref T decI8<T>(ref T io)
        {
            math.dec(ref int8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decU8<T>(ref T io)
        {
            math.dec(ref uint8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decI16<T>(ref T io)
        {
            math.dec(ref int16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decU16<T>(ref T io)
        {
            math.dec(ref uint16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decI32<T>(ref T io)
        {
            math.dec(ref int32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decU32<T>(ref T io)
        {
            math.dec(ref uint32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decI64<T>(ref T io)
        {
            math.dec(ref int64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decU64<T>(ref T io)
        {
            math.dec(ref uint64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decF32<T>(ref T io)
        {
            math.dec(ref float32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decF64<T>(ref T io)
        {
            math.dec(ref float64(ref io));
            return ref io;
        } 
    }
}