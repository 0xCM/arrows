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

        OpMetrics Div<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Div);
            var samples = Sampled(opid, true);            
            var sw = stopwatch();            
            gmath.div(samples.Left, samples.Right, dst);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison DivI8()
        {
            var opid = Id<sbyte>(OpKind.Div);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.DivFused, targets.Left);
            var benched = Measure(!~opid, Div, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison DivU8()
        {
            var opid = Id<byte>(OpKind.Div);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.DivFused, targets.Left);
            var benched = Measure(!~opid, Div, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison DivI16()
        {
            var opid = Id<short>(OpKind.Div);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.DivFused, targets.Left);
            var benched = Measure(!~opid, Div, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison DivU16()
        {
            var opid = Id<ushort>(OpKind.Div);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.DivFused, targets.Left);
            var benched = Measure(!~opid, Div, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison DivI32()
        {
            var opid = Id<int>(OpKind.Div);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.DivFused, targets.Left);
            var benched = Measure(!~opid, Div, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison DivU32()
        {
            var opid = Id<uint>(OpKind.Div);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.DivFused, targets.Left);
            var benched = Measure(!~opid, Div, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison DivI64()
        {
            var opid = Id<long>(OpKind.Div);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.DivFused, targets.Left);
            var benched = Measure(!~opid, Div, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison DivU64()
        {
            var opid = Id<ulong>(OpKind.Div);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.DivFused, targets.Left);
            var benched = Measure(!~opid, Div, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison DivF32()
        {
            var opid = Id<float>(OpKind.Div);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.DivFused, targets.Left);
            var benched = Measure(!~opid, Div, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison DivF64()
        {
            var opid = Id<double>(OpKind.Div);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.DivFused, targets.Left);
            var benched = Measure(!~opid, Div, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

    }

}