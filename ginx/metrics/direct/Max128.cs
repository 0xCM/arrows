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
    using static InX128DMetrics;

    public static class MaxInX128D
    {
        public static Metrics<T> Max<T>(this InXMetricConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                => Max(lhs,rhs,config);
        public static Metrics<T> Max<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            config = Configure(config);

            switch(kind)
            {
                case PrimalKind.int16:
                    return  Max(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return  Max(int32(lhs), int32(rhs), config).As<T>();
            }

            throw unsupported(kind);
        }

        static Metrics<int> Max(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, InXMetricConfig128 config)
        {
            var opid = Id<int>(OpKind.Max);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            for(var block = 0; block <  dst.BlockCount; block++)
                Vec128.load(dinx.max(lhs.Vector(block), rhs.Vector(block)), dst, block);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<short> Max(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, InXMetricConfig128 config)
        {
            var opid = Id<short>(OpKind.Max);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            for(var block = 0; block <  dst.BlockCount; block++)
                Vec128.load(dinx.max(lhs.Vector(block), rhs.Vector(block)), dst, block);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }
    }
}