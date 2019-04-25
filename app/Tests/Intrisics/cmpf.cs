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
        protected static readonly InXCmpF<T> InXOp = InXG.cmpf<T>();
        
        protected CmpFTest(Interval<T>? domain = null, int? streamlen = null)
            : base("cmp", domain, streamlen)        
        {

        }

        protected virtual Index<bool[]> Results(FloatComparisonMode mode)
            => fuse(LeftVecSrc,RightVecSrc, (x,y) =>  InXOp.cmpf(x,y,mode));

        protected abstract bool[] Cmp(Index<T> x, Index<T> y, FloatComparisonMode mode);


        public virtual void Verify(FloatComparisonMode mode)
        {
            for(var i=0; i < VecCount; i++)
            {
                var lVec = LeftVecSrc[i];
                var rVec = RightVecSrc[i];

                var lArr = lVec.ToArray();
                var rArr = rVec.ToArray();
                var actual = InXOp.cmpf(lVec,rVec,mode);
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
            
            protected override bool[] Cmp(Index<double> x, Index<double> y, FloatComparisonMode mode)
            {
                var result = alloc<bool>(VecLength);
                for(var i = 0; i< VecLength; i++)
                    result[i] = cmp(x[i],y[i],mode);
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
                => Verify(FloatComparisonMode.EqualOrderedNonSignaling);

            public void CmpNEq()
                => Verify(FloatComparisonMode.NotEqualOrderedNonSignaling);

            public void CmpLt()
                => Verify(FloatComparisonMode.LessThanOrderedNonSignaling);

            public void CmpLtEq()
                => Verify(FloatComparisonMode.LessThanOrEqualOrderedNonSignaling);

            public void CmpNlt()
                => Verify(FloatComparisonMode.NotLessThanUnorderedNonSignaling);

            public void CmpNltEq()
                => Verify(FloatComparisonMode.NotLessThanOrEqualUnorderedNonSignaling);

            public void CmpGt()
                => Verify(FloatComparisonMode.GreaterThanOrderedNonSignaling);

            public void CmpGtEq()
                => Verify(FloatComparisonMode.GreaterThanOrEqualOrderedNonSignaling);

            public void CmpNgt()
                => Verify(FloatComparisonMode.NotGreaterThanUnorderedNonSignaling);

            public void CmpNgtEq()
                => Verify(FloatComparisonMode.NotGreaterThanOrEqualUnorderedNonSignaling);

            private void Examples()
            {

                void CmpLt1()
                {
                    var x0 = Vec128.define(-1.5, 8.9);
                    var x1 = Vec128.define(-4.7, 3.2);
                    var result = InX.cmpf(x0,x1,FloatComparisonMode.LessThanOrderedNonSignaling);
                    trace($"{x0} < {x1} = {result}");                
                }

                void CmpLt2()
                {
                    var x0 = Vec128.define(-1.0, -1.0);
                    var x1 = Vec128.define(1.0, 1.0);
                    var result = InX.cmpf(x0,x1,FloatComparisonMode.LessThanOrderedNonSignaling);
                    trace($"{x0} < {x1} = {result}");
                }

                void CmpLt3()
                {
                    var x0 = Vec128.define(1.0, -1.0);
                    var x1 = Vec128.define(1.0, 1.0);
                    var result = InX.cmpf(x0,x1,FloatComparisonMode.LessThanOrderedNonSignaling);
                    trace($"{x0} < {x1} = {result}");
                }

                CmpLt1();
                CmpLt2();
                CmpLt3();
            }
        }
    }
}