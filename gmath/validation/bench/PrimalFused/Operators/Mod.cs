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
        public IBenchComparison ModI8()
        {
            var opid = Id<sbyte>(OpKind.Mod);
            var srcLeft = LeftSrc.Sampled(opid); 
            var srcRight = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mod(srcLeft, srcRight, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.mod(srcLeft, srcRight, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU8()
        {
            var opid = Id<byte>(OpKind.Mod);
            var srcLeft = LeftSrc.Sampled(opid); 
            var srcRight = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mod(srcLeft, srcRight, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.mod(srcLeft, srcRight, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModI16()
        {
            var opid = Id<short>(OpKind.Mod);
            var srcLeft = LeftSrc.Sampled(opid); 
            var srcRight = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mod(srcLeft, srcRight, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.mod(srcLeft, srcRight, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU16()
        {
            var opid = Id<ushort>(OpKind.Mod);
            var srcLeft = LeftSrc.Sampled(opid); 
            var srcRight = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mod(srcLeft, srcRight, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.mod(srcLeft, srcRight, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModI32()
        {
            var opid = Id<int>(OpKind.Mod);
            var srcLeft = LeftSrc.Sampled(opid); 
            var srcRight = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mod(srcLeft, srcRight, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.mod(srcLeft, srcRight, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU32()
        {
            var opid = Id<uint>(OpKind.Mod);
            var srcLeft = LeftSrc.Sampled(opid); 
            var srcRight = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mod(srcLeft, srcRight, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.mod(srcLeft, srcRight, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModI64()
        {
            var opid = Id<long>(OpKind.Mod);
            var srcLeft = LeftSrc.Sampled(opid); 
            var srcRight = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mod(srcLeft, srcRight, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.mod(srcLeft, srcRight, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU64()
        {
            var opid = Id<ulong>(OpKind.Mod);
            var dst = Targets(opid);

            var direct = Measure(opid, () => 
                math.mod(LeftSrc.Sampled(opid), NonZeroSrc.Sampled(opid), dst.Left), dst.Left.Length);

            var generic = Measure(~opid, () => 
                gmath.mod(LeftSrc.Sampled(opid), NonZeroSrc.Sampled(opid), dst.Right), dst.Right.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModF32()
        {
            var opid = Id<float>(OpKind.Mod);
            var srcLeft = LeftSrc.Sampled(opid); 
            var srcRight = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mod(srcLeft, srcRight, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.mod(srcLeft, srcRight, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModF64()
        {
            var opid = Id<double>(OpKind.Mod);
            var srcLeft = LeftSrc.Sampled(opid); 
            var srcRight = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mod(srcLeft, srcRight, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.mod(srcLeft, srcRight, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

    }

}