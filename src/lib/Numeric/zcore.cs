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
using static Z0.Traits;

partial class zcore
{
    /// <summary>
    /// Constructs a bit from the data in an integral value at a specified position
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="pos">The bit position</param>
    /// <typeparam name="T">The underlying integral type</typeparam>
    [MethodImpl(Inline)]   
    public static bit bitat<T>(intg<T> x, int pos)
        where T : struct, IEquatable<T>
            => Bits.bit(x, pos);

    /// <summary>
    /// Constructs a bit vector from a bit parameter array
    /// </summary>
    /// <param name="src">The bit source</param>

    [MethodImpl(Inline)]   
    public static BitVector<N> bitvector<N>(params bit[] src)
        where N : TypeNat, new()
            => BitVector.define<N>(src);

    /// <summary>
    /// Constructs a bit vector from a parameter array of integers
    /// </summary>
    /// <param name="src">The bit source</param>
    [MethodImpl(Inline)]   
    public static BitVector<N> bitvector<N>(params uint[] src)
        where N : TypeNat, new()
            => BitVector.define<N>(map(src, x => x == 0 ? bit.off() : bit.on()));

    /// <summary>
    /// Constructs a bit vector of natural length 8 from a parameter array of integers
    /// where there constructed vector is left-padded with zeros should there be
    /// fewer than 8 bits specified
    /// </summary>
    /// <param name="src">The bit source</param>
    [MethodImpl(Inline)]   
    public static BitVector<N8> bytevector(params uint[] src)
        => BitVector.define<N8>(map(src, x => x == 0 ? bit.off() : bit.on()));

    /// <summary>
    /// Defines a bitvector of natural length 8 from a parameter array of binary digits
    /// </summary>
    /// <param name="src">The source digits</param>
    [MethodImpl(Inline)]   
    public static BitVector<N8> bytevector(params BinaryDigit[] src)
        => BitVector.define<N8>(map(src, x => x == 0 ? bit.off() : bit.on()));

    /// <summary>
    /// Computes the integral divisors of a number, exluding 1 and the number itself
    /// </summary>
    /// <param name="src">The source value</param>
    public static IEnumerable<intg<T>> divisors<T>(intg<T> src)
        where T : struct, IEquatable<T>
    {        
        var zero = Z0.intg<T>.Zero;
        var one = Z0.intg<T>.One;
        var two = one.inc();
        if(src != zero && src != one)
        {
            var upper = (src/two).inc();
            var candidates = range<T>(two, upper);
            foreach(var c in candidates)
                if(src % c == zero )
                    yield return c;
        }    
    }

    /// <summary>
    /// Determines whether an integer is prime
    /// </summary>
    /// <param name="x">The integer to examine</param>
    /// <typeparam name="T">The underlying integer type</typeparam>
    [MethodImpl(Inline)]   
    public static bool prime<T>(intg<T> x)
        where T : struct, IEquatable<T>
    {
        var upperBound = x.ToFloatG64().sqrt().ceiling().ToIntG<T>();   
        return divisors(x).Count() == 0;
    }                

    /// <summary>
    /// Enumerates generic reals, with unit spacing, inclusively between specified bounds
    /// If the first value is greater than the last, the range will be constructed
    /// in descending order.
    /// </summary>
    /// <param name="first">The first number to yeild</param>
    /// <param name="last">The last number to yield</param>
    /// <typeparam name="T">The underlying numeric type</typeparam>
    public static IEnumerable<real<T>> reals<T>(real<T> first, real<T> last)
        where T : struct, IEquatable<T>
    {
        var current = first;
        if(first < last)
        {
            while(current<= last)
            {
                yield return current++;
            }                
        }
        else
        {
            while(current >= last)
            {
                yield return current--;
            }
        }
    }

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
        {
            while(current<= last)
            {
                yield return current++;
            }                
        }
        else
        {
            while(current >= last)
            {
                yield return current--;
            }
        }
    }


    /// <summary>
    /// Constructs the ring of integers for a given modulus
    /// </summary>
    /// <typeparam name="N">The modulus type</typeparam>
    /// <typeparam name="T">The integral type</typeparam>
    [MethodImpl(Inline)]   
    public static modg<N,T> modring<N,T>(intg<T> lhs)
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
            => new modg<N,T>(lhs);


    [MethodImpl(Inline)]
    public static int min(int x, int y)
        => x < y ? x : y;

    [MethodImpl(Inline)]
    public static uint min(uint x, uint y)
        => x < y ? x : y;

    [MethodImpl(Inline)]
    public static T min<T>(T x, T y)
        where T : Structures.Orderable<T>, new()
            => x.lt(y) ? x : y;

    /// <summary>
    /// Raises each element of the source sequence to a specified power
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="exp">The exponent value</param>
    /// <typeparam name="T">The operand type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static IEnumerable<T> pow<T>(IEnumerable<T> src, int exp)
        where T : Structures.NaturallyPowered<T>, new() 
            => map(src, x => x.pow(exp));
    
    [MethodImpl(Inline)]
    static Ordering compare<T>(T lhs, T rhs)
        where T: Structures.Orderable<T>, new()
            => lhs.gt(rhs) ? Ordering.GT :
               lhs.lt(rhs) ? Ordering.LT :
               Ordering.EQ; 

    [MethodImpl(Inline)]
    public static IEnumerable<(T lhs, Ordering, T rhs)> compare<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        where T: Structures.Orderable<T>, new()
            => fuse(lhs,rhs, (l,r) =>  (l, compare(l,r), r));


    /// <summary>
    /// Calculates the square root of each element in the source sequence
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The operand type</typeparam>
    /// <returns></returns>    
    [MethodImpl(Inline)]
    public static IEnumerable<T> sqrt<T>(IEnumerable<T> src)
        where T: Structures.Floating<T>, new()
            => map(src,x => x.sqrt());


    /// Calculates the square root of each element in the source sequence
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The operand type</typeparam>
    /// <returns></returns>    
    [MethodImpl(Inline)]
    public static IEnumerable<T> abs<T>(IEnumerable<T> src)
        where T: Structures.Number<T>, new()
            => map(src,x => x.abs());


    /// <summary>
    /// Fuses two sequences via addition
    /// </summary>
    /// <param name="lhs">The left sequence</param>
    /// <param name="rhs">The right sequence</param>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> add<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        where T: Structures.Additive<T>, new()
            => fuse(lhs,rhs, (l,r) =>  l.add(r));

    /// <summary>
    /// Fuses two sequences via subtraction
    /// </summary>
    /// <param name="lhs">The left sequence</param>
    /// <param name="rhs">The right sequence</param>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> sub<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        where T: Structures.Subtractive<T>, new()
            => fuse(lhs,rhs, (l,r) =>  l.sub(r));

    /// <summary>
    /// Fuses two sequences via multiplication
    /// </summary>
    /// <param name="lhs">The left sequence</param>
    /// <param name="rhs">The right sequence</param>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> mul<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        where T: Structures.Multiplicative<T>, new()
            => fuse(lhs,rhs, (l,r) =>  l.mul(r));

    /// <summary>
    /// Fuses two sequences via division
    /// </summary>
    /// <param name="lhs">The left sequence</param>
    /// <param name="rhs">The right sequence</param>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> div<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        where T: Structures.Divisive<T>, new()
            => fuse(lhs,rhs, (l,r) =>  l.div(r));

    /// <summary>
    /// Computes the minimum of the input sequence
    /// </summary>
    /// <param name="src">The input sequence</param>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static T min<T>(IEnumerable<T> src)
        where T : struct, Structures.Orderable<T>
    {
        T min = src.FirstOrDefault();
        foreach(var item in src)
            min = item.lt(min) ? item : min;
        return min;
    }

    /// <summary>
    /// Computes the minimum of the parameter array
    /// </summary>
    /// <param name="src">The input sequence</param>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static T min<T>(params T[] src)
        where T : struct, Structures.Orderable<T>
        => min((IEnumerable<T>)src);

    [MethodImpl(Inline)]
    public static T max<T>(T x, T y)
        where T : Structures.Orderable<T>, new()
            => x.gt(y) ? x : y;

    [MethodImpl(Inline)]
    public static T max<T>(IEnumerable<T> src)
        where T : struct, Structures.Orderable<T>
    {
        T max = src.FirstOrDefault();
        foreach(var item in src)
            max = item.gt(max) ? item : max;
        return max;
    }

    [MethodImpl(Inline)]
    public static T max<T>(params T[] src)
        where T : struct, Structures.Orderable<T>
        => max((IEnumerable<T>)src);

    /// <summary>
    /// Accumulates the elements of the input sequence
    /// </summary>
    /// <param name="src"></param>
    /// <typeparam name="T"></typeparam>
    [MethodImpl(Inline)]
    public static T sum<T>(IEnumerable<T> src)
        where T : Structures.Additive<T>, Structures.Nullary<T>, new()
    {
        var s = new T().zero;
        iter(src, x => s = x.add(s));
        return s;
    }

    public static T avg<T>(IEnumerable<T> src)
        where T : Structures.RealNumber<T>,new()
    {
        var prototype = new T();
        var result = prototype.zero;
        var count = prototype.zero;
        foreach(var val in src)
        {
            result = result.add(val);
            count = count.inc();
        }
        return count.neq(count.zero) ? result.div(count) : result;
    }

    [MethodImpl(Inline)]
    public static string hexstring(byte src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(sbyte src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(short src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(ushort src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(int src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(uint src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(long src)
        => src.ToString("X");

    [MethodImpl(Inline)]
    public static string hexstring(ulong src)
        => src.ToString("X");

    [MethodImpl(Inline)]   
    public static string hexstring(BigInteger x)
        => x.ToString("X");

    [MethodImpl(Inline)]   
    public static string hexstring(decimal src)
        => apply(Bits.split(src), parts =>
            append(
                parts.hihi.ToString("X8"),
                parts.hilo.ToString("X8"),
                parts.lohi.ToString("X8"),
                parts.lolo.ToString("X8")
            ));


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
}

