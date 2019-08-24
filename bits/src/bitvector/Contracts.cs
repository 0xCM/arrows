//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static zfunc;    
    using static nfunc;

    /// <summary>
    /// Characterizes a bitvector
    /// </summary>
    public interface IBitVector
    {
        
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

    public interface IPrimalBitVector<T> : IBitVector<T>
        where T : struct
    {
        /// <summary>
        /// Returns the canonical scalar representation of the vector
        /// </summary>
        T ToScalar();
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
        /// The number of bits enclosed by the vector
        /// </summary>
        public readonly BitSize Capacity;
    }

    public readonly struct BitVectorInfo<T>
        where T : struct
    {
        /// <summary>
        /// The number of bits enclosed by the vector
        /// </summary>
        public readonly BitSize Capacity;
    }

    public readonly struct BitVectorInfo<N,T>
        where N : ITypeNat, new()
        where T : struct
   {

        /// <summary>
        /// The number of bits enclosed by the vector
        /// </summary>
        public readonly BitSize Capacity
            => bitsize<T>() * nati<N>();
            
    }

}