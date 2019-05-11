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
            var src = Sampled(opid,true);
            var dst = Targets(opid);
            
            var lhs = Measure(opid, () => 
                math.mod(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.mod(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU8()
        {
            var opid = Id<byte>(OpKind.Mod);
            var src = Sampled(opid,true);
            var dst = Targets(opid);
            
            var lhs = Measure(opid, () => 
                math.mod(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.mod(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModI16()
        {
            var opid = Id<short>(OpKind.Mod);
            var src = Sampled(opid,true);
            var dst = Targets(opid);
            
            var lhs = Measure(opid, () => 
                math.mod(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.mod(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU16()
        {
            var opid = Id<ushort>(OpKind.Mod);
            var src = Sampled(opid,true);
            var dst = Targets(opid);
            
            var lhs = Measure(opid, () => 
                math.mod(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.mod(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModI32()
        {
            var opid = Id<int>(OpKind.Mod);
            var src = Sampled(opid,true);
            var dst = Targets(opid);
            
            var lhs = Measure(opid, () => 
                math.mod(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.mod(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU32()
        {
            var opid = Id<uint>(OpKind.Mod);
            var src = Sampled(opid,true);
            var dst = Targets(opid);
            
            var lhs = Measure(opid, () => 
                math.mod(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.mod(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModI64()
        {
            var opid = Id<long>(OpKind.Mod);
            var src = Sampled(opid,true);
            var dst = Targets(opid);
            
            var lhs = Measure(opid, () => 
                math.mod(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.mod(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU64()
        {
            var opid = Id<ulong>(OpKind.Mod);
            var src = Sampled(opid,true);
            var dst = Targets(opid);
            
            var lhs = Measure(opid, () => 
                math.mod(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.mod(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModF32()
        {
            var opid = Id<float>(OpKind.Mod);
            var src = Sampled(opid,true);
            var dst = Targets(opid);
            
            var lhs = Measure(opid, () => 
                math.mod(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.mod(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

        public IBenchComparison ModF64()
        {
            var opid = Id<double>(OpKind.Mod);
            var src = Sampled(opid,true);
            var dst = Targets(opid);
            
            var lhs = Measure(opid, () => 
                math.mod(src.Left, src.Right, dst.Left));
            var rhs = Measure(!opid, () => 
                gmath.mod(src.Left, src.Right, dst.Right));

            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(dst.Left, dst.Right);        
            return Finish(comparison);            
        }

    }

}