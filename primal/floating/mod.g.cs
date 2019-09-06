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

    partial class gfp
    {

        /// <summary>
        /// Computes the modulus of floating-point operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(fmath.mod(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                 return generic<T>(fmath.mod(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the modulus of the left and right operand and overwrites the left operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static ref T mod<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                 fmath.mod(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 fmath.mod(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        /// <summary>
        /// Computes the floating-point modulus of cells in the left and right operands,
        /// overwriting each left operand cell with the result. 
        /// Specifically, lhs[i] = lhs[i] ^ rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> mod<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.mod(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(float))
                fmath.mod(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

        /// <summary>
        /// Computes the floating-point modulus of cells in the left and right operands,
        /// and writes the result in the target operand
        /// Specifically, dst[i] = lhs[i] ^ rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.mod(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                fmath.mod(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }


    }
}