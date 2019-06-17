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
    using System.Numerics;
    using System.Text;

    using static zfunc;
    using static As;

    public static class RandomBits
    {        
        public static IEnumerable<Bit> Bits(this IRandomSource rng)
        {
            var q = (rng as Rng).BitQ;
            while(true)
            {
                if(q.TryDequeue(out Bit bit))
                {
                    yield return bit;
                }
                else
                {
                    var u64 = rng.NextInt();
                    for(var i = 0; i< 64; i++)
                    {
                        if(i == 0)
                            yield return testbit(u64, i);
                        else
                            q.Enqueue(testbit(u64, i));
                    }                    
                }                
            }
        }

        [MethodImpl(Inline)]
        public static Bit NextBit(this IRandomSource rng)
            => rng.Bits().First();

        [MethodImpl(Inline)]
        public static Sign NextSign(this IRandomSource rng)
            => rng.NextBit() ? Sign.Positive : Sign.Negative;

    }
}