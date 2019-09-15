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
        public static bool gteq(float lhs, float rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(double lhs, double rhs)
            => lhs >= rhs;        

        public static Span<bool> gteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));

    }

}