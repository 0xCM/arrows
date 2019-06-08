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
    using System.Text;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;
    using static Bits;

    /// <summary>
    /// Defines an integrally typed vector of natural length
    /// </summary>
    public ref struct BitVector<N,T> 
        where T : struct
        where N : INatPow2, new()
    {
        Span<N,T> data;

        [MethodImpl(Inline)]
        public static BitVector<N,T> Load(ref T src)
            => new BitVector<N,T>(ref src);

        [MethodImpl(Inline)]
        public static BitVector<N,T> Define(ref Span<N,T> src)
            => new BitVector<N,T>(ref src);

        [MethodImpl(Inline)]
        public static BitVector<N,T> Define(in ReadOnlySpan<T> src)
            => new BitVector<N,T>(src);

        /// <summary>
        /// Specifies the length of the vector, i.e. its component count
        /// </summary>
        public static readonly int Length = nati<N>();     

        /// <summary>
        /// Specifies the number of bytes required to store a single component
        /// </summary>
        public static readonly ByteSize ComponentSize = SizeOf<T>.Size;

        /// <summary>
        /// Specifies the component size in bits
        /// </summary>
        public static readonly int ComponentBits = SizeOf<T>.BitSize;

        /// <summary>
        /// Specifies the number of bytes required to store the entire vector
        /// </summary>
        public static readonly ByteSize DataSize = Length * ComponentSize;

        /// <summary>
        /// Specifies the data size in bits
        /// </summary>
        public static readonly BitSize BitCount = DataSize.Bytes * 8;
        

        [MethodImpl(Inline)]
        BitVector(ref T src)
        {
            data =  NatSpan.load<N,T>(ref src);  
            require(data.Length == Length);
        }

        [MethodImpl(Inline)]
        BitVector(in ReadOnlySpan<N,T> src)
        {
            require(src.Length == Length);
            data = NatSpan.replicate(src);
        }

        [MethodImpl(Inline)]
        BitVector(in ReadOnlySpan<T> src)
        {
            require(src.Length == Length);
            data = NatSpan.replicate<N,T>(src);
        }

        [MethodImpl(Inline)]
        BitVector(ref Span<N,T> src)
        {
            require(src.Length == Length);
            data = src;
        }
        
        [MethodImpl(Inline)]
        public static bool operator == (in BitVector<N,T> lhs, in BitVector<N,T> rhs) 
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (in BitVector<N,T> lhs, in BitVector<N,T> rhs) 
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator & (in BitVector<N,T> lhs, in BitVector<N,T> rhs) 
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator | (in BitVector<N,T> lhs, in BitVector<N,T> rhs) 
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ^ (in BitVector<N,T> lhs, in BitVector<N,T> rhs) 
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator << (in BitVector<N,T> lhs, int shift) 
            => lhs.ShiftL(shift);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator >> (in BitVector<N,T> lhs, int shift) 
            => lhs.ShiftR(shift);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ~ (in BitVector<N,T> src) 
            => src.Flip();
                    
        BitVector<N,T> And(in BitVector<N,T> rhs)
        {
            for(var i =0; i < Length; i++)
                gmath.and(ref data[i], rhs.data[i]);
            return this;
        }

        BitVector<N,T> Or(in BitVector<N,T> rhs)
        {
            for(var i =0; i < Length; i++)
                gmath.or(ref data[i], rhs.data[i]);
            return this;
        }

        BitVector<N,T> XOr(in BitVector<N,T> rhs)
        {
            for(var i =0; i < Length; i++)
                gmath.xor(ref data[i], rhs.data[i]);
            return this;
        }

        BitVector<N,T> ShiftL(int shift)
        {
            for(var i =0; i < Length; i++)
                gmath.shiftl(ref data[i], shift);
            return this;
        }

        BitVector<N,T> ShiftR(int shift)
        {
            for(var i =0; i < Length; i++)
                gmath.shiftr(ref data[i], shift);
            return this;
        }

        BitVector<N,T> Flip()
        {
            for(var i =0; i < Length; i++)
                gmath.flip(ref data[i]);
            return this;
        }

        public Bit this[in int pos]
        {
            [MethodImpl(Inline)]
            get => TestBit(in pos);
                        
            [MethodImpl(Inline)]
            set => SetBit(in pos, in value);
        }

        public ref T Component(int index)
            => ref data[index];

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
            math.quorem(in pos, ComponentBits, out Quorem<int> qr);
            return gbits.test(data[qr.Quotient], qr.Remainder);                
        }
        
        [MethodImpl(Inline)]
        public void EnableBit(in int pos)            
        {
            math.quorem(in pos, ComponentBits, out Quorem<int> qr);
            gbits.enable(ref data[qr.Quotient], in qr.Remainder);
        }

        [MethodImpl(Inline)]
        public void DisableBit(in int pos)            
        {
            math.quorem(in pos, ComponentBits, out Quorem<int> qr);
            gbits.disable(ref data[qr.Quotient], in qr.Remainder);
        }

        [MethodImpl(Inline)]
        public void SetBit(in int pos, in Bit value)
        {
            if(value)
                EnableBit(pos);
            else
                DisableBit(pos);
        }

        public Span<byte> Bytes()
            => data.Bytes();

        public ulong PopCount()
        {
            var count = 0ul;
            for(var i=0; i< Length; i++)
                count += gbits.pop(data[i]);
            return count;
        }        

        public string BitString()
        {
            var bs = new string[Length];
            for(var i = 0; i< Length; i++)
                bs[Length - i] = gbits.bitstring(data[i]);
            return bs.Concat(string.Empty);
        }
            
        public bool Eq(in BitVector<N,T> rhs)
        {
            for(var i = 0; i< Length; i++)
                if(gmath.neq(data[i], rhs.data[i]))
                    return false;
            return true;
        }  

        [MethodImpl(Inline)]
        public string Format()
            => BitString();

        [MethodImpl(Inline)]
        public bool NEq(in BitVector<N,T> rhs)
            => !Eq(rhs);
 
        public override int GetHashCode()
            => throw unsupported(nameof(GetHashCode));

        public override bool Equals(object rhs)
            => throw unsupported(nameof(Equals));
    } 
}