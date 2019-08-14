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
    
    partial class math
    {
        [MethodImpl(Inline)]
        public static float round(float src, int scale)
            => MathF.Round(src, scale);

        [MethodImpl(Inline)]
        public static double round(double src, int scale)
            => Math.Round(src, scale);

        [MethodImpl(Inline)]
        public static ref float round(ref float src, int scale)
        {
            src = MathF.Round(src, scale);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double round(ref double src, int scale)
        {
            src = Math.Round(src, scale);
            return ref src;
        }

        public static Span<float> round(ReadOnlySpan<float> src, int scale, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = round(src[i], scale);
            return dst;
        }

        public static Span<double> round(ReadOnlySpan<double> src, int scale, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = round(src[i], scale);
            return dst;
        }

        public static Span<float> round(Span<float> io, int scale)
        {
            for(var i = 0; i< io.Length; i++)
                round(ref io[i], scale);
            return io;
        }

        public static Span<double> round(Span<double> io, int scale)
        {
            for(var i = 0; i< io.Length; i++)
                round(ref io[i], scale);
            return io;
        }
 
    }

}