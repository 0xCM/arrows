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
       OpMetrics XOr<T>(T[] dst)
            where T : struct
        {
            var opid =  Id<T>(OpKind.XOr);
            var src = Sampled(opid);
            var lhs = Num.many(src.Left);
            var rhs = Num.many(src.Right);
            var stage = alloc<num<T>>(dst.Length);
            
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                stage[it] = lhs[it] ^ rhs[it];
            
            var time = snapshot(sw);
            stage.Extract().CopyTo(dst);
            return(SampleSize, time);
        }

        public IBenchComparison XOrI8()
        {
            var opid = Id<sbyte>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOr, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrU8()
        {
            var opid =  Id<byte>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOr, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrI16()
        {
            var opid =  Id<short>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOr, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrU16()
        {
            var opid =  Id<ushort>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOr, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }


        public IBenchComparison XOrI32()
        {
            var opid =  Id<int>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOr, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrU32()
        {
            var opid =  Id<uint>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOr, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrI64()
        {
            var opid =  Id<long>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOr, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison XOrU64()
        {
            var opid =  Id<ulong>(OpKind.XOr);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.XOr, targets.Left);
            var benched = Measure(!~opid, XOr, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

    }
}