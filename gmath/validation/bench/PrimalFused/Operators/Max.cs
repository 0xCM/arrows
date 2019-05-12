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
        public IBenchComparison MaxI8()
        {
            var opid = Id<sbyte>(OpKind.Max);
            var zero = default(sbyte);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.max(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.max(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MaxU8()
        {
            var opid = Id<byte>(OpKind.Max);
            var zero = default(byte);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.max(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.max(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MaxI16()
        {
            var opid = Id<short>(OpKind.Max);
            var zero = default(short);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.max(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.max(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MaxU16()
        {
            var opid = Id<ushort>(OpKind.Max);
            var zero = default(ushort);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.max(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.max(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MaxI32()
        {
            var opid = Id<int>(OpKind.Max);
            var zero = default(int);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.max(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.max(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MaxU32()
        {
            var opid = Id<uint>(OpKind.Max);
            var zero = default(uint);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.max(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.max(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

       public IBenchComparison MaxI64()
        {
            var opid = Id<long>(OpKind.Max);
            var zero = default(long);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.max(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.max(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MaxU64()
        {
            var opid = Id<ulong>(OpKind.Max);
            var zero = default(ulong);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.max(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.max(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MaxF32()
        {
            var opid = Id<float>(OpKind.Max);
            var zero = default(float);
            var src = LeftSrc.Sampled(opid);

            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.max(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.max(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
            
        }

        public IBenchComparison MaxF64()
        {
            var opid = Id<double>(OpKind.Max);
            var zero = default(double);
            var src = LeftSrc.Sampled(opid);

            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.max(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.max(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
            
        }


    }

}