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
    
    class RandF64 : Rand<prim>, PrimalRand<prim>
    {
        readonly Randomizer random;

        [MethodImpl(Inline)]
        public RandF64(Randomizer random)
            => this.random = random;

        [MethodImpl(Inline)]
        public prim one(prim min, prim max)
            => (double) random.one((long)min,(long)max);

        public IEnumerable<real<prim>> stream(real<prim> min, real<prim> max)
             => from value in stream(min.unwrap(), max.unwrap()) select real(value);

        public IEnumerable<prim> stream(prim min, prim max)
            => random.stream(min,max);

    }
}