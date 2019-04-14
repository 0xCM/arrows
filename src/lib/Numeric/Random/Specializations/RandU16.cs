//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zcore;

    using prim = System.UInt16;

    class RandU16 : IRandom<prim>
    {
        readonly Randomizer random;

        public RandU16(Randomizer random)
            => this.random = random;

        public prim one(prim min, prim max)
            => random.one(min, max);

        public IEnumerable<prim> stream(prim min, prim max)
            => random.stream(min,max);

   }
}