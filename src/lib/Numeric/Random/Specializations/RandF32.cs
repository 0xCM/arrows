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
    using prim = System.Single;
    
    class RandF32 : IRandom<prim>
    {
        readonly Randomizer random;

        [MethodImpl(Inline)]
        public RandF32(Randomizer random)
            => this.random = random;

        [MethodImpl(Inline)]
        public prim one(prim min, prim max)
            => (prim)random.one((uint)min,(uint)max);

        [MethodImpl(Inline)]
        prim one(prim width, prim min, prim max)
            => (prim) random.one((int)min,(int)max);

        public IEnumerable<prim> stream(prim min, prim max)
            => random.stream(min,max);


   }
}