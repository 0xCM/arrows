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

    partial class NumGBench
    {
       OpMetrics Negate<T>(T[] dst)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var src = Num.many(Sampled(opid).Left);
            var stage = alloc<num<T>>(dst.Length);
            
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                stage[it] = - src[it];

            var time = snapshot(sw);
            stage.Extract().CopyTo(dst);
            return(SampleSize, time);
        }

        public IBenchComparison NegateI8()
        {
            var opid = Id<sbyte>(OpKind.Negate);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Negate, targets.Left);
            var benched = Measure(!~opid, Negate, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }


        public IBenchComparison NegateI16()
        {
            var opid =  Id<short>(OpKind.Negate);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Negate, targets.Left);
            var benched = Measure(!~opid, Negate, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }


        public IBenchComparison NegateI32()
        {
            var opid =  Id<int>(OpKind.Negate);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Negate, targets.Left);
            var benched = Measure(!~opid, Negate, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }


        public IBenchComparison NegateI64()
        {
            var opid =  Id<long>(OpKind.Negate);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Negate, targets.Left);
            var benched = Measure(!~opid, Negate, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison NegateF32()
        {
            var opid =  Id<float>(OpKind.Negate);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Negate, targets.Left);
            var benched = Measure(!~opid, Negate, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison NegateF64()
        {
            var opid =  Id<double>(OpKind.Negate);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Negate, targets.Left);
            var benched = Measure(!~opid, Negate, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        } 
    }
}