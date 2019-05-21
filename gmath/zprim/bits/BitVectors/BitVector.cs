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
    using static Bits;

    /// <summary>
    /// Defines an integrally and naturally typed bitvector
    /// </summary>
    public ref struct BitVector<N> 
        where N : INatPow2, new()
    {
        [MethodImpl(Inline)]
        public static BitVector<N> Define(in ReadOnlySpan<Bit> src)
            => new BitVector<N>(src);

        [MethodImpl(Inline)]
        public static BitVector<N> Define(in ReadOnlySpan<char> src)
            => new BitVector<N>(src);

        [MethodImpl(Inline)]
        public static BitVector<N> Define(in ReadOnlySpan<byte> src)
            => new BitVector<N>(src);

        [MethodImpl(Inline)]
        public static BitVector<N> Define(ref Span<byte> src)
            => new BitVector<N>(ref src);

        public static readonly int BitCount = nati<N>();     

        public static readonly int ByteCount = BitCount / 8;

        static readonly uint Exponent = (uint)new N().Exponent.value;

        Span<byte> bits;
        
        BitVector(in ReadOnlySpan<char> src)
        {
            Claim.eq(src.Length, ByteCount);
            bits = src.FromBitString(out bits);                 
        }
            
        BitVector(in ReadOnlySpan<BinaryDigit> src)
        {
            Claim.eq(src.Length, ByteCount);
            bits = src.FromDigits(out bits);
        }

        BitVector(in ReadOnlySpan<Bit> src)
        {
            Claim.eq(src.Length, ByteCount);
            bits = src.FromBits(out bits);
        }

        BitVector(in ReadOnlySpan<byte> src)
        {
            Claim.eq(src.Length, ByteCount);
            bits = src.Replicate();
        }

        BitVector(ref Span<byte> src)
        {
            Claim.eq(src.Length, ByteCount);
            bits = src;
        }
        
        [MethodImpl(Inline)]
        public static bool operator == (in BitVector<N> lhs, in BitVector<N> rhs) 
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (in BitVector<N> lhs, in BitVector<N> rhs) 
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N> operator & (in BitVector<N> lhs, in BitVector<N> rhs) 
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N> operator | (in BitVector<N> lhs, in BitVector<N> rhs) 
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N> operator ^ (in BitVector<N> lhs, in BitVector<N> rhs) 
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N> operator ~ (in BitVector<N> src) 
            => src.Flip();
                    
        [MethodImpl(Optimize)]
        BitVector<N> And(in BitVector<N> rhs)
        {
            for(var i =0; i < ByteCount; i++)
                bits[i] &= rhs.bits[i];
            return this;
        }

        [MethodImpl(Optimize)]
        BitVector<N> Or(in BitVector<N> rhs)
        {
            for(var i =0; i < ByteCount; i++)
                bits[i] |= rhs.bits[i];
            return this;
        }

        [MethodImpl(Optimize)]
        BitVector<N> XOr(in BitVector<N> rhs)
        {
            for(var i =0; i < ByteCount; i++)
                bits[i] ^= rhs.bits[i];
            return this;
        }

        [MethodImpl(Optimize)]
        BitVector<N> Flip()
        {
            for(var i =0; i < ByteCount; i++)
                bits[i] = (byte)(~ bits[i]);
            return this;
        }

        public Bit this[in int pos]
        {
            [MethodImpl(Inline)]
            get => TestBit(in pos);
                        
            [MethodImpl(Inline)]
            set => SetBit(in pos, in value);
        }

        /// <summary>
        /// Tests whether the bit in an specific position is set
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <param name="pos">The bit position to test</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        /// <returns>Returns true if the identified bit is set, false otherwise</returns>
        [MethodImpl(Inline)]
        public bool TestBit(in int pos)            
        {
            math.quorem(in pos, 8, out Quorem<int> qr);
            return test(bits[qr.Quotient], qr.Remainder);                
        }
        
        [MethodImpl(Inline)]
        public void EnableBit(in int pos)            
        {
            math.quorem(in pos, 8, out Quorem<int> qr);
            enable(ref bits[qr.Quotient], in qr.Remainder);
        }

        [MethodImpl(Inline)]
        public void DisableBit(in int pos)            
        {
            math.quorem(in pos, 8, out Quorem<int> qr);
            disable(ref bits[qr.Quotient], in qr.Remainder);
        }

        [MethodImpl(Inline)]
        public void SetBit(in int pos, in Bit value)
        {
            if(value)
                EnableBit(pos);
            else
                DisableBit(pos);
        }

        [MethodImpl(Inline)]
        public ulong PopCount()
            => bits.PopCount();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bits;

        [MethodImpl(Inline)]
        public string BitString()
            => bits.ToBitString();

        [MethodImpl(Inline)]
        public string Format()
            => BitString();

        [MethodImpl(Inline)]
        public bool Eq(in BitVector<N> rhs)
        {
            for(var i = 0; i< BitCount; i++)
                if(bits[i] != rhs.bits[i])
                    return false;
            return true;
        }  
        
        [MethodImpl(Inline)]
        public bool NEq(in BitVector<N> rhs)
            => !Eq(rhs);
 
        public override int GetHashCode()
            => throw unsupported(nameof(GetHashCode));

        public override bool Equals(object rhs)
            => throw unsupported(nameof(Equals));
    } 
}