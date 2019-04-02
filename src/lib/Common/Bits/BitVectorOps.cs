//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;

    public ref struct FixedInt<N>
        where N: TypeNat<N>, new()
    {
        readonly Span<Byte> bits;

        public FixedInt(params Byte[] bits)
            => this.bits = bits;
    }

    partial struct BitVector<T> 
    {
        /// <summary>
        /// Turns off the rightmost nonzero bit, e.g.,
        /// 01110110 => 01110100
        /// </summary>
        public BitVector<T> rightmostOnToOff()
            => data & (data - One);

        /// <summary>
        /// Turns on the rightmost zero bit, e.g.,
        /// 01110111 => 01111111
        /// </summary>
        public BitVector<T> rightmostOffToOn()
            => data | (data + One);

        /// <summary>
        /// Turns off trailing nonzero bits, e.g.,
        /// 01110111 => 01110000
        /// </summary>
        public BitVector<T> trailingOnToOff()
            => data & (data + One);

        /// <summary>
        /// Turns on trailing zero bits, e.g.,
        /// 01111000 => 01111111
        /// </summary>
        public BitVector<T> trailingOffToOn()
            => data & (data + One);

        /// <summary>
        /// Tests whether the bit in an specific position is set
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <param name="pos">The bit position to test</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        /// <returns>Returns true if the identified bit is set, false otherwise</returns>
        [MethodImpl(Inline)]
        public BitVector<T> test(int pos)            
            => data & (One << pos);


    }

}