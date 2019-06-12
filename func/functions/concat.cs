//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Text;

using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]
    public static IEnumerable<T> concat<T>(params IEnumerable<T>[] src)
        where T : struct
        => src.SelectMany(x => x);

    /// <summary>
    /// Concatentates two byte arrays
    /// </summary>
    /// <param name="first">The first array of bytes</param>
    /// <param name="second">The second array of bytes</param>
    /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
    [MethodImpl(Inline)]
    public static byte[] concat(byte[] first, byte[] second)
    {
        byte[] ret = new byte[first.Length + second.Length];
        Buffer.BlockCopy(first, 0, ret, 0, first.Length);
        Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
        return ret;
    }


    /// <summary>
    /// Concatentates a parameter array of byte arrays
    /// </summary>
    /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
    public static byte[] concat(params byte[][] src)
    {
        byte[] ret = new byte[src.Sum(x => x.Length)];
        int offset = 0;
        foreach (byte[] data in src)
        {
            Buffer.BlockCopy(data, 0, ret, offset, data.Length);
            offset += data.Length;
        }
        return ret;
    }

    /// <summary>
    /// Concatenates a sequence of byte arrays
    /// </summary>
    /// <param name="src">The source arrays</param>
    /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
    public static byte[] concat(IEnumerable<byte[]> src)
    {
        byte[] ret = new byte[src.Sum(x => x.Length)];
        int offset = 0;
        foreach (byte[] data in src)
        {
            Buffer.BlockCopy(data, 0, ret, offset, data.Length);
            offset += data.Length;
        }
        return ret;
    }

    /// <summary>
    /// Concatenates a sequence of parameter arrays
    /// </summary>
    /// <param name="src">The source arrays</param>
    /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
    public static T[] concat<T>(params T[][] src)
        where T : struct
    {
        var ret = new T[src.Sum(x => x.Length)];
        int offset = 0;
        foreach (var data in src)
        {
            Buffer.BlockCopy(data, 0, ret, offset, data.Length);
            offset += data.Length;
        }
        return ret;
    }

    /// <summary>
    /// Concatenates a sequence of arrays
    /// </summary>
    /// <param name="src">The source arrays</param>
    /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
    public static T[] concat<T>(IEnumerable<T[]> src)
        where T : struct
    {
        var ret = new T[src.Sum(x => x.Length)];
        int offset = 0;
        foreach (var data in src)
        {
            Buffer.BlockCopy(data, 0, ret, offset, data.Length);
            offset += data.Length;
        }
        return ret;
    }

    /// <summary>
    /// Concatenates a sequence of strings
    /// </summary>
    /// <param name="src">The characters to concatenate</param>
    [MethodImpl(Inline)]
    public static string concat(IEnumerable<string> src)
        => string.Concat(src);

    /// <summary>
    /// Concatenates a sequence of characters
    /// </summary>
    /// <param name="src">The characters to concatenate</param>
    [MethodImpl(Inline)]
    public static string concat(IEnumerable<char> src)
        => new string(src.ToArray());

    /// <summary>
    /// Concatenates a character array
    /// </summary>
    /// <param name="items">The characters to concatenate</param>
    [MethodImpl(Inline)]
    public static string concat(params char[] items)
        => new string(items);

    /// <summary>
    /// Concatenates an array of strings
    /// </summary>
    /// <param name="items">The strings to concatenate</param>
    [MethodImpl(Inline)]
    public static string concat(params string[] items)
        => string.Concat(items);

    /// <summary>
    /// Concatenates an arbitrary number of string representations
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    [MethodImpl(Inline)]   
    public static string concat(IEnumerable<object> src)    
        => string.Concat(src);

    public static string concat(ReadOnlySpan<string> src, string sep = ", ")
    {
        var sb = new StringBuilder();
        var lastix = src.Length - 1;
        for(var i=0; i<src.Length; i++)        
        {
            sb.Append(src[i]);
            if(i != lastix)
                sb.Append(sep);
        }
        return sb.ToString();
    }

    [MethodImpl(Inline)]   
    public static string concat(Span<string> src, string sep = ", ")
        => concat(src.ReadOnly(), sep);
    

}