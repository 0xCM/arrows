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
        public static float div(float lhs, float rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static double div(double lhs, double rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static ref float div(ref float lhs, float rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double div(ref double lhs, double rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        public static Span<float> div(Span<float> lhs, ReadOnlySpan<float> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<double> div(Span<double> lhs, ReadOnlySpan<double> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<float> div(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = lhs[i] / rhs[i];
            return dst;
        }

        public static Span<double> div(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = lhs[i] / rhs[i];
            return dst;
        }

    }

}