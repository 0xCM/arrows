namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    /// <summary>
    /// Defines slice construction/manipulation routines
    /// </summary>
    public static class Slice
    {        
        [MethodImpl(Inline)]
        public static Slice<T> define<T>(params T[] data)
            => new Slice<T>(data);

        [MethodImpl(Inline)]
        public static Slice<T> define<T>(IEnumerable<T> data)
            => new Slice<T>(data);

        [MethodImpl(Inline)]
        public static Slice<T> define<T>(IReadOnlyList<T> data)
            => new Slice<T>(data);

        [MethodImpl(Inline)]
        public static Slice<N,T> define<N,T>(params T[] data)
            where N : TypeNat, new() => new Slice<N,T>(data);

        [MethodImpl(Inline)]
        public static Slice<N,T> define<N,T>(IEnumerable<T> data)
            where N : TypeNat, new() => new Slice<N,T>(data);

        [MethodImpl(Inline)]
        public static Slice<T> concat<T>(Slice<T> s1, Slice<T> s2)
            => s1 + s2;

        /// <summary>
        /// Constructs a slice from sequence of repetitions of a specified value
        /// </summary>
        /// <param name="value">The value with which to populate the slice</param>
        /// <param name="count">The number of elements in the resulting slice</param>
        /// <typeparam name="T">The value type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Slice<T> define<T>(T value, uint count)
            => new Slice<T>(repeat(value,count));

        [MethodImpl(Inline)]
        public static Slice<N,T> add<N,T>(Traits.Slice<N,T> s1, Traits.Slice<N,T> s2)
            where N : Z0.TypeNat, new() => Slice<N,T>.add(s1,s2);

        [MethodImpl(Inline)]
        public static Slice<N,T> mul<N,T>(Traits.Slice<N,T> a, Traits.Slice<N,T> b)
            where N : Z0.TypeNat, new() => Slice<N,T>.mul(a,b);

        [MethodImpl(Inline)]
        public static T sum<N,T>(Traits.Slice<N,T> x)
            where N : Z0.TypeNat, new() => Slice<N,T>.sum(x);
    
        [MethodImpl(Inline)]
        public static Slice<N,T> square<N,T>(Traits.Slice<N,T> x)
            where N : Z0.TypeNat, new() => Slice<N,T>.square(x);
    }

 
}