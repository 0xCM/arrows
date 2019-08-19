//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static zfunc;    

    /// <summary>
    /// Defines a permutation of natural length N over a sequence of T-valued symbols
    /// </summary>
    public struct Perm<N,T>
        where N : ITypeNat, new()
        where T : struct
    {
        /// <summary>
        /// Defines the permutation (0 -> terms[0], 1 -> terms[1], ..., n - 1 -> terms[N-1])
        /// </summary>
        T[] terms;
        
        static int n = (int)(new N().value);

        public static implicit operator Perm(Perm<N,T> src)
            => new Perm(Converter.convert<T,int>(src.terms));

        [MethodImpl(Inline)]
        public static bool operator ==(Perm<N,T> lhs, Perm<N,T> rhs)
            => lhs.terms.ReallyEqual(rhs.terms);

        [MethodImpl(Inline)]
        public static bool operator !=(Perm<N,T> lhs, Perm<N,T> rhs)
            => !(lhs == rhs);

        [MethodImpl(Inline)]
        Perm(IEnumerable<T> src)
        {
            terms = src.ToArray();
            require(terms.Length == n);
        }

        static readonly T[] Identity = Enumerable.Range(0,(int)n).Convert<T>().ToArray();

        /// <summary>
        /// Initializes ther permutation with the identity followed by a sequence of transpostions
        /// </summary>
        /// <param name="i">The domain index</param>
        /// <param name="j">The range index</param>
        [MethodImpl(Inline)]
        public Perm((int i, int j)[] src)
        {
            terms = new T[n];
            Identity.CopyTo(terms);
            Transpose(src);
        }

        public Perm(T[] src)
        {
            terms = new T[n];

            var m = src.Length;
            
            for(var i=0; i< m; i++)
                terms[i] = src[i];

            for(var i=m; i< n; i++)
                terms[i] = Identity[i - m];
        }

        /// <summary>
        /// Term accessor where the term index is in the inclusive range [0, N-1]
        /// </summary>
        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref terms[i];
        }

        /// <summary>
        /// The length of the permutation
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)n;
        }

        /// <summary>
        /// Effects a transposition (i,j) -> (j, i)
        /// </summary>
        /// <remarks>
        /// A transposition (l,r) is interpreted as a function composition 
        /// that carries the l-value (from the domain) to the r-value
        /// (in the l-relative codomain) and then the r-value to the l-value
        /// (in the r-relative codomain & l-relative domain). So, if
        /// a function f sends l to r and a function g sends r to l then
        /// the transposition t is the function t(l) = g(f(l)) == l. 
        /// </remarks>
        [MethodImpl(Inline)]
        public Perm<N,T> Transpose(int i, int j)
        {
            // var tmp = terms[i];
            // terms[i] = terms[j];
            // terms[j] = tmp;
            swap(ref terms[i], ref terms[j]);
            return this;
        }

        /// <summary>
        /// Effects a sequence of transpositions
        /// </summary>
        public Perm<N,T> Transpose(params (int i, int j)[] specs)
        {
            for(var k=0; k<specs.Length; k++)
                swap(ref terms[specs[k].i], ref terms[specs[k].j]);
            return this;
        }

        /// <summary>
        /// Clones the permutation
        /// </summary>
        public Perm<N,T> Replicate()
            => new Perm<N,T>(terms.Replicate());

        /// <summary>
        /// Clones the permutation and applies the transposition (i,j)
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        public Perm<N,T> Replicate(int i, int j)
        {
            var p = Replicate();
            p.Transpose(i,j);
            return p;
        }

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        public Perm<N,T> Shuffle(IRandomSource random)
        {
            random.Shuffle(terms);
            return this;
        }

        /// <summary>
        /// Provides read-only access to the permutation terms
        /// </summary>
        public ReadOnlySpan<N,T> Terms
            => terms;

        public override int GetHashCode()
            => terms.GetHashCode();

        public override bool Equals(object o)
            => (o is Perm<N,T> p) 
                ? p.terms.ReallyEqual(terms) 
                : false;
 
        public override string ToString() 
            => this.Format();
    }
}