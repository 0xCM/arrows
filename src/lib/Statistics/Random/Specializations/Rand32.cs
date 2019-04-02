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
    
    class Rand32 : Rand<sprim>
    {
        readonly Randomizer random;

        [MethodImpl(Inline)]
        public Rand32(Randomizer random)
            => this.random = random;

        [MethodImpl(Inline)]
        public sprim one(sprim min, sprim max)
            => (sprim)random.one((uprim)(min),(uprim)max);

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