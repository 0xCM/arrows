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
        public static Slice<N,T> add<N,T>(Traits.Slice<N,T> s1, Traits.Slice<N,T> s2)
            where N : Core.TypeNat, new() => SliceOps<N,T>.add(s1,s2);

        [MethodImpl(Inline)]
        public static Slice<N,T> mul<N,T>(Traits.Slice<N,T> a, Traits.Slice<N,T> b)
            where N : Core.TypeNat, new() => SliceOps<N,T>.mul(a,b);

        [MethodImpl(Inline)]
        public static T sum<N,T>(Traits.Slice<N,T> x)
            where N : Core.TypeNat, new() => SliceOps<N,T>.sum(x);
    
        [MethodImpl(Inline)]
        public static Slice<N,T> square<N,T>(Traits.Slice<N,T> x)
            where N : Core.TypeNat, new() => SliceOps<N,T>.square(x);
    }

    /// <summary>
    /// Defines slice arithmetic
    /// </summary>
    /// <typeparam name="N">The natural length type</typeparam>
    /// <typeparam name="T">The semigroup element type</typeparam>
    public static class SliceOps<N,T>
        where N : Core.TypeNat, new()
    {
        static readonly uint Length = natval<N>();
        static readonly Traits.Semiring<T> Ops = semiring<T>();

        [MethodImpl(Inline)]
        static Slice<N,U> apply<U>(Traits.Slice<N,T> s, Func<T,U> f)
        {
            var result = array<U>(Length);
            for(var i=0; i< Length; i++)
                result[i] = f(s[i]);
            return slice<N,U>(result);
        }

        [MethodImpl(Inline)]
        static Slice<N,U> apply<U>(Traits.Slice<N,T> s1, Traits.Slice<N,T> s2, Func<T,T,U> f)
        {
            var result = array<U>(Length);
            for(var i=0; i< Length; i++)
                result[i] = f(s1[i], s2[i]);
            return slice<N,U>(result);
        }

       [MethodImpl(Inline)]
       public static T reduce(Traits.Slice<N,T> s, Func<T,T,T> reducer)
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
        public static Slice<N,T> add(Traits.Slice<N,T> s1, Traits.Slice<N,T> s2)
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
        public static Slice<N,T> mul(Traits.Slice<N,T> a, Traits.Slice<N,T> b)
            => apply(a,b,Ops.mul);

        /// <summary>
        /// Sums the slice elements and returns the result
        /// </summary>
        /// <param name="s">The source slice</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static T sum(Traits.Slice<N,T> s)
            => reduce(s, Ops.add);

        /// <summary>
        /// Computes the component-wise square of a slice
        /// </summary>
        /// <param name="s">The source slice</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Slice<N,T> square(Traits.Slice<N,T> s)
            => apply(s, s, Ops.mul);

    }


}