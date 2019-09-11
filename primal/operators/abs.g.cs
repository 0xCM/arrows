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
        /// <summary>
        /// Computes the absolute value of a primal operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T abs<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.abs(int8(src)));
            else if(typeof(T) == typeof(byte))
                return src;
            else if(typeof(T) == typeof(short))
                return generic<T>(math.abs(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return src;
            else if(typeof(T) == typeof(int))
                return generic<T>(math.abs(int32(src)));
            else if(typeof(T) == typeof(uint))
                return src;
            else if(typeof(T) == typeof(long))
                return generic<T>(math.abs(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return src;
            else if(typeof(T) == typeof(float))
                return generic<T>(fmath.abs(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.abs(float64(src)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Computes the absolute value of a primal operand in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T abs<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.abs(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                return ref src;
            else if(typeof(T) == typeof(short))
                math.abs(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                return ref src;
            else if(typeof(T) == typeof(int))
                math.abs(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                return ref src;
            else if(typeof(T) == typeof(long))
                math.abs(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                return ref src;
            else if(typeof(T) == typeof(float))
                fmath.abs(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                fmath.abs(ref float64(ref src));
            else            
                throw unsupported<T>();
            return ref src;                
        }           

        [MethodImpl(Inline)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.abs(int8(src),int8(dst));
            else if(typeof(T) == typeof(short))
                math.abs(int16(src),int16(dst));
            else if(typeof(T) == typeof(int))
                math.abs(int32(src),int32(dst));
            else if(typeof(T) == typeof(long))
                math.abs(int64(src),int64(dst));
            else if(typeof(T) == typeof(float))
                fmath.abs(float32(src),float32(dst));
            else if(typeof(T) == typeof(double))
                fmath.abs(float64(src),float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

   }
}