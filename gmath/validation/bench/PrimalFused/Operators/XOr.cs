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
        public IBenchComparison XOrI8()
        {
            var opid = Id<sbyte>(OpKind.XOr);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.xor(src.Left, src.Right, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.xor(src.Left, src.Right, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrU8()
        {
            var opid = Id<byte>(OpKind.XOr);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.xor(src.Left, src.Right, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.xor(src.Left, src.Right, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrI16()
        {
            var opid = Id<short>(OpKind.XOr);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.xor(src.Left, src.Right, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.xor(src.Left, src.Right, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrU16()
        {
            var opid = Id<ushort>(OpKind.XOr);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.xor(src.Left, src.Right, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.xor(src.Left, src.Right, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrI32()
        {
            var opid = Id<int>(OpKind.XOr);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.xor(src.Left, src.Right, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.xor(src.Left, src.Right, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrU32()
        {
            var opid = Id<uint>(OpKind.XOr);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.xor(src.Left, src.Right, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.xor(src.Left, src.Right, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrI64()
        {
            var opid = Id<long>(OpKind.XOr);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.xor(src.Left, src.Right, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.xor(src.Left, src.Right, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrU64()
        {
            var opid = Id<ulong>(OpKind.XOr);
            var src = Sampled(opid);
            var dst = Targets(opid);

            var lhs = Measure(opid, () => 
                math.xor(src.Left, src.Right, dst.Left), SampleSize);

            var rhs = Measure(~opid, () => 
                gmath.xor(src.Left, src.Right, dst.Right), SampleSize);

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }
    }
}