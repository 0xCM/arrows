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
        public IBenchComparison MulI8()
        {
            var opid = Id<sbyte>(OpKind.Mul);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mul(src.Left, src.Right, dst.Left));

            var rhs = Measure(~opid, () => 
                gmath.mul(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison MulU8()
        {
            var opid = Id<byte>(OpKind.Mul);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mul(src.Left, src.Right, dst.Left));

            var rhs = Measure(~opid, () => 
                gmath.mul(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison MulI16()
        {
            var opid = Id<short>(OpKind.Mul);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mul(src.Left, src.Right, dst.Left));

            var rhs = Measure(~opid, () => 
                gmath.mul(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison MulU16()
        {
            var opid = Id<ushort>(OpKind.Mul);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mul(src.Left, src.Right, dst.Left));

            var rhs = Measure(~opid, () => 
                gmath.mul(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison MulI32()
        {
            var opid = Id<int>(OpKind.Mul);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mul(src.Left, src.Right, dst.Left));

            var rhs = Measure(~opid, () => 
                gmath.mul(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison MulU32()
        {
            var opid = Id<uint>(OpKind.Mul);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mul(src.Left, src.Right, dst.Left));

            var rhs = Measure(~opid, () => 
                gmath.mul(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison MulI64()
        {
            var opid = Id<long>(OpKind.Mul);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mul(src.Left, src.Right, dst.Left));

            var rhs = Measure(~opid, () => 
                gmath.mul(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison MulU64()
        {
            var opid = Id<ulong>(OpKind.Mul);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mul(src.Left, src.Right, dst.Left));

            var rhs = Measure(~opid, () => 
                gmath.mul(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison MulF32()
        {
            var opid = Id<float>(OpKind.Mul);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mul(src.Left, src.Right, dst.Left));

            var rhs = Measure(~opid, () => 
                gmath.mul(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison MulF64()
        {
            var opid = Id<double>(OpKind.Mul);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.mul(src.Left, src.Right, dst.Left));

            var rhs = Measure(~opid, () => 
                gmath.mul(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

    }

}