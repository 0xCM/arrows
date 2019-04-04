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
    using prim = System.Decimal;
    
    class RandF128 : Rand<prim>
    {
        readonly Randomizer random;

        [MethodImpl(Inline)]
        public RandF128(Randomizer random)
            => this.random = random;

        [MethodImpl(Inline)]
        public prim one(prim min, prim max)
            => (decimal) random.one((long)min,(long)max);

        [MethodImpl(Inline)]
        real<prim> Rand<prim>.one(real<prim> min, real<prim> max)
             => one(min,max);

        public IEnumerable<prim> stream(prim min, prim max)
        {
            foreach(var item in random.stream(min, max))
                yield return item;
        }

        public IEnumerable<real<prim>> stream(real<prim> min, real<prim> max)
        {
            foreach(var item in stream(min.unwrap(), max.unwrap()))
                yield return item;
        }

    }
}