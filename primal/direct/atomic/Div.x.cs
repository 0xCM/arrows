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
        public static Span<float> Div(this Span<float> io, float rhs)
        {
            for(var i=0; i< io.Length; i++)
                io[i] /= rhs;
            return io;                
        }

        public static Span<double> Div(this Span<double> io, double rhs)
        {
            for(var i=0; i< io.Length; i++)
                io[i] /= rhs;
            return io;                
        }


    }
}