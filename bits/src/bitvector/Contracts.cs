//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    
    using static nfunc;

    /// <summary>
    /// Characterizes a bitvector
    /// </summary>
    public interface IBitVector
    {
        /// <summary>
        /// The maximum number of bits that can be represented by the vector
        /// </summary>
        BitSize Capacity {get;}

        /// <summary>
        /// The actual number of bits represented by the vector
        /// </summary>
        BitSize Length {get;}

        /// <summary>
        /// Returns true if all bits are disabled, false otherwise
        /// </summary>
        bool Empty {get;}

        /// <summary>
        /// Returns true if at least one bit is enabled, false otherwise
        /// </summary>
        bool Nonempty {get;}

        /// <summary>
        /// Counts vector's enabled bits
        /// </summary>
        BitSize Pop();

        /// <summary>
        /// Counts the vector's leading zero bits
        /// </summary>
        /// <param name="src">The bit source</param>
        BitSize Nlz();

        /// <summary>
        /// Counts the vector's trailing zero bits
        /// </summary>
        /// <param name="src">The bit source</param>
        BitSize Ntz();

        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        BitString ToBitString();

        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        void Permute(Perm p);

        /// <summary>
        /// Reverses the vector's bits in-place
        /// </summary>
        void Reverse();

        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        void Enable(BitPos pos);     
        
        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        void Disable(BitPos pos);

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        Bit Get(BitPos pos);

        /// <summary>
        /// Sets a bit value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        void Set(BitPos pos, Bit value);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        bool Test(BitPos pos);        

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        uint Rank(BitPos pos);

    }

    /// <summary>
    /// Characterizes a bitvector parametrized by the storage cell type
    /// </summary>
    /// <typeparam name="S">The storage type</typeparam>
    public interface IBitVector<V,S> : IBitVector
        where V : struct, IBitVector
        where S : struct
    {
        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        V Between(BitPos first, BitPos last);

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        V this[Range range] {get;}            

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        V this[BitPos first, BitPos last] {get;}

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        V Lsb(int n);
    
        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        V Msb(int n);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        V Replicate();

        /// <summary>
        /// Applies a permutation to a replicated vector
        /// </summary>
        /// <param name="p">The permutation</param>
        V Replicate(Perm p);

    }

    /// <summary>
    /// Characterizes a bitvector type that represents a fixed number of bits
    /// </summary>
    /// <typeparam name="V">The concrete type</typeparam>
    /// <typeparam name="S">The scalar type over which the bitvector is formed</typeparam>
    public interface IFixedBits<V,S> : IBitVector<V,S>, IEquatable<V>
        where V : unmanaged, IFixedBits<V,S>
        where S : struct        
    {
        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        S Scalar {get;}

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        V Gather(V mask);

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        Bit Dot(V rhs);

        /// <summary>
        /// Shifts the bits in the vector leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        V Sll(uint offset);

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        V Srl(uint offset);
        
        /// <summary>
        /// Rotates vector bits rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        V Ror(uint offset);

        /// <summary>
        /// Rotates vector bits leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        V Rol(uint offset);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz">True if leadzing zeros should be trimmed, false otherwise</param>
        /// <param name="specifier">True if the prefix specifier '0b' should be prepended</param>
        /// <param name="blockWidth">The width of the blocks, if any</param>
        string Format(bool tlz, bool specifier, int? blockWidth);
 
        /// <summary>
        /// Retrieves an index-identied segment (1 byte)
        /// </summary>
        /// <param name="index">The segment index</param>
        ref byte Byte(int index);

        /// <summary>
        /// Vector content represented as a bytespan
        /// </summary>
        Span<byte> Bytes {get;}
    }

    /// <summary>
    /// Characterizes a bitvector parametrized by its natural length and cell storage type
    /// </summary>
    /// <typeparam name="T">The storage type</typeparam>
    public interface INatBits<N,T> : IBitVector
        where N : ITypeNat, new()
        where T : struct
    {

    }

    public readonly struct BitVectorInfo
    {
        public static BitVectorInfo Define(BitSize capacity)
            => new BitVectorInfo(capacity);

        BitVectorInfo(BitSize capacity)
        {
            this.Capacity = capacity;
        }

        /// <summary>
        /// The maximum number of bits that can be represented by the vector
        /// </summary>
        public readonly BitSize Capacity;
    }

    public readonly struct BitVectorInfo<T>
        where T : struct
    {
        /// <summary>
        /// The maximum number of bits that can be represented by the vector
        /// </summary>
        public readonly BitSize Capacity;
    }

    public readonly struct BitVectorInfo<N,T>
        where N : ITypeNat, new()
        where T : struct
   {

        /// <summary>
        /// The maximum number of bits that can be represented by the vector
        /// </summary>
        public readonly BitSize Capacity
            => bitsize<T>() * nati<N>();
            
    }

}