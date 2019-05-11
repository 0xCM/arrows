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
        public IBenchComparison SubI8()
        {
            var opid = Id<sbyte>(OpKind.Sub);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.sub(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.sub(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison SubU8()
        {
            var opid = Id<byte>(OpKind.Sub);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.sub(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.sub(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison SubI16()
        {
            var opid = Id<short>(OpKind.Sub);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.sub(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.sub(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison SubU16()
        {
            var opid = Id<ushort>(OpKind.Sub);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.sub(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.sub(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison SubI32()
        {
            var opid = Id<int>(OpKind.Sub);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.sub(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.sub(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison SubU32()
        {
            var opid = Id<uint>(OpKind.Sub);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.sub(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.sub(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison SubI64()
        {
            var opid = Id<long>(OpKind.Sub);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.sub(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.sub(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison SubU64()
        {
            var opid = Id<ulong>(OpKind.Sub);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.sub(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.sub(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison SubF32()
        {
            var opid = Id<float>(OpKind.Sub);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.sub(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.sub(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison SubF64()
        {
            var opid = Id<double>(OpKind.Sub);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.sub(src.Left, src.Right, dst.Left));

            var rhs = Measure(!opid, () => 
                gmath.sub(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }
    }
}