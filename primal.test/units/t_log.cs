//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_log : UnitTest<t_log>
    {

        public void log2()
        {
            Claim.eq(math.log2(Pow2.T20),20);
            Claim.eq(math.log2(Pow2.T24),24);
            Claim.eq(math.log2(Pow2.T30),30);
            Claim.eq(math.log2(Pow2.T40),40);
            Claim.eq(math.log2(Pow2.T50),50);
            Claim.eq(math.log2(Pow2.T60),60);
            Claim.eq(math.log2(Pow2.T63),63);

        }
        public void ilog2()
        {
            Claim.eq(math.ilog2(Pow2.T20),20);
            Claim.eq(math.ilog2(Pow2.T24),24);
            Claim.eq(math.ilog2(Pow2.T30),30);
            Claim.eq(math.ilog2(Pow2.T40),40);
            Claim.eq(math.ilog2(Pow2.T50),50);
            Claim.eq(math.ilog2(Pow2.T60),60);
            Claim.eq(math.ilog2(Pow2.T63),63);

        }
        public void powi32()
        {
            var lhs = Random.ReadOnlySpan<int>(Pow2.T08);
            var rhs = span<int>(lhs.Length).FillWith(2);
            for(var i = 0; i< length(lhs,rhs); i++)
            {
                var x = gmath.pow(lhs[i],rhs[i]);
                var y = gmath.mul(lhs[i], lhs[i]);
                Claim.eq(x,y);
            }

        }

        public void powu8()
        {
            var lhs = Random.ReadOnlySpan<byte>(Pow2.T08);
            var rhs = span<byte>(lhs.Length).FillWith((byte)2);
            for(var i = 0; i< length(lhs,rhs); i++)
            {
                var x = gmath.pow(lhs[i], rhs[i]);
                var y = gmath.mul(lhs[i], lhs[i]);
                Claim.eq(x,y);
            }
        }

        public void powu64()
        {
            var lhs = Random.ReadOnlySpan<ulong>(Pow2.T08);
            var rhs = span<ulong>(lhs.Length).FillWith(3ul);
            for(var i = 0; i< length(lhs,rhs); i++)
            {
                var x = gmath.pow(lhs[i], rhs[i]);
                var y = gmath.mul(gmath.mul(lhs[i], lhs[i]), lhs[i]);
                Claim.eq(x,y);
            }

        }

    }

}

