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

        public static Metrics<T> LShiftV<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
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

        public static Metrics<int> LShiftV(ReadOnlySpan256<int> lhs, ReadOnlySpan256<uint> rhs, InXMetricConfig256 config = null)
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

        public static Metrics<uint> LShiftV(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, InXMetricConfig256 config = null)
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

        public static Metrics<long> LShiftV(ReadOnlySpan256<long> lhs, ReadOnlySpan256<ulong> rhs, InXMetricConfig256 config = null)
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

        public static Metrics<ulong> LShiftV(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, InXMetricConfig256 config = null)
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