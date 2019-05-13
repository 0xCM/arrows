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

        OpMetrics Sub<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Sub);
            var samples = Sampled(opid);            
            var sw = stopwatch();            
            gmath.sub(samples.Left, samples.Right, dst);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison SubI8()
        {
            var opid = Id<sbyte>(OpKind.Sub);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.SubFused, targets.Left);
            var benched = Measure(!~opid, Sub, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison SubU8()
        {
            var opid = Id<byte>(OpKind.Sub);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.SubFused, targets.Left);
            var benched = Measure(!~opid, Sub, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison SubI16()
        {
            var opid = Id<short>(OpKind.Sub);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.SubFused, targets.Left);
            var benched = Measure(!~opid, Sub, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison SubU16()
        {
            var opid = Id<ushort>(OpKind.Sub);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.SubFused, targets.Left);
            var benched = Measure(!~opid, Sub, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison SubI32()
        {
            var opid = Id<int>(OpKind.Sub);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.SubFused, targets.Left);
            var benched = Measure(!~opid, Sub, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison SubU32()
        {
            var opid = Id<uint>(OpKind.Sub);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.SubFused, targets.Left);
            var benched = Measure(!~opid, Sub, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison SubI64()
        {
            var opid = Id<long>(OpKind.Sub);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.SubFused, targets.Left);
            var benched = Measure(!~opid, Sub, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison SubU64()
        {
            var opid = Id<ulong>(OpKind.Sub);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.SubFused, targets.Left);
            var benched = Measure(!~opid, Sub, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison SubF32()
        {
            var opid = Id<float>(OpKind.Sub);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.SubFused, targets.Left);
            var benched = Measure(!~opid, Sub, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison SubF64()
        {
            var opid = Id<double>(OpKind.Sub);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.SubFused, targets.Left);
            var benched = Measure(!~opid, Sub, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

    }

}