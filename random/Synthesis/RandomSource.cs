//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;
    using static As;

    class RandomSource : IRandomSource
    {
        readonly IPolyrand Random;

        [MethodImpl(Inline)]
        public RandomSource(IPointSource<ulong>  src)
        {
            this.Random = new Polyrand(src);
        }

        [MethodImpl(Inline)]
        public double NextDouble()
            => Random.Next<double>();

        [MethodImpl(Inline)]
        public int NextInt32(int max)
            => Random.Next(max);

        [MethodImpl(Inline)]
        public ulong NextUInt64()
            => Random.Next<ulong>();

        [MethodImpl(Inline)]
        public ulong NextUInt64(ulong max)
            => Random.Next(max);
    }

}
