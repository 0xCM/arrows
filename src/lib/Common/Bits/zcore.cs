//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using System.Text;

using Z0;


using static zcore;
using static Z0.Traits;

partial class zcore
{
    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static string bitchars(byte src)
        => lpadZ(Convert.ToString(src,2), UInt8Ops.BitSize);

    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static byte[] bytes(byte src)
        => array(src);

    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static string bitchars(sbyte src)
        => lpadZ(Convert.ToString(src,2), (int)Int8Ops.BitSize);

    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static string bitchars(short src)
        => lpadZ(Convert.ToString(src,2), UInt16Ops.BitSize);

    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static string bitchars(ushort src)
        => lpadZ(Convert.ToString(src,2), (int)Int16Ops.BitSize);

    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static string bitchars(int src)
        => lpadZ(Convert.ToString(src,2), Int32Ops.BitSize);
    
    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static string bitchars(uint src)
        => lpadZ(Convert.ToString(src,2), UInt32Ops.BitSize);

    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static string bitchars(long src)
        => lpadZ(Convert.ToString(src,2), Int64Ops.BitSize);

    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static string bitchars(ulong src)
        => apply(Bits.split(src), parts => bitchars(parts.hi) + bitchars(parts.lo));

    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static string bitchars(double src)
        => lpadZ(Convert.ToString(BitConverter.DoubleToInt64Bits(src), 2), Int64Ops.BitSize);

    /// <summary>
    /// Renders a number as a base-2 formatted string
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static string bitchars(float src)
        => lpadZ(Convert.ToString(BitConverter.SingleToInt32Bits(src), 2), Int32Ops.BitSize);

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


    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(byte src)
        => BitString.Parse(bitchars(src));


    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(sbyte src)
        => BitString.Parse(bitchars(src));

    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(short src)
        => BitString.Parse(bitchars(src));

    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(ushort src)
        => BitString.Parse(bitchars(src));

    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(int src)
        => BitString.Parse(bitchars(src));
    
    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(uint src)
        => BitString.Parse(bitchars(src));

    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(long src)
        => BitString.Parse(bitchars(src));

    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(ulong src)
        => BitString.Parse(bitchars(src));

    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(double src)
        => BitString.Parse(bitchars(src));

    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(float src)
        => BitString.Parse(bitchars(src));

    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(decimal src)
        => BitString.Parse(bitchars(src));

    /// <summary>
    /// Constructs a bitstring from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString bitstring(BigInteger src)
        => BitString.Parse(bitchars(src));

    /// <summary>
    /// Constructs a bitvector from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitVector<N8,byte> bitvector(byte src)
        => BitVector.define(N8.Rep, src.ToIntG());

    /// <summary>
    /// Constructs a bitvector from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitVector<N8,sbyte> bitvector(sbyte src)
        => BitVector.define(N8.Rep, src.ToIntG());

    /// <summary>
    /// Constructs a bitvector from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitVector<N16,short> bitvector(short src)
        => BitVector.define(N16.Rep, src.ToIntG());

    /// <summary>
    /// Constructs a bitvector from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitVector<N16,ushort> bitvector(ushort src)
        => BitVector.define(N16.Rep, src.ToIntG());

    /// <summary>
    /// Constructs a bitvector from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitVector<N32,int> bitvector(int src)
        => BitVector.define(N32.Rep, src.ToIntG());

    /// <summary>
    /// Constructs a bitvector from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitVector<N32,uint> bitvector(uint src)
        => BitVector.define(N32.Rep, src.ToIntG());

    /// <summary>
    /// Constructs a bitvector from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitVector<N64,long> bitvector(long src)
        => BitVector.define(N64.Rep, src.ToIntG());

    /// <summary>
    /// Constructs a bitvector from a number
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitVector<N64,ulong> bitvector(ulong src)
        => BitVector.define(N64.Rep, src.ToIntG());

    /// <summary>
    /// Parses a bitstring from a string representation of a bitstring
    /// </summary>
    /// <param name="src">The source number</param>
    [MethodImpl(Inline)]
    public static BitString parse(string src, out BitString dst)
        => dst = new BitString(src);
}