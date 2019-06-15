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

            var lhs = Randomizer.Vec128<double>();
            var rhs = Randomizer.Vec128<double>();

            var lDst = span<double>(2);
            lhs.StoreTo(lDst);

            var rDst = span<double>(2);
            rhs.StoreTo(rDst);

            var expect = math.fcmp(lDst, rDst, mode);
            var actual = dinx.cmpf(lhs, rhs, mode);
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
