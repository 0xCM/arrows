//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class fmath
    {

        [MethodImpl(Inline)]
        public static bool gt(float lhs, float rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(double lhs, double rhs)
            => lhs > rhs;        

        public static Span<bool> gt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));
    }
}