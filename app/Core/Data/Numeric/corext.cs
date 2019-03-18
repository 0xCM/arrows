//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using Core;

using C = Core.Contracts;

using static corefunc;
using static Core.MathOps;


partial class corext
{
    public static intg<long> ToIntG(this long x)        
        => x;

    public static intg<int> ToIntG(this int x)        
        => x;

    public static intg<short> ToIntG(this short x)        
        => x;

    public static intg<sbyte> ToIntG(this sbyte x)        
        => x;

    public static intg<ulong> ToIntG(this ulong x)        
        => x;

    public static intg<uint> ToIntG(this uint x)        
        => x;

    public static intg<ushort> ToIntG(this ushort x)        
        => x;

    public static intg<byte> ToIntG(this byte x)        
        => x;

    public static intg<BigInteger> ToIntG(this BigInteger x)        
        => x;
}
