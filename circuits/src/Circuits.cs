//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class Circuits
    {

        [MethodImpl(Inline)]
        public static ref readonly HalfAdder<T> halfadder<T>()
            where T : unmanaged 
                => ref HalfAdder<T>.Circuit;            

    }
}
