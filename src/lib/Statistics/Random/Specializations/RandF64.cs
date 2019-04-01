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
    using prim = System.Double;
    
    class RandF64 : Rand<prim>
    {
        readonly Randomizer random;

        [MethodImpl(Inline)]
        public RandF64(Randomizer random)
            => this.random = random;

        [MethodImpl(Inline)]
        public prim one(prim min, prim max)
            => (double) random.one((long)min,(long)max);

        public IEnumerable<real<prim>> stream(real<prim> min, real<prim> max)
        {
            while(true)
                yield return one(min,max);
        }

        public IEnumerable<prim> many(ulong count, prim min, prim max)
        {
            var width = max - min;
            for(var j = 0UL; j<count; j++)
                yield return one(min,max)/width;
        }

        [MethodImpl(Inline)]
        real<prim> Rand<prim>.one(real<prim> min, real<prim> max)
             => one(min,max);

        [MethodImpl(Inline)]
        IEnumerable<real<prim>> Rand<prim>.many(ulong count, real<prim> min, real<prim> max)
            => reals(many(count,min,max));

    }
}