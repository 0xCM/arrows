//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zcore;
    using static Contain;

    public static class Fixed
    {
        public static FixedList<T> list<T>(IReadOnlyList<T> src)
            where T : struct, IEquatable<T>
                => new FixedList<T>(src);

        public static FixedArray<T> array<T>(params T[] src)
            where T : struct, IEquatable<T>
                => new FixedArray<T>(src);

        public static FixedStream<T> stream<T>(IEnumerable<T> src)
            where T : struct, IEquatable<T>
                => new FixedStream<T>(src);

    }

    public readonly struct FixedArray<T> : FixedContainer<FixedArray<T>, T[],T>
        where T : struct, IEquatable<T>
    {

        public static readonly FixedArray<T> Empty = new FixedArray<T>(new T[]{});
        
        public static readonly T Zero = default(T);

        static readonly ImplicitSemigroup<T> ISG = default;

        public FixedArray(T[] src)
        {
            data = src;
            _hash = defer(() => src.HashCode());
        }     

        readonly Lazy<int> _hash;

        readonly T[] data;

        public T[] release()
            => data;

        FixedArray<T> Structures.Nullary<FixedArray<T>>.zero 
            => Empty;

        T Operative.Nullary<T>.zero 
            =>  Zero;
        
        bool eq(FixedArray<T> rhs)
            => System.Linq.Enumerable.SequenceEqual(data, rhs.data, ISG.comparer());

        bool Equatable<FixedArray<T>>.eq(FixedArray<T> rhs)
            => eq(rhs);

        bool Equatable<FixedArray<T>>.neq(FixedArray<T> rhs)
            => not(eq(rhs));

        int Hashable<FixedArray<T>>.hash()
            => _hash.Value;

        bool IEquatable<FixedArray<T>>.Equals(FixedArray<T> rhs)
            => eq(rhs);

        T Wrapped<T>.unwrap()
            => Zero;

        bool Operative.Semigroup<T>.eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        bool Operative.Semigroup<T>.neq(T lhs, T rhs)
            => not(lhs.Equals(rhs));

        string Formattable.format()
            => ISG.format();

        IEqualityComparer<T> Structures.ImplicitSemigroup<FixedArray<T>, T>.comparer(Func<T, int> hasher)
            => ISG.comparer(hasher);
    }

    public readonly struct FixedList<T> : FixedContainer<FixedList<T>, IReadOnlyList<T>,T>
        where T : struct, IEquatable<T>
    {
        public static readonly FixedList<T> Empty = new FixedList<T>(new T[]{});

        public static readonly T Zero = default(T);

        static readonly ImplicitSemigroup<T> ISG = default;

        public FixedList(IReadOnlyList<T> src)
        {
            data = src;
            _hash = defer(() => src.HashCode());
        }     

        readonly Lazy<int> _hash;

        readonly IReadOnlyList<T> data;

        public IReadOnlyList<T> release()
            => data;

        FixedList<T> Structures.Nullary<FixedList<T>>.zero 
            => Empty;

        T Operative.Nullary<T>.zero 
            =>  Zero;
        
        bool eq(FixedList<T> rhs)
            => System.Linq.Enumerable.SequenceEqual(data, rhs.data, ISG.comparer());

        bool Equatable<FixedList<T>>.eq(FixedList<T> rhs)
            => eq(rhs);

        bool Equatable<FixedList<T>>.neq(FixedList<T> rhs)
            => not(eq(rhs));

        int Hashable<FixedList<T>>.hash()
            => _hash.Value;

        bool IEquatable<FixedList<T>>.Equals(FixedList<T> rhs)
            => eq(rhs);

        T Wrapped<T>.unwrap()
            => Zero;

        bool Operative.Semigroup<T>.eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        bool Operative.Semigroup<T>.neq(T lhs, T rhs)
            => not(lhs.Equals(rhs));

        string Formattable.format()
            => ISG.format();

        IEqualityComparer<T> Structures.ImplicitSemigroup<FixedList<T>, T>.comparer(Func<T, int> hasher)
            => ISG.comparer(hasher);


    }

    public readonly struct FixedStream<T> : FixedContainer<FixedStream<T>, IEnumerable<T>,T>
        where T : struct, IEquatable<T>
    {
        public static readonly FixedStream<T> Empty = new FixedStream<T>(new T[]{});

        public static readonly T Zero = default(T);

        static readonly ImplicitSemigroup<T> ISG = default;

        public FixedStream(IEnumerable<T> src)
        {
            data = src;
            _hash = defer(() => src.HashCode());
        }     

        readonly Lazy<int> _hash;

        readonly IEnumerable<T> data;

        public IEnumerable<T> release()
            => data;


        FixedStream<T> Structures.Nullary<FixedStream<T>>.zero 
            => Empty;

        T Operative.Nullary<T>.zero 
            =>  Zero;
        
        bool eq(FixedStream<T> rhs)
            => System.Linq.Enumerable.SequenceEqual(data, rhs.data, ISG.comparer());

        bool Equatable<FixedStream<T>>.eq(FixedStream<T> rhs)
            => eq(rhs);

        bool Equatable<FixedStream<T>>.neq(FixedStream<T> rhs)
            => not(eq(rhs));

        int Hashable<FixedStream<T>>.hash()
            => _hash.Value;

        bool IEquatable<FixedStream<T>>.Equals(FixedStream<T> rhs)
            => eq(rhs);

        T Wrapped<T>.unwrap()
            => Zero;

        bool Operative.Semigroup<T>.eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        bool Operative.Semigroup<T>.neq(T lhs, T rhs)
            => not(lhs.Equals(rhs));

        string Formattable.format()
            => ISG.format();

        IEqualityComparer<T> Structures.ImplicitSemigroup<FixedStream<T>, T>.comparer(Func<T, int> hasher)
            => ISG.comparer(hasher);


    }

}