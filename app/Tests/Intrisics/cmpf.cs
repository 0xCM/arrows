//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
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
    
    using static zcore;
    
    using P = Paths;

    public abstract class CmpFTest<S,T> : InXBinOpTest<S,T>
        where S : CmpFTest<S,T>
        where T : struct, IEquatable<T>
    {        
        protected static readonly Vec128CmpFloat<T> cmpf = InXVec128Ops.cmpf;
        
        protected CmpFTest(Interval<T>? domain = null, int? streamlen = null)
            : base("cmp", domain, streamlen)        
        {

        }

        protected virtual Index<bool[]> Results(FloatCompareKind mode)
            => fuse(LeftVecSrc,RightVecSrc, (x,y) =>  cmpf(x,y,mode));

        protected abstract bool[] Cmp(Index<T> x, Index<T> y, FloatCompareKind mode);


        public virtual void Verify(FloatCompareKind mode)
        {
            for(var i=0; i < VecCount; i++)
            {
                var lVec = LeftVecSrc[i];
                var rVec = RightVecSrc[i];

                var lArr = lVec.ToArray();
                var rArr = rVec.ToArray();
                var actual = cmpf(lVec,rVec,mode);
                var expect = Cmp(lArr,rArr,mode);
            }
        }
            //=> base.Verify((x,y) => InXOp.cmpf(x,y,mode), (x,y) =>  Cmp(x,y,mode));
        
    }

    public class CmpFTests
    {
        const string BasePath = P.InX128 + P.cmpf;
        
        [DisplayName(Path)]
        public class CmpF64 : CmpFTest<CmpF64, double>
        {
            const string Path = BasePath + P.float64;

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
            
            protected override bool[] Cmp(Index<double> x, Index<double> y, FloatCompareKind kind)
            {
                var result = alloc<bool>(VecLength);
                for(var i = 0; i< VecLength; i++)
                    result[i] = cmp(x[i], y[i], (FloatComparisonMode) kind);
                return result;

            }

            public void ClearNaN()
            {
                var src = Vec128.define(3.4d, double.NaN);
                var result = inxfunc.clearNaN(src);
                var expect = Vec128.define(3.4d, -1d);
                Claim.eq(expect,result);

                src = Vec128.define(double.NaN,3.4d);
                result = inxfunc.clearNaN(src);
                expect = Vec128.define(-1d,3.4d);
                Claim.eq(expect,result);
            }

            public void BoolPack()
            {                
                var r1 = pack(false,true, true, false);
                var e1 = (byte)0b0110;
                Claim.eq(1,r1.Length);
                Claim.eq(e1, r1[0]);

                var r2 = pack(false, true, true, true);
                var e2 = (byte)0b1110;
                Claim.eq(1,r2.Length);
                Claim.eq(e2, r2[0]);

                var r3 = pack(false, true, true, true, true, false);
                var e3 = (byte)0b011110;
                Claim.eq(1,r3.Length);
                Claim.eq(e3, r3[0]);
            }

            public void BitPack()
            {
                Claim.eq((byte)0b01110011,Bits.pack8(1,1,0,0,1,1,1,0));

                Claim.eq((byte)0b00000001,Bits.pack8(1,0,0,0,0,0,0,0));

                Claim.eq((byte)0b00000010,Bits.pack8(0,1,0,0,0,0,0,0));

                Claim.eq((byte)0b11111111,Bits.pack8(1,1,1,1,1,1,1,1));

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