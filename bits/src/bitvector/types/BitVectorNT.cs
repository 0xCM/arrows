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

    /// <summary>
    /// Defines a natural bitvector parametrized by a primal component type
    /// </summary>
    /// <typeparam name="N">The vector length type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    public struct BitVector<N,T> : IBitVector<N,T>
        where N : ITypeNat, new()
        where T : struct
    {        
        Memory<T> data;
        
        /// <summary>
        /// The maximum number of bits contained in a vector component
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public static readonly BitSize SegmentCapacity = BitGrid.SegmentCapacity<T>();

        public static readonly BitSize TotalBitCount = new N().value;

        static readonly BitPos MaxBitIndex = TotalBitCount - 1;
    
        static readonly CellIndex<T>[] BitMap = BitGrid.BitMap<T>(TotalBitCount);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<T>(BitVector<N,T> src)
            => new BitVector<T>(src.data);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator +(BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => new BitVector<N,T>(gbits.xor(lhs.data, rhs.data));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator *(BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => new BitVector<N,T>(gbits.and(lhs.data, rhs.data));

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator -(BitVector<N,T> src)
            => new BitVector<N,T>(gbits.flip(src.data));                        

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => lhs.Dot(rhs);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector<N,T> src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector<N,T> src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BitVector(params T[] bits)
            : this()
        {
            this.data =bits;
            require(bits.Length * SegmentCapacity >= TotalBitCount);
        }

        [MethodImpl(Inline)]
        public BitVector(Memory<T> memory)
            : this()
        {
            this.data = memory;
            require(Bits.Length * SegmentCapacity >= TotalBitCount);
        }

        [MethodImpl(Inline)]
        public BitVector(Span<T> bits)
            : this()
        {
            this.data = bits.ToArray();
            require(bits.Length * SegmentCapacity >= TotalBitCount);
        }

        [MethodImpl(Inline)]
        public BitVector(ReadOnlySpan<T> bits)
            : this()
        {
            this.data = bits.ToArray();
            require(bits.Length * SegmentCapacity >= TotalBitCount);
        }

        [MethodImpl(Inline)]
        public static BitVector<N,T> Define(params T[] src)
            => new BitVector<N,T>(src);    


        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public Bit Get(BitPos pos)
        {
            ref readonly var cell = ref BitMap[CheckIndex(pos)];
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
            ref readonly var cell = ref BitMap[CheckIndex(pos)];
            gbits.set(ref Bits[cell.Segment], cell.Offset, in value);
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
        /// Computes the scalar product between this vector and another
        /// </summary>
        /// <param name="rhs">The other vector</param>
        public Bit Dot(BitVector<N,T> rhs)
        {             
            var result = Bit.Off;
            for(var i=0; i<Length; i++)
                result ^= this[i] & rhs[i];
            return result;
        }

        /// <summary>
        /// The data over which the bitvector is constructed
        /// </summary>
        public Span<T> Bits
        {
            [MethodImpl(Inline)]
            get => data.Span;
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length
        {
            [MethodImpl(Inline)]
            get => TotalBitCount;
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
        /// Toggles an index-identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Toggle(BitPos index)
        {         
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            BitMaskG.toggle(ref Bits[pos.Segment],  pos.Offset);
        }

        /// <summary>
        /// Enables an index-identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos index)
        {
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            gbits.enable(ref Bits[pos.Segment],  pos.Offset);
        }

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(BitPos index)
        {
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            gbits.disable(ref Bits[pos.Segment], pos.Offset);
        }

        /// <summary>
        /// Tests the status of an identified bit
        /// </summary>
        /// <param name="index">The position of the bit to test</param>
        [MethodImpl(Inline)]
        public bool Test(BitPos index)
            => Get(index);

        /// <summary>
        /// Extracts the represented data as a span of bytes
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => MemoryMarshal.AsBytes(Bits);

        /// <summary>
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public ulong Pop()
        {
            var count = 0ul;
            for(var i=0; i < TotalBitCount; i++)
                count += gbits.pop(Bits[i]);
            return count;
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
        public bool Nonempty
        {
            [MethodImpl(Inline)]
            get => Pop() != 0;
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

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => BitString.FromScalars(Bits, Length); 

        [MethodImpl(Inline)]
        public string FormatBits(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public bool Equals(in BitVector<N,T> rhs)
            => ToBitString().Equals(rhs.ToBitString());
           
        public override bool Equals(object obj)
            => obj is BitVector<N,T> x ? Equals(x) : false;
        
        public override int GetHashCode()
            => ToBitString().GetHashCode();
 
        public override string ToString()
            => FormatBits();

        [MethodImpl(Inline)]
        static int CheckIndex(BitPos index)
            =>  index <= MaxBitIndex ? index  : Errors.ThrowOutOfRange<BitPos>(index, 0, MaxBitIndex);

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