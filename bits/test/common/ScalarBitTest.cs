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

    public abstract class ScalarBitTest<T> : UnitTest<T>
        where T : ScalarBitTest<T>, new()
    {

        protected override int SampleSize => Pow2.T04;

        protected override int CycleCount => Pow2.T03;


    }

}