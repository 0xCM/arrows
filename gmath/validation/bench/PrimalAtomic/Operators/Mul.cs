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

    partial class PrimalAtomicBench
    {
        OpMetrics Mul<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Mul);
            var samples = Sampled(opid);
            var it = -1;
            
            var sw = stopwatch();            
            while(++it < SampleSize)
                dst[it] = gmath.mul(samples.Left[it], samples.Right[it]);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison MulI8()
        {
            var opid = Id<sbyte>(OpKind.Mul);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Mul, targets.Left);
            var benched = Measure(!~opid, Mul, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison MulU8()
        {
            var opid = Id<byte>(OpKind.Mul);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Mul, targets.Left);
            var benched = Measure(!~opid, Mul, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison MulI16()
        {
            var opid = Id<short>(OpKind.Mul);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Mul, targets.Left);
            var benched = Measure(!~opid, Mul, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison MulU16()
        {
            var opid = Id<ushort>(OpKind.Mul);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Mul, targets.Left);
            var benched = Measure(!~opid, Mul, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison MulI32()
        {
            var opid = Id<int>(OpKind.Mul);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Mul, targets.Left);
            var benched = Measure(!~opid, Mul, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison MulU32()
        {
            var opid = Id<uint>(OpKind.Mul);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Mul, targets.Left);
            var benched = Measure(!~opid, Mul, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison MulI64()
        {
            var opid = Id<long>(OpKind.Mul);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Mul, targets.Left);
            var benched = Measure(!~opid, Mul, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison MulU64()
        {
            var opid = Id<ulong>(OpKind.Mul);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Mul, targets.Left);
            var benched = Measure(!~opid, Mul, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison MulF32()
        {
            var opid = Id<float>(OpKind.Mul);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Mul, targets.Left);
            var benched = Measure(!~opid, Mul, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison MulF64()
        {
            var opid = Id<double>(OpKind.Mul);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Mul, targets.Left);
            var benched = Measure(!~opid, Mul, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        } 
    }
}