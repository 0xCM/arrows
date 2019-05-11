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
        public IBenchComparison FlipI8()
        {
            var opid = Id<sbyte>(OpKind.Flip);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.flip(src.Left, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.flip(src.Left, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison FlipU8()
        {
            var opid = Id<byte>(OpKind.Flip);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.flip(src.Left, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.flip(src.Left, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison FlipI16()
        {
            var opid = Id<short>(OpKind.Flip);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.flip(src.Left, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.flip(src.Left, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }
        
        public IBenchComparison FlipU16()
        {
            var opid = Id<ushort>(OpKind.Flip);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.flip(src.Left, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.flip(src.Left, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison FlipI32()
        {
            var opid = Id<int>(OpKind.Flip);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.flip(src.Left, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.flip(src.Left, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison FlipU32()
        {
            var opid = Id<uint>(OpKind.Flip);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.flip(src.Left, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.flip(src.Left, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }


        public IBenchComparison FlipI64()
        {
            var opid = Id<long>(OpKind.Flip);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.flip(src.Left, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.flip(src.Left, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison FlipU64()
        {
            var opid = Id<ulong>(OpKind.Flip);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.flip(src.Left, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.flip(src.Left, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }
 
    }

}