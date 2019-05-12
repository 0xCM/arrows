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

    using Z0.Testing;
    
    //using static zcore;
    using static zfunc;
    using static mfunc;

    using P = Paths;

    public abstract class CmpFTest<S,T> : InXBinOpTest<S,T>
        where S : CmpFTest<S,T>
        where T : struct, IEquatable<T>
    {        
        protected CmpFTest(Interval<T>? domain = null, int? streamlen = null)
            : base(OpKind.Add.Vec128OpId<T>(), domain, streamlen)        
        {

        }


        protected abstract bool[] Cmp(T[] x, T[] y, FloatCompareKind mode);


        public virtual void Verify(FloatCompareKind mode)
        {
            for(var i=0; i < VecCount; i++)
            {
                var lVec = LeftVecSrc[i];
                var rVec = RightVecSrc[i];

                var lArr = lVec.ToArray();
                var rArr = rVec.ToArray();
                var expect = Cmp(lArr,rArr,mode);
            }
        }
        
    }

    public class CmpFTests
    {
        public class CmpF64 : CmpFTest<CmpF64, double>
        {
            static bool cmp(double x, double y, FloatComparisonMode mode)
            {
                var result = mode switch{

                    FloatComparisonMode.EqualUnorderedNonSignaling => x == y,
                    FloatComparisonMode.EqualOrderedNonSignaling => x == y,
                    FloatComparisonMode.EqualOrderedSignaling => x == y,
                    FloatComparisonMode.EqualUnorderedSignaling => x == y,

                    FloatComparisonMode.NotEqualOrderedNonSignaling => x != y,
                    FloatComparisonMode.NotEqualUnorderedNonSignaling => x != y,
                    FloatComparisonMode.NotEqualOrderedSignaling => x != y,
                    FloatComparisonMode.NotEqualUnorderedSignaling => x != y,

                    FloatComparisonMode.LessThanOrderedNonSignaling => x < y,
                    FloatComparisonMode.LessThanOrderedSignaling => x < y,

                    FloatComparisonMode.GreaterThanOrderedNonSignaling =>  x > y,
                    FloatComparisonMode.GreaterThanOrderedSignaling =>  x > y,

                    FloatComparisonMode.LessThanOrEqualOrderedNonSignaling =>  x <= y,
                    FloatComparisonMode.LessThanOrEqualOrderedSignaling =>  x <= y,
                    
                    FloatComparisonMode.GreaterThanOrEqualOrderedNonSignaling => x >= y,
                    FloatComparisonMode.GreaterThanOrEqualOrderedSignaling => x >= y,

                    FloatComparisonMode.NotGreaterThanOrEqualUnorderedNonSignaling => !(x >= y),                    
                    FloatComparisonMode.NotGreaterThanOrEqualUnorderedSignaling => !(x >= y),                    
                    
                    FloatComparisonMode.NotGreaterThanUnorderedSignaling => !(x > y),                    
                    FloatComparisonMode.NotGreaterThanUnorderedNonSignaling => !(x > y),

                    FloatComparisonMode.NotLessThanOrEqualUnorderedNonSignaling => !(x <= y),
                    FloatComparisonMode.NotLessThanOrEqualUnorderedSignaling => !(x <= y),
                    
                    FloatComparisonMode.NotLessThanUnorderedNonSignaling => !(x < y),
                    FloatComparisonMode.NotLessThanUnorderedSignaling => !(x < y),

                    _ => throw new NotSupportedException()
                };
                                
                return result; 
            }
            
            protected override bool[] Cmp(double[] x, double[] y, FloatCompareKind kind)
            {
                var result = alloc<bool>(VecLength);
                for(var i = 0; i< VecLength; i++)
                    result[i] = cmp(x[i], y[i], (FloatComparisonMode) kind);
                return result;
            }

            public void ClearNaN()
            {
                var src = Vec128.define(3.4d, double.NaN);
                var result = mfunc.clearNaN(src);
                var expect = Vec128.define(3.4d, -1d);
                Claim.eq(expect,result);

                src = Vec128.define(double.NaN,3.4d);
                result = mfunc.clearNaN(src);
                expect = Vec128.define(-1d,3.4d);
                Claim.eq(expect,result);
            }

            public void CmpEq()
                => Verify(FloatCompareKind.EqOrdNS);

            public void CmpNEq()
                => Verify(FloatCompareKind.NEqOrdNS);

            public void CmpLt()
                => Verify(FloatCompareKind.LtOrdNS);

            public void CmpLtEq()
                => Verify(FloatCompareKind.LtEqOrdNS);

            public void CmpNlt()
                => Verify(FloatCompareKind.NLtUnOrdNS);

            public void CmpNltEq()
                => Verify(FloatCompareKind.NLtEqUnOrdNS);

            public void CmpGt()
                => Verify(FloatCompareKind.GtOrdNS);

            public void CmpGtEq()
                => Verify(FloatCompareKind.GtEqOrdNS);

            public void CmpNgt()
                => Verify(FloatCompareKind.NGtUnOrdNS);

            public void CmpNgtEq()
                => Verify(FloatCompareKind.NGtEqUnOrdNS);

            private void Examples()
            {

                void CmpLt1()
                {
                    var x0 = Vec128.define(-1.5, 8.9);
                    var x1 = Vec128.define(-4.7, 3.2);
                    var result = dinx.cmpf(x0,x1,FloatCompareKind.LtOrdNS);
                    trace($"{x0} < {x1} = {result}");                
                }

                void CmpLt2()
                {
                    var x0 = Vec128.define(-1.0, -1.0);
                    var x1 = Vec128.define(1.0, 1.0);
                    var result = dinx.cmpf(x0,x1,FloatCompareKind.LtOrdNS);
                    trace($"{x0} < {x1} = {result}");
                }

                void CmpLt3()
                {
                    var x0 = Vec128.define(1.0, -1.0);
                    var x1 = Vec128.define(1.0, 1.0);
                    var result = dinx.cmpf(x0,x1,FloatCompareKind.LtOrdNS);
                    trace($"{x0} < {x1} = {result}");
                }

                CmpLt1();
                CmpLt2();
                CmpLt3();
            }
        }
    }
}