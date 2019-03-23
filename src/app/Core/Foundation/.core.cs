//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Core;
using static Core.Credit;
using static corefunc;
using static Core.Traits;


public static partial class corefunc
{
    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    /// <summary>
    /// Specifies the generic type definition for a specified generic type
    /// </summary>
    /// <typeparam name="T">The generic type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Type typedef(Type t)
        => t.GetGenericTypeDefinition();


    /// <summary>
    /// Creates an instance of a specified type
    /// </summary>
    /// <param name="t">The type of the instance to create</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static T instance<T>(Type t, params object[] args)
        => (T)Activator.CreateInstance(t,args);


    /// <summary>
    /// Constructs a non-valued option
    /// </summary>
    /// <typeparam name="A">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Option<A> none<A>() 
        => Option<A>.None;
    
    /// <summary>
    /// Constructs a valued option
    /// </summary>
    /// <param name="value">The option value</param>
    /// <typeparam name="A">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Option<A> some<A>(A value) 
        => new Option<A>(value);



    /// <summary>
    /// Explicitly casts a source value to value of the indicated type, raising
    /// an exception if operation fails
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static T cast<T>(object src) 
        => (T) src;


    /// <summary>
    /// The univeral identity function that returns the source value
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="A">The source value type</typeparam>
    /// <returns>The source value</returns>
    [MethodImpl(Inline)]   
    public static A  identity<A>(A x) => x;

    /// <summary>
    /// Constructs a citation for a bibliographic resource
    /// </summary>
    /// <param name="resource">The referenced biblography resource</param>
    /// <param name="location">The location of interest within the referenced work</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Citation cite(Resource resource, int location)
        => Citation.define(resource,location);

    /// <summary>
    /// Concatenates an arbitrary number of strings
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string concat(params string[] src) => string.Concat(src);
    
    /// <summary>
    /// Concatenates an arbitrary number of string representations
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string concat<T>(IEnumerable<T> src) 
        => string.Concat(src);

    /// <summary>
    /// Concatenates an arbitrary number of string representations,
    /// separated by a specified delimiter
    /// </summary>
    /// <param name="delimiter">The separator</param>
    /// <param name="src">The values for which string representations will
    /// be formed</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string concat<T>(string delimiter, IEnumerable<T> src) 
        => string.Join(delimiter, src.Select(x => x.ToString()));

    /// <summary>
    /// Defines a symbol
    /// </summary>
    /// <param name="name">The name of the symbol</param>
    /// <param name="description">Formal or informal description depending on context/needs</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Expose.Symbol symbol(string name, string description = null)
        => new Expose.Symbol(name,description);

    /// <summary>
    /// Returns the name of the supplied type
    /// </summary>
    /// <param name="full">Whether the full name should be returned</param>
    /// <typeparam name="T">The type to examine</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string typename<T>(bool full = false)
        => typeof(T).Name;

    /// <summary>
    /// Returns the System.Type of the supplied parametric type
    /// </summary>
    /// <typeparam name="T">The source type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Type type<T>() 
        => typeof(T);

    /// <summary>
    /// Returns a pair of System.Type 
    /// </summary>
    /// <typeparam name="T0">The first source type</typeparam>
    /// <typeparam name="T1">The second source type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Type t0,Type t1) types<T0,T1>() 
        => (typeof(T0),typeof(T1));

    /// <summary>
    /// Returns a triple of System.Type 
    /// </summary>
    /// <typeparam name="T0">The first source type</typeparam>
    /// <typeparam name="T1">The second source type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Type t0,Type t1, Type t2) types<T0,T1,T2>() 
        => (typeof(T0),typeof(T1),typeof(T2));

    /// <summary>
    /// Returns true if the input is false, false otherwise
    /// </summary>
    /// <param name="a">The value to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool not(bool a) 
        => a ? true : false;

    /// <summary>
    /// Raises a NotImplemented exception
    /// </summary>
    /// <returns></returns>
    public static T noimpl<T>() 
        => throw new NotImplementedException();

    /// <summary>
    /// Raises a NotImplemented exception
    /// </summary>
    /// <returns></returns>
    public static void noimpl() 
        => throw new NotImplementedException();

    /// <summary>
    /// Raises a NotSupportedException exception
    /// </summary>
    /// <returns></returns>
    public static T nosupport<T>()
        => throw new NotSupportedException();

    /// <summary>
    /// Replicates a given value a specified number of times
    /// </summary>
    /// <param name="value">The value to replicate</param>
    /// <param name="count">The number of replicants</param>
    /// <typeparam name="T">The replicant type</typeparam>
    /// <returns></returns>
    public static T[] repeat<T>(T value, long count)
    {
        var dst = array<T>(count);
        for(var idx = 0; idx < count; idx ++)
            dst[idx] = value;
        return dst;            
    }
    
    [MethodImpl(Inline)]   
    public static T[] repeat<N,T>(T value)
        where N : TypeNat, new()
        => repeat(value, natval<N>());

    [MethodImpl(Inline)]   
    public static Enumerable<I> items<I>(params I[] src)
        => src.Reify();

    /// <summary>
    /// Encloses text content between left and right braces
    /// </summary>
    /// <param name="content">The content to be embraced</param>
    /// <returns></returns>
    public static string embrace(object content)      
        => $"{AsciSym.Lbrace}{content}{AsciSym.Rbrace}";

    /// <summary>
    /// Constructs the default set associated with a type whose elements
    /// consist of all potential values of the type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Set<T> set<T>() 
        => TotalSet<T>.Inhabitant;


    /// <summary>
    /// Constructs an arrow, based at a specified source, projecting
    /// onto a specified value
    /// </summary>
    /// <param name="a">The source point in the domain</param>
    /// <param name="b">The target point in the codomain</param>
    /// <typeparam name="A">The domain type</typeparam>
    /// <typeparam name="B">The codomain type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Core.PointedArrow<A,B> arrow<A,B>(A a, B b, string label = null)
        => new Core.PointedArrow<A,B>(a,b,label);



    /// <summary>
    /// Renders the suppled value as text and emits the text, and a carriage return, 
    /// to the console
    /// </summary>
    /// <param name="x">The value to reveal</param>
    [MethodImpl(Inline)]   
    public static void print<T>(T x)
        => Console.WriteLine(x);

    /// <summary>
    /// Writes an empty line to the console
    /// </summary>
    /// <param name="x">The value to reveal</param>
    [MethodImpl(Inline)]   
    public static void print()
        => Console.WriteLine();

    /// <summary>
    /// Invokes the print operation for each item in the sequence
    /// </summary>
    /// <param name="x">The value to reveal</param>
    [MethodImpl(Inline)]   
    public static void printeach<T>(IEnumerable<T> items)
        => iter(items, print) ;


    /// <summary>
    /// Demands truth that enforced with an exeption upon false
    /// </summary>
    /// <param name="x">The value to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool demand(bool x)
        => x ? x : throw new ArgumentException();

    [MethodImpl(Inline)]   
    public static Stopwatch stopwatch() 
        => Stopwatch.StartNew();

    [MethodImpl(Inline)]   
    public static long elapsed(Stopwatch sw) 
        => sw.ElapsedMilliseconds;

    [MethodImpl(Inline)]   
    public static O ops<T,O>()
        => Resolve.ops<T,O>();
    
    [MethodImpl(Inline)]
    public static Traits.Semigroup<T> semigroup<T>() 
        => Resolve.ops<T,Traits.Semigroup<T>>();

    [MethodImpl(Inline)]
    public static Traits.Semiring<T> semiring<T>() 
        => Resolve.ops<T,Traits.Semiring<T>>();


    [MethodImpl(Inline)]
    public static intg<T> min<T>(intg<T> x, intg<T> y)
        => x < y ? x : y;


    [MethodImpl(Inline)]
    public static intg<T> max<T>(intg<T> x, intg<T> y)
        => x > y ? x : y;

    [MethodImpl(Inline)]
    public static Func<S,T,U> curry<S,T,U>(Func<(S,T), U> f)
    {
        U g(S a, T b) => f((a,b));        
        return g;
    }

    public static T acaddmul<T>(Semiring<T> sr, IReadOnlyList<T> a, IReadOnlyList<T> b)
    {
        var result = sr.zero;
        for(var i=0; i < min<int>(a.Count, b.Count); i++)
            result = sr.add(result,  sr.mul(a[i], b[i]));
        return result;
    }

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static byte[] digits(uint x)
        => x.ToIntG<uint>().digits();
}

