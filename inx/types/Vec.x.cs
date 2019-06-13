//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using X86 = System.Runtime.Intrinsics.X86;
    using NumVec = System.Numerics.Vector;

    
    using static zfunc;

    public static class VecX
    {
        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool[] TestNaN(this Vec128<float> src)
            => array(
                src[0].IsNaN(), 
                src[1].IsNaN(),
                src[2].IsNaN(), 
                src[3].IsNaN()
                );

        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool[] TestNaN(this Vec128<double> src)
            => array(
                src[0].IsNaN(), 
                src[1].IsNaN()
                );

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool IsNaN(this Vector128<float> src, int index)
                => src.GetElement(index).IsNaN();

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool IsNaN(this Vector128<double> src, int index)
                => src.GetElement(index).IsNaN();

        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool[] TestNaN(this Vector128<float> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN(),
                src.GetElement(2).IsNaN(), 
                src.GetElement(3).IsNaN()
                );

        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool[] TestNaN(this Vector128<double> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN()
                );

        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool[] TestNaN(this Vector256<float> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN(),
                src.GetElement(2).IsNaN(), 
                src.GetElement(3).IsNaN(),
                src.GetElement(4).IsNaN(), 
                src.GetElement(5).IsNaN(),
                src.GetElement(6).IsNaN(), 
                src.GetElement(7).IsNaN()
                );


        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool[] TestNaN(this Vector256<double> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN(),
                src.GetElement(2).IsNaN(), 
                src.GetElement(3).IsNaN()
                );

        /// <summary>
        /// Replaces an identified NaN component with a specified value
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vector128<float> ClearNaN(this in Vector128<float> src, int ix, float replacement = -1)
            => src.WithElement(ix,src.GetElement(ix).ClearNaN(replacement));

        /// <summary>
        /// Replaces any NaN components with a specified value
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vector128<float> ClearNaN(this in Vector128<float> src, float replacement = -1)
        {
            var x0 = src.GetElement(0).ClearNaN(replacement);
            var x1 = src.GetElement(1).ClearNaN(replacement);
            var x2 = src.GetElement(2).ClearNaN(replacement);
            var x3 = src.GetElement(3).ClearNaN(replacement);
            return Vector128.Create(x0,x1,x2,x3);
        }

        /// <summary>
        /// Replaces an identified NaN component with a specified value
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vector128<double> ClearNaN(this in Vector128<double> src, int ix, double replacement = -1)
            => src.WithElement(ix,src.GetElement(ix).ClearNaN(replacement));

        /// <summary>
        /// Replaces any NaN components with -1
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vec128<double> ClearNaN(this in Vector128<double> src, double replacement = -1)
        {
            var x0 = src.GetElement(0).ClearNaN(replacement);
            var x1 = src.GetElement(1).ClearNaN(replacement);
            return Vector128.Create(x0,x1);
        }

        /// <summary>
        /// Replaces any NaN components with -1
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vec256<double> ClearNaN(this in Vector256<double> src, double replacement = -1)
        {
            var x0 = src.GetElement(0).ClearNaN(replacement);
            var x1 = src.GetElement(1).ClearNaN(replacement);
            var x2 = src.GetElement(2).ClearNaN(replacement);
            var x3 = src.GetElement(3).ClearNaN(replacement);
            return Vector256.Create(x0,x1,x2,x3);
        }

        /// <summary>
        /// Replaces any NaN components with -1
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vec256<float> ClearNaN(this in Vector256<float> src, float replacement = -1)
        {
            var x0 = src.GetElement(0).ClearNaN(replacement);
            var x1 = src.GetElement(1).ClearNaN(replacement);
            var x2 = src.GetElement(2).ClearNaN(replacement);
            var x3 = src.GetElement(3).ClearNaN(replacement);
            var x4 = src.GetElement(4).ClearNaN(replacement);
            var x5 = src.GetElement(5).ClearNaN(replacement);
            var x6 = src.GetElement(6).ClearNaN(replacement);
            var x7 = src.GetElement(7).ClearNaN(replacement);
            return Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);
        }
    }
}