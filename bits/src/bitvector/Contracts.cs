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
    /// Characterizes a bitvector parametrized by the underlying
    /// storage type
    /// </summary>
    /// <typeparam name="T">The storage type</typeparam>
    public interface IBitVector<T> : IBitVector
        where T : struct
    {

    }

    public interface IPrimalBits<V,T> : IBitVector<T>, IEquatable<V>
        where T : struct
        where V : struct, IPrimalBits<V,T>
        
    {
        /// <summary>
        /// Returns the canonical scalar representation of the vector
        /// </summary>
        T ToScalar();

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        V Replicate();

        /// <summary>
        /// Applies a permutation to a replicated vector
        /// </summary>
        /// <param name="p">The permutation</param>
        V Replicate(Perm p);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        V Extract(T mask);

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        Bit Dot(V rhs);

        /// <summary>
        /// Shifts the bits in the vector leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        V ShiftL(byte offset);

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        V ShiftR(byte offset);
        
        /// <summary>
        /// Rotates vector bits rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        V RotR(byte offset);

        /// <summary>
        /// Rotates vector bits leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        V RotL(byte offset);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        V Between(BitPos first, BitPos last);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz"></param>
        /// <param name="specifier"></param>
        /// <param name="blockWidth"></param>
        string FormatBits(bool tlz, bool specifier, int? blockWidth);
 
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
    /// Characterizes a bitvector parametrized by its natural length and
    /// the underlying storage type 
    /// </summary>
    /// <typeparam name="T">The storage type</typeparam>
    public interface IBitVector<N,T> : IBitVector
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