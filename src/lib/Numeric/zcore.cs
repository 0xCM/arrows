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
    /// Specifies operations applicable to any integer
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static Integer<T> integer<T>()
        => ops<T,Integer<T>>();

    /// <summary>
    /// Specifies operations applicable signed ingegers
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static SignedInt<T> signedint<T>()
        => ops<T,SignedInt<T>>();

    /// <summary>
    /// Specifies operations applicable unsigned integers
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static Natural<T> natural<T>()
        => ops<T,Natural<T>>();

    /// <summary>
    /// Specifies operations applicable to any number
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static Number<T> number<T>()
        => ops<T, Traits.Number<T>>();

    /// <summary>
    /// Specifies operations applicable to ordered numbers
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static OrderedNumber<T> ordnum<T>()
        => ops<T, Traits.OrderedNumber<T>>();

    /// <summary>
    /// Specifies operations applicable to any real number
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static Real<T> real<T>()
        => ops<T, Traits.Real<T>>();

    /// <summary>
    /// Constructs a generic real from a byte primitive 
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(byte x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a generic real from a sbyte primitive 
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(sbyte x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a generic real from a short primitive 
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(short x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a generic real from a ushort primitive 
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(ushort x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a generic real from a primitive int
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(int x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a generic real from a primitive uint
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(uint x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a generic real from a primitive long
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(long x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a generic real from a primitive ulong
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(ulong x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a generic real from a primitive float
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(float x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a generic real from a primitive double 
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(double x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a generic real from a primitive decimal
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The target primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(decimal x)
        => convert<T>(x);

    /// <summary>
    /// Constructs a real byte from a primitive byte
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> real(byte x)
        => x;

    /// <summary>
    /// Constructs a real sbyte from a primitive sbyte
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> real(sbyte x)
        => x;

    /// <summary>
    /// Constructs a real short from a primitive short
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> real(short x)
        => x;

    /// <summary>
    /// Constructs a real ushort from a primitive ushort
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> real(ushort x)
        => convert<ushort>(x);

    /// <summary>
    /// Constructs a real int from a primitive int
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> real(int x)
        => x;

    /// <summary>
    /// Constructs a real uint from a primitive uint
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> real(uint x)
        => x;

    /// <summary>
    /// Constructs a real long from a primitive long
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> real(long x)
        => x;

    [MethodImpl(Inline)]
    public static real<ulong> real(ulong x)
        => x;

    [MethodImpl(Inline)]
    public static real<float> real(float x)
        => x;

    [MethodImpl(Inline)]
    public static real<double> real(double x)
        => x;

    [MethodImpl(Inline)]
    public static real<decimal> real(decimal x)
        => x;


    /// <summary>
    /// Specifies operations applicable to floating point numbers
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [MethodImpl(Inline)]
    public static FiniteFloat<T> floating<T>()
        => ops<T,FiniteFloat<T>>();

    /// <summary>
    /// Constructs a generic integer
    /// </summary>
    /// <param name="value">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static intg<T> intg<T>(T value)
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
        => new real<T>(x);

    /// <summary>
    /// Constructs a generic float
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static floatg<T> floatg<T>(T x)
        => new floatg<T>(x);


    /// <summary>
    /// Computes the integral divisors of a number, exluding 1 and the number itself
    /// </summary>
    /// <param name="src">The source value</param>
    public static IEnumerable<intg<T>> divisors<T>(intg<T> src)
        where T : new()
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
        where T : new()
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
    public static T acaddmul<T>(Semiring<T> sr, Traits.FiniteSeq<T> a, Traits.FiniteSeq<T> b)
    {
        var result = sr.zero;
        for(var i=0; i < min<int>(a.count, b.count); i++)
            result = sr.add(result,  sr.mul(a[i], b[i]));
        return result;
    }

    /// <summary>
    /// Computes the sign of the product of two numbers
    /// </summary>
    /// <param name="lhs">The left number</param>
    /// <param name="rhs">The right number</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Sign sigmul<T>(T lhs,T rhs)
        where T : Number<T>, new()
            => (number<T>().sign(lhs),number<T>().sign(rhs)) switch   
                {
                    (Sign.Negative, Sign.Positive) => Sign.Negative,
                    (Sign.Positive, Sign.Negative) => Sign.Negative,
                    (Sign.Positive, Sign.Positive) => Sign.Positive,
                    (Sign.Negative, Sign.Negative) => Sign.Positive,
                    (Sign.Neutral, _) => Sign.Neutral,
                    (_, Sign.Neutral) => Sign.Neutral,
                    _ => Sign.Neutral
                };
}

