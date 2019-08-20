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
    /// Defines a permutation over the integers [0, 1, ..., n - 1] where n is the permutation length
    /// </summary>
    public struct Perm
    {
        /// <summary>
        /// Defines the permutation (0 -> terms[0], 1 -> terms[1], ..., n - 1 -> terms[n-1])
        /// where n is the length of the array
        /// </summary>
        int[] terms;

        /// <summary>
        /// Defines an untyped identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static Perm Identity(int n)
            => new Perm(range(0, n-1));

        /// <summary>
        /// Creates a new identity permutation of natural length
        /// </summary>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The term type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<N> Identity<N>(N n = default)
            where N : ITypeNat, new()
                => Perm<N>.Identity.Replicate();

        /// <summary>
        /// Defines an untyped permutation determined by values in a source span
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static Perm Define(ReadOnlySpan<int> src)
            => new Perm(src.ToArray());

        /// <summary>
        /// Defines a permutation of natural length
        /// </summary>
        /// <param name="length">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The symbol type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<N> Define<N>(N length, params int[] terms)
            where N : ITypeNat, new()
                => new Perm<N>(terms);

        /// <summary>
        /// Defines an identity permutation of natural length and applies a specified sequence of transpostions
        /// </summary>
        /// <param name="length">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<N> Define<N>(params Swap<N>[] transpositions)
            where N : ITypeNat, new()
                => new Perm<N>(transpositions);

        /// <summary>
        /// Defines a generic permutation of natural length
        /// </summary>
        /// <param name="length">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The term type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<N,T> Define<N,T>(N length, params T[] terms)
            where N : ITypeNat, new()
            where T : struct
                => new Perm<N,T>(terms);

        /// <summary>
        /// Defines a generic identity permutation of natural length and applies a specified sequence of transpostions
        /// </summary>
        /// <param name="length">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The term type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<N,T> Define<N,T>(params Swap<N>[] transpositions)
            where N : ITypeNat, new()
            where T : struct
                => new Perm<N,T>(transpositions);

        /// <summary>
        /// Defines a transposition for a permutation of natural length
        /// </summary>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static Swap<N> Swap<N>(int i, int j)
            where N : ITypeNat, new()
                => (i,j);

        /// <summary>
        /// Defines an identity permutation over symbols of a specified type
        /// </summary>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The symbol type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<N,T> Identity<N,T>(N n = default, T rep = default)
            where N : ITypeNat, new()
            where T : struct
                => Perm<N,T>.Identity.Replicate();

        [MethodImpl(Inline)]
        public static implicit operator Perm(Span<int> src)
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator Perm(ReadOnlySpan<int> src)
            => Define(src);

        [MethodImpl(Inline)]
        public static bool operator ==(Perm lhs, Perm rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Perm lhs, Perm rhs)
            => !(lhs == rhs);

        /// <summary>
        /// Initializes permutation with the identity followed by a sequence of transpostions
        /// </summary>
        /// <param name="n">The length of the permutation</param>
        /// <param name="i">The source value</param>
        /// <param name="j">The target value/param>
        [MethodImpl(Inline)]
        public Perm(int n, (int i, int j)[] src)
        {
            terms = Identity(n).terms;
            Transpose(src);
        }
        
        [MethodImpl(Inline)]
        public Perm(int n, int[] src)
        {
            terms = new int[n];

            var m = src.Length;
            
            for(var i=0; i< m; i++)
                terms[i] = src[i];

            var identity = Identity(n);
            for(var i=m; i< n; i++)
                terms[i] = identity[i - m];
        }
        
        [MethodImpl(Inline)]
        public Perm(IEnumerable<int> src)
        {
            terms = src.ToArray();
        }
                
        /// <summary>
        /// Term accessor where the term index is in the inclusive range [0, N-1]
        /// </summary>
        public ref int this[int i]
        {
            [MethodImpl(Inline)]
            get => ref terms[i];
        }

        /// <summary>
        /// Effects an in-place transposition, returning the result for convenience
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
        public Perm Transpose(int i, int j)
        {
            swap(ref terms[i], ref terms[j]);
            return this;
        }

        /// <summary>
        /// Effects a sequence of in-place transpositions
        /// </summary>
        public Perm Transpose(params (int i, int j)[] specs)
        {
            for(var k=0; k<specs.Length; k++)
                swap(ref terms[specs[k].i], ref terms[specs[k].j]);
            return this;
        }

        /// <summary>
        /// The length of the permutation
        /// </summary>
        public int Length
            => terms.Length;

        /// <summary>
        /// Provies read-only access the the permutation terms
        /// </summary>
        public ReadOnlySpan<int> Terms
            => terms;

        /// <summary>
        /// Clones the permutation
        /// </summary>
        public Perm Replicate()
            => new Perm(terms.Replicate());

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        public Perm Shuffle(IRandomSource random)
        {
            random.Shuffle(terms);
            return this;
        }

        /// <summary>
        /// Formats a permutation as a 2-column matrix
        /// </summary>
        /// <param name="src">The source permutation</param>
        /// <param name="colwidth">The width of the matrix columns, if specified</param>
        [MethodImpl(Inline)]
        public string Format(int? colwidth = null)        
            => Terms.FormatPerm(colwidth);

        public override int GetHashCode()
            => terms.GetHashCode();
        
        public bool Equals(Perm rhs)
        {   
            var len = rhs.Length;
            if(len != terms.Length)
                return(false);
            
            for(var i=0; i<len; i++)
                if(terms[i] != rhs.terms[i])
                    return false;
            
            return true;
        }

        public override bool Equals(object o)
            => (o is Perm p) ? p == this : false;
    }


}