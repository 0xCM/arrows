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

    public readonly ref struct BitVector<T>
        where T : struct
    {
        /// <summary>
        /// Specifies the number of bits that can be placed in one segment
        /// </summary>
        public static readonly BitSize SegmentCapacity = BitGridLayout.SegmentCapacity<T>();

        readonly Span<T> bits;
    
        readonly BitSize MaxBitCount;

        readonly BitSize SegLength;
    
        readonly BitPos<T>[] BitMap;

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly int Length;
            
        [MethodImpl(Inline)]
        public BitVector(Span<T> bits, BitSize? bitcount = null)
        {
            this.MaxBitCount = bits.Length * (int)SegmentCapacity;
            this.Length = (int)(bitcount ?? (uint)MaxBitCount);
            this.bits = bits;
            this.SegLength = BitGridLayout.MinSegmentCount<T>(MaxBitCount);            
            this.BitMap = BitGridLayout.BitMap<T>(MaxBitCount);
        }


        [MethodImpl(Inline)]
        public BitVector(ReadOnlySpan<T> bits, BitSize? bitcount = null)
            : this(bits.Replicate(),bitcount)
        {

        }

        [MethodImpl(Inline)]
        public static BitVector<T> Define(BitSize bitcount, params T[] src)
            => new BitVector<T>(src,bitcount);    

        [MethodImpl(Inline)]
        public static BitVector<T> Define(params T[] src)
            => new BitVector<T>(src);    

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector<T> lhs, in BitVector<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector<T> lhs, in BitVector<T> rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitVector<T> operator +(BitVector<T> lhs, in BitVector<T> rhs)
            => new BitVector<T>(gbits.xor(in lhs.bits, rhs.bits));

        [MethodImpl(Inline)]
        public static BitVector<T> operator *(BitVector<T> lhs, in BitVector<T> rhs)
            => new BitVector<T>(gbits.and(in lhs.bits, rhs.bits));

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator -(BitVector<T> src)
            => new BitVector<T>(gbits.flip(in src.bits));

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector<T> lhs, in BitVector<T> rhs)
            => lhs.Dot(rhs);
        
        /// <summary>
        /// Reads the value of an index-identified bit
        /// </summary>
        /// <param name="bit">The absolute bit position</param>
        [MethodImpl(Inline)]
        public Bit GetBit(in int bit)
        {
            ref readonly var pos = ref BitMap[bit];
            return gbits.test(in bits[pos.SegIdx], pos.BitOffset);
        }

        [MethodImpl(Inline)]
        public Bit GetBit(in BitPos<T> pos)
            => gbits.test(in bits[pos.SegIdx], pos.BitOffset);

        /// <summary>
        /// Sets the value of the bit at a specified position
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        [MethodImpl(Inline)]
        public void SetBit(in int bit, Bit value)
        {
            ref readonly var pos = ref BitMap[bit];
            gbits.set(ref bits[pos.SegIdx], pos.BitOffset, in value);
        }

        /// <summary>
        /// Sets the value of an identified bit
        /// </summary>
        /// <param name="pos">Identifies the bit to set</param>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public void SetBit(in BitPos<T> pos, Bit value)
            => gbits.set(ref bits[pos.SegIdx], pos.BitOffset, in value);

        /// <summary>
        /// Returns a reference to the segment in which a specified bit is defined
        /// </summary>
        /// <param name="pos">The segmented bit position</param>
        [MethodImpl(Inline)]
        public ref T GetSegment(in BitPos<T> pos)
            => ref bits[pos.SegIdx];

        /// <summary>
        /// A bit-level accessor/manipulator
        /// </summary>
        public Bit this[in int bit]
        {
            [MethodImpl(Inline)]
            get => GetBit(bit);
            
            [MethodImpl(Inline)]
            set => SetBit(bit, value);
        }
        
        /// <summary>
        /// Computes the scalar product between this vector and another of identical length
        /// </summary>
        /// <param name="rhs"></param>
        public Bit Dot(BitVector<T> rhs)
        {
            require(this.Length == rhs.Length);

            var result = Bit.Off;
            for(var i=0; i<Length; i++)
                result ^= this[i] & rhs[i];
            return result;
        }

        T Extract(in BitPos<T> first, in BitPos<T> last, bool debug = false)
        {

            var sameSeg = first.SegIdx == last.SegIdx;
            var wantedCount = last - first;
            var firstCount = sameSeg ? wantedCount : (int)SegmentCapacity - first.BitOffset;
            var lastCount = wantedCount - firstCount;
            
            if(wantedCount > SegmentCapacity)
                throw new ArgumentException($"The total count {wantedCount} exceeds segment capacity of {SegmentCapacity}");

            ref var seg1 = ref GetSegment(in first);
            var part1 = gbits.extract(in seg1, first.BitOffset, (byte)firstCount);
            
            if(sameSeg)
                return part1;

            ref var seg2 = ref GetSegment(in last);
            var part2 = gbits.extract(in seg2, 0, (byte)lastCount);            

            if(debug)
            {
                print($"first = {first}");
                print($"last = {last}");
                print($"totalCount = {wantedCount}");
                print($"firstCount = {firstCount}");
                print($"LastCount = {lastCount}");
            }
            gbits.shiftl(ref part2, firstCount);
            return gbits.or(ref part1, part2);              
        }

        public T Extract(int first, int last)
            => Extract(in BitMap[first], in BitMap[last]);
    

        [MethodImpl(Inline)]
        public void Toggle(in int bit)
        {         
            ref readonly var pos = ref BitMap[bit];
            BitMaskG.toggle(ref bits[pos.SegIdx],  pos.BitOffset);
        }

        /// <summary>
        /// Enables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(in int bit)
        {
            ref readonly var pos = ref BitMap[bit];
            gbits.enable(ref bits[pos.SegIdx], pos.BitOffset);
        }

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(in int bit)
        {
            ref readonly var pos = ref BitMap[bit];
            gbits.disable(ref bits[pos.SegIdx], pos.BitOffset);
        }

        /// <summary>
        /// Tests the status of an identified bit
        /// </summary>
        /// <param name="bit">The position of the bit to test</param>
        [MethodImpl(Inline)]
        public bool Test(in int bit)
            => GetBit(bit);

        /// <summary>
        /// Extracts the represented data as a span of bytes
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => MemoryMarshal.AsBytes(bits);

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => BitString.FromScalars(bits, Length); 

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

        /// <summary>
        /// Sets all the bits to align with the source value
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public void Fill(Bit value)
        {
            var primal = PrimalInfo.Get<T>();
            if(value)
                bits.Fill(primal.MaxVal);
            else
                bits.Fill(primal.Zero);
        }

        [MethodImpl(Inline)]
        public bool Equals(in BitVector<T> rhs)
            => ToBitString().Equals(rhs.ToBitString());
    
        [MethodImpl(Inline)]
        public bool NEq(in BitVector<T> rhs)
            => !Equals(rhs);
            
        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException(); 
    }

}
