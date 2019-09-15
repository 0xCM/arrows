//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class fmath
    {

        [MethodImpl(Inline)]
        public static bool eq(float lhs, float rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(double lhs, double rhs)
            => lhs == rhs;

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool eq(ReadOnlySpan<float> src, float target)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i] != target)
                    return false;
            return true;
        }

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool eq(ReadOnlySpan<double> src, double target)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i] != target)
                    return false;
            return true;
        }


    }

}