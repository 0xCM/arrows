//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public sealed class SymbolTest : UnitTest<SymbolTest>
    {
        public void MultiCharSymbols()
        {
            print($"Length = {BlackBoard.A.Length}");
        }

    }
}