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
    /// Defines a permutation of natural length N over the intergers
    /// </summary>
    public struct Perm<N>
        where N : ITypeNat, new()
    {
        /// <summary>
        /// Defines the permutation (0 -> terms[0], 1 -> terms[1], ..., n - 1 -> terms[N-1])
        /// </summary>
        int[] terms;

        static int n = (int)(new N().value);

        /// <summary>
        /// The canonical identity permutation of length N
        /// </summary>
        public static readonly Perm<N> Identity 
            = new Perm<N>(AllocIdentity());

        /// <summary>
        /// The empty permutation of length N
        /// </summary>
        public static readonly Perm<N> Empty 
            = new Perm<N>(new int[n]);

        [MethodImpl(Inline)]
        static int[] AllocIdentity()
            => range(0, n - 1).ToArray();

        /// <summary>
        /// Allocates an empty permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm<N> Alloc()
            => Empty.Replicate();

        /// <summary>
        /// Implicitly converts the source to an unsized permutation
        /// </summary>
        /// <param name="f">The permutation to convert</param>
        [MethodImpl(Inline)]
        public static implicit operator Perm(Perm<N> f)
            => new Perm(f.terms);

        /// <summary>
        /// Computes the composition h of f and g where h(i) = g(f(i)) for i = 0, ... n
        /// </summary>
        /// <param name="f">The left permutation</param>
        /// <param name="g">The right permutation</param>
        [MethodImpl(Inline)]
        public static Perm<N> operator *(Perm<N> f, Perm<N> g)
            => f.Compose(g);

        /// <summary>
        /// Computes the inverse of f
        /// </summary>
        /// <param name="f">The source permutation</param>
        [MethodImpl(Inline)]
        public static Perm<N> operator ~(Perm<N> f)
            => f.Invert();

        [MethodImpl(Inline)]
        public static bool operator ==(Perm<N> f, Perm<N> g)
            => f.terms.ReallyEqual(g.terms);

        [MethodImpl(Inline)]
        public static bool operator !=(Perm<N> f, Perm<N> g)
            => !(f == g);

        /// <summary>
        /// Initializes a permutation with the identity followed by a sequence of transpostions
        /// </summary>
        /// <param name="swaps">The transpositions to apply to the identity</param>
        [MethodImpl(Inline)]
        public Perm(Swap<N>[] swaps)
        {
            terms = new int[n];
            Identity.terms.CopyTo(terms);
            Apply(swaps);
        }

        /// <summary>
        /// Initializes a permutation with array content that implicitly defines a permutation
        /// </summary>
        /// <param name="src">The source array</param>
        public Perm(int[] src)
        {
            if(src.Length == n)
                terms = src;
            else
            {
                terms = new int[n];

                var m = src.Length;
                
                for(var i=0; i< m; i++)
                    terms[i] = src[i];

                for(var i=m; i< n; i++)
                    terms[i] = Identity[i - m];
            }
        }

        /// <summary>
        /// Provides read-only access to the permutation terms
        /// </summary>
        public ReadOnlySpan<N,int> Terms
            => terms;

        /// <summary>
        /// Term evaluator/manipulator where i is in the discrete domain [0, N-1]
        /// </summary>
        public ref int this[int i]
        {
            [MethodImpl(Inline)]
            get => ref terms[i];
        }

        /// <summary>
        /// The permutation length
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
        /// <param name="swap">The transposition to apply</param>
        /// A transposition (l,r) is interpreted as a function composition 
        /// that carries the l-value (from the domain) to the r-value
        /// (in the l-relative codomain) and then the r-value to the l-value
        /// (in the r-relative codomain & l-relative domain). So, if
        /// a function f sends l to r and a function g sends r to l then
        /// the transposition t is the function t(l) = g(f(l)) == l. 
        /// </remarks>
        [MethodImpl(Inline)]
        public Perm<N> Apply(in Swap<N> src)
        {
            (var i, var j) = src;
            swap(ref terms[i], ref terms[j]);
            return this;
        }

        /// <summary>
        /// Effects a sequence of transpositions
        /// </summary>
        public Perm<N> Apply(params Swap<N>[] specs)
        {
            for(var k=0; k<specs.Length; k++)
                Apply(specs[k]);
            return this;
        }

        /// <summary>
        /// Clones the permutation
        /// </summary>
        public Perm<N> Replicate()
            => new Perm<N>(terms.Replicate());

        /// <summary>
        /// Clones the permutation and applies the transposition (i,j)
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        public Perm<N> Replicate(in Swap<N> s)
        {
            var p = Replicate();
            p.Apply(s);
            return p;
        }

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        public Perm<N> Shuffle(IRandomSource random)
        {
            random.Shuffle(terms);
            return this;
        }

        /// <summary>
        /// Computes the inverse permutation t of the current permutation p 
        /// such that p*t = t*p = I where I denotes the identity permutation
        /// </summary>
        public Perm<N> Invert()
        {
            var dst = Alloc();
            for(var i=0; i< n; i++)
                dst[terms[i]] = i;
            return dst;
        }

        /// <summary>
        /// Creates a new permutation p via composition, p[i] = g(f(i)) for i = 0, ... n
        /// where f denotes the current permutation
        /// </summary>
        /// <param name="f">The left permutation</param>
        /// <param name="g">The right permutation</param>
        public Perm<N> Compose(Perm<N> g)
        {
            var dst = Alloc();
            var f = this;
            for(var i=0; i< n; i++)
                dst[i] = g[f[i]];
            return dst;
        }
 
        /// <summary>
        /// Computes the cycle rooted at a specified point in the domain
        /// </summary>
        /// <param name="start">The domain point at which be begin evaluation</param>
        public PermCycle Cycle(int start)
        {
            require(start >= 0 && start < n);
            Span<PermTerm> cterms = stackalloc PermTerm[n];
            var traversed = new HashSet<int>(n);
            var index = start;
            var ctix = 0;
            
            while(true)
            {
                var image = terms[index];
                if(traversed.Contains(image))
                    break;
                else
                {
                    traversed.Add(image);                    
                    cterms[ctix++] = new PermTerm(index, image);
                    index = image;
                }                
            }

            return new PermCycle(cterms.Slice(0, ctix).ToArray());
        }

        /// <summary>
        /// Formats a permutation as a 2-column matrix
        /// </summary>
        /// <param name="src">The source permutation</param>
        /// <param name="colwidth">The width of the matrix columns, if specified</param>
         public string Format(int? colwidth = null)
            => Terms.Unsized.FormatPerm(colwidth);

         public override string ToString() 
            => this.Format();

         public override int GetHashCode()
            => terms.GetHashCode();

         public override bool Equals(object o)
            => (o is Perm<N> p)  ? p.terms.ReallyEqual(terms)  : false;

    }
}