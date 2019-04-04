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
    using sprim = System.Int64;
    using uprim = System.UInt64;
    using prim = System.Int64;

    class Rand64 : Rand<sprim>
    {
        readonly Randomizer random;

        [MethodImpl(Inline)]
        public Rand64(Randomizer random)
            => this.random = random;

        [MethodImpl(Inline)]
        public sprim one(sprim min, sprim max)
            => random.one(min,max);


        public IEnumerable<prim> stream(prim min, prim max)
        {
            while(true)
                yield return one(min,max);
        }

        public IEnumerable<real<prim>> stream(real<prim> min, real<prim> max)
        {
            while(true)
                yield return one(min,max);
        }

        [MethodImpl(Inline)]
        real<prim> Rand<prim>.one(real<prim> min, real<prim> max)
             => one(min,max);

   }
}