//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;


    public static class Slice
    {
        [MethodImpl(Inline)]
        public static Reify.Slice<N,T> add<N,T>(Class.Slice<N,T> s1, Class.Slice<N,T> s2)
            where N : Core.TypeNat => Slice<N,T>.add(s1,s2);

        [MethodImpl(Inline)]
        public static Reify.Slice<N,T> mul<N,T>(Class.Slice<N,T> a, Class.Slice<N,T> b)
            where N : Core.TypeNat => Slice<N,T>.mul(a,b);

        [MethodImpl(Inline)]
        public static T sum<N,T>(Class.Slice<N,T> x)
            where N : Core.TypeNat => Slice<N,T>.sum(x);
    
        [MethodImpl(Inline)]
        public static Reify.Slice<N,T> square<N,T>(Class.Slice<N,T> x)
            where N : Core.TypeNat => Slice<N,T>.square(x);
    }

    /// <summary>
    /// Defines slice arithmetic
    /// </summary>
    /// <typeparam name="N">The natural length type</typeparam>
    /// <typeparam name="T">The semigroup element type</typeparam>
    public static class Slice<N,T>
        where N : Core.TypeNat
    {
        static readonly int Length = natval<N>();
        static readonly Class.Semiring<T> Ops = semiring<T>();

        [MethodImpl(Inline)]
        static Class.Slice<N,U> apply<U>(Class.Slice<N,T> s, Func<T,U> f)
        {
            var result = array<U>(Length);
            for(var i=0; i< Length; i++)
                result[i] = f(s[i]);
            return slice<N,U>(result);
        }

        [MethodImpl(Inline)]
        static Reify.Slice<N,U> apply<U>(Class.Slice<N,T> s1, Class.Slice<N,T> s2, Func<T,T,U> f)
        {
            var result = array<U>(Length);
            for(var i=0; i< Length; i++)
                result[i] = f(s1[i], s2[i]);
            return slice<N,U>(result);
        }

       [MethodImpl(Inline)]
       public static T reduce(Class.Slice<N,T> s, Func<T,T,T> reducer)
        {
            var result = Ops.zero;
            for(var i=0; i< Length; i++)
                result = reducer(result,s[i]);
            return result;

        }


        /// <summary>
        /// Calculates the component-wise sum of two slices via a semigroup
        /// </summary>
        /// <param name="sg">The semigroup defining the desired addition operator</param>
        /// <param name="s1">The first slice</param>
        /// <param name="s2">the second slice</param>
        /// <returns></returns>
        public static Reify.Slice<N,T> add(Class.Slice<N,T> s1, Class.Slice<N,T> s2)
            => apply(s1,s2,Ops.add);

        /// <summary>
        /// Calculates the component-wise product of two slices via a semigroup
        /// </summary>
        /// <param name="sg">The semigroup defining the desired product operator</param>
        /// <param name="a">The first slice</param>
        /// <param name="b">the second slice</param>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">The semigroup element type</typeparam>
        /// <returns></returns>
        public static Reify.Slice<N,T> mul(Class.Slice<N,T> a, Class.Slice<N,T> b)
            => apply(a,b,Ops.mul);

        /// <summary>
        /// Sums the slice elements and returns the result
        /// </summary>
        /// <param name="s">The source slice</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static T sum(Class.Slice<N,T> s)
            => reduce(s, Ops.add);

        /// <summary>
        /// Computes the component-wise square of a slice
        /// </summary>
        /// <param name="s">The source slice</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Reify.Slice<N,T> square(Class.Slice<N,T> s)
            => apply(s, s, Ops.mul);

    }

    partial class Reify
    {

        public readonly struct Slice<N,T> : Class.Slice<Slice<N,T>,N,T>
            where N : TypeNat
        {
                        
            public IReadOnlyList<T> cells {get;}

            public static implicit operator Slice<N,T>(T[] src)
                => new Slice<N,T>(src);

            public Slice(params T[] src)
            {
                this.length = natcheck<N>(src.Length);
                this.cells = src;
            }

            public Slice(IReadOnlyList<T> src)
            {
                this.cells = src;
                this.length = natcheck<N>(this.cells.Count);
            }

            public Slice(IEnumerable<T> src)
            {
                this.cells = src.ToArray();
                this.length = natcheck<N>(this.cells.Count);
            }

            public int length {get;}

            public T this[int i] => cells[i];

            public override string ToString() 
                => embrace(string.Join(',' ,cells));

        }        

    }

    public static class SliceX
    {
        public static Reify.Slice<N,T> slice<N,T>(this Core.TypeNat<N> nat, IEnumerable<T> src)
            where N : TypeNat
                => new Reify.Slice<N, T>(src);

    }

}