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
            => lhs.spec.ReallyEqual(rhs.spec);

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
        
        public override bool Equals(object o)
            => (o is Permutation p) ? p == this : false;
    }

    /// <summary>
    /// Defines a permutation of natural length over a sequence of symbols
    /// </summary>
    public struct Permutation<N,T>
        where N : ITypeNat, new()
        where T : struct
    {
        static N n = default;
        
        static uint length = (uint)n.value;


        [MethodImpl(Inline)]
        public static bool operator ==(Permutation<N,T> lhs, Permutation<N,T> rhs)
            => lhs.terms.ReallyEqual(rhs.terms);

        [MethodImpl(Inline)]
        public static bool operator !=(Permutation<N,T> lhs, Permutation<N,T> rhs)
            => !(lhs == rhs);

        public Permutation(T[] terms)
        {
            require(terms.Length == length);
            this.terms = terms;
            this.HashCode = hash(terms);
        }

        readonly int HashCode;        
        
        T[] terms;

        /// <summary>
        /// Term accessor where the term index is in the inclusive range [1,N]
        /// </summary>
        public ref T this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref terms[TermIndex(i)];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)length;
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
        public void Transpose(uint i, uint j)
        {
            var _i = TermIndex(i);
            var _j = TermIndex(j);
            var tmp = terms[_i];
            terms[_i] = terms[_j];
            terms[_j] = tmp;
        }

        public Permutation<N,T> Replicate()
            => new Permutation<N,T>(terms.Replicate());

        /// <summary>
        /// Clones the permutation and applies the transposition (i,j)
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        public Permutation<N,T> Replicate(uint i, uint j)
        {
            var p = Replicate();
            p.Transpose(i,j);
            return p;
        }
            
        public ReadOnlySpan<T> Terms
            => terms;

        public override int GetHashCode()
            => HashCode;

        public override bool Equals(object o)
            => (o is Permutation<N,T> p) 
                ? p.terms.ReallyEqual(terms) 
                : false;

        public string Format(int? colwidth = null)
        {
            var line1 = sbuild();
            var line2 = sbuild();
            var pad = colwidth ?? 3;
            var leftBoundary = $"{AsciSym.Pipe}".PadRight(2);
            var rightBoundary = $"{AsciSym.Pipe}";
            
            line1.Append(leftBoundary);
            line2.Append(leftBoundary);
            for(var i=0; i < terms.Length; i++)
            {
                line1.Append($"{i + 1}".PadRight(pad));
                line2.Append($"{terms[i]}".PadRight(pad));
            }
            line1.Append(rightBoundary);
            line2.Append(rightBoundary);
            
            return line1.ToString() + eol() + line2.ToString();

        }

        public override string ToString() 
            => Format();

        /// <summary>
        /// Validates a term index and, if valid, translates it to a storage index. If invalid,
        /// throws an exception
        /// </summary>
        /// <param name="i">The index to validate</param>
        [MethodImpl(Inline)]
        static uint TermIndex(uint i)      
            => i <= length && i != 0 ? i - 1 : Errors.ThrowOutOfRange<uint>((int)i, 1, (int)length);
    }

}