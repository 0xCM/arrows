//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;
    using static mfunc;

    /// <summary>
    /// Defines an integrally and naturally typed bitvector
    /// </summary>
    public ref struct BitVector<N> 
        where N : ITypeNat, new()
    {
        Span<Bit> bits;

        BitVector(Span<char> src)
            => bits = src.ToBits();

        BitVector(ReadOnlySpan<char> src)
            => bits = src.ToBits();

        BitVector(Span<Bit> src)
        {
            nfunc.require<N>(src.Length);
            bits = src;
            for(var i =0; i< Length; i++)
                bits[i] = src[i];
        }

        public static readonly int Length = nati<N>();        

        [MethodImpl(Inline)]
        public static BitVector<N> Define(Span<Bit> src)
            => new BitVector<N>(src);

        [MethodImpl(Inline)]
        public static BitVector<N> Define(Span<char> src)
                => new BitVector<N>(src);

        [MethodImpl(Inline)]
        public static BitVector<N> Define(ReadOnlySpan<char> src)
                => new BitVector<N>(src);

        [MethodImpl(Inline)]
        public static BitVector<N> Define(ReadOnlySpan<BinaryDigit> src)
        {
            var dst = span<char>(src.Length);
            for(var i=0; i<Length; i++)
                dst[i] = src[i].ToBit();            
            return new BitVector<N>(dst);
        }

        
        [MethodImpl(Inline)]
        public static bool operator == (BitVector<N> lhs, in BitVector<N> rhs) 
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (BitVector<N> lhs, in BitVector<N> rhs) 
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N> operator & (BitVector<N> lhs, in BitVector<N> rhs) 
        {
            lhs.And(rhs);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static BitVector<N> operator | (BitVector<N> lhs, in BitVector<N> rhs) 
        {
            lhs.Or(rhs);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static BitVector<N> operator ^ (BitVector<N> lhs, in BitVector<N> rhs) 
        {
            lhs.XOr(rhs);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static BitVector<N> operator ~ (BitVector<N> src) 
        {
            src.Flip();
            return src;
        }
        
            

        public void And(in BitVector<N> rhs)
        {
            for(var i =0; i<  Length; i++)
                bits[i] = Bit.And(bits[i], rhs.bits[i]);            
        }

        public void Or(in BitVector<N> rhs)
        {
            for(var i =0; i<  Length; i++)
                bits[i] = Bit.Or(bits[i], rhs.bits[i]);            
        }

        public void XOr(in BitVector<N> rhs)
        {
            for(var i =0; i<  Length; i++)
                bits[i] = Bit.XOr(bits[i], rhs.bits[i]);            
        }

        public void Flip()
        {
            for(var i =0; i<  Length; i++)
                bits[i] = Bit.Flip(bits[i]);
        }

        /// <summary>
        /// Tests whether the bit in an specific position is set
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <param name="pos">The bit position to test</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        /// <returns>Returns true if the identified bit is set, false otherwise</returns>
        [MethodImpl(Inline)]
        public bool TestBit(int pos)            
            => bits[pos] == Bit.One;

        
        [MethodImpl(Inline)]
        public string Format()
            => bits.ToBitString();


        [MethodImpl(Inline)]
        public bool Eq(BitVector<N> rhs)
        {
            for(var i = 0; i< Length; i++)
                if(bits[i] != rhs.bits[i])
                    return false;
            return true;
        }  
        
        [MethodImpl(Inline)]
        public bool NEq(BitVector<N> rhs)
            => not(Eq(rhs));
 
        public override int GetHashCode()
            => throw unsupported(nameof(GetHashCode));

        public override bool Equals(object rhs)
            => throw unsupported(nameof(Equals));
    } 
}