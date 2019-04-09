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


    [DisplayName("analogs/int32")]
    public class Int32Analog : BinOpTest<primitive>
    {
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
            var compare = fuse(expect, actual, (v1,v2) =>  vector<N128,bool>(v1 == v2));
            var result = compare.Where(v => v.any(x => x == false)).Count();
            Claim.eq(result,0);
                
        }

        [Repeat(5)]
        public IReadOnlyList<Vector<N128,int32>> AnalogSum()
            => fuse(LeftAnaVecs,RightAnaVecs, (lhs,rhs) => lhs.fuse(rhs, (x,y) => x + y));

        [Repeat(5)]
        public IReadOnlyList<Vector<N128,int>> BaselineSum()
            => fuse(LeftPrimVecs, RightPrimVecs, (lhs,rhs) => lhs.fuse(rhs, (x,y) => x + y));
    

    }

}