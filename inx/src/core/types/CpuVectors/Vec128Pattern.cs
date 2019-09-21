//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    /// <summary>
    /// Reifies and provides storage for common 128-bit vector patterns
    /// </summary>
    public readonly struct Vec128Pattern<T> 
        where T : unmanaged
    {
        static readonly int Length = Vec128<T>.Length;

        static readonly Vec128<T> Zero = Vec128<T>.Zero;

        /// <summary>
        /// A vector with all bits turned on
        /// </summary>
        public static readonly Vec128<T> AllOnes = ginx.cmpeq(Zero,Zero);

        /// <summary>
        /// A vector where each component is assigned the numeric value 1
        /// </summary>
        public static readonly Vec128<T> Units = CalcUnits();

        public static readonly Vec128<T> Increasing = Increments();

        public static readonly Vec128<T> Decreasing = Decrements(convert<T>(Length - 1));

        public static readonly Vec128<T> FpSignMask = CalcFpSignMask();

        /// <summary>
        /// Creates a vector with incrementing components
        /// v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> Increments(T first = default, params Swap[] swaps)
        {
            var n = Length;
            var dst = Span128.Alloc<T>(n);
            var val = first;
            for(var i=0; i < n; i++)
            {
                dst[i] = val;
                gmath.inc(ref val);
            }
            return Vec128.Load(dst.Swap(swaps));
        }

        /// <summary>
        /// Creates a vector with decrementing components
        /// v[0] = last and v[i-1] = v[i] - 1 for i=1...N-1
        /// </summary>
        /// <param name="last">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to decrements prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vec128<T> Decrements(T last = default, params Swap[] swaps)
        {
            var n = Length;
            var dst = Span128.Alloc<T>(n);
            var val = last;
            for(var i=0; i<n; i++)
            {
                dst[i] = val;
                gmath.dec(ref val);
            }

            return Vec128.Load(dst.Swap(swaps));
        }

       static Vec128<T> CalcUnits()
        {
            var n = Length;
            var dst = Span128.Alloc<T>(n);
            var one = gmath.one<T>();
            for(var i=0; i<n; i++)
                dst[i] = one;
            return Vec128.Load(dst);
        }

        static Vec128<T> CalcFpSignMask()
        {
            if(typeof(T) == typeof(float))
                return CalcFpSignMask32().As<T>();
            else if(typeof(T) == typeof(double))
                return CalcFpSignMask64().As<T>();
            else 
                return Vec128<T>.Zero;
        }

        static Vec128<double> CalcFpSignMask64()
            => Vec128.Fill(-0.0);

        static Vec128<float> CalcFpSignMask32()
            => Vec128.Fill(-0.0f);
    }
}

