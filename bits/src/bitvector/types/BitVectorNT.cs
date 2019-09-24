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

    public readonly struct BitVectorProxy<N,T>
        where T : unmanaged
        where N : ITypeNat, new()
    {
        readonly T[] data;

        [MethodImpl(Inline)]
        public static BitVectorProxy<N,T> From(in BitVector<N,T> src)
            => new BitVectorProxy<N,T>(src);
        
        [MethodImpl(Inline)]
        public static implicit operator BitVectorProxy<N,T>(in BitVector<N,T> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N,T>(BitVectorProxy<N,T> src)
            => src.BitVector;
        
        [MethodImpl(Inline)]
        public BitVectorProxy(in BitVector<N,T> src)
        {
            data = src.Data.ToArray();
        }

        /// <summary>
        /// The subject of the proxy, in this case a T-bitvector
        /// </summary>
        public BitVector<N,T> BitVector
        {
            [MethodImpl(Inline)]
            get => BitVector<N,T>.LoadUnchecked(data);
        }

    }

    /// <summary>
    /// Defines a natural bitvector parametrized by a primal component type
    /// </summary>
    /// <typeparam name="N">The vector length type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    public ref struct BitVector<N,T> //: INatBits<N,T>
        where N : ITypeNat, new()
        where T : unmanaged
    {        
        Span<T> data;
        
        /// <summary>
        /// The maximum number of bits contained in a vector component
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public static readonly BitSize SegmentCapacity = bitsize<T>();

        public static readonly BitSize TotalBitCount = new N().value;

        static readonly BitPos MaxBitIndex = TotalBitCount - 1;
    
        static readonly CellIndex<T>[] BitMap = BitSize.BitMap<T>(TotalBitCount);

        /// <summary>
        /// The minimum number of cells of type T required to store N bits
        /// </summary>
        public static int CellCount = TotalBitCount/SegmentCapacity + (TotalBitCount % SegmentCapacity == 0 ? + 0 : + 1);

        [MethodImpl(Inline)]
        public static BitVector<N,T> Alloc(T? fill = null)
        {
            Span<T> cells = new T[CellCount];
            if(fill.HasValue)
                cells.Fill(fill.Value);
            return new BitVector<N,T>(cells);
        }

        [MethodImpl(Inline)]
        internal static BitVector<N,T> LoadUnchecked(T[] src)
            => new BitVector<N,T>(src,true);

        [MethodImpl(Inline)]
        internal static BitVector<N,T> LoadUnchecked(Span<T> src)
            => new BitVector<N,T>(src,true);

        [MethodImpl(Inline)]
        public static BitVector<N,T> FromCell(T src)
            => new BitVector<N, T>(src);        
        
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load(params T[] src)
            => new BitVector<N,T>(src);    

        [MethodImpl(Inline)]
        public static BitVector<N,T> Load(Span<T> src)
            => new BitVector<N,T>(src);    

        [MethodImpl(Inline)]
        public static implicit operator BitVector<T>(BitVector<N,T> src)
            => BitVector<T>.Load(src.data);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ^(BitVector<N,T> lhs, BitVector<N,T> rhs)
            => new BitVector<N,T>(gbitspan.xor(lhs.data, rhs.data));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator &(BitVector<N,T> lhs, BitVector<N,T> rhs)
            => new BitVector<N,T>(gbitspan.and(lhs.data, rhs.data));

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(BitVector<N,T> lhs, BitVector<N,T> rhs)
            => lhs.Dot(rhs);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ~(BitVector<N,T> src)
            => new BitVector<N,T>(gbitspan.flip(src.data));                        

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
        BitVector(Span<T> src)
            : this()
        {
            require(src.Length * SegmentCapacity >= TotalBitCount);
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitVector(params T[] src)
            : this(src.AsSpan())
        {

        }

        [MethodImpl(Inline)]
        BitVector(Span<T> src,bool skipChecks)
            : this()
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitVector(T[] src, bool skipChecks)
        {
            this.data = src;
        }

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public Bit Get(BitPos pos)
        {
            ref readonly var cell = ref BitMap[CheckIndex(pos)];
            return gbits.test(in Data[cell.Segment], cell.Offset);
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
            gbits.set(ref Data[cell.Segment], cell.Offset, in value);
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
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsBytes();
        }

        /// <summary>
        /// Returns a proxy that can be used where ref structs can't, but it's not free
        /// </summary>
        public readonly BitVectorProxy<N,T> Proxy
        {
            [MethodImpl(Inline)]
            get => this;
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
            get => data.Length * SegmentCapacity;
        }

        /// <summary>
        /// Toggles an index-identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Toggle(BitPos index)
        {         
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            BitMaskG.toggle(ref Data[pos.Segment],  pos.Offset);
        }

        /// <summary>
        /// Enables an index-identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos index)
        {
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            gbits.enable(ref Data[pos.Segment],  pos.Offset);
        }

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(BitPos index)
        {
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            gbits.disable(ref Data[pos.Segment], pos.Offset);
        }

        /// <summary>
        /// Tests the status of an identified bit
        /// </summary>
        /// <param name="index">The position of the bit to test</param>
        [MethodImpl(Inline)]
        public bool Test(BitPos index)
            => Get(index);

        /// <summary>
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Pop()
        {
            var count = 0u;
            for(var i=0; i < TotalBitCount; i++)
                count += gbits.pop(Data[i]);
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
                Data.Fill(primal.MaxVal);
            else
                Data.Fill(primal.Zero);
        }

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => BitString.FromScalars<T>(Data, Length); 

        [MethodImpl(Inline)]
        public string FormatBits(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public bool Equals(in BitVector<N,T> rhs)
            => ToBitString().Equals(rhs.ToBitString());
           
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

        public BitSize Nlz()
        {
            throw new NotImplementedException();
        }

        public BitSize Ntz()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
            => throw new NotImplementedException();
        
        public override int GetHashCode()
            => throw new NotImplementedException();
 
        public override string ToString()
            => throw new NotImplementedException();

    }
}