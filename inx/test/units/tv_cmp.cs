//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    
    using static zfunc;

    public class tv_cmp : UnitTest<tv_cmp>
    {                    
        public void eq128f64()
            => cmp128f64_check(FpCmpMode.EQ_OQ);

        public void neq128f64()
            => cmp128f64_check(FpCmpMode.NEQ_OQ);

        public void lt128f64()
            => cmp128f64_check(FpCmpMode.LT_OQ);

        public void lteq128f64()
            => cmp128f64_check(FpCmpMode.LE_OQ);

        public void nlt128f64()
            => cmp128f64_check(FpCmpMode.LE_OQ);

        public void nlteqf128()
            => cmp128f64_check(FpCmpMode.NLE_UQ);

        public void gt128f64()
            => cmp128f64_check(FpCmpMode.GT_OQ);

        public void gteq128f64()
            => cmp128f64_check(FpCmpMode.GE_OQ);

        public void ngt128f64()
            => cmp128f64_check(FpCmpMode.NGT_UQ);

        public void ngteq128f64()
            => cmp128f64_check(FpCmpMode.NGE_UQ);

        public void eq256f64()
            => cmp256f64_check(FpCmpMode.EQ_OQ);

        public void neq256f64()
            => cmp256f64_check(FpCmpMode.NEQ_OQ);

        public void lt256f64()
            => cmp256f64_check(FpCmpMode.LT_OQ);

        public void lteq256f64()
            => cmp256f64_check(FpCmpMode.LE_OQ);

        public void nlt256f64()
            => cmp256f64_check(FpCmpMode.LE_OQ);

        public void nlteq256f64()
            => cmp256f64_check(FpCmpMode.NLE_UQ);

        public void gt256f64()
            => cmp256f64_check(FpCmpMode.GT_OQ);

        public void gteq256f64()
            => cmp256f64_check(FpCmpMode.GE_OQ);

        public void ngt256f64()
            => cmp256f64_check(FpCmpMode.NGT_UQ);

        public void ngteq256f64()
            => cmp256f64_check(FpCmpMode.NGE_UQ);

        public void eq256f32()
            => cmp256f32_check(FpCmpMode.EQ_OQ);

        public void neq256f32()
            => cmp256f32_check(FpCmpMode.NEQ_OQ);

        public void lt256f32()
            => cmp256f32_check(FpCmpMode.LT_OQ);

        public void lteq256f32()
            => cmp256f32_check(FpCmpMode.LE_OQ);

        public void nlt256f32()
            => cmp256f32_check(FpCmpMode.LE_OQ);

        public void nlteq256f32()
            => cmp256f32_check(FpCmpMode.NLE_UQ);

        public void gt256f32()
            => cmp256f32_check(FpCmpMode.GT_OQ);

        public void gteq256f32()
            => cmp256f32_check(FpCmpMode.GE_OQ);

        public void ngt256f32()
            => cmp256f32_check(FpCmpMode.NGT_UQ);

        public void ngteq256f32()
            => cmp256f32_check(FpCmpMode.NGE_UQ);

        void cmp128f64_check(FpCmpMode mode)
        {
            for(var i = 0; i<SampleSize; i++)
            {
                var lhs = Polyrand.CpuVec128<double>();
                var rhs = Polyrand.CpuVec128<double>();

                Span<double> lDst = stackalloc double[2];
                lhs.StoreTo(ref head(lDst));

                Span<double> rDst = stackalloc double[2];
                rhs.StoreTo(ref head(rDst));

                var expect = fmath.fcmp(lDst, rDst, mode);
                var actual = dfp.cmpf(lhs, rhs, mode);
                Claim.eq(expect,actual);
            }

        }

        void cmp256f32_check(FpCmpMode mode)
        {
            for(var i = 0; i<SampleSize; i++)
            {
                var x = Polyrand.CpuVec256<float>();
                var y = Polyrand.CpuVec256<float>();

                Span<float> xDst = stackalloc float[8];
                x.StoreTo(ref head(xDst));

                Span<float> yDst = stackalloc float[8];
                y.StoreTo(ref head(yDst));

                var expect = fmath.fcmp(xDst, yDst, mode);
                var actual = dfp.cmpf(x, y, mode);
                Claim.eq(expect,actual);
            }

        }

        void cmp256f64_check(FpCmpMode mode)
        {
            for(var i = 0; i<SampleSize; i++)
            {
                var x = Polyrand.CpuVec256<double>();
                var y = Polyrand.CpuVec256<double>();

                Span<double> xDst = stackalloc double[4];
                x.StoreTo(ref head(xDst));

                Span<double> yDst = stackalloc double[4];
                y.StoreTo(ref head(yDst));

                var expect = fmath.fcmp(xDst, yDst, mode);
                var actual = dfp.cmpf(x, y, mode);
                Claim.eq(expect,actual);
            }

        }

    }
}
