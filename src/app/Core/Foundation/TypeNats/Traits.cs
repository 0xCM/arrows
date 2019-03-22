//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;



    public interface TypeNat
    {
        /// <summary>
        /// Specifies the value of the natural number represented by a singleton type
        /// </summary>
        uint value {get;}

    }

    

    /// <summary>
    /// Characterizes a typenat
    /// </summary>
    /// <typeparam name="T0">The represented type</typeparam>
    public interface TypeNat<T0> : TypeNat 
        where T0: TypeNat
    {
        /// <summary>
        /// Specifies the current value of the representative type
        /// </summary>
        T0 rep {get;}

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
        T1 nextrep {get;}
    }

}