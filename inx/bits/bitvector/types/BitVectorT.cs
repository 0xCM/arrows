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
        public static readonly BitSize SegCapacity = SizeOf<T>.BitSize;

        readonly Span<T> bits;
    
        readonly int MaxBitCount;

        readonly int SegLength;
    
        readonly BitPos<T>[] BitMap;

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly int Length;
            

        [MethodImpl(Inline)]
        public BitVector(Span<T> bits, uint? dim = null)
        {
            this.MaxBitCount = bits.Length * (int)SegCapacity;
            this.Length = (int)(dim ?? (uint)MaxBitCount);
            this.bits = bits;
            this.SegLength = BitGridLayout.MinSegmentCount<T>(MaxBitCount);            
            this.BitMap = BitGridLayout.BitMap<T>(MaxBitCount);
        }


        [MethodImpl(Inline)]
        public BitVector(ReadOnlySpan<T> bits, uint? dim = null)
            : this(bits.Replicate(),dim)
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
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector<T> lhs, in BitVector<T> rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitVector<T> operator +(BitVector<T> lhs, in BitVector<T> rhs)
            => new BitVector<T>(gbits.xor(in lhs.bits, rhs.bits));

        [MethodImpl(Inline)]
        public static BitVector<T> operator *(BitVector<T> lhs, in BitVector<T> rhs)
            => new BitVector<T>(gbits.and(in lhs.bits, rhs.bits));

        [MethodImpl(Inline)]
        public static BitVector<T> operator -(BitVector<T> src)
            => new BitVector<T>(gbits.flip(in src.bits));

        [MethodImpl(Inline)]
        public static BitVector<T> operator |(BitVector<T> lhs, in BitVector<T> rhs)
            => new BitVector<T>(gbits.or(in lhs.bits, rhs.bits));

        
        /// <summary>
        /// Retrieves the value of the bit at a specified position
        /// </summary>
        /// <param name="bit">The absolute bit position</param>
        [MethodImpl(Inline)]
        public Bit GetBit(in int bit)
        {
            ref readonly var pos = ref BitMap[bit];
            return gbits.test(in bits[pos.SegIdx], pos.BitOffset);
        }

        /// <summary>
        /// Returns a reference to the segment in which a specified bit is defined
        /// </summary>
        /// <param name="pos">The segmented bit position</param>
        [MethodImpl(Inline)]
        public ref T GetSegment(in BitPos<T> pos)
            => ref bits[pos.SegIdx];

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

        [MethodImpl(Inline)]
        public void SetBit(in BitPos<T> pos, Bit value)
            => gbits.set(ref bits[pos.SegIdx], pos.BitOffset, in value);


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
        

        T Extract(in BitPos<T> first, in BitPos<T> last, bool debug = false)
        {

            var sameSeg = first.SegIdx == last.SegIdx;
            var wantedCount = last - first;
            var firstCount = sameSeg ? wantedCount : (int)SegCapacity - first.BitOffset;
            var lastCount = wantedCount - firstCount;
            
            if(wantedCount > SegCapacity)
                throw new ArgumentException($"The total count {wantedCount} exceeds segment capacity of {SegCapacity}");

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
            gbits.toggle(ref bits[pos.SegIdx],  pos.BitOffset);
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
            => bits.ToBitString();

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
        public bool Eq(in BitVector<T> rhs)
            => bits.Identical(rhs.bits);
    
        [MethodImpl(Inline)]
        public bool NEq(in BitVector<T> rhs)
            => !bits.Identical(rhs.bits);
            
        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException(); 
    }

}
