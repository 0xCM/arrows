//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static InXMetrics;

    partial class InXVecBench
    {

        public static Metrics<T> LShift<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int32:
                    return LShift(int32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return LShift(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return LShift(int64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return LShift(uint64(lhs), uint64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<int> LShift(ReadOnlySpan128<int> lhs, ReadOnlySpan128<uint> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<int>(OpKind.LShift, config);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshift(lhs, rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<uint> LShift(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<uint>(OpKind.LShift, config);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshift(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<long> LShift(ReadOnlySpan128<long> lhs, ReadOnlySpan128<ulong> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<long>(OpKind.LShift, config);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshift(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<ulong> LShift(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<ulong>(OpKind.LShift, config);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshift(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

    }

}