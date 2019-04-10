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


}