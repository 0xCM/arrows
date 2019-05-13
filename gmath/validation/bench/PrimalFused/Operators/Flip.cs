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
        OpMetrics Flip<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Flip);
            var samples = Sampled(opid);            
            var sw = stopwatch();            
            gmath.flip(samples.Left, dst);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison FlipI8()
        {
            var opid = Id<sbyte>(OpKind.Flip);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.FlipFused, targets.Left);
            var benched = Measure(!~opid, Flip, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison FlipU8()
        {
            var opid = Id<byte>(OpKind.Flip);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.FlipFused, targets.Left);
            var benched = Measure(!~opid, Flip, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison FlipI16()
        {
            var opid = Id<short>(OpKind.Flip);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.FlipFused, targets.Left);
            var benched = Measure(!~opid, Flip, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }
        
        public IBenchComparison FlipU16()
        {
            var opid = Id<ushort>(OpKind.Flip);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.FlipFused, targets.Left);
            var benched = Measure(!~opid, Flip, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison FlipI32()
        {
            var opid = Id<int>(OpKind.Flip);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.FlipFused, targets.Left);
            var benched = Measure(!~opid, Flip, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison FlipU32()
        {
            var opid = Id<uint>(OpKind.Flip);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.FlipFused, targets.Left);
            var benched = Measure(!~opid, Flip, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }


        public IBenchComparison FlipI64()
        {
            var opid = Id<long>(OpKind.Flip);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.FlipFused, targets.Left);
            var benched = Measure(!~opid, Flip, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison FlipU64()
        {
            var opid = Id<ulong>(OpKind.Flip);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.FlipFused, targets.Left);
            var benched = Measure(!~opid, Flip, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }
 
    }

}