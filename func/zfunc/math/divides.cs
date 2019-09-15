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
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, uint m)
        where N : ITypeNat, new()
            => Mod<N>.divisible(m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, long m)
        where N : ITypeNat, new()
            => (ulong)m % n.value == 0;

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, ulong m)
        where N : ITypeNat, new()
            => m % n.value == 0;

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, int m)
        where N : ITypeNat, new()
            => divides<N>(n, (uint)m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, short m)
        where N : ITypeNat, new()
            => divides<N>(n, (uint)m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, ushort m)
        where N : ITypeNat, new()
            => divides<N>(n, (uint)m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, byte m)
        where N : ITypeNat, new()
            => divides<N>(n, (uint)m);
    
    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divides<N>(N n, sbyte m)
        where N : ITypeNat, new()
            => divides<N>(n, (uint)m);


}

