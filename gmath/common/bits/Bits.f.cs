//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;
using System.Diagnostics;

using Z0;
using static zfunc;

partial class mfunc
{

    [MethodImpl(Inline)]
    public static Bit[] bits(params Bit[] src)
        => src;

    [MethodImpl(Inline)]
    public static byte[] pack(params bool[] src)
        => Bits.pack(src);

    /// <summary>
    /// Reinterprets the Bits of a float as the Bits of an int
    /// </summary>
    /// <param name="src">The source value to reinterpret</param>
    [MethodImpl(Inline)]   
    public static int bitsf(float src)
        => BitConverter.SingleToInt32Bits(src);

    /// <summary>
    /// Reinterprets the Bits of an int as the Bits of a float
    /// </summary>
    /// <param name="src">The source value to reinterpret</param>
    [MethodImpl(Inline)]   
    public static float bitsf(int src)
        => BitConverter.Int32BitsToSingle(src);

    /// <summary>
    /// Reinterprets the Bits of a double as the Bits of a long
    /// </summary>
    /// <param name="src">The source value to reinterpret</param>
    [MethodImpl(Inline)]   
    public static long bitsf(double src)
        => BitConverter.DoubleToInt64Bits(src);

    /// <summary>
    /// Reinterprets the Bits of a long as the Bits of a double
    /// </summary>
    /// <param name="src">The source value to reinterpret</param>
    [MethodImpl(Inline)]   
    public static double bitsf(long src)
        => BitConverter.Int64BitsToDouble(src);



}