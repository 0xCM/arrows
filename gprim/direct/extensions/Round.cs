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
    using System.Diagnostics;

    using static zfunc;    
    
    partial class MathX
    {
        [MethodImpl(Inline)]
        public static float Round(this float src, int scale)
            => math.round(src, scale);

        [MethodImpl(Inline)]
        public static double Round(this double src, int scale)
            => math.round(src, scale);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> Round(this ReadOnlySpan<float> src, int scale, Span<float> dst)
            => math.round(src, scale, dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> Round(this ReadOnlySpan<double> src, int scale, Span<double> dst )
            => math.round(src, scale, dst);            

        [MethodImpl(Inline)]
        public static Span<float> Round(this Span<float> src, int scale)
            => math.round(src, scale);            

        [MethodImpl(Inline)]
        public static Span<double> Round(this Span<double> src, int scale)
            => math.round(src, scale);            


    }

}