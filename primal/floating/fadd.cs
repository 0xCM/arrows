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
        public static float fadd(float lhs, float rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static double fadd(double lhs, double rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static ref float fadd(ref float lhs, float rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double fadd(ref double lhs, double rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static float fadd(float lhs, float rhs, out float dst)
            => dst = lhs + rhs;

        [MethodImpl(Inline)]
        public static double fadd(double lhs, double rhs, out double dst)
            => dst = lhs + rhs;

        public static Span<float> fadd(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = fadd(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<double> fadd(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = fadd(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<float> fadd(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => fadd(lhs,rhs,span<float>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<double> fadd(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => fadd(lhs,rhs,span<double>(length(lhs,rhs)));

        public static Span<float> fadd(Span<float> lhs, ReadOnlySpan<float> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] += rhs[i];
            return lhs;
        }

        public static Span<double> fadd(Span<double> lhs, ReadOnlySpan<double> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] += rhs[i];
            return lhs;
        }

        public static Span<float> fadd(Span<float> lhs, float rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] += rhs;
            return lhs;
        }

        public static Span<double> fadd(Span<double> lhs, double rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] += rhs;
            return lhs;
        }

    }

}