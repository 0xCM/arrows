//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;
    using static Examples;

    public class GemmTest : UnitTest<GemmTest>
    {
        static void gemm<M,N>()
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var n = nati<N>();
            var method = varintro($"{m}x{n} * {n}x{m} = {m}x{m}");
            var count = m*n;
            
            var srcA = span<double>(count);
            for(var i=1; i<= count; i++)
                srcA[i-1] = i;
            var a = NatSpan.load<M,N,double>(ref srcA[0]);

            var srcB = span<double>(m*n);
            for(var i=1; i<= count; i++)
                srcB[i-1] = i;
            var b = NatSpan.load<N,M,double>(ref srcB[0]);

            var timer = input(
                nameof(a), a.Format(zpad: a.EntryPadWidth()), 
                nameof(b), b.Format(zpad: b.EntryPadWidth())
                );            
            var c = mkl.gemm(a,b);            
            var time = snapshot(timer);   
        
            finale(nameof(c), c.Format(zpad: c.EntryPadWidth()), timer, method);
        }
        
        public static void Gemm()
        {
            gemm<N3,N4>();
            gemm<N5,N7>();
            gemm<N10,N10>();
            gemm<N16,N16>();
            gemm<N17,N17>();

        }

        public void Dot()
        {
            var lhs = Random.Span<double>(Pow2.T08);
            var rhs = Random.Span<double>(Pow2.T08);

            var x = mkl.dot(lhs,rhs).Round(4);
            var y = lhs.ReadOnly().Dot(rhs).Round(4);
            Claim.eq(x,y);
        }


    }


}