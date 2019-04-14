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
    using sprim = System.Int32;
    using uprim = System.UInt32;
    using prim = System.Int32;
    
    class Rand32 : IRandom<prim>
    {
        readonly Randomizer random;

        [MethodImpl(Inline)]
        public Rand32(Randomizer random)
            => this.random = random;

        [MethodImpl(Inline)]
        public sprim one(sprim min, sprim max)
            => random.one(min,max);

        public IEnumerable<prim> stream(prim min, prim max)
            => random.stream(min,max);    
    }
}