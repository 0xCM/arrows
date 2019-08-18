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

    public struct BitVector<T> : IBitVector<T>
        where T : struct
    {

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length;

        readonly Memory<T> data;
    
        readonly BitSize MaxBitCount;

        readonly BitSize SegLength;
    
        readonly BitPos<T>[] BitMap;


        /// <summary>
        /// Specifies the number of bits that can be placed in one segment
        /// </summary>
        public static readonly BitSize SegmentCapacity = BitGridLayout.SegmentCapacity<T>();

        [MethodImpl(Inline)]
        public static BitVector<T> Load(Memory<T> data)
            => new BitVector<T>(data);    

        [MethodImpl(Inline)]
        public static BitVector<T> FromSegments(BitSize bitcount, params T[] src)
            => new BitVector<T>(new Memory<T>(src), bitcount);

        /// <summary>
        /// Creates a bitvector defined by an arbitrary number of segments
        /// </summary>
        /// <param name="src">The source segment</param>
        [MethodImpl(Inline)]
        public static BitVector<T> FromSegments(params T[] src)
            => new BitVector<T>(new Memory<T>(src));

        /// <summary>
        /// Creates a bitvector defined by a single segment
        /// </summary>
        /// <param name="src">The source segment</param>
        [MethodImpl(Inline)]
        public static BitVector<T> FromSegment(T src)
            => new BitVector<T>(src);

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector<T> lhs, in BitVector<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector<T> lhs, in BitVector<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitVector<T> operator +(BitVector<T> lhs, in BitVector<T> rhs)
            => new BitVector<T>(gbits.xor(in lhs.data, rhs.data));

        [MethodImpl(Inline)]
        public static BitVector<T> operator *(BitVector<T> lhs, in BitVector<T> rhs)
            => new BitVector<T>(gbits.and(lhs.data, rhs.data));

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator -(BitVector<T> src)
            => new BitVector<T>(gbits.flip(src.data));

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector<T> lhs, in BitVector<T> rhs)
            => lhs.Dot(rhs);

        [MethodImpl(Inline)]
        public BitVector(Memory<T> data, BitSize? bitcount = null)
        {            
            this.data = data;
            this.MaxBitCount = data.Span.Length * (int)SegmentCapacity;
            this.Length = (int)(bitcount ?? (uint)MaxBitCount);
            this.SegLength = BitGridLayout.MinSegmentCount<T>(MaxBitCount);            
            this.BitMap = BitGridLayout.BitMap<T>(MaxBitCount);
        }

        [MethodImpl(Inline)]
        BitVector(T segment)
        {            
            this.data = new T[]{segment};
            this.MaxBitCount = SegmentCapacity;
            this.Length = MaxBitCount;
            this.SegLength = MaxBitCount;
            this.BitMap = BitGridLayout.BitMap<T>(MaxBitCount);
        }

        [MethodImpl(Inline)]
        public BitVector(T[] data, BitSize? bitcount = null)
            : this(new Memory<T>(data), bitcount)
        {            
        }

        [MethodImpl(Inline)]
        public BitVector(ReadOnlySpan<T> bits, BitSize? bitcount = null)
            : this(new Memory<T>(bits.ToArray()),bitcount)
        {

        }

        readonly Span<T> Bits
        {
            [MethodImpl(Inline)]
            get => data.Span;
        }

        /// <summary>
        /// A bit-level accessor/manipulator
        /// </summary>
        public Bit this[BitPos index]
        {
            [MethodImpl(Inline)]
            get => GetBit(index);
            
            [MethodImpl(Inline)]
            set => SetBit(index, value);
        }

        /// <summary>
        /// Reads the value of an index-identified bit
        /// </summary>
        /// <param name="index">The absolute bit position</param>
        [MethodImpl(Inline)]
        public Bit GetBit(BitPos index)
        {
            ref readonly var pos = ref BitMap[index];
            return gbits.test(in Bits[pos.SegIdx], pos.BitOffset);
        }

        /// <summary>
        /// Sets the value of an identified bit
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        [MethodImpl(Inline)]
        public void SetBit(BitPos index, Bit value)
        {
            ref readonly var pos = ref BitMap[index];
            gbits.set(ref Bits[pos.SegIdx], pos.BitOffset, in value);
        }

        /// <summary>
        /// Tests the status of an identified bit
        /// </summary>
        /// <param name="bit">The position of the bit to test</param>
        [MethodImpl(Inline)]
        public bool Test(BitPos bit)
            => GetBit(bit);

        /// <summary>
        /// Enables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos bit)
            => SetBit(bit, Bit.On);

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(BitPos bit)
        {
            ref readonly var pos = ref BitMap[bit];
            gbits.disable(ref Bits[pos.SegIdx], pos.BitOffset);
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

        [MethodImpl(Inline)]
        public void Toggle(BitPos bit)
        {         
            ref readonly var pos = ref BitMap[bit];
            BitMaskG.toggle(ref Bits[pos.SegIdx],  pos.BitOffset);
        }

        [MethodImpl(Inline)]
        public T Between(BitPos first, BitPos last)
        {
            ref readonly var x = ref BitMap[first];
            ref readonly var y = ref BitMap[last];
            return Extract(in x, in y);
        }

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
            => BitString.FromScalars(Bits, Length); 

        /// <summary>
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public ulong Pop()
        {
            var count = 0ul;
            for(var i=0; i< Bits.Length; i++)
                count += gbits.pop(Bits[i]);
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
                Bits.Fill(primal.MaxVal);
            else
                Bits.Fill(primal.Zero);
        }

            
        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

        /// <summary>
        /// Returns a reference to the segment in which a specified bit is defined
        /// </summary>
        /// <param name="pos">The segmented bit position</param>
        [MethodImpl(Inline)]
        ref T GetSegment(in BitPos<T> pos)
            => ref Bits[pos.SegIdx];

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

        [MethodImpl(Inline)]
        public bool Equals(in BitVector<T> rhs)
            => ToBitString().Equals(rhs.ToBitString());

        public override bool Equals(object obj)
            => obj is BitVector<T> x ? Equals(x) : false;
        
        public override int GetHashCode()
            => ToBitString().GetHashCode();
    
        public override string ToString()
            => Format();
 
    }

}
