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
    /// Defines a transposition in the context of a permutation of natural length
    /// </summary>
    public struct Swap<N>
        where N : ITypeNat, new()
    {
        /// <summary>
        /// The first index
        /// </summary>
        Mod<N> i;
        
        /// <summary>
        /// The second index
        /// </summary>
        Mod<N> j;

        /// <summary>
        /// The empty element
        /// </summary>
        public static readonly Swap<N> Empty = (-1,-1);
        
        /// <summary>
        /// The monodial zero
        /// </summary>
        public static readonly Swap<N> Zero = (0,0);

        /// <summary>
        /// Creates a chain of transpositions, that includes the initial transposition
        /// </summary>
        /// <param name="s0">The leading transposition</param>
        /// <param name="len">The length of the chain</param>
        public static Swap<N>[] Chain(Swap<N> s0, int len)
        {
            var dst = new Swap<N>[len];
            dst[0]  = s0;
            for(var k = 1; k < len; k++)
                dst[k] = ++s0;
            return dst;
        }

        /// <summary>
        /// Parses a transposition in canonical form (i j), if possible; otherwise
        /// returns the empty transposition
        /// </summary>
        /// <param name="src">The source text</param>
        public static Swap<N> Parse(string src)
        {
            var indices = src.RemoveAny(AsciSym.LParen, AsciSym.RParen).Trim().Split(AsciSym.Space);
            if(indices.Length != 2)
                return Empty;

            var result = Try(() => (Int32.Parse(indices[0]), Int32.Parse(indices[1])));
            if(result.IsSome())
                return result.Value();
            else
                return Empty;
        }

        [MethodImpl(Inline)]
        public static implicit operator Swap<N>((int i, int j) src)
            => new Swap<N>(src);

        [MethodImpl(Inline)]
        public static implicit operator (int i, int j)(Swap<N> src)
            => (src.i, src.j);

        [MethodImpl(Inline)]
        public static Swap<N> operator ++(in Swap<N> src)
        {
            ref var dst = ref As.asRef(in src);
            dst.i++;
            dst.j++;
            return dst;
        }

        [MethodImpl(Inline)]
        public static Swap<N> operator --(in Swap<N> src)
        {
            ref var dst = ref As.asRef(in src);
            if(src.i != 0)
                dst.i--;
            if(src.j != 0)
                --dst.j;
            return dst;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(Swap<N> lhs, Swap<N> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Swap<N> lhs, Swap<N> rhs)
            => !(lhs == rhs);                    

        [MethodImpl(Inline)]
        public Swap((int i, int j) src)
        {
            this.i = src.i;
            this.j = src.j;
        }

        [MethodImpl(Inline)]
        public Swap(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        /// <summary>
        /// Renders the tranposition as text in canonical form
        /// </summary>
        public string Format()
            => $"({i} {j})";
        
        public bool IsEmpy
            => i == Empty.i && j == Empty.j;

            
        /// <summary>
        /// Determines whether this transposition is identical to another.
        /// Note that the order of indices is immaterial
        /// </summary>
        /// <param name="rhs">The right transposition</param>
        [MethodImpl(Inline)]
        public bool Equals(Swap<N> rhs)
            => (i == rhs.i && j == rhs.j) || (i == rhs.j && j == rhs.i);

        [MethodImpl(Inline)]
        public void Deconstruct(out int i, out int j)
        {
            i = this.i;
            j = this.j;
        }

        /// <summary>
        /// Creates a copy
        /// </summary>
        [MethodImpl(Inline)]
        public Swap<N> Replicate()
            => (i,j);

        public override int GetHashCode()
            => throw new NotSupportedException();
             
        public override bool Equals(object o)
            => throw new NotSupportedException();

    }

}