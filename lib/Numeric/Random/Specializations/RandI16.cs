//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using prim = System.Int16;

    class RandI16 : IRandom<prim>
    {
        readonly Randomizer random;

        [MethodImpl(Inline)]
        public RandI16(Randomizer random)
            => this.random = random;

        [MethodImpl(Inline)]
        public prim one(prim min, prim max)
            => random.one(min,max);

        public IEnumerable<prim> stream(prim min, prim max)
            => random.stream(min,max);
   }
}