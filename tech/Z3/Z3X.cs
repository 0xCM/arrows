//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Microsoft.Z3;
    using Z3 = Microsoft.Z3;
    using Z3C = Microsoft.Z3.Context;
    using static zfunc;

    public static class Z3X
    {
        [MethodImpl(Inline)]
        public static Z3.Symbol Symbol(this Z3C ctx, string name)
            => ctx.MkSymbol(name);

        [MethodImpl(Inline)]
        public static Z3.Symbol Symbol(this Z3C ctx, int index)
            => ctx.MkSymbol(index);

        [MethodImpl(Inline)]
        public static Z3.Symbol[] Symbols(this Z3C ctx, params string[] names)
            => names.Select(n => ctx.Symbol(n)).ToArray();

    }

}