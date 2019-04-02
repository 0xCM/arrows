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
    using prim = System.Byte;
    
    class RandU8 : Rand<prim>
    {
        readonly Randomizer random;

        public RandU8(Randomizer random)
            => this.random = random;

        prim one(prim min, prim max)
            => random.one(min, max);


        public IEnumerable<real<prim>> stream(real<prim> min, real<prim> max)
        {
            while(true)
                yield return one(min,max);
        }

        [MethodImpl(Inline)]
        real<prim> Rand<prim>.one(real<prim> min, real<prim> max)
             => one(min,max);

        [MethodImpl(Inline)]
        public IEnumerable<real<prim>> many(ulong count, real<prim> min, real<prim> max)
             => stream(min,max).Take((int)count);

    }



}