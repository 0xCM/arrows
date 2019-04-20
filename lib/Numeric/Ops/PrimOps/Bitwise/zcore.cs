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


partial class zcore
{
    /// <summary>
    /// Defines a one-byte bit array 
    /// </summary>
    /// <param name="bits">The source bits</param>
    [MethodImpl(Inline)]
    public static bit[] bits(bit x0, bit x1, bit x2, bit x3, bit x4, bit x5, bit x6, bit x7)
        => array(x0, x1, x2, x3, x4, x5, x6, x7);

    /// <summary>
    /// Packs bools into bytes
    /// </summary>
    /// <param name="src">The source values</param>
    [MethodImpl(Inline)]
    public static byte[] pack(params bool[] src)
        => Bits.pack(src);


    /// <summary>
    /// Reinterprets the bits of a float as the bits of an int
    /// </summary>
    /// <param name="src">The source value to reinterpret</param>
    [MethodImpl(Inline)]   
    public static int bitsf(float src)
        => BitConverter.SingleToInt32Bits(src);

    /// <summary>
    /// Reinterprets the bits of an int as the bits of a float
    /// </summary>
    /// <param name="src">The source value to reinterpret</param>
    [MethodImpl(Inline)]   
    public static float bitsf(int src)
        => BitConverter.Int32BitsToSingle(src);

    /// <summary>
    /// Reinterprets the bits of a double as the bits of a long
    /// </summary>
    /// <param name="src">The source value to reinterpret</param>
    [MethodImpl(Inline)]   
    public static long bitsf(double src)
        => BitConverter.DoubleToInt64Bits(src);

    /// <summary>
    /// Reinterprets the bits of a long as the bits of a double
    /// </summary>
    /// <param name="src">The source value to reinterpret</param>
    [MethodImpl(Inline)]   
    public static double bitsf(long src)
        => BitConverter.Int64BitsToDouble(src);

}