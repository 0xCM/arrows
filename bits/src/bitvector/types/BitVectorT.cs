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
    
        readonly CellIndex<T>[] BitMap;


        /// <summary>
        /// Specifies the number of bits that can be placed in one segment
        /// </summary>
        public static readonly BitSize SegmentCapacity = BitGrid.SegmentCapacity<T>();

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

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector<T> src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector<T> src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public BitVector(Memory<T> data, BitSize? bitcount = null)
        {            
            this.data = data;
            this.MaxBitCount = data.Span.Length * (int)SegmentCapacity;
            this.Length = (int)(bitcount ?? (uint)MaxBitCount);
            this.SegLength = BitGrid.MinSegmentCount<T>(MaxBitCount);            
            this.BitMap = BitGrid.BitMap<T>(MaxBitCount);
        }

        [MethodImpl(Inline)]
        BitVector(T segment)
        {            
            this.data = new T[]{segment};
            this.MaxBitCount = SegmentCapacity;
            this.Length = MaxBitCount;
            this.SegLength = MaxBitCount;
            this.BitMap = BitGrid.BitMap<T>(MaxBitCount);
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
            get => Get(index);
            
            [MethodImpl(Inline)]
            set => Set(index, value);
        }

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly Bit Get(BitPos pos)
        {
            ref readonly var cell = ref BitMap[pos];
            return gbits.test(in Bits[cell.Segment], cell.Offset);
        }

        /// <summary>
        /// Sets a bit value
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        /// <param name="value">The value the bit will receive</param>
        [MethodImpl(Inline)]
        public void Set(BitPos pos, Bit value)
        {
            ref readonly var cell = ref BitMap[pos];
            gbits.set(ref Bits[cell.Segment], cell.Offset, in value);
        }

        /// <summary>
        /// Tests the status of an identified bit
        /// </summary>
        /// <param name="bit">The position of the bit to test</param>
        [MethodImpl(Inline)]
        public bool Test(BitPos bit)
            => Get(bit);

        /// <summary>
        /// Enables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos bit)
            => Set(bit, Bit.On);

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(BitPos bit)
        {
            ref readonly var pos = ref BitMap[bit];
            gbits.disable(ref Bits[pos.Segment], pos.Offset);
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
            BitMaskG.toggle(ref Bits[pos.Segment],  pos.Offset);
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
        public readonly BitString ToBitString()
            => BitString.FromScalars(Bits, Length); 

        /// <summary>
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public readonly ulong Pop()
        {
            var count = 0ul;
            for(var i=0; i< Bits.Length; i++)
                count += gbits.pop(Bits[i]);
            return count;
        }

        /// <summary>
        /// The maximum number of bits that can be represented by the vector
        /// </summary>
        public readonly BitSize Capacity
        {
            [MethodImpl(Inline)]
            get => data.Span.Length * SegmentCapacity;
        }

        /// <summary>
        /// Returns true if no bits are enabled, false otherwise
        /// </summary>
        public bool Empty
        {
            [MethodImpl(Inline)]
            get => Pop() == 0;
        }

        /// <summary>
        /// Returns true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public readonly bool Nonempty
        {
            [MethodImpl(Inline)]
            get => Pop() != 0;
        }

        readonly BitSize IBitVector.Length 
        {
            [MethodImpl(Inline)]
            get => Length;
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
        public string FormatBits(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        /// <summary>
        /// Returns a reference to the segment in which a specified bit is defined
        /// </summary>
        /// <param name="pos">The segmented bit position</param>
        [MethodImpl(Inline)]
        ref T GetSegment(in CellIndex<T> pos)
            => ref Bits[pos.Segment];

        T Extract(in CellIndex<T> first, in CellIndex<T> last, bool describe = false)
        {

            var sameSeg = first.Segment == last.Segment;
            var wantedCount = last - first;
            var firstCount = sameSeg ? wantedCount : (int)SegmentCapacity - first.Offset;
            var lastCount = wantedCount - firstCount;
            
            if(wantedCount > SegmentCapacity)
                throw new ArgumentException($"The total count {wantedCount} exceeds segment capacity of {SegmentCapacity}");

            ref var seg1 = ref GetSegment(in first);
            var part1 = gbits.extract(in seg1, first.Offset, (byte)firstCount);
            
            if(sameSeg)
                return part1;

            ref var seg2 = ref GetSegment(in last);
            var part2 = gbits.extract(in seg2, 0, (byte)lastCount);            

            if(describe)
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
            => FormatBits();

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public uint Rank(BitPos pos)
            => throw new NotImplementedException();

        public void Permute(Perm p)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        BitSize IBitVector.Pop()
        {
            throw new NotImplementedException();
        }

        public BitSize Nlz()
        {
            throw new NotImplementedException();
        }

        public BitSize Ntz()
        {
            throw new NotImplementedException();
        }
    }

}
