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
    /// Constructs a non-valued option
    /// </summary>
    /// <typeparam name="A">The underlying type</typeparam>
    /// <returns></returns>
    public static Option<A> none<A>() 
        => Option<A>.None;
    
    /// <summary>
    /// Constructs a valued option
    /// </summary>
    /// <param name="value">The option value</param>
    /// <typeparam name="A">The underlying type</typeparam>
    /// <returns></returns>
    public static Option<A> some<A>(A value) 
        => new Option<A>(value);

    /// <summary>
    /// Applies a function to elements of an input sequence to produce 
    /// a transformed output sequence
    /// </summary>
    /// <param name="f">The function to be applied</param>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="A">The input element type</typeparam>
    /// <typeparam name="B">The output element type</typeparam>
    /// <returns></returns>
    public static IEnumerable<B> map<A,B>(IEnumerable<A> src, Func<A,B> f)
        => src.Select(x => f(x));

    public static Option<Y> map<X,Y>(Option<X> src, Func<X,Y> f)
        => src.exists ? f(src.value) : none<Y>();

    public static Y map<X,Y>(X x,Func<X,Y> f)
        => f(x);

    /// <summary>
    /// Explicitly casts a source value to value of the indicated type, raising
    /// an exception if operation fails
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    /// <returns></returns>
    public static T cast<T>(object src) => (T) src;

    /// <summary>
    /// Applies a function to elements of an input sequence to produce 
    /// a transformed output sequence
    /// </summary>
    /// <param name="f">The function to be applied</param>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="A">The input element type</typeparam>
    /// <typeparam name="B">The output element type</typeparam>
    /// <returns></returns>
    public static IEnumerable<B> mapi<A,B>(Func<int,A,B> f, IEnumerable<A> src)
    {
        var i = 0;
        foreach(var item in src)
            yield return f(i++,item);
    }

    /// <summary>
    /// The univeral identity function that returns the source value
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="A">The source value type</typeparam>
    /// <returns>The source value</returns>
    public static A  identity<A>(A x) => x;


    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    public static Core.Vector<N,T> vector<N,T>(params T[] components)
        where N : TypeNat, new()
            => new Core.Vector<N,T>(components);

    /// <summary>
    /// Constructs a covector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    public static Core.Covector<N,T> covector<N,T>(params T[] components)
        where N : TypeNat, new()
            => new Core.Covector<N,T>(components);

    /// <summary>
    /// Constructs a covector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    public static Core.Covector<N,T> covector<N,T>(IReadOnlyList<T> components)
        where N : TypeNat, new()
            => new Core.Covector<N,T>(components);


    /// <summary>
    /// Constructs integrally-keyed associative array, otherwise known
    /// as a list from an enumeration
    /// </summary>
    /// <param name="values"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Core.Index<T> list<T>(IEnumerable<T> values)
        => new Core.Index<T>(values);

    /// <summary>
    /// Constructs a citation for a bibliographic resource
    /// </summary>
    /// <param name="resource">The referenced biblography resource</param>
    /// <param name="location">The location of interest within the referenced work</param>
    /// <returns></returns>
    public static Citation cite(Resource resource, int location)
        => Citation.define(resource,location);

    /// <summary>
    /// Concatenates an arbitrary number of strings
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    public static string concat(params string[] src) => string.Concat(src);
    
    /// <summary>
    /// Concatenates an arbitrary number of string representations
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    /// <returns></returns>
    public static string concat<T>(IEnumerable<T> src) 
        => string.Concat(src);

    /// <summary>
    /// Defines a symbol
    /// </summary>
    /// <param name="name">The name of the symbol</param>
    /// <param name="description">Formal or informal description depending on context/needs</param>
    /// <returns></returns>
    public static Expose.Symbol symbol(string name, string description = null)
        => new Expose.Symbol(name,description);

    /// <summary>
    /// Returns the name of the supplied type
    /// </summary>
    /// <param name="full">Whether the full name should be returned</param>
    /// <typeparam name="T">The type to examine</typeparam>
    /// <returns></returns>
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
    
    public static T fold<T>(IEnumerable<T> src, Func<T,T,T> f, T a0 = default(T))
    {
        var cumulant = a0;
        foreach(var item in src)
            cumulant = f(cumulant,item);            
        return cumulant;
    }

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
    /// Retrieves the representative of the set of rational numbers
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Q Q() 
        => Core.Q.Inhabitant;

    /// <summary>
    /// Retrieves the representative of the set of integers
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Z Z() 
        => Core.Z.Inhabitant;

    /// <summary>
    /// Retrieves the representative of the set of real numbers
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static R R() 
        => Core.R.Inhabitant;

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
    /// Iterates over the supplied items, invoking a receiver for each
    /// </summary>
    /// <param name="src">The source items</param>
    /// <param name="f">The receiver</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]   
    public static void iter<T>(IEnumerable<T> src, Action<T> f)
    {
        foreach(var item in src)
            f(item);
    }

    /// <summary>
    /// Attaches a 0-based integer sequence to the input value sequence and
    /// yield the paired sequence elements
    /// </summary>
    /// <param name="i">The index of the paired value</param>
    /// <param name="value">The indexed value</param>
    /// <typeparam name="T">The item type</typeparam>
    public static IEnumerable<(int i, T value)> iteri<T>(IEnumerable<T> items)
    {
        var idx = 0;
        foreach(var item in items)
            yield return (idx++, item);
    }


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


    /// <summary>
    /// Left-Pads the input string with an optionally-specified character.
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <param name="c">The padding character, if specifed; otherwise, a space is used as the filler</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string lpad(string src, int width, char? c = null)
        => src.PadLeft(width,c ?? ' ');

    /// <summary>
    /// Left-Pads the input string with zeros
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string lpadZ(string src, int width)
        => src.PadLeft(width,'0');

    /// <summary>
    /// Right-Pads the input string with an optionally-specified character.
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <param name="c">The padding character, if specifed; otherwise, a space is used as the filler</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string rpad(string src, int width, char? c = null)
        => src.PadRight(width,c ?? ' ');

    /// <summary>
    /// Right-Pads the input string with zeros
    /// </summary>
    /// <param name="src">The input text</param>
    /// <param name="width">The with of the padded string</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static string rpadZ(string src, int width)
        => src.PadRight(width,'0');

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
    public static num<T> min<T>(num<T> x, num<T> y)
        where T : new()
        => x < y ? x : y;

    [MethodImpl(Inline)]
    public static num<T> max<T>(num<T> x, num<T> y)
        where T : new()
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

    public static string format<T>(T x)
        => x.ToString();
}

