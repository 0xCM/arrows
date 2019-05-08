//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    
    using static mfunc;


    public abstract class Literal<T,L>
        where T : Literal<T,L>
    {
        [MethodImpl(Inline)]
        public static implicit operator L(Literal<T,L> src)
            => src.Value;

        public readonly L Value;

        protected Literal(L Value)
            => this.Value = Value;

    }


}