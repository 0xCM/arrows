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
    /// Defines a transposition, i.e. a specification for the transposition
    /// of two elements, denoted by an ordered pair of space-delimited indices (i j)
    /// </summary>
    public struct SwapG<T>
        where T : unmanaged
    {
        /// <summary>
        /// The first index
        /// </summary>
        public T i;
        
        /// <summary>
        /// The second index
        /// </summary>
        public T j;
        
        /// <summary>
        /// The monodial zero
        /// </summary>
        public static readonly SwapG<T> Zero = default;

        /// <summary>
        /// Creates a chain of transpositions, that includes the initial transposition
        /// </summary>
        /// <param name="s0">The leading transposition</param>
        /// <param name="len">The length of the chain</param>
        public static SwapG<T>[] Chain(SwapG<T> s0, int len)
        {
            var dst = new SwapG<T>[len];
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
        public static SwapG<T> Parse(string src)
        {
            var indices = src.RemoveAny(AsciSym.LParen, AsciSym.RParen).Trim().Split(AsciSym.Space);
            if(indices.Length != 2)
                return Zero;
            
            var result = Try(() => (gmath.parse<T>(indices[0]), gmath.parse<T>(indices[1])));
            if(result.IsSome())
                return result.Value();
            else
                return Zero;
        }


        [MethodImpl(Inline)]
        public static implicit operator SwapG<T>((T i, T j) src)
            => new SwapG<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator (T i, T j)(SwapG<T> src)
            => src.ToTuple();

        [MethodImpl(Inline)]
        public static SwapG<T> operator ++(in SwapG<T> src)
        {
            ref var dst = ref As.asRef(in src);
            gmath.inc(ref dst.i);
            gmath.inc(ref dst.j);
            return dst;
        }

        [MethodImpl(Inline)]
        public static SwapG<T> operator --(in SwapG<T> src)
        {
            ref var dst = ref As.asRef(in src);
            if(gmath.nonzero(src.i))
                gmath.dec(ref dst.i);
            
            if(gmath.nonzero(src.j))
                gmath.dec(ref dst.j);
            return dst;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(SwapG<T> lhs, SwapG<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(SwapG<T> lhs, SwapG<T> rhs)
            => !(lhs == rhs);                    

        [MethodImpl(Inline)]
        public SwapG((T i, T j) src)
        {
            this.i = src.i;
            this.j = src.j;
        }

        /// <summary>
        /// Renders the tranposition as text in canonical form
        /// </summary>
        public string Format()
            => $"({i} {j})";
        
        public bool IsEmpy
            => !gmath.nonzero(i) && !gmath.nonzero(j);
            
        /// <summary>
        /// Determines whether this transposition is identical to another.
        /// Note that the order of indices is immaterial
        /// </summary>
        /// <param name="rhs">The right transposition</param>
        [MethodImpl(Inline)]
        public bool Equals(SwapG<T> rhs)
            => (gmath.eq(i, rhs.i) && gmath.eq(j ,rhs.j) || 
               (gmath.eq(i, rhs.j) && gmath.eq(j, rhs.i)));

        [MethodImpl(Inline)]
        public void Deconstruct(out T i, out T j)
        {
            i = this.i;
            j = this.j;
        }

        [MethodImpl(Inline)]
        public (T i, T j) ToTuple()
            => (i,j);

        /// <summary>
        /// Creates a copy
        /// </summary>
        [MethodImpl(Inline)]
        public SwapG<T> Replicate()
            => (i,j);

        public override int GetHashCode()
            => throw new NotSupportedException();
             
        public override bool Equals(object o)
            => o is SwapG<T> x ? Equals(x) : false;
    }

    /// <summary>
    /// Defines a transposition in the context of a permutation of natural length
    /// </summary>
    public struct SwapG<N,T>
        where N : ITypeNat, new()
        where T : unmanaged
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
        /// The monodial zero
        /// </summary>
        public static readonly SwapG<N,T> Zero = default;

        /// <summary>
        /// Creates a chain of transpositions, that includes the initial transposition
        /// </summary>
        /// <param name="t0">The leading transposition</param>
        /// <param name="len">The length of the chain</param>
        public static SwapG<N,T>[] Chain(SwapG<N,T> t0, int len)
        {
            var dst = new SwapG<N,T>[len];
            dst[0]  = t0;
            for(var k = 1; k < len; k++)
                dst[k] = ++t0;
            return dst;
        }

        /// <summary>
        /// Parses a transposition in canonical form (i j), if possible; otherwise
        /// returns the empty transposition
        /// </summary>
        /// <param name="src">The source text</param>
        public static SwapG<N,T> Parse(string src)
            => FromTuple(SwapG<T>.Parse(src));

        /// <summary>
        /// Converts a tuple representation to a swap
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        [MethodImpl(Inline)]
        public static SwapG<N,T> FromTuple((T i, T j) src)
            => new SwapG<N,T>(src);
        
        [MethodImpl(Inline)]
        public static implicit operator SwapG<N,T>((T i, T j) src)
            => FromTuple(src);
        
        /// <summary>
        /// Implicitly converts the transpostion to its unsized representation
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        [MethodImpl(Inline)]
        public static implicit operator SwapG<T>(SwapG<N,T> src)
            => new SwapG<T>(src.ToTuple());

        /// <summary>
        /// Implicitly converts the transpostion to its canonical tuple representation
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        [MethodImpl(Inline)]
        public static implicit operator (T i, T j)(SwapG<N,T> src)
            => src.ToTuple();

        [MethodImpl(Inline)]
        public static implicit operator Swap(SwapG<N,T> src)
            => (src.i, src.j);

        [MethodImpl(Inline)]
        public static SwapG<N,T> operator ++(in SwapG<N,T> src)
        {
            ref var dst = ref As.asRef(in src);
            dst.i++;
            dst.j++;
            return dst;
        }

        [MethodImpl(Inline)]
        public static SwapG<N,T> operator --(in SwapG<N,T> src)
        {
            ref var dst = ref As.asRef(in src);
            if(src.i != 0)
                dst.i--;
            if(src.j != 0)
                --dst.j;
            return dst;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(SwapG<N,T> lhs, SwapG<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(SwapG<N,T> lhs, SwapG<N,T> rhs)
            => !(lhs == rhs);                    

        [MethodImpl(Inline)]
        public SwapG((int i, int j) src)
        {
            this.i = src.i;
            this.j = src.j;
        }

        [MethodImpl(Inline)]
        public SwapG((T i, T j) src)
        {
            this.i = convert<T,uint>(src.i);
            this.j = convert<T,uint>(src.j);
        }

        [MethodImpl(Inline)]
        SwapG(Mod<N> i, Mod<N> j)
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
            => i == Zero.i && j == Zero.j;
            
        /// <summary>
        /// Determines whether this transposition is identical to another.
        /// Note that the order of indices is immaterial
        /// </summary>
        /// <param name="rhs">The right transposition</param>
        [MethodImpl(Inline)]
        public bool Equals(SwapG<N,T> rhs)
            => (i == rhs.i && j == rhs.j) || (i == rhs.j && j == rhs.i);

        [MethodImpl(Inline)]
        public void Deconstruct(out T i, out T j)
        {
            i = convert<T>(this.i.State);
            j = convert<T>(this.j.State);
        }

        /// <summary>
        /// Converts the transpostion to its canonical tuple representation
        /// </summary>
        /// <param name="i">The first term index</param>
        /// <param name="j">The second term index</param>
        [MethodImpl(Inline)]
        public (T i, T j) ToTuple()
            => (convert<T>(i.State), convert<T>(j.State));

        /// <summary>
        /// Creates a copy
        /// </summary>
        [MethodImpl(Inline)]
        public SwapG<N,T> Replicate()
            => new SwapG<N,T>(i,j);

        public override int GetHashCode()
            => throw new NotSupportedException();
             
        public override bool Equals(object o)
            => throw new NotSupportedException();

    }
   
}