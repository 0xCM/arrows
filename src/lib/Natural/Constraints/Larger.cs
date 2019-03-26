//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static zcore;

    partial class Demands
    {


        /// <summary>
        /// Requires n1:T1, n2:T2 => n1 > n2
        /// </summary>
        /// <typeparam name="T1">The first nat type</typeparam>
        /// <typeparam name="T2">The second nat type</typeparam>
        public interface Larger<T1,T2> : Demand<T1,T2>
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
    public readonly struct Larger<T1,T2> : Demands.Larger<T1,T2>
        where T1: TypeNat, new()
        where T2: TypeNat, new()
    {
        public Larger(T1 n1, T2 n2)
            => valid = demand(n1.value > n2.value);
        
        public bool valid {get;}

    }
 }