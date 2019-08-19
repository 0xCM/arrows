//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Specifies a relation between two sets (which may or may not be identical)
    /// </summary>
    /// <typeparam name="S">The departure set type</typeparam>
    /// <typeparam name="T">The destination set type</typeparam>
    public interface IBinaryRelationOps<S,T>
    {
        bool Related(S x, T y);
    }

    /// <summary>
    /// Specifies an homogenous relation on a given set
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IBinaryRelationOps<T> : IBinaryRelationOps<T,T>
    {
        
    }

    /// <summary>
    /// Spcifies that a ~ a for every a:T
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IReflexiveOps<T> : IBinaryRelationOps<T>
    {

    }

    /// <summary>
    /// Spcifies if a,b:T & a!=b then a ~ b & b ~ a => a = b
    /// </summary>
    /// <typeparam name="S">The departure set type</typeparam>
    /// <typeparam name="T">The destination set type</typeparam>
    public interface IAntisymmetricOps<S,T> : IBinaryRelationOps<S,T>
    {

    }

    /// <summary>
    /// Spcifies if a,b:T & a!=b then a ~ b & b ~ a => a = b
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IAntisymmetricOps<T> : IAntisymmetricOps<T,T>
    {

    }

    /// <summary>
    /// Spcifies that a ~ b iff b ~ a for every a:S,b:T
    /// </summary>
    /// <typeparam name="S">The departure set type</typeparam>
    /// <typeparam name="T">The destination set type</typeparam>
    public interface ISymmetricOps<S,T> : IBinaryRelationOps<S,T>
    {
        
    }

    /// <summary>
    /// Spcifies that a ~ b iff b ~ a for every a,b:T
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface ISymmetricOps<T> : ISymmetricOps<T,T>
    {
        
    }

    /// <summary>
    /// Spcifies a ~ b & b ~ c => a ~ c for every a,b,c:T
    /// </summary>
    /// <typeparam name="S">The departure set type</typeparam>
    /// <typeparam name="T">The destination set type</typeparam>
    public interface ITransitiveOps<S,T> : IBinaryRelationOps<S,T>
    {

    }

    /// <summary>
    /// Spcifies a ~ b & b ~ c => a ~ c for every a,b,c:T
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface ITransitiveOps<T> : ITransitiveOps<T,T>
    {
        
    }        
 
}
