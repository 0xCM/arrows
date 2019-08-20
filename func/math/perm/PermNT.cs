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
    /// <remarks>The symbol type must be convertible to an integer, wouldn't it be
    /// nice if I could encode that in the type system?</remarks>
    public struct Perm<N,T>
        where N : ITypeNat, new()
        where T : struct
    {
        /// <summary>
        /// Defines the permutation (0 -> terms[0], 1 -> terms[1], ..., n - 1 -> terms[N-1])
        /// </summary>
        T[] terms;

        static int n = (int)(new N().value);

        /// <summary>
        /// The canonical identity permutation of length N
        /// </summary>
        public static readonly Perm<N,T> Identity 
            = new Perm<N,T>(AllocIdentity());

        /// <summary>
        /// The empty permutation of length N
        /// </summary>
        public static readonly Perm<N,T> Empty 
            = new Perm<N,T>(new T[n]);

        [MethodImpl(Inline)]
        static T[] AllocIdentity()
            => range(default(T), convert<int,T>(n - 1)).ToArray();

        /// <summary>
        /// Allocates an empty permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm<N,T> Alloc()
            => Empty.Replicate();

        /// <summary>
        /// Implicitly converts the source to an untyped/unsized permutation
        /// </summary>
        /// <param name="src">The permutation to convert</param>
        [MethodImpl(Inline)]
        public static implicit operator Perm(Perm<N,T> src)
            => new Perm(Converter.convert<T,int>(src.terms));

        /// <summary>
        /// Implicitly converts the source to an integer permutation of the same natural length
        /// </summary>
        /// <param name="src">The permutation to convert</param>
        [MethodImpl(Inline)]
        public static implicit operator Perm<N>(Perm<N,T> src)
            => new Perm<N>(Converter.convert<T,int>(src.terms));

        /// <summary>
        /// Creates a new permutation p via composition, p[i] = g(f(i)) for i = 0, ... n
        /// </summary>
        /// <param name="f">The left permutation</param>
        /// <param name="g">The right permutation</param>
        [MethodImpl(Inline)]
        public static Perm<N,T> operator *(Perm<N,T> f, Perm<N,T> g)
            => f.Compose(g);

        [MethodImpl(Inline)]
        public static bool operator ==(Perm<N,T> lhs, Perm<N,T> rhs)
            => lhs.terms.ReallyEqual(rhs.terms);

        [MethodImpl(Inline)]
        public static bool operator !=(Perm<N,T> lhs, Perm<N,T> rhs)
            => !(lhs == rhs);

        /// <summary>
        /// Initializes a permutation with the identity followed by a sequence of transpostions
        /// </summary>
        /// <param name="swaps">The transpositions to apply to the identity</param>
        [MethodImpl(Inline)]
        public Perm(Swap<N>[] swaps)
        {
            terms = new T[n];
            Identity.terms.CopyTo(terms);
            Apply(swaps);
        }

        /// <summary>
        /// Initializes a permutation with array content that implicitly defines a permutation
        /// </summary>
        /// <param name="src">The source array</param>
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

        [MethodImpl(Inline)]
        Perm<N,T> Transpose((int i, int j) src)
        {
            swap(ref terms[src.i], ref terms[src.j]);
            return this;
        }

        /// <summary>
        /// Effects a transposition (i,j) -> (j, i)
        /// </summary>
        /// <remarks>
        /// <param name="swap">The transposition to apply</param>
        /// A transposition (l,r) is interpreted as a function composition 
        /// that carries the l-value (from the domain) to the r-value
        /// (in the l-relative codomain) and then the r-value to the l-value
        /// (in the r-relative codomain & l-relative domain). So, if
        /// a function f sends l to r and a function g sends r to l then
        /// the transposition t is the function t(l) = g(f(l)) == l. 
        /// </remarks>
        [MethodImpl(Inline)]
        public Perm<N,T> Apply(in Swap<N> swap)
            => Transpose(swap);

        /// <summary>
        /// Effects a sequence of transpositions
        /// </summary>
        public Perm<N,T> Apply(params Swap<N>[] specs)
        {
            for(var k=0; k<specs.Length; k++)
                Apply(specs[k]);
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
        public Perm<N,T> Replicate(in Swap<N> s)
        {
            var p = Replicate();
            p.Transpose(s);
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

        Dictionary<T,int> IndexTerms()
        {
            var dst = new Dictionary<T,int>(n);
            for(var i=0; i<terms.Length; i++)
                dst[terms[i]] = i;
            return dst;
        }

        public Perm<N,T> Compose(Perm<N,T> y)
        {
            var x = this;
            var dst = Alloc();
            var yTerms = y.IndexTerms();
            for(var i=0; i< n; i++)
            {
                if(yTerms.TryGetValue(x[i], out int index))
                    dst[i] = y[index];
            }

            return dst;
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
 
        /// <summary>
        /// Formats a permutation as a 2-column matrix
        /// </summary>
        /// <param name="src">The source permutation</param>
        /// <param name="colwidth">The width of the matrix columns, if specified</param>
        public string Format(int? colwidth = null)        
                => Terms.Unsized.FormatPerm(colwidth);

        public override string ToString() 
            => this.Format();
    }
}