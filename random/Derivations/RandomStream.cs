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

    static class RngStream
    {
        [MethodImpl(Inline)]
        public static IRandomStream<T> Define<T>(IEnumerable<T> src)
            where T : struct
                => new RngStream<T>(src);
    }

    readonly struct RngStream<T> : IRandomStream<T>
        where T : struct
    {
        readonly IEnumerable<T> src;

        [MethodImpl(Inline)]
        public RngStream(IEnumerable<T> src)
            => this.src = src;

        public IEnumerator<T> GetEnumerator()
            => src.GetEnumerator();

        [MethodImpl(Inline)]
        public T Next()
            => src.First();

        public IEnumerable<T> Next(int count)
            => src.Take(count);

        IEnumerator IEnumerable.GetEnumerator()
            => src.GetEnumerator();
    }


}