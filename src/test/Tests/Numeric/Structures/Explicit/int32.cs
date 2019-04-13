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

    using Explicit = int32;
    using AnaVect = Vector<N128,int32>;
    using P = Paths;

    [DisplayName(Path)]
    public class Int32Explicit : BinOpTest<Int32Explicit,int>
    {
        public const string Path = P.explicits + P.int32;
        
        IReadOnlyList<int[]> LeftVec {get;}
        
        IReadOnlyList<int[]> RightVec {get;}


        IReadOnlyList<Num128> LeftExp {get;}

        IReadOnlyList<Num128> RightExp {get;}


        public Int32Explicit()
            : base(Defaults.Int32Range)
        {
            LeftVec = MakeArrays(LeftPrimSrc, 4).Freeze();
            RightVec = MakeArrays(RightPrimSrc, 4).Freeze();
            LeftExp = map(LeftVec, x => Num128.define(x[0],x[1],x[2],x[3]));
            RightExp = map(RightVec, x => Num128.define(x[0],x[1],x[2],x[3]));
        }

        public void Validate()
        {
            var expect = map(Baseline(), x => x.ToReadOnlyList());
            var actual = map(Compute(), x => x.i32values());
            var count = expect.Count;
            for(var i = 0; i< expect.Count; i++)
            {
                for(var j = 0; j < 4; j++)
                    Claim.eq(expect[i][j], actual[i][j]);
            }
        }

        [Repeat(10)]
        public IReadOnlyList<primitive[]> Baseline()
        {
            var count = LeftVec.Count;
            var dst = array<primitive[]>(count);
            for(var i=0; i<count; i++)
            {
                dst[i] = array(
                    LeftVec[i][0] + RightVec[i][0],
                    LeftVec[i][1] + RightVec[i][1],
                    LeftVec[i][2] + RightVec[i][2],
                    LeftVec[i][3] + RightVec[i][3]
                    );
            }
            return dst;
        }


        [Repeat(10)]
        public IReadOnlyList<Num128> Compute()
        {
            var count = LeftExp.Count;
            var dst = array<Num128>(LeftExp.Count);
            for(var i=0; i<count; i++)
                dst[i] =  Num128.addi32(LeftExp[i], RightExp[i]);
            return dst;
        }


    }

}