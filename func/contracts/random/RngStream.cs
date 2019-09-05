//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    public struct RandomStream<T> : IRandomStream<T>
        where T : struct
    {

        [MethodImpl(Inline)]
        public RandomStream(RngKind rng, IEnumerable<T> src)
        {
            this.src = src;
            this.RngKind = rng;
        }

        readonly IEnumerable<T> src;

        public RngKind RngKind {get;}

        public IEnumerator<T> GetEnumerator()
            => src.GetEnumerator();

        public IEnumerable<T> Next(int count)
            => src.Take(count);

        IEnumerator IEnumerable.GetEnumerator()
            => src.GetEnumerator();
    }
}