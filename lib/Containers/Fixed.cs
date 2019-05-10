//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zcore;
    using static zfunc;

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

    public readonly struct FixedArray<T> : IFixedContainer<FixedArray<T>, T[],T>
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

        FixedArray<T> INullary<FixedArray<T>>.zero 
            => Empty;

        T INullaryOps<T>.zero 
            =>  Zero;
        
        bool eq(FixedArray<T> rhs)
            => System.Linq.Enumerable.SequenceEqual(data, rhs.data, ISG.comparer());


        bool IEquatable<FixedArray<T>>.Equals(FixedArray<T> rhs)
            => eq(rhs);

        bool ISemigroupOps<T>.eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        bool ISemigroupOps<T>.neq(T lhs, T rhs)
            => not(lhs.Equals(rhs));

        string format()
            => ISG.format();

        IEqualityComparer<T> IImplicitSemigroup<FixedArray<T>, T>.comparer(Func<T, int> hasher)
            => ISG.comparer(hasher);
    }

    public readonly struct FixedList<T> : IFixedContainer<FixedList<T>, IReadOnlyList<T>,T>
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

        FixedList<T> INullary<FixedList<T>>.zero 
            => Empty;

        T INullaryOps<T>.zero 
            =>  Zero;
        
        bool eq(FixedList<T> rhs)
            => System.Linq.Enumerable.SequenceEqual(data, rhs.data, ISG.comparer());


        bool IEquatable<FixedList<T>>.Equals(FixedList<T> rhs)
            => eq(rhs);

        
        bool ISemigroupOps<T>.eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        bool ISemigroupOps<T>.neq(T lhs, T rhs)
            => not(lhs.Equals(rhs));

        string format()
            => ISG.format();

        IEqualityComparer<T> IImplicitSemigroup<FixedList<T>, T>.comparer(Func<T, int> hasher)
            => ISG.comparer(hasher);


    }

    public readonly struct FixedStream<T> : IFixedContainer<FixedStream<T>, IEnumerable<T>,T>
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


        FixedStream<T> INullary<FixedStream<T>>.zero 
            => Empty;

        T INullaryOps<T>.zero 
            =>  Zero;
        
        bool eq(FixedStream<T> rhs)
            => System.Linq.Enumerable.SequenceEqual(data, rhs.data, ISG.comparer());


        bool IEquatable<FixedStream<T>>.Equals(FixedStream<T> rhs)
            => eq(rhs);

        bool ISemigroupOps<T>.eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        bool ISemigroupOps<T>.neq(T lhs, T rhs)
            => not(lhs.Equals(rhs));

        string format()
            => ISG.format();

        IEqualityComparer<T> IImplicitSemigroup<FixedStream<T>, T>.comparer(Func<T, int> hasher)
            => ISG.comparer(hasher);
    }
}