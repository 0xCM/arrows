//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static As;

    public static class Polynomial
    {

        [MethodImpl(Inline)]
        public static Polynomial<T> Define<T>(params (T scalar, int exp)[] terms)
            where T : unmanaged
                => Polynomial<T>.Define(terms);
    }

}