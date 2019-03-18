//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Numerics;



    public interface TypeNat
    {
        int natval {get;}
    }

    public interface NatSeq : TypeNat
    {
        
    }


    /// <summary>
    /// Characterizes a typenat
    /// </summary>
    /// <typeparam name="T0">The represented type</typeparam>
    public interface TypeNat<T0> : TypeNat 
        where T0: TypeNat
    {
        T0 current {get;}
    }

    /// <summary>
    /// Characterizes a typenat and its successor
    /// </summary>
    /// <typeparam name="T0">The represented type</typeparam>
    /// <typeparam name="T1">The type of the successor</typeparam>
    public interface TypeNat<T0,T1> : TypeNat<T0>
        where T0: TypeNat
        where T1: TypeNat
    {
        /// <summary>
        /// The singleton value of the representative
        /// </summary>
        /// <value></value>
        T1 next {get;}
    }

}