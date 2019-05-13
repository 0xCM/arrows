//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;


    /// <summary>
    /// Characterizes fractional operations
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IFractionalOps<T> : IRealNumberOps<T> 
        where T : struct, IEquatable<T>
    {
        T ceiling(T x);
        
        T floor(T x);

        
    }
    


   public interface IFractional<S> : IRealNumber<S> 
        where S : IFractional<S>, new()
    {
        S ceiling();
        
        S floor();

    }

    /// <summary>
    /// Characterizes a fractional structure
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IFractional<S,T> : IFractional<S>, IRealNumber<S,T> 
        where S : IFractional<S,T>, new()
    {

        
    }

    public interface IRational<T>
    {
        /// <summary>
        /// The dividend
        /// </summary>
        T Over();

        /// <summary>
        /// The divisor
        /// </summary>
        T Under();

        (T Over, T Under) Paired();

    }
    
    public interface IRational<T,R> : IRational<T>
    {

    }

    /// <summary>
    /// Charactrizes a rational number
    /// </summary>
    public interface IRational<S, T, R> : IRational<T,R>
        where S : IRational<S,T,R>,  new()
    {
    }

}