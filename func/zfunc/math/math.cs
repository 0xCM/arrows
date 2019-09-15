//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{


    [MethodImpl(Inline)]
    static sbyte sign(sbyte src)
        => BitMask.test(src,7) ? (sbyte)(-1) : (sbyte)1;

    [MethodImpl(Inline)]
    static short sign(short src)
        => BitMask.test(src,15) ? (short)(-1) : (short)1;

    [MethodImpl(Inline)]
    static int sign(int src)
        => BitMask.test(src,31) ? -1 : 1;

    [MethodImpl(Inline)]
    static long sign(long src)
        => BitMask.test(src,63) ? -1 : 1;


}