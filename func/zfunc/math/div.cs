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

    /// <summary>
    /// Computes m / n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static uint div<N>(uint m, N n = default)
        where N : ITypeNat, new()
            => Mod<N>.div(m);

    /// <summary>
    /// Computes m / n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static int div<N>(int m, N n = default)
        where N : ITypeNat, new()
            => (int)div<N>((uint)m) * sign(m);

    /// <summary>
    /// Computes m / n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static short div<N>(short m, N n = default)
        where N : ITypeNat, new()
            => (short)(div<N>((uint)m) * sign(m));

    /// <summary>
    /// Computes m / n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static ushort div<N>(ushort m, N n = default)
        where N : ITypeNat, new()
            => (ushort)div<N>((uint)m);

    /// <summary>
    /// Computes m / n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static byte div<N>(byte m, N n = default)
        where N : ITypeNat, new()
            => (byte)div<N>((uint)m);

    /// <summary>
    /// Computes m / n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static sbyte div<N>(sbyte m, N n = default)
        where N : ITypeNat, new()
            => (sbyte)(div<N>((uint)m) * sign(m));



}