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
    

    [MethodImpl(Inline)]
    public static string bitchars(byte src)
        => lpadZ(Convert.ToString(src,2), UInt8Ops.BitSize);

    [MethodImpl(Inline)]
    public static string bitchars(sbyte src)
        => lpadZ(Convert.ToString(src,2), Int8Ops.BitSize);

    [MethodImpl(Inline)]
    public static string bitchars(short src)
        => lpadZ(Convert.ToString(src,2), UInt16Ops.BitSize);

    [MethodImpl(Inline)]
    public static string bitchars(ushort src)
        => lpadZ(Convert.ToString(src,2), Int16Ops.BitSize);

    [MethodImpl(Inline)]
    public static string bitchars(int src)
        => lpadZ(Convert.ToString(src,2), Int32Ops.BitSize);
    
    [MethodImpl(Inline)]
    public static string bitchars(uint src)
        => lpadZ(Convert.ToString(src,2), UInt32Ops.BitSize);

    [MethodImpl(Inline)]
    public static string bitchars(long src)
        => lpadZ(Convert.ToString(src,2), Int64Ops.BitSize);

    [MethodImpl(Inline)]
    public static string bitchars(ulong src)
        => apply(Bits.split(src), parts => bitchars(parts.hi) + bitchars(parts.lo));

    [MethodImpl(Inline)]
    public static string bitchars(double src)
        => lpadZ(Convert.ToString(BitConverter.DoubleToInt64Bits(src), 2), Int64Ops.BitSize);

    [MethodImpl(Inline)]
    public static string bitchars(float src)
        => lpadZ(Convert.ToString(BitConverter.SingleToInt32Bits(src), 2), Int32Ops.BitSize);

    [MethodImpl(Inline)]
    public static string bitchars(decimal src)
        => zcore.apply(Bits.split(src), 
            parts => bitchars(parts.hihi) + bitchars(parts.hilo)
                   + bitchars(parts.lohi) + bitchars(parts.lolo));


    /// <summary>
    /// Represents the source value as a sequence of base-2 integers
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

        return base2.ToString();
    }


    [MethodImpl(Inline)]
    public static BitString bitstring(byte src)
        => BitString.Parse(bitchars(src));

    [MethodImpl(Inline)]
    public static BitString bitstring(sbyte src)
        => BitString.Parse(bitchars(src));

    [MethodImpl(Inline)]
    public static BitString bitstring(short src)
        => BitString.Parse(bitchars(src));

    [MethodImpl(Inline)]
    public static BitString bitstring(ushort src)
        => BitString.Parse(bitchars(src));

    [MethodImpl(Inline)]
    public static BitString bitstring(int src)
        => BitString.Parse(bitchars(src));
    
    [MethodImpl(Inline)]
    public static BitString bitstring(uint src)
        => BitString.Parse(bitchars(src));

    [MethodImpl(Inline)]
    public static BitString bitstring(long src)
        => BitString.Parse(bitchars(src));

    [MethodImpl(Inline)]
    public static BitString bitstring(ulong src)
        => BitString.Parse(bitchars(src));

    [MethodImpl(Inline)]
    public static BitString bitstring(double src)
        => BitString.Parse(bitchars(src));

    [MethodImpl(Inline)]
    public static BitString bitstring(float src)
        => BitString.Parse(bitchars(src));

    [MethodImpl(Inline)]
    public static BitString bitstring(decimal src)
        => BitString.Parse(bitchars(src));


    [MethodImpl(Inline)]
    public static BitString bitstring(BigInteger src)
        => BitString.Parse(bitchars(src));


    [MethodImpl(Inline)]
    public static BitString parse(string src, out BitString dst)
        => dst = new BitString(src);
}