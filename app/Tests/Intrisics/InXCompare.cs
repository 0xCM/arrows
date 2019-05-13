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


        protected abstract bool[] Cmp(T[] x, T[] y, FloatComparisonMode mode);


        public virtual void Verify(FloatComparisonMode mode)
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

                    FloatComparisonMode.OrderedEqualNonSignaling => x == y,
                    FloatComparisonMode.OrderedEqualSignaling => x == y,
                    FloatComparisonMode.UnorderedEqualNonSignaling => x == y,
                    FloatComparisonMode.UnorderedEqualSignaling => x == y,

                    FloatComparisonMode.OrderedNotEqualNonSignaling => x != y,
                    FloatComparisonMode.OrderedNotEqualSignaling => x != y,
                    FloatComparisonMode.UnorderedNotEqualNonSignaling => x != y,
                    FloatComparisonMode.UnorderedNotEqualSignaling => x != y,

                    FloatComparisonMode.OrderedLessThanNonSignaling => x < y,
                    FloatComparisonMode.OrderedLessThanSignaling => x < y,

                    FloatComparisonMode.OrderedGreaterThanNonSignaling=>  x > y,
                    FloatComparisonMode.OrderedGreaterThanSignaling =>  x > y,

                    FloatComparisonMode.OrderedLessThanOrEqualNonSignaling =>  x <= y,
                    FloatComparisonMode.OrderedLessThanOrEqualSignaling =>  x <= y,
                    
                    FloatComparisonMode.OrderedGreaterThanOrEqualNonSignaling => x >= y,
                    FloatComparisonMode.OrderedGreaterThanOrEqualSignaling => x >= y,

                    FloatComparisonMode.UnorderedNotGreaterThanOrEqualNonSignaling => !(x >= y),                    
                    FloatComparisonMode.UnorderedNotGreaterThanOrEqualSignaling => !(x >= y),                    
                    
                    FloatComparisonMode.UnorderedNotGreaterThanNonSignaling => !(x > y),                    
                    FloatComparisonMode.UnorderedNotGreaterThanSignaling => !(x > y),

                    FloatComparisonMode.UnorderedNotLessThanOrEqualNonSignaling => !(x <= y),
                    FloatComparisonMode.UnorderedNotLessThanOrEqualSignaling => !(x <= y),
                    
                    FloatComparisonMode.UnorderedNotLessThanNonSignaling => !(x < y),
                    FloatComparisonMode.UnorderedNotLessThanSignaling => !(x < y),

                    _ => throw new NotSupportedException()
                };
                                
                return result; 
            }
            
            protected override bool[] Cmp(double[] x, double[] y, FloatComparisonMode kind)
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

            private void Examples()
            {

                void CmpLt1()
                {
                    var x0 = Vec128.define(-1.5, 8.9);
                    var x1 = Vec128.define(-4.7, 3.2);
                    var result = dinx.cmpf(x0,x1,FloatComparisonMode.OrderedLessThanNonSignaling);
                    trace($"{x0} < {x1} = {result}");                
                }

                void CmpLt2()
                {
                    var x0 = Vec128.define(-1.0, -1.0);
                    var x1 = Vec128.define(1.0, 1.0);
                    var result = dinx.cmpf(x0,x1,FloatComparisonMode.OrderedLessThanNonSignaling);
                    trace($"{x0} < {x1} = {result}");
                }

                void CmpLt3()
                {
                    var x0 = Vec128.define(1.0, -1.0);
                    var x1 = Vec128.define(1.0, 1.0);
                    var result = dinx.cmpf(x0,x1,FloatComparisonMode.OrderedLessThanNonSignaling);
                    trace($"{x0} < {x1} = {result}");
                }

                CmpLt1();
                CmpLt2();
                CmpLt3();
            }
        }
    }
}