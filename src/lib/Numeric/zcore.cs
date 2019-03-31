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
        where T : IConvertible
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
    /// Renders a generic number as a bitstring
    /// </summary>
    /// <param name="src">The source number</param>
    /// <typeparam name="T">The unerlying numeric type</typeparam>
    [MethodImpl(Inline)]   
    public static string bitstring<T>(num<T> src)
        => src.bitstring();

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

    /// <summary>
    /// Specifies the canoncial representative of the set of rational numbers
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Q Q() 
        => Z0.Q.Inhabitant;

    /// <summary>
    /// Specifies the canoncial representative of the set of integers
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Z Z() 
        => Z0.Z.Inhabitant;

    /// <summary>
    /// Specifies the canoncial representative of the set of real numbers
    /// </summary>
    [MethodImpl(Inline)]   
    public static R R() 
        => Z0.R.Inhabitant;

    [MethodImpl(Inline)]
    public static intg<T> min<T>(intg<T> x, intg<T> y)
        => x < y ? x : y;


    [MethodImpl(Inline)]
    public static intg<T> max<T>(intg<T> x, intg<T> y)
        => x > y ? x : y;

    [MethodImpl(Inline)]   
    public static T acaddmul<T>(Operative.Semiring<T> sr, Structure.FiniteSeq<T> a, Structure.FiniteSeq<T> b)
    {
        var result = sr.zero;
        for(var i=0; i < min<uint>(a.count, b.count); i++)
            result = sr.add(result,  sr.mul(a[i], b[i]));
        return result;
    }

    /// <summary>
    /// Computes the sign of the product of two numbers
    /// </summary>
    /// <param name="lhs">The left number</param>
    /// <param name="rhs">The right number</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static Sign sigmul<T>(T lhs,T rhs)
        where T : Operative.Number<T>, new()
            => (Resolver.number<T>().sign(lhs),Resolver.number<T>().sign(rhs)) switch   
                {
                    (Sign.Negative, Sign.Positive) => Sign.Negative,
                    (Sign.Positive, Sign.Negative) => Sign.Negative,
                    (Sign.Positive, Sign.Positive) => Sign.Positive,
                    (Sign.Negative, Sign.Negative) => Sign.Positive,
                    (Sign.Neutral, _) => Sign.Neutral,
                    (_, Sign.Neutral) => Sign.Neutral,
                    _ => Sign.Neutral
                };

    /// <summary>
    /// Constructs a bit from the data in an integral value at a specified position
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="pos">The bit position</param>
    /// <typeparam name="T">The underlying integral type</typeparam>
    [MethodImpl(Inline)]   
    public static bit bit<T>(intg<T> x, int pos)
        => Bits.bit(x, pos);
}

