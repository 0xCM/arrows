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
    using static mfunc;
    using static As;
    using static InXMetrics;

    partial class InXVecBench
    {

        public static Metrics<T> LShiftV<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int32:
                    return LShiftV(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return LShiftV(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return LShiftV(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return LShiftV(uint64(lhs), uint64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<int> LShiftV(ReadOnlySpan128<int> lhs, ReadOnlySpan128<uint> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<int>(OpKind.LShiftV, config);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshiftv(lhs, rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<uint> LShiftV(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<uint>(OpKind.LShiftV, config);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshiftv(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<long> LShiftV(ReadOnlySpan128<long> lhs, ReadOnlySpan128<ulong> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<long>(OpKind.LShiftV, config);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshiftv(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<ulong> LShiftV(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<ulong>(OpKind.LShiftV, config);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshiftv(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

    }

}