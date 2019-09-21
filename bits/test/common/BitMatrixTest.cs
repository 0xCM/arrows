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

    public abstract class BitMatrixTest<T> : UnitTest<T>
        where T : BitMatrixTest<T>, new()
    {
        protected override int CycleCount => Pow2.T14;



    }

}