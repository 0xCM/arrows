//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    
    using static mfunc;

    public static class Num128X
    {
        /// <summary>
        /// Determines whether the number is NaN and returns true if so; false otherwise
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static bool IsNaN(this Num128<float> src)
                => src.value.IsNaN();

        /// <summary>
        /// Determines whether the number is NaN and returns true if so; false otherwise
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static bool IsNaN(this Num128<double> src)
                => src.value.IsNaN();
    }
}