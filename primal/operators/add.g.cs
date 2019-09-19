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
        /// <summary>
        /// Adds two primal integers
        /// </summary>
        /// <param name="lhs">The left integer</param>
        /// <param name="rhs">The right integer</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T iadd<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.add(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.add(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.add(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.add(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.add(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.add(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.add(int64(lhs), int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.add(uint64(lhs), uint64(rhs)));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                return gfp.fadd(lhs,rhs);
            else
                return iadd(lhs,rhs);
        }
                    
        [MethodImpl(Inline)]
        public static ref T add<T>(ref T lhs, in T rhs)
            where T : struct
        {                        
            if(typeof(T) == typeof(sbyte))
                 math.add(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                 math.add(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                 math.add(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                 math.add(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                 math.add(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                 math.add(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                 math.add(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                 math.add(ref uint64(ref lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                 fmath.fadd(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 fmath.fadd(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.add(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.add(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.add(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.add(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.add(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.add(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.add(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.add(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                fmath.fadd(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                fmath.fadd(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }


        [MethodImpl(Inline)]
        public static Span<T> add<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct        
        {
            if(typeof(T) == typeof(sbyte))
                math.add(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.add(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.add(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.add(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.add(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.add(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.add(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.add(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                fmath.fadd(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                fmath.fadd(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

        /// <summary>
        /// Adds a scalar value to each element of the source span in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="scalar">The scalar value</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> add<T>(Span<T> src, T scalar)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.add(int8(src), int8(scalar));
            else if(typeof(T) == typeof(byte))
                math.add(uint8(src), uint8(scalar));
            else if(typeof(T) == typeof(short))
                math.add(int16(src), int16(scalar));
            else if(typeof(T) == typeof(ushort))
                math.add(uint16(src), uint16(scalar));
            else if(typeof(T) == typeof(int))
                math.add(int32(src), int32(scalar));
            else if(typeof(T) == typeof(uint))
                math.add(uint32(src), uint32(scalar));
            else if(typeof(T) == typeof(long))
                math.add(int64(src), int64(scalar));
            else if(typeof(T) == typeof(ulong))
                math.add(uint64(src), uint64(scalar));
            else if(typeof(T) == typeof(float))
                fmath.fadd(float32(src), float32(scalar));
            else if(typeof(T) == typeof(double))
                fmath.fadd(float64(src), float64(scalar));
            else
                throw unsupported<T>();
            return src;
        }
    }
}