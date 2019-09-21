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
    using static As;
    using static AsIn;
    using static FixedBitOps;

    public struct FixedBits<V,S>
        where V : unmanaged, IFixedBits<V,S>
        where S : unmanaged
    {   
        internal BitVector64 data;

        public static readonly FixedBits<V,S> Zero = default;

        [MethodImpl(Inline)]
        public static implicit operator V(FixedBits<V,S> src)
            => src.PrimalBits;

        [MethodImpl(Inline)]
        public static implicit operator FixedBits<V,S>(BitVector4 src)
            => new FixedBits<V, S>(src);

        [MethodImpl(Inline)]
        public static implicit operator FixedBits<V,S>(BitVector8 src)
            => new FixedBits<V, S>(src);

        [MethodImpl(Inline)]
        public static implicit operator FixedBits<V,S>(BitVector16 src)
            => new FixedBits<V, S>(src);

        [MethodImpl(Inline)]
        public static implicit operator FixedBits<V,S>(BitVector32 src)
            => new FixedBits<V, S>(src);

        [MethodImpl(Inline)]
        public static implicit operator FixedBits<V,S>(BitVector64 src)
            => new FixedBits<V, S>(src);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static FixedBits<V,S> operator &(in FixedBits<V,S> lhs, in FixedBits<V,S> rhs)
            => and(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static FixedBits<V,S> operator |(in FixedBits<V,S> lhs, in FixedBits<V,S> rhs)
            => or(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static FixedBits<V,S> operator ^(in FixedBits<V,S> lhs, in FixedBits<V,S> rhs)
            => xor(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The left vector</param>
        [MethodImpl(Inline)]
        public static FixedBits<V,S> operator ~(in FixedBits<V,S> src)
            => flip(in src);

        /// <summary>
        /// Applies a logical left-shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="rhs">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static FixedBits<V,S> operator <<(in FixedBits<V,S> src, int offset)
            => sll(in src,offset);

        /// <summary>
        /// Applies a logical left-shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="rhs">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static FixedBits<V,S> operator >>(in FixedBits<V,S> src, int offset)
            => srl(in src,offset);

        internal BitVector4 bv4
        {
            [MethodImpl(Inline)]
            get => data.bv4;

            [MethodImpl(Inline)]
            set => data.bv4 = value;
        }

        internal BitVector8 bv8
        {
            [MethodImpl(Inline)]
            get => data.bv8;

            [MethodImpl(Inline)]
            set => data.bv8 = value;
        }

        internal BitVector16 bv16
        {
            [MethodImpl(Inline)]
            get => data.bv16;

            [MethodImpl(Inline)]
            set => data.bv16 = value;
        }

        internal BitVector32 bv32
        {
            [MethodImpl(Inline)]
            get => data.bv32;
            
            [MethodImpl(Inline)]
            set => data.bv32 = value;
        }

        [MethodImpl(Inline)]
        internal FixedBits(UInt4 bv)
            : this()
        {
            this.bv4 = bv;
        }

        [MethodImpl(Inline)]
        internal FixedBits(byte bv)
            : this()
        {
            this.bv8 = bv;
        }

        [MethodImpl(Inline)]
        internal FixedBits(ushort bv)
            : this()
        {
            this.bv16 = bv;
        }

        [MethodImpl(Inline)]
        internal FixedBits(uint bv)
            : this()
        {
            this.bv32 = bv;
        }

        [MethodImpl(Inline)]
        internal FixedBits(ulong bv)
            : this()
        {
            this.data = bv;
        }

        [MethodImpl(Inline)]
        internal FixedBits(BitVector4 bv)
            : this()
        {
            this.bv4 = bv;
        }

        [MethodImpl(Inline)]
        internal FixedBits(BitVector8 bv)
            : this()
        {
            this.bv8 = bv;
        }

        [MethodImpl(Inline)]
        internal FixedBits(BitVector16 bv)
            : this()
        {
            this.bv16 = bv;
        }

        [MethodImpl(Inline)]
        internal FixedBits(BitVector32 bv)
            : this()
        {
            this.bv32 = bv;
        }

        [MethodImpl(Inline)]
        internal FixedBits(BitVector64 bv)
            : this()
        {
            this.data = bv;
        }

        /// <summary>
        /// The primal bitvector's scalar value
        /// </summary>
        public S Scalar
        {
            [MethodImpl(Inline)]
            get => scalar(in this);
        }

        /// <summary>
        /// The fixed-length primal bitvector upon which this parametric bitvector is predicated
        /// </summary>
        public V PrimalBits
        {
            [MethodImpl(Inline)]
            get => primalbits(in this);
        }

        [MethodImpl(Inline)]
        public static ref FixedBits<U,D> As<U,D>(ref FixedBits<V,S> src)
            where U : unmanaged, IFixedBits<U,D>
            where D : unmanaged            
                => ref Unsafe.As<FixedBits<V,S>, FixedBits<U,D>>(ref src);
    }
}