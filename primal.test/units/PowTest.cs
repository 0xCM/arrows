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
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using D = PrimalDelegates;

    public class PowTest : UnitTest<PowTest>
    {
        public void PowI32Test()
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

        public void PowU8Test()
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

        public void PowU64Test()
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

