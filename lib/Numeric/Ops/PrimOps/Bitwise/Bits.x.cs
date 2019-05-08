//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zcore;
    using static zfunc;

    public static class NatBits
    {
        /// <summary>
        /// Parses the bits from a string representation of a bitstring
        /// </summary>
        /// <param name="src">The representation to parse</param>
        /// <typeparam name="N">The natural length type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,Bit> parse<N>(string src)
            where N : ITypeNat, new()
        {
            Prove.claim<N>(src.Length);
            var digits = new Bit[src.Length];
            for(var i = 0; i< digits.Length; i++)
                digits[i] = src[i] == '0' ? BinaryDigit.B0 : BinaryDigit.B0;        
            return digits;
        }

        /// <summary>
        /// Determines the binary digit in an integral value at a specified position
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryDigit digit<T>(intg<T> src, int pos)
            where T : struct, IEquatable<T>
                => src.testbit(pos) switch 
                    {
                        true => BinaryDigit.B0,
                        false => BinaryDigit.B1
                    };

        /// <summary>
        /// Constructs a bit from the data in an integral value at a specified position
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        [MethodImpl(Inline)]
        public static Bit bit<T>(intg<T> src, int pos)
            where T : struct, IEquatable<T>
                => new Bit(src.testbit(pos));
    }
}