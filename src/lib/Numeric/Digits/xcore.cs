//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;

    using static zcore;


    partial class xcore
    {
        /// <summary>
        /// Converts a binary digit to a generic digit in base 2
        /// </summary>
        /// <param name="src">The source digit</param>
        public static Digit<N2,BinaryDigit> ToDigitG(this BinaryDigit src)
            => Digit.define(src,Nats.N2);

        /// <summary>
        /// Converts a generic integer to a stream of decimal digts
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        public static IEnumerable<DecimalDigit> ToDecimalDigits<T>(this intg<T> src)
            where T : struct, IEquatable<T>    
                =>  DecimalDigits.parse(src.format());

        /// <summary>
        /// Converts a generic integer to a stream of generic digts in base 10
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        public static IEnumerable<Digit<N10,DecimalDigit>> ToDecimalDigitsG<T>(this intg<T> src)
            where T : struct, IEquatable<T>    
                =>  map(DecimalDigits.parse(src.format()), d => Digit.define(d,Nats.N10));

        /// <summary>
        /// Converts a generic integer to a stream of generic digts in base 10
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        public static IEnumerable<Digit<N2,BinaryDigit>> ToBinaryDigitsG<T>(this intg<T> src)
            where T : struct, IEquatable<T>    
                => map(src.bitstring().bits,b => Digit.define( b ? BinaryDigit.One : BinaryDigit.Zero, Nats.N2));

        /// <summary>
        /// Converts a decimal digit to a generic digit in base 10
        /// </summary>
        /// <param name="src">The source digit</param>
        public static Digit<N10,DecimalDigit> ToDigitG(this DecimalDigit src)
            => Digit.define(src,Nats.N10);

        /// <summary>
        /// Converts a hex digit to a generic digit in base 16
        /// </summary>
        /// <param name="src">The soruce digit</param>
        public static Digit<N16,HexDigit> ToDigitG(this HexDigit src)
            => Digit.define(src,Nats.N16);
    }
}