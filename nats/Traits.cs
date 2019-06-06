//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Characterizes a type-level natural number, a *typenat*
    /// </summary>
    public interface ITypeNat
    {
        /// <summary>
        /// Specifies the value of the associated natural number
        /// </summary>
        ulong value {get;}

        /// <summary>
        /// Specifies the associated base-10 digits 
        /// </summary>
        byte[] Digits();

        /// <summary>
        /// Specifies the canonical sequence representative
        /// </summary>
        NatSeq seq {get;}

    }

    /// <summary>
    /// Characterizes a typenat
    /// </summary>
    /// <typeparam name="T">The represented type</typeparam>
    public interface ITypeNat<T> : ITypeNat 
        where T: ITypeNat
    {
        /// <summary>
        /// Specifies the representing type
        /// </summary>
        ITypeNat rep {get;}
    }

    /// <summary>
    /// Characterizes an enumerable with a known length as specified
    /// by a natural type parameter
    /// </summary>
    public interface IEnumerable<N,I> : IEnumerable<I>
        where N : ITypeNat, new()
    {
        /// <summary>
        /// The value of the natural parameter
        /// </summary>
        uint Length {get;}
    }

    public interface IArray<N,T> : IEnumerable<N,T>
        where N : ITypeNat, new()
    {
        /// <summary>
        /// Specifies or retrieves an array value via an unchecked index
        /// </summary>
        ref T this[int ix] {get;}
    }

    /// <summary>
    /// Characterizes the reification of a natural number k such that 
    /// a:K1 & b:K2 & k = a + b
    /// </summary>
    /// <typeparam name="K2">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatAdd<S,K1,K2> : ITypeNat
        where S : INatAdd<S,K1,K2>, new()
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
    {

    }

    public interface INatDemand 
    {

    }

    /// <summary>
    /// Characterizes a constraint on a nat
    /// </summary>
    /// <typeparam name="K1">The Nat type</typeparam>
    public interface INatDemand<K1> : INatDemand
        where K1 : ITypeNat, new()
    {
        /// <summary>
        /// Specifies whether reification satisfies demand
        /// </summary>
        /// <remarks>
        /// Any attempt to instantiate an invalid reification should fail
        /// and thus this attribute should always be true
        /// </remarks>
        bool valid {get;}
    }
    
    /// <summary>
    /// Characterizes binary relationship between two nats
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatDemand<K1,K2> : INatDemand
        where K1 : ITypeNat, new()
        where K2 : ITypeNat
    {
        
    }

    /// <summary>
    /// Characterizes ternary relationship among three nats
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    /// <typeparam name="K3">The third nat type</typeparam>
    public interface IDemand<K1,K2,K3> : INatDemand
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
        where K3 : ITypeNat, new()
    {
        
    }

    /// <summary>
    /// Requires n:K & n1:K1 & n2:K2 => n1 <= n <= n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatBetween<K,K1,K2> : IDemand<K,K1,K2>
        where K : ITypeNat, new()
        where K1: ITypeNat, new()
        where K2: ITypeNat, new()
    {
        
    }

    /// <summary>
    /// Requires n1:T1 & n2:T2 => n1 == n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatEq<K1,K2> : INatDemand<K1,K2>
        where K1: ITypeNat, new()
        where K2: ITypeNat, new()
    {
        
    }

    /// <summary>
    /// Requires n1:T1 & n2:T2 => n1 != n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatNEq<K1,K2> : INatDemand<K1,K2>
        where K1: ITypeNat, new()
        where K2: ITypeNat, new()
    {
        
    }

    /// <summary>
    /// Requires k1:K1, k2:K2 => k1 > k2
    /// </summary>
    /// <typeparam name="K1">The larger nat type</typeparam>
    /// <typeparam name="K2">The smaller nat type</typeparam>
    public interface INatGt<K1,K2> : INatDemand<K1,K2>
        where K1: ITypeNat, new()
        where K2: ITypeNat, new()
    {
        
    }

    /// <summary>
    /// Requires k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    /// <typeparam name="K3">The third nat type</typeparam>
    public interface INatMod<K1,K2,K3> : IDemand<K1,K2,K3>
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
        where K3 : ITypeNat, new()
    {

    }

    /// <summary>
    /// Requires k:K => k % 2 == 0
    /// </summary>
    /// <typeparam name="K">An even natural type</typeparam>
    public interface INatEven<K> : INatDemand<K>
        where K : ITypeNat, new()
    {

    }

    /// <summary>
    /// Requires k:K => k % 2 != 0
    /// </summary>
    /// <typeparam name="K">An Odd natural type</typeparam>
    public interface INatOdd<K> : INatDemand<K>
        where K : ITypeNat, new()
    {

    }

    /// <summary>
    /// Requires k1: K1 & k2:K2 => k1 - 1 = k2
    /// </summary>
    /// <typeparam name="K1"></typeparam>
    /// <typeparam name="K2"></typeparam>
    public interface INatPrior<K1,K2> : INatGt<K1,K2>
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
    {

    }       

    /// <summary>
    /// Characterizes the reification of a natural number k such that 
    /// a:K1 & b:K2 & k = a * b
    /// </summary>
    /// <typeparam name="K2">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatMul<S,K1,K2> : ITypeNat
        where S : INatMul<S,K1,K2>, new()
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
    {

    }

    /// <summary>
    /// Characterizes a natural k such that b:B & e:E => k = b^e
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatPow<B,E> : ITypeNat
        where B : ITypeNat, new()
        where E : ITypeNat, new()
    {
        
    }

    public interface INatPow2 : ITypeNat
    {
        ITypeNat Exponent {get;}        
    }

    /// <summary>
    /// Characterizes a natural k such that e:E => k = 2^e
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatPow2<E> : INatPow2, INatPow<N2,E>
        where E : ITypeNat, new()
    {

    }

    /// <summary>
    /// Characterizes the reification of a natural k such that 
    /// b:B & e:E => k = b^e
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatPow<S,B,E> : INatPow<B,E>, ITypeNat<S>
        where S : INatPow<S,B,E>, new()
        where B : ITypeNat, new()
        where E : ITypeNat, new()
    {
        
    }

    /// <summary>
    /// Characterizes the reification of a natural number k such that 
    /// a:K1 & b:K2 & k = a - b
    /// </summary>
    /// <typeparam name="K2">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface INatSub<S,K1,K2> : ITypeNat
        where S : INatSub<S,K1,K2>, new()
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
    {

    }

    /// <summary>
    /// Characterizes operational aspects of a N-dimensional vector space over 
    /// a field K inhabited by vectors from and abelian group A
    /// </summary>
    /// <typeparam name="N">The dimension type</typeparam>
    /// <typeparam name="K">The field type</typeparam>
    /// <typeparam name="G">The indidual type</typeparam>
    public interface IVectorSpaceOps<N,K,G> : ILeftModuleOps<K,G>
        where N : ITypeNat, new()
        where G : IGroupAOps<G>, new()
        where K : IFieldOps<K>, new()
    {

    }

    /// <summary>
    /// Requires k1:K1 & k2:K2 => k1 + 1 = k2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatNext<K1,K2> : INatLt<K1,K2> 
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
    {

    } 


    /// <summary>
    /// Requires n:T => n is prime
    /// </summary>
    /// <typeparam name="K">A prime nat type</typeparam>
    public interface INatPrime<K> : INatDemand<K>
        where K : ITypeNat, new()
    {
        
    }

    /// <summary>
    /// Requires n:T =>  n = p^m for some prime number p and and integer m
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPrimePower<T> : INatDemand<T>
        where T : ITypeNat, new()
    {

    }

    /// <summary>
    /// Requires m:T =>  m = p^n for some prime number p and and natural n
    /// </summary>
    /// <typeparam name="P">The prime type</typeparam>
    /// <typeparam name="N">The power type</typeparam>
    public interface IPrimePower<P,N> : INatDemand<P,N>
        where P : ITypeNat, INatPrime<P>,new()
        where N : ITypeNat, new()
    {

    }

    /// <summary>
    /// Requires n1:T1 & n2:T2 => n1 < T2
    /// </summary>
    public interface INatLt<K1,K2> : INatDemand<K1,K2>
        where K1: ITypeNat, new()
        where K2: ITypeNat, new()
    {
        
    }

    /// <summary>
    /// Requires k:K => k != 0
    /// </summary>
    /// <typeparam name="K">A nonzero natural type</typeparam>
    public interface INatNonZero<K> : INatDemand<K>, INatGt<K,N0>
        where K : ITypeNat, new()
    {

    }

    public interface IDim
    {
        
    }
}