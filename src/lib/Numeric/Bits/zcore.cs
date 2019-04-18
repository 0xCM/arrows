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
    public static bit[] bits(bit b7, bit b6, bit b5, bit b4, bit b3, bit b2, bit b1, bit b0)
        => array(b7, b6, b5, b4, b3, b2, b1, b0);

    /// <summary>
    /// Packs bools into bytes
    /// </summary>
    /// <param name="src">The source values</param>
    /// <remarks>Adapted from https://stackoverflow.com/questions/713057/convert-bool-to-byte</remarks>
    [MethodImpl(Inline)]
    public static byte[] pack(params bool[] src)
    {
        int srcLen = src.Length;
        int dstLen = srcLen >> 3;
        
        if ((srcLen & 0x07) != 0) 
            ++dstLen;

        var dst = new byte[dstLen];
        for (int i = 0; i < srcLen; i++)
            if (src[i])
                dst[i >> 3] |= (byte)(1 << (i & 0x07));
        
        return dst;
    }

    const byte Mask00 = 0&7;
    
    const byte Mask01 = 1&7;
    
    const byte Mask02 = 2&7;
    
    const byte Mask03 = 3&7;
    
    const byte Mask04 = 4&7;
    
    const byte Mask05 = 5&7;
    
    const byte Mask06 = 6&7;
    
    const byte Mask07 = 7&7;

    const byte LShift00 = 1 << Mask00;

    const byte LShift01 = 1 << Mask01;

    const byte LShift02 = 1 << Mask02;

    const byte LShift03 = 1 << Mask03;
    
    const byte LShift04 = 1 << Mask04;

    const byte LShift05 = 1 << Mask05;

    const byte LShift06 = 1 << Mask06;

    const byte LShift07 = 1 << Mask07;

    public static byte bitpack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
    {
        var dst =(byte)0;
        
        if(x0 != 0)
            dst |= LShift00;
        
        if(x1 != 0)
            dst |= LShift01;
        
        if(x2 != 0)
            dst |= LShift02;

        if(x3 != 0)
            dst |= LShift03;

        if(x4 != 0)
            dst |= LShift04;

        if(x5 != 0)
            dst |= LShift05;

        if(x6 != 0)
            dst |= LShift06;

        if(x7 != 0)
            dst |= LShift07;
        
        return dst;
    }


}