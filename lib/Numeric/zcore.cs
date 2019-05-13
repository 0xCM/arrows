//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using Z0;


using static zcore;
using static zfunc;

using static Z0.Traits;

partial class zcore
{
    static ArgumentException mismatched<T>(Span<T> lhs, Span<T> rhs)
        => new ArgumentException($"The left item count {lhs.Length} does not match the right item count {rhs.Length}");

    [MethodImpl(Inline)]
    static int matchedCount<T>(Span<T> lhs, Span<T> rhs)
        => lhs.Length != rhs.Length? throw mismatched(lhs,rhs) : lhs.Length;

    [MethodImpl(Inline)]
    public static Span<T> fuse<T>(Span<T> lhs, Span<T> rhs, Func<T,T,T> f)
    {
        var len = matchedCount(lhs,rhs);
        for(var i = 0; i < len ; i++)
            lhs[i] = f(lhs[i], rhs[i]);
        return lhs;
    }

    /// <summary>
    /// Constructs a bit vector from a bit parameter array
    /// </summary>
    /// <param name="src">The bit source</param>

    [MethodImpl(Inline)]   
    public static BitVector<N> bitvector<N>(params Bit[] src)
        where N : ITypeNat, new()
            => BitVector.Define<N>(src);

    /// <summary>
    /// Constructs a bit vector from a parameter array of integers
    /// </summary>
    /// <param name="src">The bit source</param>
    [MethodImpl(Inline)]   
    public static BitVector<N> bitvector<N>(params uint[] src)
        where N : ITypeNat, new()
            => BitVector.Define<N>(map(src, x => x == 0 ? Bit.Off : Bit.On));

    /// <summary>
    /// Constructs a bit vector of natural length 8 from a parameter array of integers
    /// where there constructed vector is left-padded with zeros should there be
    /// fewer than 8 bits specified
    /// </summary>
    /// <param name="src">The bit source</param>
    [MethodImpl(Inline)]   
    public static BitVector<N8> bytevector(params uint[] src)
        => BitVector.Define<N8>(map(src, x => x == 0 ? Bit.Off : Bit.On));

    /// <summary>
    /// Defines a bitvector of natural length 8 from a parameter array of binary digits
    /// </summary>
    /// <param name="src">The source digits</param>
    [MethodImpl(Inline)]   
    public static BitVector<N8> bytevector(params BinaryDigit[] src)
        => BitVector.Define<N8>(map(src, x => x == 0 ? Bit.Off : Bit.On));


    /// <summary>
    /// Constructs a contiguous range of integers inclusively between specified bounds
    /// If the first value is greater than the last, the range will be constructed
    /// in descending order.
    /// </summary>
    /// <param name="first">The first integer to yield</param>
    /// <param name="last">The last integer to yield</param>
    /// <typeparam name="T">The underlying integer type</typeparam>
    public static IEnumerable<intg<T>> range<T>(intg<T> first, intg<T> last)
        where T : struct, IEquatable<T>
    {
        var current = first;
        if(first < last)
            while(current<= last)
                yield return current++;
        else
            while(current >= last)
                yield return current--;
    }

    /// <summary>
    /// Constructs the ring of integers for a given modulus
    /// </summary>
    /// <typeparam name="N">The modulus type</typeparam>
    /// <typeparam name="T">The integral type</typeparam>
    [MethodImpl(Inline)]   
    public static modg<N,T> modring<N,T>(intg<T> lhs)
        where N : ITypeNat, new()
        where T : struct, IEquatable<T>
            => new modg<N,T>(lhs);

    
    [MethodImpl(Inline)]
    static Ordering compare<T>(T lhs, T rhs)
        where T: IOrderable<T>, new()
            => lhs.gt(rhs) ? Ordering.GT :
               lhs.lt(rhs) ? Ordering.LT :
               Ordering.EQ; 

    [MethodImpl(Inline)]
    public static (T lhs, Ordering, T rhs)[] compare<T>(T[] lhs, T[] rhs)
        where T: IOrderable<T>, new()
            => fuse(lhs,rhs, (l,r) =>  (l, compare(l,r), r));


    [MethodImpl(Inline)]   
    public static sbyte abs(sbyte x)
    {
        var m = (sbyte)(x >> 8 - 1);
        return (sbyte) ((x + m) ^ m);
    }

    [MethodImpl(Inline)]   
    public static short abs(short x)
    {
        var m = (short)(x >> 16 - 1);
        return (short) ((x + m) ^ m);
    }

    [MethodImpl(Inline)]   
    public static double abs(double x)
        => Math.Abs(x);

    [MethodImpl(Inline)]   
    public static float abs(float x)
        => MathF.Abs(x);

    [MethodImpl(Inline)]   
    public static decimal abs(decimal x)
        => Math.Abs(x);

    [MethodImpl(Inline)]   
    public static int abs(int x)
    {
        var m = x >> 32 - 1;
        return (x + m) ^ m;
    }

    [MethodImpl(Inline)]   
    public static long abs(long x)
    {
        var m = (x >> 64 - 1);
        return (x + m) ^ m;
    }

    /// <summary>
    /// Determines whether a value is equivalent to the NaN representative
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static bool NaN(double src)
        => double.IsNaN(src);

    /// <summary>
    /// Determines whether a value is equivalent to the NaN representative
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static bool NaN(float src)
        => float.IsNaN(src);

    /// <summary>
    /// Determines whether a double value is bounded 
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static bool finite(double src)
        => double.IsFinite(src);

    /// <summary>
    /// Determines whether a value is nonzero
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static bool nonzero(double src)
        => src != 0;

}