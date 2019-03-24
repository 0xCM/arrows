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

    /// <summary>
    /// Encapsulates a linear data segment with length determined at runtime
    /// </summary>
    public readonly struct Slice<T> : Traits.Slice<T>, IEquatable<Slice<T>>
    {                    
        public static Slice<T> operator + (Slice<T> lhs, Slice<T> rhs)
            => new Slice<T>(lhs.Concat(rhs));

        public static bool operator == (Slice<T> lhs, Slice<T> rhs)
            => lhs.Equals(rhs);

        public static bool operator != (Slice<T> lhs, Slice<T> rhs)
            => not(lhs == rhs);

        public IReadOnlyList<T> cells {get;}

        public static implicit operator Slice<T>(T[] src)
            => new Slice<T>(src);

        public Slice(params T[] src)
        {
            this.length = src.Length();
            this.cells = src;
        }

        public Slice(IReadOnlyList<T> src)
        {
            this.cells = src;
            this.length = this.cells.Length();
        }

        public Slice(IEnumerable<T> src)
        {
            this.cells = src.ToArray();
            this.length = this.cells.Length();
        }

        public intg<uint> length {get;}

        public T this[int i] 
            => cells[i];

        public (Slice<T> lhs, Slice<T> rhs) conform(Slice<T> rhs, T filler)
        {
            var lhsLen = length;
            var rhsLen = rhs.length;
            if(lhsLen == rhsLen)
                return(this,rhs);

            var filled = repeat(filler, lhsLen > rhsLen ? lhsLen - rhsLen : lhsLen - rhsLen);
            if(lhsLen > rhsLen)
                return (this, rhs + filled);
            else
                return (this + filled, rhs);

        }

        public Slice<N,T> ToNatLenth<N>()
            where N : TypeNat, new()
                => new Slice<N,T>(cells);

        public override string ToString() 
            => embrace(string.Join(',' ,cells));

        public IEnumerator<T> GetEnumerator()
            => cells.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        public bool Equals(Slice<T> rhs)
        {
            if(length != rhs.length)
                return false;
            for(var i = 0; i<length; i++)
            {
                if(!Object.Equals(this[i], rhs[i]))
                    return false;
            }
            return true;            
        }

        public override bool Equals(object rhs)
            => rhs is Slice<T> ? Equals((Slice<T>)rhs) : false;

        public override int GetHashCode()
            => cells.GetHashCode();
    }        


    /// <summary>
    /// Encapsulates a linear data segment with naturally-typed length
    /// </summary>
    public readonly struct Slice<N,T> : Traits.Slice<Slice<N,T>,N,T>
        where N : TypeNat, new()
    {                    
        
        static readonly uint Length = natval<N>();

        static readonly Traits.Semiring<T> Ops = semiring<T>();

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
            => fold(s,reducer, Ops.zero);

        /// <summary>
        /// Calculates the component-wise sum of two slices via a semigroup
        /// </summary>
        /// <param name="sg">The semigroup defining the desired addition operator</param>
        /// <param name="s1">The first slice</param>
        /// <param name="s2">the second slice</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
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


        public IReadOnlyList<T> cells {get;}

        public static implicit operator Slice<N,T>(T[] src)
            => new Slice<N,T>(src);

        public Slice(params T[] src)
        {
            this.cells = src;
            this.length = natcheck<N>(cells.Length());
        }

        public Slice(IReadOnlyList<T> src)
        {
            this.cells = src;
            this.length = natcheck<N>(cells.Length());
        }

        public Slice(IEnumerable<T> src)
        {
            this.cells = src.ToArray();
            this.length = natcheck<N>(cells.Length());
        }

        public intg<uint> length {get;}

        public T this[int i] 
            => cells[i];

        public override string ToString() 
            => embrace(string.Join(',' ,cells));

        public IEnumerator<T> GetEnumerator()
            => cells.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }        

}