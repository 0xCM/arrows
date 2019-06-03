//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Metrics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static InXNumGMetrics128;
    using static Span128;

    public static class DivInXNumD
    {
        public static Metrics<T> Div<T>(this InXNumDConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return config.Div(float32(lhs), float32(rhs)).As<T>();
            else if (typeof(T) == typeof(double))
                return config.Div(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported(PrimalKinds.kind<T>());            
        }

        static Metrics<float> Div(this InXNumDConfig128 config, ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs)
        {
            var opid = Id<float>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var blocks = dst.BlockCount;
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            for(var block = 0; block < blocks; block++)
                dinx.div(lhs.Scalar(block), rhs.Scalar(block), ref dst[block]);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<double> Div(this InXNumDConfig128 config, ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs)
        {
            var opid = Id<double>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var blocks = dst.BlockCount;
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            for(var block = 0; block < blocks; block++)
                dinx.div(lhs.Scalar(block), rhs.Scalar(block), ref dst[block]);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        } 
    }
}
