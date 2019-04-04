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
    /// Constructs a generic integer
    /// </summary>
    /// <param name="value">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static intg<T> intg<T>(T value)
        where T : IConvertible
            => new intg<T>(value);

    /// <summary>
    /// Constructs a generic number
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static num<T> numg<T>(T x)
        => new num<T>(x);

    /// <summary>
    /// Constructs a real number
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static real<T> real<T>(T x)
        where T: IConvertible
            => new real<T>(x);

    /// <summary>
    /// Constructs a generic float
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static floatg<T> floatg<T>(T x)
        where T : IConvertible
            => new floatg<T>(x);


    /// <summary>
    /// Computes the integral divisors of a number, exluding 1 and the number itself
    /// </summary>
    /// <param name="src">The source value</param>
    public static IEnumerable<intg<T>> divisors<T>(intg<T> src)
    {        
        var zero = Z0.intg<T>.Zero;
        var one = Z0.intg<T>.One;
        var two = one.inc();
        if(src != zero && src != one)
        {
            var upper = (src/two).inc();
            var candidates = range(two, upper);
            foreach(var c in candidates)
                if(src.mod(c) == zero )
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
        where T : IConvertible
    {
        var upperBound = x.ToFloatG().sqrt().ceiling().ToIntG<T>();   
        return divisors(x).Count() == 0;
    }                

    /// <summary>
    /// Enumerates generic integers inclusively between specified first and last values.
    /// If the first value is greater than the last, the range will be constructed
    /// in descending order.
    /// </summary>
    /// <param name="first">The first integer to yeild</param>
    /// <param name="last">The last integer to yield</param>
    /// <typeparam name="T">The underlying integral type</typeparam>
    /// <returns></returns>
    public static IEnumerable<intg<T>> range<T>(intg<T> first, intg<T> last)
    {
        var current = first;
        if(first < last)
        {
            while(current <= last)
                yield return current++;
        }
        else
        {
            while(current >= last)
                yield return current--;
        }
    }


    /// <summary>
    /// Constructs the ring of integers for a given modulus
    /// </summary>
    /// <typeparam name="N">The modulus type</typeparam>
    /// <typeparam name="T">The integral type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static modg<N,T> modring<N,T>(T lhs)
        where T : IConvertible
        where N : TypeNat, new()
            => new modg<N,T>(lhs);


    [MethodImpl(Inline)]
    public static int min(int x, int y)
        => x < y ? x : y;

    [MethodImpl(Inline)]
    public static uint min(uint x, uint y)
        => x < y ? x : y;

    [MethodImpl(Inline)]
    public static T min<T>(T x, T y)
        where T : Structures.Ordered<T>, new()
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
        where T : Structures.Powered<T>, new() 
            => map(src, x => x.pow(exp));
    
    [MethodImpl(Inline)]
    static Ordering compare<T>(T lhs, T rhs)
        where T: Structures.Ordered<T>, new()
            => lhs.gt(rhs) ? Ordering.GT :
               lhs.lt(rhs) ? Ordering.LT :
               Ordering.EQ; 

    [MethodImpl(Inline)]
    public static IEnumerable<(T lhs, Ordering, T rhs)> compare<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        where T: Structures.Ordered<T>, new()
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
        where T : struct, Structures.Ordered<T>
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
        where T : struct, Structures.Ordered<T>
        => min((IEnumerable<T>)src);

    [MethodImpl(Inline)]
    public static T max<T>(T x, T y)
        where T : Structures.Ordered<T>, new()
            => x.gt(y) ? x : y;

    [MethodImpl(Inline)]
    public static T max<T>(IEnumerable<T> src)
        where T : struct, Structures.Ordered<T>
    {
        T max = src.FirstOrDefault();
        foreach(var item in src)
            max = item.gt(max) ? item : max;
        return max;
    }

    [MethodImpl(Inline)]
    public static T max<T>(params T[] src)
        where T : struct, Structures.Ordered<T>
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


}

