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
using Symbols;
using static Core.Credit;
using static corefunc;
using static Core.Class;


public static partial class corefunc
{
    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    /// <summary>
    /// Constructs a left-valuedcopair
    /// </summary>
    /// <param name="left"></param>
    /// <typeparam name="A">The left type</typeparam>
    /// <typeparam name="B">The right type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Reify.Copair<A,B> copair<A,B>(A left)
        => new Reify.Copair<A, B>(left);

    /// <summary>
    /// Constructs a right-valued copair
    /// </summary>
    /// <param name="right"></param>
    /// <typeparam name="A">The left type</typeparam>
    /// <typeparam name="B">The right type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Reify.Copair<A,B> copair<A,B>(B right)
        => new Reify.Copair<A, B>(right);


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
    /// Constructs an associative array
    /// </summary>
    /// <param name="items">Item tuples that will be indexed/stored</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static Index<K,V> index<K,V>(IEnumerable<(K key,V value)> items)
        => new Reify.Index<K,V>(items);

    /// <summary>
    /// Constructs an associative array
    /// </summary>
    /// <param name="items">Keyed values that will be indexed/stored</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static Index<K,V> index<K,V>(IEnumerable<KeyedValue<K,V>> items)
        => new Reify.Index<K,V>(items);

    /// <summary>
    /// Constructs an integrally-indexed associative array
    /// </summary>
    /// <param name="value">The value</param>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static Reify.Index<V> index<V>(IEnumerable<V> items)
        => new Reify.Index<V>(items);

    /// <summary>
    /// Constructs an index from a collection of of 2-tuples
    /// </summary>
    /// <param name="src">The collection of 2-tuples from which to construct an index</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static Index<K,V> index<K,V>((K key, V value)[] src)
        => new Reify.Index<K,V>(map(src,kvp));

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
    /// Constructs a keyed value
    /// </summary>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static KeyedValue<K,V> kvp<K,V>(K key, V value)
        => new KeyedValue<K,V>(key,value);

    /// <summary>
    /// Constructs a keyed value from a 2-tuple
    /// </summary>
    /// <param name="kv">The source tuple</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static KeyedValue<K,V> kvp<K,V>( (K key, V value) kv)
        => new KeyedValue<K,V>(kv);


    /// <summary>
    /// Constructs integrally-keyed associative array, otherwise known
    /// as a list from a parameter array
    /// </summary>
    /// <param name="values"></param>
    /// <typeparam name="A"></typeparam>
    /// <returns></returns>
    public static Reify.Index<A> list<A>(params A[] values)
        => new Reify.Index<A>(values);

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    public static Reify.Vector<N,T> vector<N,T>(params T[] components)
        where N : TypeNat
            => new Reify.Vector<N,T>(components);

    /// <summary>
    /// Constructs a covector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    public static Reify.Covector<N,T> covector<N,T>(params T[] components)
        where N : TypeNat
            => new Reify.Covector<N,T>(components);

    /// <summary>
    /// Constructs a covector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    public static Reify.Covector<N,T> covector<N,T>(IReadOnlyList<T> components)
        where N : TypeNat
            => new Reify.Covector<N,T>(components);


    /// <summary>
    /// Constructs integrally-keyed associative array, otherwise known
    /// as a list from an enumeration
    /// </summary>
    /// <param name="values"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Reify.Index<T> list<T>(IEnumerable<T> values)
        => new Reify.Index<T>(values);

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
    public static Symbol symbol(string name, string description = null)
        => new Symbol(name,description);

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

   [MethodImpl(Inline)]
    public static T[] array<T>(long len)
        => new T[len];

   [MethodImpl(Inline)]
    public static Array<N,T> array<N,T>(params T[] data)
        where N : TypeNat
            => new Reify.Array<N,T>(data);

   [MethodImpl(Inline)]
    public static IEnumerable<T> seq<T>(params T[] items)
        => items;

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

    /// <summary>
    /// Extracts a pair's left member
    /// </summary>
    /// <param name="pair">The source pair</param>
    /// <typeparam name="A">The left member type</typeparam>
    /// <typeparam name="B">The right member type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static A left<A,B>(Pair<A,B> pair)
        => pair.left;

    /// <summary>
    /// Extracts a pair's right member
    /// </summary>
    /// <param name="pair">The source pair</param>
    /// <typeparam name="A">The left member type</typeparam>
    /// <typeparam name="B">The right member type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static B right<A,B>(Pair<A,B> pair)
        => pair.right;

    [MethodImpl(Inline)]   
    public static Enumerable<I> items<I>(params I[] src)
        => src.Reify();

    /// <summary>
    /// Encloses text content between left and right braces
    /// </summary>
    /// <param name="content">The content to be embraced</param>
    /// <returns></returns>
    public static string embrace(object content)      
        => $"{Asci.lbrace}{content}{Asci.rbrace}";

    /// <summary>
    /// Constructs the default set associated with a type whose elements
    /// consist of all potential values of the type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Set<T> set<T>() => TotalSet<T>.Inhabitant;


    /// <summary>
    /// Retrieves the representative of the set of rational numbers
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Q Q() => Core.Q.Inhabitant;

    /// <summary>
    /// Retrieves the representative of the set of integers
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Z Z() => Core.Z.Inhabitant;

    /// <summary>
    /// Retrieves the representative of the set of real numbers
    /// </summary>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static R R() => Core.R.Inhabitant;

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
    public static PointedArrow<A,B> arrow<A,B>(A a, B b, string label = null)
        => new PointedArrow<A,B>(a,b,label);

    /// <summary>
    /// Constructs a pair
    /// </summary>
    /// <param name="a">The value of the left member</param>
    /// <param name="b">The value of the right member</param>
    /// <typeparam name="A">The left member type</typeparam>
    /// <typeparam name="B">The right member type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Reify.Pair<A,B> pair<A,B>(A a, B b)
        => Reify.Pair.define(a,b);

    /// <summary>
    /// Constructs an elementwise cartesian product from the input sequences
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static IEnumerable<Reify.Pair<T,T>> cross<T>(IEnumerable<T> x, IEnumerable<T> y)
        => from a in x from b in y select pair(a,b);

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
    /// Retrieves the value of the natural number associated with a typenat
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static uint natval<N>() 
        where N : TypeNat
        => Nats.nat<N>().value;


    /// <summary>
    /// Retrieves the value of the natural number associated with a typenat
    /// and retuns the value if it agrees with a supplied expected value; othwise,
    /// raises an exception
    /// </summary>
    /// <param name="expected">The expected natural value</param>
    /// <typeparam name="N">The nat type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static uint natcheck<N>(uint expected)
            where N : TypeNat
           => natval<N>() == expected 
            ? expected 
            : throw new ArgumentException(); 

    /// <summary>
    /// Retrieves the value of a pair of nats
    /// </summary>
    /// <typeparam name="M">The first nat type</typeparam>
    /// <typeparam name="N">The second type</typeparam>
    /// <returns></returns>
    public static (uint m, uint n) natvals<M,N>()
        where N : TypeNat
        where M : TypeNat
            => (natval<M>(),natval<N>());            

    /// <summary>
    /// Retrieves the value of a nat triple
    /// </summary>
    /// <typeparam name="M">The first nat type</typeparam>
    /// <typeparam name="N">The second type</typeparam>
    /// <returns></returns>
    public static (uint m, uint n, uint p) natvals<M,N,P>()
        where N : TypeNat
        where M : TypeNat
        where P : TypeNat
            => (natval<M>(),natval<N>(), natval<P>());            

    /// <summary>
    /// Verfies that the lengh of a list agrees with the parameterized natural
    /// If successful, the input list is returned; otherwise, an exception is
    /// raised
    /// </summary>
    /// <param name="src">The source list</param>
    /// <typeparam name="N">The nat type</typeparam>
    /// <typeparam name="T">The list element type</typeparam>
    public static IReadOnlyList<T> natcheck<N,T>(IReadOnlyList<T> src)
            where N : TypeNat
           => natval<N>() == src.Count 
            ? src
            : throw new ArgumentException(); 

    /// <summary>
    /// Verfies that the lengh of an array agrees with the parameterized natural
    /// If successful, the input list is returned; otherwise, an exception is
    /// raised
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="N">The nat type</typeparam>
    /// <typeparam name="T">The list element type</typeparam>
    public static T[] natcheck<N,T>(params T[] src)
            where N : TypeNat
           => natval<N>() == src.Length 
            ? src
            : throw new NatConstraintException("equality", natval<N>(), (uint)src.Length); 

    /// <summary>
    /// Demands truth that enforced with an exeption upon false
    /// </summary>
    /// <param name="x">The value to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool demand(bool x)
        => x ? x : throw new ArgumentException();

    public static IEnumerable<IReadOnlyList<T>> partition<W,T>(IEnumerable<T> src)
        where W : TypeNat
    {
        var width = natval<W>();
        var sement = new T[width];
        var current = 0;
        foreach(var item in src)
        {
            if(current == width)
            {
                current = 0;
                yield return sement;
                sement = new T[width];
            }
                
            sement[current++] = item;
        }

        for(var i = current; i < width; i++)
            sement[i] = default(T);
        
        yield return sement;
    }


    [MethodImpl(Inline)]   
    public static Reify.Slice<N,T> slice<N,T>(IEnumerable<T> src)
        where N : TypeNat
            => new Reify.Slice<N,T>(src);

    [MethodImpl(Inline)]   
    public static Reify.Slice<N,T> slice<N,T>(params T[] src)
        where N : TypeNat
            => new Reify.Slice<N,T>(src);

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
        => Operations.ops<T,O>();
    
    [MethodImpl(Inline)]
    public static Class.Semigroup<T> semigroup<T>() 
        => Operations.ops<T,Class.Semigroup<T>>();

    [MethodImpl(Inline)]
    public static Class.Semiring<T> semiring<T>() 
        => Operations.ops<T,Class.Semiring<T>>();

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
}

