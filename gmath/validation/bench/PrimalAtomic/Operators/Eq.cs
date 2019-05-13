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
        OpMetrics Eq<T>(bool[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Eq);
            var samples = Sampled(opid);
            var it = -1;
            
            var sw = stopwatch();            
            while(++it < SampleSize)
                dst[it] = gmath.eq(samples.Left[it], samples.Right[it]);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison EqI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.EqI8, targets.Left);
            var benched = Measure(!~opid, Eq<sbyte>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison EqU8()
        {
            var opid = Id<byte>(OpKind.Eq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.EqU8, targets.Left);
            var benched = Measure(!~opid, Eq<byte>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison EqI16()
        {
            var opid = Id<short>(OpKind.Eq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.EqI16, targets.Left);
            var benched = Measure(!~opid, Eq<short>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison EqU16()
        {
            var opid = Id<ushort>(OpKind.Eq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.EqU16, targets.Left);
            var benched = Measure(!~opid, Eq<ushort>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison EqI32()
        {
            var opid = Id<int>(OpKind.Eq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.EqI32, targets.Left);
            var benched = Measure(!~opid, Eq<int>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison EqU32()
        {
            var opid = Id<uint>(OpKind.Eq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.EqU32, targets.Left);
            var benched = Measure(!~opid, Eq<uint>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison EqI64()
        {
            var opid = Id<long>(OpKind.Eq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.EqI64, targets.Left);
            var benched = Measure(!~opid, Eq<long>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison EqU64()
        {
            var opid = Id<ulong>(OpKind.Eq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.EqU64, targets.Left);
            var benched = Measure(!~opid, Eq<ulong>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison EqF32()
        {
            var opid = Id<float>(OpKind.Eq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.EqF32, targets.Left);
            var benched = Measure(!~opid, Eq<float>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison EqF64()
        {
            var opid = Id<double>(OpKind.Eq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.EqF64, targets.Left);
            var benched = Measure(!~opid, Eq<double>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
      }

    }
}