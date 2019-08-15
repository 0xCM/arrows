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
    /// Computes m % n
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static uint mod<N>(uint m, N n = default)
        where N : ITypeNat, new()
            => Mod<N>.mod(m);

    /// <summary>
    /// Computes m % n
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static int mod<N>(int m, N n = default)
        where N : ITypeNat, new()
            => (int)mod<N>((uint)m) * sign(m);

    /// <summary>
    /// Computes m % n
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static short mod<N>(short m, N n = default)
        where N : ITypeNat, new()
            => (short)(mod<N>((uint)m) * sign(m));

    /// <summary>
    /// Computes m % n
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static ushort mod<N>(ushort m, N n = default)
        where N : ITypeNat, new()
            => (ushort)mod<N>((uint)m);

    /// <summary>
    /// Computes m % n
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static byte mod<N>(byte m, N n = default)
        where N : ITypeNat, new()
            => (byte)mod<N>((uint)m);

    /// <summary>
    /// Computes m % n
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static sbyte mod<N>(sbyte m, N n = default)
        where N : ITypeNat, new()
            => (sbyte)(mod<N>((uint)m) * sign(m));

    /// <summary>
    /// Computes m % n
    /// </summary>
    /// <param name="m">The source value</param>
    /// <param name="n">The modulus</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static long mod<N>(long m, N n = default)
        where N : ITypeNat, new()
            => m % (long)n.value  * sign(m);

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

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divisible<N>(uint m, N n = default)
        where N : ITypeNat, new()
            => Mod<N>.divisible(m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divisible<N>(long m, N n = default)
        where N : ITypeNat, new()
            => (ulong)m % n.value == 0;

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divisible<N>(ulong m, N n = default)
        where N : ITypeNat, new()
            => m % n.value == 0;

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divisible<N>(int m, N n = default)
        where N : ITypeNat, new()
            => divisible<N>((uint)m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divisible<N>(short m, N n = default)
        where N : ITypeNat, new()
            => divisible<N>((uint)m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divisible<N>(ushort m, N n = default)
        where N : ITypeNat, new()
            => divisible<N>((uint)m);

    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divisible<N>(byte m, N n = default)
        where N : ITypeNat, new()
            => divisible<N>((uint)m);
    
    /// <summary>
    /// Determines whether m is evenly divisible by n
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static bool divisible<N>(sbyte m, N n = default)
        where N : ITypeNat, new()
            => divisible<N>((uint)m);

    [MethodImpl(Inline)]
    public static bool even(sbyte test)
        => divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool even(byte test)
        => divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool even(short test)
        => divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool even(int test)
        => divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool even(ushort test)
        => divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool even(uint test)
        => divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool even(long test)
        => divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool even(ulong test)
        => divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool odd(sbyte test)
        => Mod<N2>.mod((uint)test) != 0;

    [MethodImpl(Inline)]
    public static bool odd(byte test)
        => !divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool odd(short test)
        => !divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool odd(ushort test)
        => !divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool odd(int test)
        => !divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool odd(uint test)
        => !divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool odd(long test)
        => !divisible<N2>((uint)test);

    [MethodImpl(Inline)]
    public static bool odd(ulong test)
        => !divisible<N2>((uint)test);

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

