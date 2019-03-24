//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using static corefunc;


    partial class Traits
    {
        /// <summary>
        /// Requires n1:T1 & n2:T2 => n1 == n2
        /// </summary>
        /// <typeparam name="T1">The first nat type</typeparam>
        /// <typeparam name="T2">The second nat type</typeparam>
        public interface EQ<T1,T2> : NatConstraint<T1,T2>
            where T1: TypeNat, new()
            where T2: TypeNat, new()
        {
            
        }

        /// <summary>
        /// Requires n1:T1 & n2:T2 => n1 != n2
        /// </summary>
        /// <typeparam name="N1">The first nat type</typeparam>
        /// <typeparam name="N2">The second nat type</typeparam>
        public interface NEQ<N1,N2> : NatConstraint<N1,N2>
            where N1: TypeNat, new()
            where N2: TypeNat, new()
        {
            
        }

    }

    /// <summary>
    /// Reifies evidence that n1:T1 & n2:T2 => n1 = n2
    /// </summary>
    /// <typeparam name="T1">The first nat type</typeparam>
    /// <typeparam name="N2">The second nat type</typeparam>
     public readonly struct EQ<T1,T2> : Traits.EQ<T1,T2>
        where T1: TypeNat, new()
        where T2: TypeNat, new()
    {

    }

    /// <summary>
    /// Reifies evidence that n1:T1 & n2:T2 => n1 != n2
    /// </summary>
    /// <typeparam name="T1">The first nat type</typeparam>
    /// <typeparam name="N2">The second nat type</typeparam>
     public readonly struct NEQ<T1,T2> : Traits.NEQ<T1,T2>
        where T1: TypeNat, new()
        where T2: TypeNat, new()
    {

    }


}