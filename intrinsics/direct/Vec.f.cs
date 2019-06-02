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
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Diagnostics;

    using static zfunc;

    public static class VecXX
    {
        /// <summary>
        /// Returns the vector component for a specified index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index</param>
        /// <typeparam name="T">The vector primitive type</typeparam>
        [MethodImpl(Inline)]
        public static T component<T>(in Vector128<T> src, int index)
            where T : struct
                => src.GetElement(index);

        /// <summary>
        /// Returns the vector component for a specified index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index</param>
        /// <typeparam name="T">The vector primitive type</typeparam>
        [MethodImpl(Inline)]
        public static T component<T>(in Vector256<T> src, int index)
            where T : struct
                => src.GetElement(index);


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