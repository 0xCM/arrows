//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;


    partial class Structures
    {
        public interface BitString :  Formattable, Lengthwise
        {
            

        }
        
        public interface BitString<S> : BitString, FreeMonoid<S>
            where S : BitString<S>, new()
        {


        }

        public interface BitString<S,N> : BitString<S>
            where S : BitString<S,N>, new()
            where N : TypeNat, new()
        {


        }

    }

    public readonly struct BitString : Structures.BitString<BitString>
    {
        [MethodImpl(Inline)]   
        public static BitString Parse(string src)
            => new BitString(src);

        public static readonly BitString Empty = default;

        [MethodImpl(Inline)]   
        public static BitString define(IEnumerable<bit> src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString defineG<T>(intg<T> src)
        {
            var len = (int)src.bitsize;
            var bits = new bit[len];
            for(var i = 0; i < len; i++)
                bits[i] = src.testbit(i);
            return new BitString(bits);
        }

        [MethodImpl(Inline)]   
        public static BitString define(byte src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(sbyte src)
            => new BitString(src);


        [MethodImpl(Inline)]   
        public static BitString define(short src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(ushort src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(int src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(uint src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(long src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(ulong src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(double src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(decimal src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(float src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(BigInteger src)
            => new BitString(src);

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(byte src)
            => lpadZ(Convert.ToString(src,2), primops.bitsize<byte>());

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(sbyte src)
            => lpadZ(Convert.ToString(src,2), primops.bitsize<sbyte>());

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(short src)
            => lpadZ(Convert.ToString(src,2), primops.bitsize<short>());

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(ushort src)
            => lpadZ(Convert.ToString(src,2), primops.bitsize<ushort>());

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(int src)
            => lpadZ(Convert.ToString(src,2), primops.bitsize<int>());
        
        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(uint src)
            => lpadZ(Convert.ToString(src,2), primops.bitsize<uint>());

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(long src)
            => lpadZ(Convert.ToString(src,2), primops.bitsize<long>());

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(ulong src)
            => apply(Bits.split(src), parts 
                => bitchars(parts.hi) + bitchars(parts.lo));

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(double src)
            => lpadZ(Convert.ToString(BitConverter.DoubleToInt64Bits(src), 2), primops.bitsize<long>());

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(float src)
            => lpadZ(Convert.ToString(BitConverter.SingleToInt32Bits(src), 2), primops.bitsize<int>());

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(decimal src)
            => zcore.apply(Bits.split(src), 
                parts => bitchars(parts.hihi) + bitchars(parts.hilo)
                    + bitchars(parts.lohi) + bitchars(parts.lolo));

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// <remarks>
        /// Taken from https://stackoverflow.com/questions/14048476/biginteger-to-hex-decimal-octal-binary-strings
        /// </remarks>
        public static string bitchars(BigInteger x)
        {
            var bytes = x.ToByteArray();
            var idx = bytes.Length - 1;

            // Create a StringBuilder having appropriate capacity.
            var base2 = new StringBuilder(bytes.Length * 8);

            // Convert first byte to binary.
            var binary = Convert.ToString(bytes[idx], 2);

            // Ensure leading zero exists if value is positive.
            if (binary[0] != '0' && x.Sign == 1)
                base2.Append('0');

            // Append binary string to StringBuilder.
            base2.Append(binary);

            // Convert remaining bytes adding leading zeros.
            for (idx--; idx >= 0; idx--)
                base2.Append(Convert.ToString(bytes[idx], 2).PadLeft(8, '0'));

            return base2.ToString().Substring(1);
        }


        [MethodImpl(Inline)]
        public static BitString operator + (BitString lhs, BitString rhs) 
            => lhs.concat(rhs);

        public Slice<bit> bits {get;}

        public BitString zero 
            => Empty;


        [MethodImpl(Inline)]
        public bool nonzero()
            => bits.length != 0;


        [MethodImpl(Inline)]
        public BitString(params bit[] src)
            => this.bits = src;

        [MethodImpl(Inline)]
        public BitString(Slice<bit> src)
            => this.bits = src;

        [MethodImpl(Inline)]
        public BitString(IEnumerable<bit> src)
            => this.bits = slice(src);

        [MethodImpl(Inline)]
        static Slice<bit> parse(string src)
            => slice(map(src,c => bit.Parse(c)));

        [MethodImpl(Inline)]
        public BitString(byte src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(sbyte src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(short src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(ushort src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(int src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(uint src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(long src)
            => bits = parse(bitchars(src));
        
        [MethodImpl(Inline)]
        public BitString(ulong src)
            => bits = parse(bitchars(src));
                                                       
        [MethodImpl(Inline)]
        public BitString(double src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(decimal src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(float src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(BigInteger src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(string src)
            => bits = slice(map(src,c => bit.Parse(c)));

        [MethodImpl(Inline)]
        public BitString concat(BitString rhs)
            => new BitString(bits + rhs.bits);

        [MethodImpl(Inline)]
        public bool eq(BitString rhs)
            => bits.eq(rhs.bits);

        [MethodImpl(Inline)]
        public bool eq(BitString lhs, BitString rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(BitString rhs)
            => this.eq(rhs);

        [MethodImpl(Inline)]
        public bool neq(BitString rhs)
            => bits.neq(rhs.bits);

        [MethodImpl(Inline)]
        public bool neq(BitString lhs, BitString rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public string format()
            => string.Concat(map(bits,b =>  b.format()));

        [MethodImpl(Inline)]
        public int hash()
            => bits.hash();

        public uint length
            => bits.length;

        public override string ToString()
            => format();

        public override int GetHashCode()
            => hash();


    }

 
    partial class xcore
    {
        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this byte src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this sbyte src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this short src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this ushort src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this int src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this uint src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this long src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this ulong src)
            => primops.bitstring(src);

        /// <summary>
        /// Consructs a bitstring from a stream of bool
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this IEnumerable<bool> src)
            => BitString.define(src.ToBits());

        /// <summary>
        /// Consructs a bitstring from bitslice
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this Slice<bit> src)
            => BitString.define(src);

    }
}