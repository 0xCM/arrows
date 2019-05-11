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
        public IBenchComparison AndI8()
        {
            var opid = Id<sbyte>(OpKind.And);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.and(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.and(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison AndU8()
        {
            var opid = Id<byte>(OpKind.And);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.and(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.and(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison AndI16()
        {
            var opid = Id<short>(OpKind.And);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.and(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.and(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison AndU16()
        {
            var opid = Id<ushort>(OpKind.And);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.and(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.and(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison AndI32()
        {
            var opid = Id<int>(OpKind.And);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.and(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.and(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison AndU32()
        {
            var opid = Id<uint>(OpKind.And);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.and(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.and(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison AndI64()
        {
            var opid = Id<long>(OpKind.And);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.and(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.and(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison AndU64()
        {
            var opid = Id<ulong>(OpKind.And);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.and(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.and(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }
    }
}