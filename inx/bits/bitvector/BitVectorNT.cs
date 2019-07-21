//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    

    public ref struct BitVector<N,T>
        where N : ITypeNat, new()
        where T : struct
    {
        Span<T> bits;

        public static readonly BitSize SegmentCapacity = BitLayout.SegmentCapacity<T>();

        public static readonly BitSize TotalBitCount = new N().value;
    
        static readonly BitPos<T>[] BitMap = BitLayout.BitMap<T>(TotalBitCount);

        [MethodImpl(Inline)]
        public BitVector(params T[] bits)
            : this()
        {
            this.bits =bits;
            require(bits.Length * SegmentCapacity >= TotalBitCount);
        }

        [MethodImpl(Inline)]
        public BitVector(Span<T> bits)
            : this()
        {
            this.bits =bits;
            require(bits.Length * SegmentCapacity >= TotalBitCount);
        }

        [MethodImpl(Inline)]
        public BitVector(ReadOnlySpan<T> bits)
            : this()
        {
            this.bits =bits.Replicate();
            require(bits.Length * SegmentCapacity >= TotalBitCount);
        }

        [MethodImpl(Inline)]
        public static BitVector<N,T> Define(params T[] src)
            => new BitVector<N,T>(src);    

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static Bit operator *(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => (lhs & rhs).Pop() != 0;

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator |(BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => new BitVector<N,T>(gbits.or(in lhs.bits, rhs.bits));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator &(BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => new BitVector<N,T>(gbits.and(in lhs.bits, rhs.bits));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ^(BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => new BitVector<N,T>(gbits.xor(in lhs.bits, rhs.bits));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ~(BitVector<N,T> src)
            => new BitVector<N,T>(gbits.flip(in src.bits));
        
        /// <summary>
        /// Retrieves the value of the bit at a specified position
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        [MethodImpl(Inline)]
        public Bit GetBit(in int index)
        {
            ref readonly var pos = ref BitMap[index];
            return gbits.test(in bits[pos.SegIdx], pos.BitOffset);
        }
            
        /// <summary>
        /// Sets the value of the bit at a specified position
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        [MethodImpl(Inline)]
        public void SetBit(in int index, Bit value)
        {
            ref readonly var pos = ref BitMap[index];
            gbits.set(ref bits[pos.SegIdx], pos.BitOffset, in value);
        }

        /// <summary>
        /// A bit-level accessor/manipulator
        /// </summary>
        public Bit this[in int index]
        {
            [MethodImpl(Inline)]
            get => GetBit(index);
            
            [MethodImpl(Inline)]
            set => SetBit(index, value);
        }

        /// <summary>
        /// The data over which the bitvector is constructed
        /// </summary>
        Span<T> Bits
        {
            [MethodImpl(Inline)]
            get => bits;
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public int Length
            => TotalBitCount;

        [MethodImpl(Inline)]
        public void Toggle(in int index)
        {         
            ref readonly var pos = ref BitMap[index];
            gbits.toggle(ref bits[pos.SegIdx],  pos.BitOffset);
        }

        /// <summary>
        /// Enables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(in int index)
        {
            ref readonly var pos = ref BitMap[index];
            gbits.enable(ref bits[pos.SegIdx],  pos.BitOffset);
        }

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(in int index)
        {
            ref readonly var pos = ref BitMap[index];
            gbits.disable(ref bits[pos.SegIdx], pos.BitOffset);
        }

        /// <summary>
        /// Tests the status of an identified bit
        /// </summary>
        /// <param name="index">The position of the bit to test</param>
        [MethodImpl(Inline)]
        public bool Test(in int index)
            => GetBit(index);

        /// <summary>
        /// Extracts the represented data as a span of bytes
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => MemoryMarshal.AsBytes(Bits);

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => Bits.ToBitString();

        /// <summary>
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public ulong Pop()
        {
            var count = 0ul;
            for(var i=0; i< bits.Length; i++)
                count += gbits.pop(bits[i]);
            return count;
        }

        [MethodImpl(Inline)]
        public bool Eq(in BitVector<N,T> rhs)
            => bits.Eq(rhs.bits);

        [MethodImpl(Inline)]
        public bool NEq(in BitVector<N,T> rhs)
            => !bits.Eq(rhs.bits);
            
        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException(); 
    }
}