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
    using sprim = System.Single;
    using prim = System.Single;
    
    class RandF32 : Rand<sprim>
    {
        readonly Randomizer random;

        [MethodImpl(Inline)]
        public RandF32(Randomizer random)
            => this.random = random;

        [MethodImpl(Inline)]
        sprim one(prim min, prim max)
            => (float)random.one((uint)min,(uint)max);

        [MethodImpl(Inline)]
        prim one(prim width, prim min, prim max)
            => (prim) random.one((int)min,(int)max);

        public IEnumerable<prim> stream(prim min, prim max)
        {
            var width = max - min;
            while(true)
                yield return one(width, min,max);
        }

        public IEnumerable<real<prim>> stream(real<prim> min, real<prim> max)
        {
            var width = max - min;
            while(true)
                yield return one(width, min,max);
        }

        [MethodImpl(Inline)]
        real<prim> Rand<prim>.one(real<prim> min, real<prim> max)
             => one(min,max);

   }
}