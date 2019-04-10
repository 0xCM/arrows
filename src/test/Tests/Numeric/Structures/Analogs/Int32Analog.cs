//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    using static ztest;

    using primitive = System.Int32;
    using PrimVec = Vector<N128,int>;

    using analog = int32;
    using AnaVect = Vector<N128,int32>;
    using P = Paths;

    [DisplayName(Path)]
    public class Int32Analog : BinOpTest<primitive>
    {
        public const string Path = P.analogs + P.int32;
        
        IReadOnlyList<PrimVec> LeftPrimVecs {get;}

        IReadOnlyList<PrimVec> RightPrimVecs {get;}

        IReadOnlyList<AnaVect> LeftAnaVecs {get;}

        IReadOnlyList<AnaVect> RightAnaVecs {get;}


        public Int32Analog()
            : base(-250000,250000)
        {
            LeftPrimVecs = MakeVectors<N128>(LeftPrimSrc).Freeze();
            RightPrimVecs = MakeVectors<N128>(RightPrimSrc).Freeze();
            LeftAnaVecs = map(LeftPrimVecs, v => v.map(int32.define));
            RightAnaVecs = map(RightPrimVecs, v => v.map(int32.define));
        }

        public void VerifySum()
        {
            var expect = BaselineSum();
            var actual = map(AnalogSum(), v => v.map(x => (int)x));
            var equality = Vector.equality(expect,actual);
            var result = equality.Where(v => v.CountFalse() != 0).Count();
            Claim.eq(result,0);                
        }



        public void VerifyMul()
        {
            var expect = BaselineMul();
            var actual = map(AnalogMul(), v => v.map(x => (int)x));
            var equality = Vector.equality(expect,actual);
            var result = equality.Where(v => v.CountFalse() != 0).Count();
            Claim.eq(result,0);                
        }

        [Repeat(5)]
        public IReadOnlyList<Vector<N128,int32>> AnalogSum()
            => fuse(LeftAnaVecs, RightAnaVecs, (lhs,rhs) => lhs.fuse(rhs, (x,y) => x + y));


        [Repeat(5)]
        public IReadOnlyList<Vector<N128,int>> BaselineSum()
            => fuse(LeftPrimVecs, RightPrimVecs, (lhs,rhs) => lhs.fuse(rhs, (x,y) => x + y));

        [Repeat(5)]
        public IReadOnlyList<Vector<N128,int32>> AnalogMul()
            => fuse(LeftAnaVecs, RightAnaVecs, (lhs,rhs) => lhs.fuse(rhs, (x,y) => x * y));

        [Repeat(5)]
        public IReadOnlyList<Vector<N128,int>> BaselineMul()
            => fuse(LeftPrimVecs, RightPrimVecs, (lhs,rhs) => lhs.fuse(rhs, (x,y) => x * y));


    }

}