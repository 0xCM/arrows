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
        /// Requires n1:T1, n2:T2 => n1 > n2
        /// </summary>
        /// <typeparam name="T1">The first nat type</typeparam>
        /// <typeparam name="T2">The second nat type</typeparam>
        public interface GT<T1,T2> : NatConstraint<T1,T2>
            where T1: TypeNat, new()
            where T2: TypeNat, new()
        {
            
        }

    }
    
    /// <summary>
    /// Provides evidence that n1:T1, n2:T2 => n1 > n2
    /// </summary>
    /// <typeparam name="T1">The first nat type</typeparam>
    /// <typeparam name="T2">The second nat type</typeparam>
    public readonly struct GT<T1,T2> : Traits.GT<T1,T2>
        where T1: TypeNat, new()
        where T2: TypeNat, new()
    {

    }
 }