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
        OpMetrics Dec<T>(T[] io)
            where T : struct
        {
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                gmath.dec(ref io[it]);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison DecI8()
        {
            var opid = Id<sbyte>(OpKind.Dec);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.DecIO, io.Left);            
            var benched = Measure(!~opid, Dec, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecU8()
        {
            var opid = Id<byte>(OpKind.Dec);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.DecIO, io.Left);            
            var benched = Measure(!~opid, Dec, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecI16()
        {
            var opid = Id<short>(OpKind.Dec);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.DecIO, io.Left);            
            var benched = Measure(!~opid, Dec, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecU16()
        {
            var opid = Id<ushort>(OpKind.Dec);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.DecIO, io.Left);            
            var benched = Measure(!~opid, Dec, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecI32()
        {
            var opid = Id<int>(OpKind.Dec);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.DecIO, io.Left);            
            var benched = Measure(!~opid, Dec, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecU32()
        {
            var opid = Id<uint>(OpKind.Dec);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.DecIO, io.Left);            
            var benched = Measure(!~opid, Dec, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecI64()
        {
            var opid = Id<long>(OpKind.Dec);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.DecIO, io.Left);            
            var benched = Measure(!~opid, Dec, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecU64()
        {
            var opid = Id<ulong>(OpKind.Dec);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.DecIO, io.Left);            
            var benched = Measure(!~opid, Dec, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecF32()
        {
            var opid = Id<float>(OpKind.Dec);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.DecIO, io.Left);            
            var benched = Measure(!~opid, Dec, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecF64()
        {
            var opid = Id<double>(OpKind.Dec);
            var io = LeftSample(opid).PairReplicate();
            var baselined = Measure(opid, Baselines.DecIO, io.Left);            
            var benched = Measure(!~opid, Dec, io.Right);
            var comparison = Run(opid, baselined, benched);                        
            Claim.eq(io.Left, io.Right);                        
            return Finish(comparison);
        }

   }
}