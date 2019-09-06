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

    /// <summary>
    /// Represents a base-2 polynomial of degree at most N = 15. The represented polynomial is of the form
    /// a_i * x^i + . . . a_1 * x^1 + a_0 * x^0 where  a_i = 0 | 1 and i = 0..N
    /// </summary>
    public readonly struct GfPoly16
    {
        readonly ushort data;
        
        readonly byte degree;

        public static readonly GfPoly16 Zero = default;

        public static GfPoly16 FromExponents(params byte[] exponents)
            => new GfPoly16(exponents);

        public static GfPoly16 FromScalar(ushort data)
            => new GfPoly16(data);

        [MethodImpl(Inline)]
        public static implicit operator ushort(GfPoly16 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(GfPoly16 src)
            => src.ToBitVector();
        
        [MethodImpl(Inline)]
        public static implicit operator BitVector<N9,ushort>(GfPoly16 src)
            => src.ToNatVec();

        [MethodImpl(Inline)]
        public static implicit operator GfPoly<N9,ushort>(GfPoly16 src)
            => src.ToNatPoly();

        [MethodImpl(Inline)]
        public GfPoly16(params byte[] exponents)
        {
            data = Gf.Poly<ushort>(exponents);
            degree = exponents.Length != 0 ? exponents[0] : (byte)0;
        }

        [MethodImpl(Inline)]
        public GfPoly16(ushort data)
        {
            this.data = data;
            this.degree = math.sub((byte)15,Bits.nlz(data));
        }

        /// <summary>
        /// Returns a bit indicating whether the coefficient for x^i is 1 or 0
        /// </summary>
        public Bit this[int i]
        {
            [MethodImpl(Inline)]
            get => gbits.test(data,i);
        }

        /// <summary>
        /// Returns the scalar representation of the polynomial
        /// </summary>
        public ushort Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The degree (N) of the polynomial
        /// </summary>
        public byte Degree
        {
            [MethodImpl(Inline)]
            get => degree;
        }

        /// <summary>
        /// Specfies whether the polynomial is the zero polynomial
        /// </summary>
        public bool Nonzero
        {
            [MethodImpl(Inline)]
            get => !gmath.nonzero(data);
        }

        /// <summary>
        /// Converts the polynomial to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 ToBitVector()
            => data;

        /// <summary>
        /// Converts the polynomial to a representation with natural degree
        /// </summary>
        [MethodImpl(Inline)]
        public GfPoly<N9,ushort> ToNatPoly()
            => new GfPoly<N9, ushort>(data);

        /// <summary>
        /// Converts the polynomial to a bitvector with natural length equal to the degree
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector<N9,ushort> ToNatVec()
            => new BitVector<N9, ushort>(data);
        
        /// <summary>
        /// Formats the polynomial
        /// </summary>
        public string Format()
            => ToNatPoly().Format();
    }
}