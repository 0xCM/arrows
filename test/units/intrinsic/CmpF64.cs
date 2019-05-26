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
    using static mfunc;

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
            lhs.ExtractTo(lDst);

            var rDst = span<double>(2);
            rhs.ExtractTo(rDst);

            var expect = math.fcmp(lDst, rDst, mode);
            var actual = dinx.cmpf(lhs, rhs, mode);
            Claim.eq(expect,actual);

        }
            

        // public void ClearNaN()
        // {
        //     var src = Vec128.define(3.4d, double.NaN);
        //     var result = mfunc.clearNaN(src);
        //     var expect = Vec128.define(3.4d, -1d);
        //     Claim.eq(expect,result);

        //     src = Vec128.define(double.NaN,3.4d);
        //     result = mfunc.clearNaN(src);
        //     expect = Vec128.define(-1d,3.4d);
        //     Claim.eq(expect,result);
        // }

        public void CmpEq(bool ordered = true, bool signal = false)
            => Verify(FloatComparisonMode.OrderedEqualNonSignaling);

        public void CmpNEq(bool ordered = true, bool signal = false)
            => Verify(FloatComparisonMode.OrderedNotEqualNonSignaling);

        public void CmpLt(bool signal = false)
            => Verify(FloatComparisonMode.OrderedLessThanNonSignaling);

        public void CmpLtEq(bool signal = false)
            => Verify(FloatComparisonMode.OrderedLessThanOrEqualNonSignaling);

        public void CmpNlt()
            => Verify(FloatComparisonMode.OrderedLessThanOrEqualNonSignaling);

        public void CmpNltEq(bool signal = false)
            => Verify(FloatComparisonMode.UnorderedNotLessThanOrEqualNonSignaling);

        public void CmpGt(bool signal = false)
            => Verify(FloatComparisonMode.OrderedGreaterThanNonSignaling);

        public void CmpGtEq(bool signal = false)
            => Verify(FloatComparisonMode.OrderedGreaterThanOrEqualNonSignaling);

        public void CmpNgt(bool signal = false)
            => Verify(FloatComparisonMode.UnorderedNotGreaterThanNonSignaling);

        public void CmpNgtEq(bool signal = false)
            => Verify(FloatComparisonMode.UnorderedNotGreaterThanOrEqualNonSignaling);

        public void Misc()
        {
            var x0 = Vec128.define(-1.5, 8.9);
            var x1 = Vec128.define(-4.7, 3.2);
            var result = dinx.cmpf(x0,x1,FloatComparisonMode.OrderedLessThanNonSignaling);
            Trace($"{x0} < {x1} = {result}");                


            x0 = Vec128.define(-1.0, -1.0);
            x1 = Vec128.define(1.0, 1.0);
            result = dinx.cmpf(x0,x1,FloatComparisonMode.OrderedLessThanNonSignaling);
            Trace($"{x0} < {x1} = {result}");


            x0 = Vec128.define(1.0, -1.0);
            x1 = Vec128.define(1.0, 1.0);
            result = dinx.cmpf(x0,x1,FloatComparisonMode.OrderedLessThanNonSignaling);
            Trace($"{x0} < {x1} = {result}");
        }
    }
}
