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
    /// Defines a permutation over the integers
    /// </summary>
    public struct Permutation
    {
        /// <summary>
        /// Defines a permutation of natural length
        /// </summary>
        /// <param name="length">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The term type</typeparam>
        [MethodImpl(Inline)]
        public static Permutation<N,T> Define<N,T>(N length, params T[] terms)
            where N : ITypeNat, new()
            where T : struct
                => new Permutation<N,T>(terms);
         
        [MethodImpl(Inline)]
        public static bool operator ==(Permutation lhs, Permutation rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Permutation lhs, Permutation rhs)
            => !(lhs == rhs);

        [MethodImpl(Inline)]
        public static Permutation Identity(int len)
            => new Permutation(range(1, len));

        [MethodImpl(Inline)]
        public static Permutation Define(Span<int> src)
            => new Permutation(src.ToArray());

        [MethodImpl(Inline)]
        public static Permutation Define(ReadOnlySpan<int> src)
            => new Permutation(src.ToArray());

        [MethodImpl(Inline)]
        public static implicit operator Permutation(Span<int> src)
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator Permutation(ReadOnlySpan<int> src)
            => Define(src);

        [MethodImpl(Inline)]
        public Permutation(int[] spec)
            => this.spec = spec;
        
        [MethodImpl(Inline)]
        public Permutation(IEnumerable<int> spec)
            => this.spec = spec.ToArray();
                
        int[] spec;

        public ref int this[int i]
        {
            [MethodImpl(Inline)]
            get => ref spec[i - 1];
        }

        /// <summary>
        /// The raw data that defines the permuation
        /// </summary>
        public int[] Data
            => spec;

        /// <summary>
        /// Effects a transposition
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
        public void Transpose(int i, int j)
        {
            var tmp = spec[i];
            spec[i] = spec[j];
            spec[j] = tmp;
        }

        public int Length
            => spec.Length;

        public Permutation Replicate()
            => new Permutation(spec.Replicate());

        static string Format(Permutation p)
            =>(from i in range(1, p.spec.Length)
                select $"({i}, {p.spec[i-1]})").Bracket();
        
        public string Format()
            => Format(this);

        public override int GetHashCode()
            => spec.GetHashCode();
        
        public bool Equals(Permutation rhs)
        {   
            var len = rhs.Length;
            if(len != spec.Length)
                return(false);
            
            for(var i=0; i<len; i++)
                if(spec[i] != rhs.spec[i])
                    return false;
            
            return true;

        }
        public override bool Equals(object o)
            => (o is Permutation p) ? p == this : false;
    }


}