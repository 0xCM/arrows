//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    public class CmpF64 : UnitTest<CmpF64>
    {
        public CmpF64()
        {

        }
        
        void Verify(FloatComparisonMode mode)
        {

            var lhs = Random.CpuVec128<double>();
            var rhs = Random.CpuVec128<double>();

            var lDst = span<double>(2);
            lhs.ToSpan(lDst);

            var rDst = span<double>(2);
            rhs.ToSpan(rDst);

            var expect = math.fcmp(lDst, rDst, mode);
            var actual = dfp.cmpf(lhs, rhs, mode);
            Claim.eq(expect,actual);

        }
            
        public void CmpEq()
            => Verify(FloatComparisonMode.OrderedEqualNonSignaling);

        public void CmpNEq()
            => Verify(FloatComparisonMode.OrderedNotEqualNonSignaling);

        public void CmpLt()
            => Verify(FloatComparisonMode.OrderedLessThanNonSignaling);

        public void CmpLtEq()
            => Verify(FloatComparisonMode.OrderedLessThanOrEqualNonSignaling);

        public void CmpNlt()
            => Verify(FloatComparisonMode.OrderedLessThanOrEqualNonSignaling);

        public void CmpNltEq()
            => Verify(FloatComparisonMode.UnorderedNotLessThanOrEqualNonSignaling);

        public void CmpGt()
            => Verify(FloatComparisonMode.OrderedGreaterThanNonSignaling);

        public void CmpGtEq()
            => Verify(FloatComparisonMode.OrderedGreaterThanOrEqualNonSignaling);

        public void CmpNgt()
            => Verify(FloatComparisonMode.UnorderedNotGreaterThanNonSignaling);

        public void CmpNgtEq()
            => Verify(FloatComparisonMode.UnorderedNotGreaterThanOrEqualNonSignaling);

    }
}
