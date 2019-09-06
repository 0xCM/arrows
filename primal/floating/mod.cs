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
        public static float mod(float lhs, float rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static double mod(double lhs, double rhs)
            => lhs % rhs;


        [MethodImpl(Inline)]
        public static ref float mod(ref float lhs, in float rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double mod(ref double lhs, in double rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        public static void mod(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static Span<float> mod(Span<float> lhs, ReadOnlySpan<float> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] %= rhs[i];
            return lhs;
        }

        public static Span<double> mod(Span<double> lhs, ReadOnlySpan<double> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] %= rhs[i];
            return lhs;
        }

        public static Span<float> mod(Span<float> lhs, float rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] %= rhs;
            return lhs;
        }

        public static Span<double> mod(Span<double> lhs, double rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] %= rhs;
            return lhs;
        }


    }
}