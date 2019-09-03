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
        Perm perm;

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
            => f.perm;

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
        public static Perm<N> operator ++(in Perm<N> lhs)
            => lhs.Inc();

        [MethodImpl(Inline)]
        public static Perm<N> operator --(in Perm<N> lhs)
            => lhs.Dec();

        [MethodImpl(Inline)]
        public static bool operator ==(Perm<N> f, Perm<N> g)
            => f.Equals(g);

        [MethodImpl(Inline)]
        public static bool operator !=(Perm<N> f, Perm<N> g)
            => !f.Equals(g);

        /// <summary>
        /// Initializes a permutation with the identity followed by a sequence of transpostions
        /// </summary>
        /// <param name="swaps">The transpositions to apply to the identity</param>
        [MethodImpl(Inline)]
        public Perm(Swap<N>[] swaps)
        {
            this.perm = new Perm(n, swaps.Unsized());
        }

        [MethodImpl(Inline)]
        Perm(Perm src)
        {
            this.perm = src;
        }

        /// <summary>
        /// Initializes a permutation with array content that implicitly defines a permutation
        /// </summary>
        /// <param name="src">The source array</param>
        public Perm(int[] src)
        {
            if(src.Length == n)
                perm = new Perm(src);
            else
            {
                var tmp = new int[n];
                
                var m = src.Length;                                
                for(var i=0; i< m; i++)
                    tmp[i] = src[i];

                for(var i=m; i< n; i++)
                    tmp[i] = Identity[i - m];
                perm = new Perm(tmp);
            }
        }

        public ReadOnlySpan<int> Terms
            => perm.Terms;

        /// <summary>
        /// Term evaluator/manipulator where i is in the discrete domain [0, N-1]
        /// </summary>
        public ref int this[int i]
        {
            [MethodImpl(Inline)]
            get => ref perm[i];
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
        /// <param name="swap">The transposition to apply</param>
        [MethodImpl(Inline)]
        public Perm<N> Swap(in Swap<N> src)
        {            
            (var i, var j) = src;
            perm.Swap(src);
            return this;
        }

        /// <summary>
        /// Effects a sequence of transpositions
        /// </summary>
        public Perm<N> Swap(params Swap<N>[] specs)
        {            
            for(var k=0; k<specs.Length; k++)            
                perm.Swap(specs[k]);
            return this;
        }

        /// <summary>
        /// Clones the permutation
        /// </summary>
        public Perm<N> Replicate()
            => new Perm<N>(perm.Replicate());

        /// <summary>
        /// Clones the permutation and applies the transposition (i,j)
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        public Perm<N> Replicate(in Swap<N> s)
        {
            var p = Replicate();
            p.Swap(s);
            return p;
        }

        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        public Perm<N> Shuffle(IPolyrand random)
        {
            perm.Shuffle(random);            
            return this;
        }

        /// <summary>
        /// Computes the inverse permutation t of the current permutation p 
        /// such that p*t = t*p = I where I denotes the identity permutation
        /// </summary>
        public Perm<N> Invert()
            => new Perm<N>(perm.Invert());

        /// <summary>
        /// Creates a new permutation p via composition, p[i] = g(f(i)) for i = 0, ... n
        /// where f denotes the current permutation
        /// </summary>
        /// <param name="f">The left permutation</param>
        /// <param name="g">The right permutation</param>
        public Perm<N> Compose(Perm<N> g)
            => new Perm<N>(perm.Compose(g.perm));
 
        /// <summary>
        /// Applies a modular increment to the permutation in-place
        /// </summary>
        [MethodImpl(Inline)]
        public Perm<N> Inc()
        {
            perm.Inc();
            return this;
        }

        /// <summary>
        /// Applies a modular decrement to the permutation in-place
        /// </summary>
        [MethodImpl(Inline)]
        public Perm<N> Dec()
        {
            perm.Dec();
            return this;
        }

        /// <summary>
        /// Computes a permutation cycle originating at a specified point
        /// </summary>
        /// <param name="start">The domain point at which evaluation will begin</param>
        public PermCycle Cycle(int start)
            => perm.Cycle(start);

        [MethodImpl(Inline)]
        public bool Equals(Perm<N> g)
            => perm.Equals(g.perm);

        /// <summary>
        /// Formats a permutation as a 2-column matrix
        /// </summary>
        /// <param name="src">The source permutation</param>
        /// <param name="colwidth">The width of the matrix columns, if specified</param>
        [MethodImpl(Inline)]
         public string Format(int? colwidth = null)
            => perm.Format(colwidth);

         public override string ToString() 
            => this.Format();

         public override int GetHashCode()
            => perm.GetHashCode();

         public override bool Equals(object o)
            => (o is Perm<N> p)  ? p.perm.Equals(perm)  : false;

    }
}