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
        OpMetrics Or<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Or);
            var samples = Sampled(opid);            
            var sw = stopwatch();            
            gmath.or(samples.Left, samples.Right, dst);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison OrI8()
        {
            var opid = Id<sbyte>(OpKind.Or);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.OrFused, targets.Left);
            var benched = Measure(!~opid, Or, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison OrU8()
        {
            var opid = Id<byte>(OpKind.Or);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.OrFused, targets.Left);
            var benched = Measure(!~opid, Or, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison OrI16()
        {
            var opid = Id<short>(OpKind.Or);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.OrFused, targets.Left);
            var benched = Measure(!~opid, Or, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison OrU16()
        {
            var opid = Id<ushort>(OpKind.Or);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.OrFused, targets.Left);
            var benched = Measure(!~opid, Or, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison OrI32()
        {
            var opid = Id<int>(OpKind.Or);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.OrFused, targets.Left);
            var benched = Measure(!~opid, Or, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison OrU32()
        {
            var opid = Id<uint>(OpKind.Or);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.OrFused, targets.Left);
            var benched = Measure(!~opid, Or, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison OrI64()
        {
            var opid = Id<long>(OpKind.Or);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.OrFused, targets.Left);
            var benched = Measure(!~opid, Or, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison OrU64()
        {
            var opid = Id<ulong>(OpKind.Or);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.OrFused, targets.Left);
            var benched = Measure(!~opid, Or, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        } 
    }
}