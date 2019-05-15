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



        OpMetrics Add<T>(T[] dst)
            where T : struct
        {
            var opid = Id<T>(OpKind.Add);
            var samples = Sampled(opid);            
            var sw = stopwatch();            
            fused.add<T>(samples.Left, samples.Right, dst);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison AddI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AddFused, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AddU8()
        {
            var opid = Id<byte>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AddFused, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AddI16()
        {
            var opid = Id<short>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AddFused, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AddU16()
        {
            var opid = Id<ushort>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AddFused, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AddI32()
        {
            var opid = Id<int>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AddFused, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AddU32()
        {
            var opid = Id<uint>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AddFused, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AddI64()
        {
            var opid = Id<long>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AddFused, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AddU64()
        {
            var opid = Id<ulong>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AddFused, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AddF32()
        {
            var opid = Id<float>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AddFused, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison AddF64()
        {
            var opid = Id<double>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.AddFused, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

    }

}