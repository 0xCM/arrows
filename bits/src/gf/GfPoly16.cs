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
        
        [MethodImpl(Inline)]
        public static implicit operator ushort(GfPoly16 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(GfPoly16 src)
            => src.ToBitVector();

        [MethodImpl(Inline)]
        public GfPoly16(params byte[] exponents)
        {
            data = Gf.Poly<ushort>(exponents);
            degree = exponents.Length != 0 ? exponents[0] : (byte)0;
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

        [MethodImpl(Inline)]
        public BitVector16 ToBitVector()
            => data;

        /// <summary>
        /// Formats the polynomial as a binary number
        /// </summary>
        public string Format()
            => BitString.FromScalar(data).Format(true);
    }
}