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
            var opid = Id<sbyte>(OpKind.Min);
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
            var opid = Id<byte>(OpKind.Min);
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
            var opid = Id<short>(OpKind.Min);
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
            var opid = Id<ushort>(OpKind.Min);
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
            var opid = Id<int>(OpKind.Min);
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
            var opid = Id<uint>(OpKind.Min);
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
            var opid = Id<long>(OpKind.Min);
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
            var opid = Id<ulong>(OpKind.Min);
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
            var opid = Id<float>(OpKind.Min);
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
            var opid = Id<double>(OpKind.Min);
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