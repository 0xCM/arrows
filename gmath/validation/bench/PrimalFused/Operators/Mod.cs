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

        OpMetrics Mod<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Mod);
            var samples = Sampled(opid, true);            
            var sw = stopwatch();            
            gmath.mod(samples.Left, samples.Right, dst);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison ModI8()
        {
            var opid = Id<sbyte>(OpKind.Mod);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.ModFused, targets.Left);
            var benched = Measure(!~opid, Mod, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison ModU8()
        {
            var opid = Id<byte>(OpKind.Mod);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.ModFused, targets.Left);
            var benched = Measure(!~opid, Mod, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison ModI16()
        {
            var opid = Id<short>(OpKind.Mod);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.ModFused, targets.Left);
            var benched = Measure(!~opid, Mod, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison ModU16()
        {
            var opid = Id<ushort>(OpKind.Mod);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.ModFused, targets.Left);
            var benched = Measure(!~opid, Mod, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison ModI32()
        {
            var opid = Id<int>(OpKind.Mod);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.ModFused, targets.Left);
            var benched = Measure(!~opid, Mod, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison ModU32()
        {
            var opid = Id<uint>(OpKind.Mod);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.ModFused, targets.Left);
            var benched = Measure(!~opid, Mod, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison ModI64()
        {
            var opid = Id<long>(OpKind.Mod);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.ModFused, targets.Left);
            var benched = Measure(!~opid, Mod, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison ModU64()
        {
            var opid = Id<ulong>(OpKind.Mod);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.ModFused, targets.Left);
            var benched = Measure(!~opid, Mod, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison ModF32()
        {
            var opid = Id<float>(OpKind.Mod);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.ModFused, targets.Left);
            var benched = Measure(!~opid, Mod, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison ModF64()
        {
            var opid = Id<double>(OpKind.Mod);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.ModFused, targets.Left);
            var benched = Measure(!~opid, Mod, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

    }

}