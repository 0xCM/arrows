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
        OpMetrics XOr<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.XOr);
            var samples = Sampled(opid);            
            var sw = stopwatch();            
            gmath.xor(samples.Left, samples.Right, dst);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison XOrI8()
        {
            var opid = Id<sbyte>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOrFused, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrU8()
        {
            var opid = Id<byte>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOrFused, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrI16()
        {
            var opid = Id<short>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOrFused, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrU16()
        {
            var opid = Id<ushort>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOrFused, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrI32()
        {
            var opid = Id<int>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOrFused, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrU32()
        {
            var opid = Id<uint>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOrFused, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrI64()
        {
            var opid = Id<long>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOrFused, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrU64()
        {
            var opid = Id<ulong>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOrFused, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        } 
    }
}