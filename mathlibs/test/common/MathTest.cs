//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;


    public class MathTest<T> : UnitTest<T>
        where T : MathTest<T>, new()
    {
        protected override int RoundCount => 1;

        protected override int CycleCount => Pow2.T03;

        protected override int SampleSize => Pow2.T08;

    }



}