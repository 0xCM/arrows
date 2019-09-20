//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
    using static BitParts;

    public abstract class BitVectorTest<T> : UnitTest<T>
        where T : BitVectorTest<T>, new()
    {

        protected override int SampleSize => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

    }

}