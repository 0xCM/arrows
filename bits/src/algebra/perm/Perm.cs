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
 
    using static zfunc;    


    /// <summary>
    /// Defines a permutation over an integral type based at 0, [0, 1, ..., n - 1] where n is the permutation length
    /// </summary>
    /// <typeparam name="T">The integral type</typeparam>
    public struct PermG<T>
        where T : unmanaged
    {
        /// <summary>
        /// Defines the permutation (0 -> terms[0], 1 -> terms[1], ..., n - 1 -> terms[n-1])
        /// where n is the length of the array
        /// </summary>
        T[] terms;

        /// <summary>
        /// Defines an untyped identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static PermG<T> Identity(T n)
            => new PermG<T>(range(default, gmath.dec(n)));

        /// <summary>
        /// Allocates an empty permutation
        /// </summary>
        [MethodImpl(Inline)]
        static PermG<T> Alloc(int n)
            => new PermG<T>(new T[n]);

        /// <summary>
        /// Defines an untyped permutation determined by values in a source span
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static PermG<T> Define(ReadOnlySpan<T> src)
            => new PermG<T>(src.ToArray());
        
        [MethodImpl(Inline)]
        public static implicit operator PermG<T>(Span<T> src)
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator PermG<T>(ReadOnlySpan<T> src)
            => Define(src);

        /// <summary>
        /// Implicitly converts an integral value n into an identity permutation of length n
        /// </summary>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static implicit operator PermG<T>(T n)
            => Identity(n);

        /// <summary>
        /// Computes the composition h of f and g where f and g have common length n and
        /// h(i) = g(f(i)) for i = 0, ... n-1
        /// </summary>
        /// <param name="f">The left permutation</param>
        /// <param name="g">The right permutation</param>
        [MethodImpl(Inline)]
        public static PermG<T> operator *(PermG<T> f, PermG<T> g)
            => f.Compose(g);

        [MethodImpl(Inline)]
        public static PermG<T> operator ++(in PermG<T> lhs)
            => lhs.Inc();

        [MethodImpl(Inline)]
        public static PermG<T> operator --(in PermG<T> lhs)
            => lhs.Dec();

        [MethodImpl(Inline)]
        public static bool operator ==(PermG<T> lhs, PermG<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(PermG<T> lhs, PermG<T> rhs)
            => !(lhs == rhs);

        /// <summary>
        /// Initializes permutation with the identity followed by a sequence of transpostions
        /// </summary>
        /// <param name="n">The length of the permutation</param>
        /// <param name="swaps">The transpositions applied to the identity</param>
        [MethodImpl(Inline)]
        public PermG(T n, (T i, T j)[] swaps)
        {
            terms = Identity(n).terms;
            Swap(swaps);
        }

        /// <summary>
        ///  Initializes permutation with the identity followed by a sequence of transpostions
        /// </summary>
        /// <param name="n">The length of the permutation</param>
        /// <param name="swaps">The transpositions applied to the identity</param>
        [MethodImpl(Inline)]
        public PermG(T n, SwapG<T>[] swaps)
        {
            terms = Identity(n).terms;
            Swap(swaps);            
        }

        [MethodImpl(Inline)]
        public PermG(T[] src)
        {
            terms = src;
        }

        [MethodImpl(Inline)]
        public PermG(IEnumerable<T> src)
        {
            terms = src.ToArray();
        }

        [MethodImpl(Inline)]
        public PermG(T n, T[] src)
        {
            var count = iVal(n);
            terms = new T[count];

            var m = src.Length;
            
            for(var i=0; i< m; i++)
                terms[i] = src[i];

            var identity = Identity(n);
            for(var i=m; i< count; i++)
                terms[i] = identity[i - m];
        }
                        
        /// <summary>
        /// Term accessor where the term index is in the inclusive range [0, N-1]
        /// </summary>
        ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref terms[i];
        }

        /// <summary>
        /// Term accessor where the term index is in the inclusive range [0, N-1]
        /// </summary>
        public ref T this[T i]
        {
            [MethodImpl(Inline)]
            get => ref terms[iVal(i)];
        }

        [MethodImpl(Inline)]
        public PermG<T> Swap(T i, T j)
        {
            
            swap(ref terms[iVal(i)], ref terms[iVal(j)]);
            return this;
        }

        /// <summary>
        /// Effects a sequence of in-place transpositions
        /// </summary>
        public PermG<T> Swap(params (T i, T j)[] specs)
        {
            
            for(var k=0; k<specs.Length; k++)
                swap(ref terms[iVal(specs[k].i)], ref terms[iVal(specs[k].j)]);
            return this;
        }

        /// <summary>
        /// Effects a sequence of in-place transpositions
        /// </summary>
        public PermG<T> Swap(params Swap[] specs)
        {
            for(var k=0; k<specs.Length; k++)
                swap(ref terms[specs[k].i], ref terms[specs[k].j]);
            return this;
        }

        /// <summary>
        /// Effects a sequence of in-place transpositions
        /// </summary>
        public PermG<T> Swap(params SwapG<T>[] specs)
        {
            for(var k=0; k<specs.Length; k++)
                Swap(specs[k]);
            return this;
        }

        /// <summary>
        /// The length of the permutation
        /// </summary>
        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => terms.Length;
        }

        public readonly ReadOnlySpan<T> Terms
            => terms;

        /// <summary>
        /// Applies a modular increment to the permutation in-place
        /// </summary>
        public PermG<T> Inc()
        {
            Span<T> src = Replicate().terms;
            var lastix = Length - 1;
            for(var i=0; i< lastix; i++)
                terms[i] = src[i + 1];
            terms[lastix] = src[0];
            return this;
        }

        /// <summary>
        /// Applies a modular decrement to the permutation in-place
        /// </summary>
        public PermG<T> Dec()
        {
            Span<T> src = Replicate().terms;
            terms[0] = src[Length - 1];
            for(var i=1; i< Length; i++)
                terms[i] = src[i - 1];
            return this;
        }

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public PermG<T> Shuffle(IPolyrand random)
        {
            random.Shuffle(terms);
            return this;
        }

        /// <summary>
        /// Clones the permutation
        /// </summary>
        public readonly PermG<T> Replicate()
            => new PermG<T>(terms.Replicate());

        /// <summary>
        /// Creates a new permutation p via composition, p[i] = g(f(i)) for i = 0, ... n
        /// where f denotes the current permutation
        /// </summary>
        /// <param name="f">The left permutation</param>
        /// <param name="g">The right permutation</param>
        public readonly PermG<T> Compose(PermG<T> g)
        {
            var n = length(terms, g.terms);
            var dst = Alloc(n);
            var f = this;
            for(var i=0; i< n; i++)
                dst[i] = g[f[i]];
            return dst;
        }

        /// <summary>
        /// Computes the inverse permutation t of the current permutation p 
        /// such that p*t = t*p = I where I denotes the identity permutation
        /// </summary>
        public readonly PermG<T> Invert()
        {
            var dst = Alloc(Length);
            for(var i=0; i< Length; i++)
                dst[terms[i]] = convert<T>(i);
            return dst;
        }

        /// <summary>
        /// Computes a permutation cycle originating at a specified point
        /// </summary>
        /// <param name="start">The domain point at which evaluation will begin</param>
        public readonly PermCycleG<T> Cycle(T start)
        {
            var iStart = iVal(start);
            require(iStart >= 0 && iStart < Length);
            Span<PermTerm<T>> cterms = stackalloc PermTerm<T>[Length];
            var traversed = new HashSet<T>(Length);
            var index = start;
            var ctix = 0;
            
            while(true)
            {
                var image = terms[iVal(index)];
                if(traversed.Contains(image))
                    break;
                else
                {
                    traversed.Add(image);                    
                    cterms[ctix++] = new PermTerm<T>(index, image);
                    index = image;
                }                
            }

            return new PermCycleG<T>(cterms.Slice(0, ctix).ToArray());
        }


        public readonly override int GetHashCode()
            => terms.GetHashCode();
        
        public readonly bool Equals(PermG<T> rhs)
        {   
            var len = rhs.Length;
            if(len != terms.Length)
                return(false);
            
            for(var i=0; i<len; i++)
                if(gmath.neq(terms[i], rhs.terms[i]))
                    return false;            
            return true;
        }

        [MethodImpl(Inline)]
        static int iVal(T src)
            => convert<T,int>(src);

        public readonly override bool Equals(object o)
            => (o is PermG<T> p) ? p == this : false;
    }



}