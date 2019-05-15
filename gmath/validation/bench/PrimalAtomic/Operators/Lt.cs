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
        OpMetrics Lt<T>(bool[] dst)
            where T : struct
        {
            var opid = Id<T>(OpKind.Lt);
            var samples = Sampled(opid);
            var it = -1;
            
            var sw = stopwatch();            
            while(++it < SampleSize)
                dst[it] = gmath.lt(samples.Left[it], samples.Right[it]);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison LtI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtI8, targets.Left);
            var benched = Measure(!~opid, Lt<sbyte>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtU8()
        {
            var opid = Id<byte>(OpKind.Lt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtU8, targets.Left);
            var benched = Measure(!~opid, Lt<byte>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtI16()
        {
            var opid = Id<short>(OpKind.Lt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtI16, targets.Left);
            var benched = Measure(!~opid, Lt<short>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtU16()
        {
            var opid = Id<ushort>(OpKind.Lt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtU16, targets.Left);
            var benched = Measure(!~opid, Lt<ushort>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtI32()
        {
            var opid = Id<int>(OpKind.Lt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtI32, targets.Left);
            var benched = Measure(!~opid, Lt<int>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtU32()
        {
            var opid = Id<uint>(OpKind.Lt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtU32, targets.Left);
            var benched = Measure(!~opid, Lt<uint>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtI64()
        {
            var opid = Id<long>(OpKind.Lt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtI64, targets.Left);
            var benched = Measure(!~opid, Lt<long>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtU64()
        {
            var opid = Id<ulong>(OpKind.Lt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtU64, targets.Left);
            var benched = Measure(!~opid, Lt<ulong>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtF32()
        {
            var opid = Id<float>(OpKind.Lt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtF32, targets.Left);
            var benched = Measure(!~opid, Lt<float>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison LtF64()
        {
            var opid = Id<double>(OpKind.Lt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.LtF64, targets.Left);
            var benched = Measure(!~opid, Lt<double>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
      }

    }
}