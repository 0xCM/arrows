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

    public struct Perm
    {
        [MethodImpl(Inline)]
        public static bool operator ==(Perm lhs, Perm rhs)
            => lhs.spec.ReallyEqual(rhs.spec);

        [MethodImpl(Inline)]
        public static bool operator !=(Perm lhs, Perm rhs)
            => !(lhs == rhs);

        [MethodImpl(Inline)]
        public static Perm Identity(int len)
            => new Perm(range(1, len));

        [MethodImpl(Inline)]
        public static Perm Define(Span<int> src)
            => new Perm(src.ToArray());

        [MethodImpl(Inline)]
        public static Perm Define(ReadOnlySpan<int> src)
            => new Perm(src.ToArray());

        [MethodImpl(Inline)]
        public static implicit operator Perm(Span<int> src)
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator Perm(ReadOnlySpan<int> src)
            => Define(src);

        [MethodImpl(Inline)]
        public Perm(int[] spec)
            => this.spec = spec;
        
        [MethodImpl(Inline)]
        public Perm(IEnumerable<int> spec)
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

        public Perm Replicate()
            => new Perm(spec.Replicate());

        static string Format(Perm p)
            =>(from i in range(1, p.spec.Length)
                select $"({i}, {p.spec[i-1]})").Bracket();
        
        public string Format()
            => Format(this);

        public override int GetHashCode()
            => spec.GetHashCode();
        
        public override bool Equals(object o)
            => (o is Perm p) ? p == this : false;
    }

}