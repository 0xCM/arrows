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
        public static ListSemigroup<T> list<T>(IReadOnlyList<T> src)
            where T : struct, IEquatable<T>
                => new ListSemigroup<T>(src);

        public static ArraySemigroup<T> array<T>(params T[] src)
            where T : struct, IEquatable<T>
                => new ArraySemigroup<T>(src);

        public static StreamSemigroup<T> stream<T>(IEnumerable<T> src)
            where T : struct, IEquatable<T>
                => new StreamSemigroup<T>(src);

    }

    public readonly struct ArraySemigroup<T> : IFixedContainer<ArraySemigroup<T>, T[],T>
        where T : struct, IEquatable<T>
    {

        public static readonly ArraySemigroup<T> Empty = new ArraySemigroup<T>(new T[]{});
        
        public static readonly T Zero = default(T);

        static readonly ImplicitSemigroup<T> ISG = default;

        public ArraySemigroup(T[] src)
        {
            data = src;
            _hash = defer(() => src.HashCode());
        }     

        readonly Lazy<int> _hash;

        readonly T[] data;

        public T[] Release()
            => data;

        ArraySemigroup<T> INullary<ArraySemigroup<T>>.zero 
            => Empty;

        T INullaryOps<T>.zero 
            =>  Zero;
        
        bool eq(ArraySemigroup<T> rhs)
            => System.Linq.Enumerable.SequenceEqual(data, rhs.data, ISG.comparer());


        bool IEquatable<ArraySemigroup<T>>.Equals(ArraySemigroup<T> rhs)
            => eq(rhs);

        bool ISemigroupOps<T>.eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        bool ISemigroupOps<T>.neq(T lhs, T rhs)
            => not(lhs.Equals(rhs));

        string format()
            => ISG.format();

        IEqualityComparer<T> IImplicitSemigroup<ArraySemigroup<T>, T>.comparer(Func<T, int> hasher)
            => ISG.comparer(hasher);
    }

    public readonly struct ListSemigroup<T> : IFixedContainer<ListSemigroup<T>, IReadOnlyList<T>,T>
        where T : struct, IEquatable<T>
    {
        public static readonly ListSemigroup<T> Empty = new ListSemigroup<T>(new T[]{});

        public static readonly T Zero = default(T);

        static readonly ImplicitSemigroup<T> ISG = default;

        public ListSemigroup(IReadOnlyList<T> src)
        {
            data = src;
            _hash = defer(() => src.HashCode());
        }     

        readonly Lazy<int> _hash;

        readonly IReadOnlyList<T> data;

        public IReadOnlyList<T> Release()
            => data;

        ListSemigroup<T> INullary<ListSemigroup<T>>.zero 
            => Empty;

        T INullaryOps<T>.zero 
            =>  Zero;
        
        bool eq(ListSemigroup<T> rhs)
            => System.Linq.Enumerable.SequenceEqual(data, rhs.data, ISG.comparer());


        bool IEquatable<ListSemigroup<T>>.Equals(ListSemigroup<T> rhs)
            => eq(rhs);

        
        bool ISemigroupOps<T>.eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        bool ISemigroupOps<T>.neq(T lhs, T rhs)
            => not(lhs.Equals(rhs));

        IEqualityComparer<T> IImplicitSemigroup<ListSemigroup<T>, T>.comparer(Func<T, int> hasher)
            => ISG.comparer(hasher);

    }

    public readonly struct StreamSemigroup<T> : IFixedContainer<StreamSemigroup<T>, IEnumerable<T>,T>
        where T : struct, IEquatable<T>
    {
        public static readonly StreamSemigroup<T> Empty = new StreamSemigroup<T>(new T[]{});

        public static readonly T Zero = default(T);

        static readonly ImplicitSemigroup<T> ISG = default;

        public StreamSemigroup(IEnumerable<T> src)
        {
            data = src;
        }     

        readonly IEnumerable<T> data;

        public IEnumerable<T> Release()
            => data;

        StreamSemigroup<T> INullary<StreamSemigroup<T>>.zero 
            => Empty;

        T INullaryOps<T>.zero 
            =>  Zero;
        
        bool IEquatable<StreamSemigroup<T>>.Equals(StreamSemigroup<T> rhs)
            => System.Linq.Enumerable.SequenceEqual(data, rhs.data, ISG.comparer());

        bool ISemigroupOps<T>.eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        bool ISemigroupOps<T>.neq(T lhs, T rhs)
            => not(lhs.Equals(rhs));

        IEqualityComparer<T> IImplicitSemigroup<StreamSemigroup<T>, T>.comparer(Func<T, int> hasher)
            => ISG.comparer(hasher);
    }
}