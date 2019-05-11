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
        public IBenchComparison OrI8()
        {
            var opid = Id<sbyte>(OpKind.Or);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.or(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.or(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison OrU8()
        {
            var opid = Id<byte>(OpKind.Or);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.or(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.or(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison OrI16()
        {
            var opid = Id<short>(OpKind.Or);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.or(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.or(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison OrU16()
        {
            var opid = Id<ushort>(OpKind.Or);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.or(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.or(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison OrI32()
        {
            var opid = Id<int>(OpKind.Or);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.or(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.or(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison OrU32()
        {
            var opid = Id<uint>(OpKind.Or);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.or(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.or(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison OrI64()
        {
            var opid = Id<long>(OpKind.Or);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.or(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.or(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison OrU64()
        {
            var opid = Id<ulong>(OpKind.Or);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.or(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.or(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }
    }
}