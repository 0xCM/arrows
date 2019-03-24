//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using Core;


using static corefunc;
using static Core.Operations;

partial class corefunc
{

    /// <summary>
    /// Constructs a generic integer
    /// </summary>
    /// <param name="value">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static intg<T> intg<T>(T value)
        => new intg<T>(value);

    /// <summary>
    /// Constructs a generic number
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static num<T> numg<T>(T x)
        => new num<T>(x);

    /// <summary>
    /// Constructs a generic float
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static floatg<T> floatg<T>(T x)
        => new floatg<T>(x);

    /// <summary>
    /// Constructs a generic rational number
    /// </summary>
    /// <param name="over">The numerator</param>
    /// <param name="under">The denominator</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static fraction<T> ratio<T>(T over, T under)
        where T : Traits.Integer<T>, new()
            => new fraction<T>(over,under);

    /// <summary>
    /// Computes the modulus (remainder) for two generic numbers
    /// </summary>
    /// <param name="lhs">The value to divide</param>
    /// <param name="rhs">The value to divide by</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static num<T> mod<T>(T lhs, T rhs)
        => numg<T>(lhs).mod(rhs);

    /// <summary>
    /// Computes the square root for a generic float
    /// </summary>
    /// <param name="x">The operand</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static floatg<T> sqrt<T>(T x)
        => floatg<T>(x).sqrt();

    /// <summary>
    /// Enumerates the divisors of the input values, excluding 1 and itself
    /// </summary>
    /// <param name="src"></param>
    /// <returns></returns>
    public static IEnumerable<intg<T>> divisors<T>(intg<T> src)
        where T : new()
    {        
        var zero = Core.intg<T>.Zero;
        var one = Core.intg<T>.One;
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

    [MethodImpl(Inline)]   
    public static bool prime<T>(intg<T> x)
        where T : new()
    {
        var upperBound = x.ToFloatG().sqrt().ceiling().ToIntG<T>();   
        return divisors(x).Count() == 0;
    }            

    // [MethodImpl(Inline)]   
    // public static bool prime(intg<ulong> x)
    //     => prime<ulong>(x);

    // [MethodImpl(Inline)]   
    // public static bool prime(intg<uint> x)
    //     => prime<uint>(x);

    // [MethodImpl(Inline)]   
    // public static bool prime(intg<long> x)
    //     => prime(x.ToIntG<ulong>());

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
    public static mod<N,T> modring<N,T>(T lhs)
        where N : TypeNat, new()
            => new mod<N,T>(lhs);

    /// <summary>
    /// Specifies the canoncial representative of the set of rational numbers
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Q Q() 
        => Core.Q.Inhabitant;

    /// <summary>
    /// Specifies the canoncial representative of the set of integers
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Z Z() 
        => Core.Z.Inhabitant;

    /// <summary>
    /// Specifies the canoncial representative of the set of real numbers
    /// </summary>
    [MethodImpl(Inline)]   
    public static R R() 
        => Core.R.Inhabitant;

    public static T acaddmul<T>(Traits.Semiring<T> sr, IReadOnlyList<T> a, IReadOnlyList<T> b)
    {
        var result = sr.zero;
        for(var i=0; i < min<int>(a.Count, b.Count); i++)
            result = sr.add(result,  sr.mul(a[i], b[i]));
        return result;
    }

}

