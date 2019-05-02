//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using X86 = System.Runtime.Intrinsics.X86;
    using NumVec = System.Numerics.Vector;

    using static zcore;

    public static class VecX
    {
        /// <summary>
        /// Determines whether the number is NaN and returns true if so; false otherwise
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static bool TestNaN(this Num128<float> src)
                => src.value.IsNaN();

        /// <summary>
        /// Determines whether the number is NaN and returns true if so; false otherwise
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static bool TestNaN(this Num128<double> src)
                => src.value.IsNaN();

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


    }

}