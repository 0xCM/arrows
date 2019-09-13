//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public static T[] concat<T>(params T[][] src)
    {
        var totalLen = src.Sum(x => x.Length);
        var dst = new T[totalLen];
        var idx = 0;
        for(var i=0; i< src.Length; i++)
        {
            var arr = src[i];
            var len = arr.Length;
            for(var j = 0; j<len; j++)
                dst[idx++] = arr[j];            
        }        

        return dst;
    }

    /// <summary>
    /// Concatenates a sequence of arrays
    /// </summary>
    /// <param name="src">The source arrays</param>
    public static T[] concat<T>(IEnumerable<T[]> src)
        => concat(src.ToArray());

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
    /// Concatenates a character with an array of strings
    /// </summary>
    /// <param name="c">The leading character</param>
    /// <param name="items">The trailing content</param>
    [MethodImpl(Inline)]
    public static string concat(char c, params string[] items)
        => c + concat(items);

    /// <summary>
    /// Concatenates two characters with an array of strings
    /// </summary>
    /// <param name="c1">The first character</param>
    /// <param name="c2">The second character</param>
    /// <param name="items">The trailing content</param>
    [MethodImpl(Inline)]
    public static string concat(char c1, char c2, params string[] items)
        => $"{c1}{c2}" + concat(items);
    
    /// <summary>
    /// Concatenates three characters with an array of strings
    /// </summary>
    /// <param name="c1">The first character</param>
    /// <param name="c2">The second character</param>
    /// <param name="c3">The third character</param>
    /// <param name="items">The trailing content</param>
    [MethodImpl(Inline)]
    public static string concat(char c1, char c2, char c3, params string[] items)
        => $"{c1}{c2}{c3}"  + concat(items);

    [MethodImpl(Inline)]
    public static string concat(string s1, char c1, char c2, char c3, params string[] items)
        => $"{s1}{c1}{c2}{c3}" + concat(items);

    [MethodImpl(Inline)]
    public static string concat(char c1, string s, char c2, params string[] items)
        => $"{c1}{s}{c2}" + concat(items);

    [MethodImpl(Inline)]
    public static string concat(string s1, params char[] items)
        => s1 + concat(items);

    [MethodImpl(Inline)]
    public static string concat(string s1, char c1, string s2, char c2, char c3, params string[] items)
        => $"{s1}{c1}{s2}{c2}{c3}" + concat(items);

    [MethodImpl(Inline)]
    public static string concat(string s1, string s2, params char[] items)
        => s1 + s2 + concat(items);

    [MethodImpl(Inline)]
    public static string concat(string s1, string s2, char c1, char c2, params string[] items)
        => $"{s1}{s2}{c1}{c2}" + concat(items);


    [MethodImpl(Inline)]
    public static string concat(string s1, string s2, string s3, params char[] items)
        => $"{s1}{s2}{s3}" + concat(items);
         
    [MethodImpl(Inline)]
    public static string concat(string s1, char c1, string s2, params char[] items)
        => $"{s1}{c1}{s2}" + concat(items);

    [MethodImpl(Inline)]
    public static string concat(string s1, char c1, char c2, params string[] items)
        => $"{s1}{c1}{c2}" + concat(items);

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