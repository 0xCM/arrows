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
        public IBenchComparison MinI8()
        {
            var opid = Id<sbyte>(OpKind.MinAggregate);
            var zero = default(sbyte);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.min(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.min(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MinU8()
        {
            var opid = Id<byte>(OpKind.MinAggregate);
            var zero = default(byte);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.min(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.min(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MinI16()
        {
            var opid = Id<short>(OpKind.MinAggregate);
            var zero = default(short);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.min(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.min(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MinU16()
        {
            var opid = Id<ushort>(OpKind.MinAggregate);
            var zero = default(ushort);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.min(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.min(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MinI32()
        {
            var opid = Id<int>(OpKind.MinAggregate);
            var zero = default(int);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.min(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.min(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MinU32()
        {
            var opid = Id<uint>(OpKind.MinAggregate);
            var zero = default(uint);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.min(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.min(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

       public IBenchComparison MinI64()
        {
            var opid = Id<long>(OpKind.MinAggregate);
            var zero = default(long);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.min(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.min(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MinU64()
        {
            var opid = Id<ulong>(OpKind.MinAggregate);
            var zero = default(ulong);
            var src = LeftSrc.Sampled(opid);
            
            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.min(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.min(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
        }

        public IBenchComparison MinF32()
        {
            var opid = Id<float>(OpKind.MinAggregate);
            var zero = default(float);
            var src = LeftSrc.Sampled(opid);

            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.min(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.min(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
            
        }

        public IBenchComparison MinF64()
        {
            var opid = Id<double>(OpKind.MinAggregate);
            var zero = default(double);
            var src = LeftSrc.Sampled(opid);

            var lhsDst = zero;
            var rhsDst = zero;

            var lhs = Measure(opid, () => lhsDst = math.min(src));
            var rhs = Measure(!opid, () => rhsDst = gmath.min(src));
            
            var comparison = Compare(opid, lhs, rhs);
            Claim.eq(lhsDst, rhsDst);            
            return Finish(comparison);
            
        }


    }

}