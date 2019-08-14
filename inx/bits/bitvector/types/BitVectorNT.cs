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
    public ref struct BitVector<N,T>
        where N : ITypeNat, new()
        where T : struct
    {
        Span<T> bits;

        /// <summary>
        /// The maximum number of bits contained in a vector component
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public static readonly BitSize SegmentCapacity = BitGridLayout.SegmentCapacity<T>();

        public static readonly BitSize TotalBitCount = new N().value;

        static readonly int MaxBitIndex = TotalBitCount - 1;
    
        static readonly BitPos<T>[] BitMap = BitGridLayout.BitMap<T>(TotalBitCount);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<T>(BitVector<N,T> src)
            => new BitVector<T>(src.bits);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator +(BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => new BitVector<N,T>(gbits.xor(in lhs.bits, rhs.bits));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator *(BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => new BitVector<N,T>(gbits.and(in lhs.bits, rhs.bits));

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator -(BitVector<N,T> src)
            => new BitVector<N,T>(gbits.flip(in src.bits));                        

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => lhs.Dot(rhs);

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => lhs.NEq(rhs);

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
            this.bits = bits;
            require(bits.Length * SegmentCapacity >= TotalBitCount);
        }

        [MethodImpl(Inline)]
        public BitVector(ReadOnlySpan<T> bits)
            : this()
        {
            this.bits = bits.Replicate();
            require(bits.Length * SegmentCapacity >= TotalBitCount);
        }

        [MethodImpl(Inline)]
        public static BitVector<N,T> Define(params T[] src)
            => new BitVector<N,T>(src);    

        [MethodImpl(Inline)]
        static int CheckIndex(int index)
            => index >= 0 && index <= MaxBitIndex ? index  : Errors.ThrowOutOfRange<int>(index, 0, MaxBitIndex);

        /// <summary>
        /// Retrieves the value of the bit at a specified position
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        [MethodImpl(Inline)]
        public Bit GetBit(in int index)
        {
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            return gbits.test(in bits[pos.SegIdx], pos.BitOffset);
        }
            
        /// <summary>
        /// Sets the value of the bit at a specified position
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        [MethodImpl(Inline)]
        public void SetBit(in int index, Bit value)
        {
            ref readonly var pos = ref BitMap[CheckIndex(index)];
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
        /// Computes the scalar product between this vector and another
        /// </summary>
        /// <param name="rhs"></param>
        public Bit Dot(BitVector<N,T> rhs)
        {             
            //  var and = gbits.and(bits, rhs.bits);
            //  var pop = 0u;
            //  for(var i =0; i< and.Length; i++)
            //     pop += (uint)gbits.pop(and[i]);
            //  return Mod<N2>.mod(pop);               
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
            get => bits;
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public BitSize Length
        {
            [MethodImpl(Inline)]
            get => TotalBitCount;
        }

        [MethodImpl(Inline)]
        public void Toggle(in int index)
        {         
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            BitMaskG.toggle(ref bits[pos.SegIdx],  pos.BitOffset);
        }

        /// <summary>
        /// Enables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(in int index)
        {
            ref readonly var pos = ref BitMap[CheckIndex(index)];
            gbits.enable(ref bits[pos.SegIdx],  pos.BitOffset);
        }

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(in int index)
        {
            ref readonly var pos = ref BitMap[CheckIndex(index)];
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
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public ulong Pop()
        {
            var count = 0ul;
            for(var i=0; i < TotalBitCount; i++)
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

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => BitString.FromScalars(Bits, Length); 

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

        [MethodImpl(Inline)]
        public bool Equals(in BitVector<N,T> rhs)
            => ToBitString().Equals(rhs.ToBitString());

        [MethodImpl(Inline)]
        public bool NEq(in BitVector<N,T> rhs)
            => !Equals(rhs);
           
        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException(); 
    }
}