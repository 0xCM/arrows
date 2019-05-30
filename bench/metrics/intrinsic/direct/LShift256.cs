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
    using static InX256DMetrics;

    public static class LShiftInX256D
    {
        public static Metrics<T> LShiftD<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct        
                => LShift(lhs,rhs,config);


        static Metrics<T> LShift<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXConfig256 config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            config = Configure(config);

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

        public static Metrics<int> LShift(ReadOnlySpan256<int> lhs, ReadOnlySpan256<uint> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<int>(OpKind.LShift);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshift(lhs, rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<uint> LShift(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<uint>(OpKind.LShift);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshift(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<long> LShift(ReadOnlySpan256<long> lhs, ReadOnlySpan256<ulong> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<long>(OpKind.LShift);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshift(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<ulong> LShift(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<ulong>(OpKind.LShift);            
            var dst = alloc(lhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.lshift(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

    }

}