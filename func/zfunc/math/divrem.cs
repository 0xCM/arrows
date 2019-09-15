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
    /// Computes the quotient and remainder
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="r">The remainder</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static uint divrem<N>(uint m, out uint r, N n = default)
        where N : ITypeNat, new()
            => Mod<N>.divrem(m, out r);

    /// <summary>
    /// Computes the quotient and remainder
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="r">The remainder</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static int divrem<N>(int m, out int r, N n = default)
        where N : ITypeNat, new()
    {
        var q = (int)divrem((uint)m, out uint ur, n);
        r = (int)ur;
        return q * sign(m);
    }
            
    /// <summary>
    /// Computes the quotient and remainder
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="r">The remainder</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static ushort divrem<N>(ushort m, out ushort r, N n = default)
        where N : ITypeNat, new()
    {
        var q = (ushort)divrem((uint)m, out uint ur, n);
        r = (ushort)ur;
        return q;
    }

    /// <summary>
    /// Computes the quotient and remainder
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="r">The remainder</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static short divrem<N>(short m, out short r, N n = default)
        where N : ITypeNat, new()
    {
        var q = divrem((uint)m, out uint ur, n);
        r = (short)ur;
        return (short)(q * sign(m));
    }

    /// <summary>
    /// Computes the quotient and remainder
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="r">The remainder</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static byte divrem<N>(byte m, out byte r, N n = default)
        where N : ITypeNat, new()
    {
        var q = (byte)divrem((uint)m, out uint ur, n);
        r = (byte)ur;
        return q;
    }

    /// <summary>
    /// Computes the quotient and remainder
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="r">The remainder</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static long divrem<N>(long m, out long r, N n = default)
        where N : ITypeNat, new()
            => Math.DivRem(m,(long)n.value, out r);

    /// <summary>
    /// Computes the quotient and remainder
    /// </summary>
    /// <param name="m">The dividend</param>
    /// <param name="r">The remainder</param>
    /// <param name="n">The divisor</param>
    /// <typeparam name="N">The modulus type</typeparam>
    [MethodImpl(Inline)]
    public static ulong divrem<N>(ulong m, out ulong r, N n = default)
        where N : ITypeNat, new()
    {
        var q = m / n.value;
        r = m - n.value * q;
        return q;
    }

}