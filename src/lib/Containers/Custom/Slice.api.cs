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
        /// <summary>
        /// Constructs a slice from a parameter array
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The individual type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> define<T>(params T[] src)
                => new Slice<T>(src);

        /// <summary>
        /// Constructs a slice from a stream
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The individual type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> define<T>(IEnumerable<T> src)
            where T : Equatable<T>, new()
                => new Slice<T>(src);

        /// <summary>
        /// Constructs a slice from a readonly list
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The individual type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> define<T>(IReadOnlyList<T> src)
                => new Slice<T>(src);

        /// <summary>
        /// Constructs a slice of natural length from a parameter array
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The individual type</typeparam>
        /// <typeparam name="N">The natural length type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,T> define<N,T>(params T[] src)
            where N : TypeNat, new() 
              => new Slice<N,T>(src);


        /// <summary>
        /// Constructs a slice of natural length from a stream
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The individual type</typeparam>
        /// <typeparam name="N">The natural length type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,T> define<N,T>(IEnumerable<T> src)
            where N : TypeNat, new() 
            => new Slice<N,T>(src);

        /// <summary>
        /// Constructs a new slice by appending the second to the first
        /// </summary>
        /// <param name="s1">The first slice</param>
        /// <param name="s2">The second slice</param>
        /// <typeparam name="T">The individual type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> concat<T>(Slice<T> s1, Slice<T> s2)
            => s1 + s2;

        /// <summary>
        /// Constructs a new slice by appending the second to the first
        /// </summary>
        /// <param name="s1">The first slice</param>
        /// <param name="s2">The second slice</param>
        /// <typeparam name="T">The individual type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<Add<M,N>,T> concat<N,M,T>(Slice<N,T> s1, Slice<M,T> s2)
            where N : TypeNat, new() 
            where M : TypeNat, new() 
                => define<Add<M,N>,T>(s1.data + s2.data);

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

        /// <summary>
        /// Calculates the component-wise sum of two slices 
        /// </summary>
        /// <param name="s1">The first slice</param>
        /// <param name="s2">the second slice</param>
        /// <typeparam name="T">The semigroup-conforming element type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> add<T>(Structures.Slice<T> s1, Structures.Slice<T> s2)
            where T : Structures.Semiring<T>, new()     
                => slice(fuse(s1,s2, (x,y) =>  x.add(y)));

        /// <summary>
        /// Calculates the component-wise sum of two slices 
        /// </summary>
        /// <param name="s1">The first slice</param>
        /// <param name="s2">the second slice</param>
        /// <typeparam name="T">The semigroup-conforming element type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> mul<T>(Slice<T> s1, Slice<T> s2)
            where T : Structures.Semiring<T>, new()     
                => slice(fuse(s1,s2, (x,y) =>  x.mul(y)));

        /// <summary>
        /// Raises each component to a specified power
        /// </summary>
        /// <param name="s1">The first slice</param>
        [MethodImpl(Inline)]
        public static Slice<T> pow<T>(Slice<T> s1, int exp)
            where T : Structures.NaturallyPowered<T>, Equatable<T>, new()     
                => map(s1, x => x.pow(exp));


        /// <summary>
        /// Calculates the component-wise sum of two slices via a semiring
        /// </summary>
        /// <param name="s1">The first slice</param>
        /// <param name="s2">the second slice</param>
        /// <typeparam name="T">The semigroup-conforming element type</typeparam>
        [MethodImpl(Inline)]
        static Slice<T> mul2<T>(Slice<T> s1, Slice<T> s2)
                where T : Operative.Semiring<T>, Equatable<T>,  new()     
                    => apply(s1,s2,semiring<T>().mul);

        [MethodImpl(Inline)]
        public static Slice<N,T> square<N,T>(Slice<N,T> x)
            where N : Z0.TypeNat, new() 
            where T : Structures.Semiring<T>, Equatable<T>,  new()     
                => new Slice<N,T>(fuse(x,x, (a,b) => a.mul(b)));

        [MethodImpl(Inline)]
        public static T reduce<N,T>(Slice<N,T> s, Func<T,T,T> reducer)
                where N : Z0.TypeNat, new()
                where T : Structures.Semiring<T>, new()     
                    => fold(s,reducer);

        [MethodImpl(Inline)]
        static Slice<U> apply<T,U>(Structures.Slice<T> s1, Structures.Slice<T> s2, Func<T,T,U> f)
            where T : Operative.Semiring<T>, Equatable<T>, new()     
            where U : Operative.Semiring<U>, Equatable<U>, new()     
        {
            var len = s1.length;
            demand(s1.length == s2.length, $"The slice lengths {s1.length} and {s2.length} must match");
            var result = array<U>(len);
            for(var i=0; i< len; i++)
                result[i] = f(s1[i], s2[i]);
            return slice<U>(result);
        }

        [MethodImpl(Inline)]
        static Slice<N,U> apply<N,T,U>(Slice<N,T> s1, Slice<N,T> s2, Func<T,T,U> f)
            where N : Z0.TypeNat, new()
            where T : Operative.Semiring<T>, Equatable<T>, new()     
            where U : Operative.Semiring<U>, Equatable<U>, new()     
        {
            var len = natval<N>();
            var result = array<U>((uint)len);
            for(var i=0UL; i< len; i++)
                result[i] = f(s1[i], s2[i]);
            return slice<N,U>(result);
        }

        [MethodImpl(Inline)]
        public static T sum<N,T>(Slice<N,T> x)
            where N : Z0.TypeNat, new() 
            where T : Structures.Semiring<T>, new()     
                => reduce(x, (a,b) => a.add(b));

        /// <summary>
        /// Calculates the component-wise sum of two slices via a semigroup
        /// </summary>
        /// <param name="s1">The first slice</param>
        /// <param name="s2">the second slice</param>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">The semigroup-conforming element type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,T> add<N,T>(Slice<N,T> s1, Slice<N,T> s2)
                where N : Z0.TypeNat, new()
                where T : Operative.Semiring<T>, Equatable<T>, new()     
                    => new Slice<N,T>(apply(s1,s2,semiring<T>().add));

        /// <summary>
        /// Calculates the component-wise product of two slices via a semigroup
        /// </summary>
        /// <param name="sg">The semigroup defining the desired addition operator</param>
        /// <param name="s1">The first slice</param>
        /// <param name="s2">the second slice</param>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">The semigroup-conforming element type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,T> mul<N,T>(Slice<N,T> s1, Slice<N,T> s2)
                where N : Z0.TypeNat, new()
                where T : Operative.Semiring<T>, Equatable<T>, new()      
                    => new Slice<N,T>(apply(s1,s2,semiring<T>().mul));
    } 
}