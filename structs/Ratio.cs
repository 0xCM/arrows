//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a ratio between two values, a measure that indicates how many
    /// times the first number contains the second
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Ratio</remarks>
    public readonly ref struct Ratio<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static implicit operator (T A, T B)(Ratio<T> src)
            => (src.A, src.B);

        [MethodImpl(Inline)]
        public static implicit operator Ratio<T>((T A, T B) src)
            => new Ratio<T>(src.A, src.B);

        [MethodImpl(Inline)]
        public Ratio(in T a, in T b)
        {
            this.A = a;
            this.B = b;
        }

        /// <summary>
        /// The left value
        /// </summary>
        public readonly T A;

        /// <summary>
        /// The right value
        /// </summary>
        public readonly T B;

        public string Format()
            => $"{A}:{B}";

    }

}