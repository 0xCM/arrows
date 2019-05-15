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

        OpMetrics Inc<T>(T[] io)
            where T : struct
        {
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                gmath.inc(ref io[it]);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison IncI8()
        {
            var opid = Id<sbyte>(OpKind.Inc);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.IncIO, io.Left);            
            var benched = Measure(!~opid, Inc, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison IncU8()
        {
            var opid = Id<byte>(OpKind.Inc);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.IncIO, io.Left);            
            var benched = Measure(!~opid, Inc, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison IncI16()
        {
            var opid = Id<short>(OpKind.Inc);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.IncIO, io.Left);            
            var benched = Measure(!~opid, Inc, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison IncU16()
        {
            var opid = Id<ushort>(OpKind.Inc);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.IncIO, io.Left);            
            var benched = Measure(!~opid, Inc, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison IncI32()
        {
            var opid = Id<int>(OpKind.Inc);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.IncIO, io.Left);            
            var benched = Measure(!~opid, Inc, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison IncU32()
        {
            var opid = Id<uint>(OpKind.Inc);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.IncIO, io.Left);            
            var benched = Measure(!~opid, Inc, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison IncI64()
        {
            var opid = Id<long>(OpKind.Inc);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.IncIO, io.Left);            
            var benched = Measure(!~opid, Inc, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison IncU64()
        {
            var opid = Id<ulong>(OpKind.Inc);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.IncIO, io.Left);            
            var benched = Measure(!~opid, Inc, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison IncF32()
        {
            var opid = Id<float>(OpKind.Inc);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.IncIO, io.Left);            
            var benched = Measure(!~opid, Inc, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison IncF64()
        {
            var opid = Id<double>(OpKind.Inc);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.IncIO, io.Left);            
            var benched = Measure(!~opid, Inc, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

    }


}