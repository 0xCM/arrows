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
        public IBenchComparison DivI8()
        {
            var opid = Id<sbyte>(OpKind.Div);
            var srcLeft = LeftSrc.Sampled(opid); 
            var srcRight = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.div(srcLeft, srcRight, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.div(srcLeft, srcRight, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison DivU8()
        {
            var opid = Id<byte>(OpKind.Div);
            var leftSrc = LeftSrc.Sampled(opid); 
            var rightSrc = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.div(leftSrc, rightSrc, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.div(leftSrc, rightSrc, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison DivI16()
        {
            var opid = Id<short>(OpKind.Div);
            var leftSrc = LeftSrc.Sampled(opid); 
            var rightSrc = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.div(leftSrc, rightSrc, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.div(leftSrc, rightSrc, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison DivU16()
        {
            var opid = Id<ushort>(OpKind.Div);
            var leftSrc = LeftSrc.Sampled(opid); 
            var rightSrc = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.div(leftSrc, rightSrc, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.div(leftSrc, rightSrc, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison DivI32()
        {
            var opid = Id<int>(OpKind.Div);
            var leftSrc = LeftSrc.Sampled(opid); 
            var rightSrc = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.div(leftSrc, rightSrc, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.div(leftSrc, rightSrc, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison DivU32()
        {
            var opid = Id<uint>(OpKind.Div);
            var leftSrc = LeftSrc.Sampled(opid); 
            var rightSrc = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.div(leftSrc, rightSrc, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.div(leftSrc, rightSrc, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison DivI64()
        {
            var opid = Id<long>(OpKind.Div);
            var leftSrc = LeftSrc.Sampled(opid); 
            var rightSrc = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.div(leftSrc, rightSrc, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.div(leftSrc, rightSrc, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison DivU64()
        {
            var opid = Id<ulong>(OpKind.Div);
            var leftSrc = LeftSrc.Sampled(opid); 
            var rightSrc = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.div(leftSrc, rightSrc, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.div(leftSrc, rightSrc, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison DivF32()
        {
            var opid = Id<float>(OpKind.Div);
            var leftSrc = LeftSrc.Sampled(opid); 
            var rightSrc = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.div(leftSrc, rightSrc, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.div(leftSrc, rightSrc, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison DivF64()
        {
            var opid = Id<double>(OpKind.Div);
            var leftSrc = LeftSrc.Sampled(opid); 
            var rightSrc = NonZeroSrc.Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.div(leftSrc, rightSrc, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.div(leftSrc, rightSrc, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

    }

}