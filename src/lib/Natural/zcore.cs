//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.Traits;


public static partial class zcore
{

    /// <summary>
    /// Retrieves the value of the natural number associated with a typenat
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static uint natval<N>() 
        where N : TypeNat, new()
        => new N().value; //Nats.nat<N>().value;

    /// <summary>
    /// Returns the natural value as a generic integer
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    /// <typeparam name="T">The integral type</typeparam>
    [MethodImpl(Inline)]   
    public static intg<T> natvalg<N,T>()
        where N : TypeNat, new()
            => new N().value.ToIntG<T>(); //=> natval<N>().ToIntG<T>();

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
            where N : TypeNat, new()
           => natval<N>() == expected 
            ? expected 
            : throw new ArgumentException(); 

    [MethodImpl(Inline)]   
    public static uint natcheck<N>(int expected)
            where N : TypeNat, new()
           => natval<N>() == (uint)expected 
            ? (uint)expected 
            : throw new ArgumentException(); 


    /// <summary>
    /// Retrieves the value of a pair of nats
    /// </summary>
    /// <typeparam name="M">The first nat type</typeparam>
    /// <typeparam name="N">The second type</typeparam>
    /// <returns></returns>
    public static (uint m, uint n) natvals<M,N>()
        where N : TypeNat, new()
        where M : TypeNat, new()
            => (natval<M>(),natval<N>());            

    /// <summary>
    /// Retrieves the value of a nat triple
    /// </summary>
    /// <typeparam name="M">The first nat type</typeparam>
    /// <typeparam name="N">The second type</typeparam>
    /// <returns></returns>
    public static (uint m, uint n, uint p) natvals<M,N,P>()
        where N : TypeNat, new()
        where M : TypeNat, new()
        where P : TypeNat, new()
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
        where N : TypeNat, new()
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
        where N : TypeNat, new()
           => natval<N>() == src.Length 
            ? src
            : throw new NatConstraintException("equality", natval<N>(), (uint)src.Length); 

    /// <summary>
    /// Constructs the specifeid natural representative
    /// </summary>
    /// <typeparam name="N">The natural type</typeparam>
    /// <returns></returns>
    public static N natrep<N>()
        where N : TypeNat,new()
            => new N(); 

    
   /// <summary>
   /// Constructs a nondegenerate interval bounded by natural types
   /// </summary>
   /// <typeparam name="K1">The type of the left endpoint</typeparam>
   /// <typeparam name="K2">The type of the right endpoint</typeparam>
   /// <returns></returns>
   public static Interval<K1,K2> interval<K1,K2>()
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
            => new Interval<K1,K2>(natrep<K1>(), natrep<K2>());
}