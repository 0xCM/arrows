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
        public static float dot(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(float);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        public static double dot(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(double);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }
    }
}