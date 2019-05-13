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
        OpMetrics LtEq<T>(bool[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.LtEq);
            var samples = Sampled(opid);
            var it = -1;
            
            var sw = stopwatch();            
            while(++it < SampleSize)
                dst[it] = gmath.lteq(samples.Left[it], samples.Right[it]);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison LtEqI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtEqI8, targets.Left);
            var benched = Measure(!~opid, LtEq<sbyte>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtEqU8()
        {
            var opid = Id<byte>(OpKind.LtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtEqU8, targets.Left);
            var benched = Measure(!~opid, LtEq<byte>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtEqI16()
        {
            var opid = Id<short>(OpKind.LtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtEqI16, targets.Left);
            var benched = Measure(!~opid, LtEq<short>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtEqU16()
        {
            var opid = Id<ushort>(OpKind.LtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtEqU16, targets.Left);
            var benched = Measure(!~opid, LtEq<ushort>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtEqI32()
        {
            var opid = Id<int>(OpKind.LtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtEqI32, targets.Left);
            var benched = Measure(!~opid, LtEq<int>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtEqU32()
        {
            var opid = Id<uint>(OpKind.LtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtEqU32, targets.Left);
            var benched = Measure(!~opid, LtEq<uint>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtEqI64()
        {
            var opid = Id<long>(OpKind.LtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtEqI64, targets.Left);
            var benched = Measure(!~opid, LtEq<long>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtEqU64()
        {
            var opid = Id<ulong>(OpKind.LtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtEqU64, targets.Left);
            var benched = Measure(!~opid, LtEq<ulong>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtEqF32()
        {
            var opid = Id<float>(OpKind.LtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtEqF32, targets.Left);
            var benched = Measure(!~opid, LtEq<float>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtEqF64()
        {
            var opid = Id<double>(OpKind.LtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtEqF64, targets.Left);
            var benched = Measure(!~opid, LtEq<double>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
      }

    }
}