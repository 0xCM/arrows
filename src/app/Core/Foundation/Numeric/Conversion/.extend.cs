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
using Core;

using C = Core.Contracts;

using static corefunc;
using static Core.Operations;


public static class ConversionX
{
    [MethodImpl(Inline)]   
    public static IReadOnlyList<T> Unwrap<T>(this IEnumerable<intg<T>> src)
        => src.Select(x => x.data).ToList();

    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this byte src)
        => (T)Convert.ChangeType(src,typeof(T));

    [MethodImpl(Inline)]   
    public static intg<byte> ToIntG(this byte src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this sbyte src)
        => (T)Convert.ChangeType(src,typeof(T));

    [MethodImpl(Inline)]   
    public static intg<sbyte> ToIntG(this sbyte src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this short src)
        => (T)Convert.ChangeType(src,typeof(T));

    [MethodImpl(Inline)]   
    public static intg<short> ToIntG(this short src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this ushort src)
        => (T)Convert.ChangeType(src,typeof(T));

    [MethodImpl(Inline)]   
    public static intg<ushort> ToIntG(this ushort src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this int src)
        => (T)Convert.ChangeType(src,typeof(T));

    [MethodImpl(Inline)]   
    public static intg<int> ToIntG(this int src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this uint src)
        => (T)Convert.ChangeType(src,typeof(T));

    [MethodImpl(Inline)]   
    public static intg<uint> ToIntG(this uint src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this long src)    
        where T : new()
        => (T)Convert.ChangeType(src,typeof(T));

    [MethodImpl(Inline)]   
    public static intg<long> ToIntG(this long src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this ulong src)
        => (T)Convert.ChangeType(src,typeof(T));

    [MethodImpl(Inline)]   
    public static intg<ulong> ToIntG(this ulong src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<BigInteger> ToIntG(this BigInteger src)
        => src;


    [MethodImpl(Inline)]   
    public static string ToHexString(this BigInteger x)
        => x.ToString("X");

    [MethodImpl(Inline)]   
    public static string ToHexString(this decimal src)
        => map(Bits.split(src), parts =>
            concat(
                parts.hihi.ToString("X8"),
                parts.hilo.ToString("X8"),
                parts.lohi.ToString("X8"),
                parts.lolo.ToString("X8")
            ));

    /// <summary>
    /// Represents the source value as a sequence of base-2 integers
    /// <remarks>
    /// Taken from https://stackoverflow.com/questions/14048476/biginteger-to-hex-decimal-octal-binary-strings
    /// </remarks>
    public static string ToBitString(this BigInteger x)
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
    public static string ToBitString(this sbyte src)
            => lpadZ(Convert.ToString(src,2), UInt8Ops.MaxBitLength);

    [MethodImpl(Inline)]   
    public static string ToBitString(this short src)
        => lpadZ(Convert.ToString(src,2), UInt16Ops.MaxBitLength);

    [MethodImpl(Inline)]   
    public static string ToBitString(this int src)
        => lpadZ(Convert.ToString(src,2), Int32Ops.MaxBitLength);

    [MethodImpl(Inline)]   
    public static string ToBitString(this uint src)
        => lpadZ(Convert.ToString(src,2), UInt32Ops.MaxBitLength);

    [MethodImpl(Inline)]   
    public static string ToBitString(this ulong src)
        => map(Bits.split(src), 
                parts => parts.hi.ToBitString() 
                        + parts.lo.ToBitString());

    public static string ToBitString(this float x)
        => BitConverter.SingleToInt32Bits(x).ToBitString();

    [MethodImpl(Inline)]   
    public static string ToBitString(this decimal src)
        => map(Bits.split(src), parts =>
            concat(
                parts.hihi.ToBitString(),
                parts.hilo.ToBitString(),
                parts.lohi.ToBitString(),
                parts.lolo.ToBitString()
            ));

    [MethodImpl(Inline)]   
    public static string ToBitString(this double x)
        => lpadZ(map(Bits.split(x), 
            ieee => concat(ieee.sign == Sign.Negative ? "1" : "0",
                        ieee.exponent.ToBitString(),
                        ieee.mantissa.ToBitString()                        
                )), Float64Ops.MaxBitLength);

}

