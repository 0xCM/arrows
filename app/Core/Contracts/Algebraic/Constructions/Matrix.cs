//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;

    /// <summary>
    /// Characterizes a type that supports a notion of transposition
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public interface Tranposable<S,T>
    {
        /// <summary>
        /// Effects the source-to-target transposition
        /// </summary>
        /// <param name="src">The source type</param>
        /// <returns></returns>
        T tranpose(S src);        
    }

    /// <summary>
    /// Characterizes a fixed-lenth sequence of elements
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    /// <typeparam name="N">The natural number type that indicates the slice length</typeparam>
    public interface Slice<T,N>
        where N : TypeNat
    {
        /// <summary>
        /// Specifies the slice length in accordance with natural parameter
        /// </summary>
        int length {get;}           

        /// <summary>
        /// Accesses the element at a specified index
        /// </summary>
        T this[int ix] {get;}
    }
    
    public interface Vector<T,N> : Slice<T,N>, Tranposable<Vector<T,N>, Covector<T,N>>
        where N : TypeNat
    {
        
    }

    public interface Covector<T,N> : Slice<T,N>, Tranposable<Covector<T,N>,Vector<T,N>>
        where N : TypeNat
    {
        
    }

    public interface Matrix<M,N,T> : Tranposable<Matrix<M,N,T>, Matrix<N,M,T>>
        where M : TypeNat
        where N : TypeNat
    {

    }

}