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

    partial class PrimalFusedBench
    {
        OpMetrics And<T>(T[] dst)
            where T : struct
        {
            var opid = Id<T>(OpKind.And);
            var samples = Sampled(opid);            
            var sw = stopwatch();            
            fused.and<T>(samples.Left, samples.Right, dst);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison AndI8()
        {
            var opid = Id<sbyte>(OpKind.And);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AndFused, targets.Left);
            var benched = Measure(!~opid, And, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AndU8()
        {
            var opid = Id<byte>(OpKind.And);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AndFused, targets.Left);
            var benched = Measure(!~opid, And, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AndI16()
        {
            var opid = Id<short>(OpKind.And);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AndFused, targets.Left);
            var benched = Measure(!~opid, And, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AndU16()
        {
            var opid = Id<ushort>(OpKind.And);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AndFused, targets.Left);
            var benched = Measure(!~opid, And, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AndI32()
        {
            var opid = Id<int>(OpKind.And);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AndFused, targets.Left);
            var benched = Measure(!~opid, And, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AndU32()
        {
            var opid = Id<uint>(OpKind.And);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AndFused, targets.Left);
            var benched = Measure(!~opid, And, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AndI64()
        {
            var opid = Id<long>(OpKind.And);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AndFused, targets.Left);
            var benched = Measure(!~opid, And, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AndU64()
        {
            var opid = Id<ulong>(OpKind.And);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AndFused, targets.Left);
            var benched = Measure(!~opid, And, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        } 
    }
}