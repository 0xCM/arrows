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

        public static Span<double> Square(this ReadOnlySpan<double> src, Span<double> dst)
        {
            for(var i=0; i< src.Length; i++)
                dst[i] = src[i]*src[i];
            return dst;
        }
        
        [MethodImpl(Inline)]
        public static Span<double> Square(this ReadOnlySpan<double> src)
            => src.Square(new double[src.Length]);            

        [MethodImpl(Inline)]
        public static Span<double> Square(this Span<double> io)
            => io.ReadOnly().Square(io);            

        [MethodImpl(Inline)]
        public static Span<double> Square(this Span<double> src, Span<double> dst)
            => src.ReadOnly().Square(dst);

    }

}