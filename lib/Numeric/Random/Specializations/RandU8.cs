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
    
    using prim = System.Byte;
    
    class RandU8 : IRandom<prim>
    {
        readonly Randomizer random;

        [MethodImpl(Inline)]
        public RandU8(Randomizer random)
            => this.random = random;

        public IEnumerable<prim> stream(prim min, prim max)
            => random.stream(min,max); 
    }
}