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
        /// Requires n1:T1 & n2:T2 => n1 == n2
        /// </summary>
        /// <typeparam name="T1">The first nat type</typeparam>
        /// <typeparam name="T2">The second nat type</typeparam>
        public interface Same<T1,T2> : Demand<T1,T2>
            where T1: TypeNat, new()
            where T2: TypeNat, new()
        {
            
        }

        /// <summary>
        /// Requires n1:T1 & n2:T2 => n1 != n2
        /// </summary>
        /// <typeparam name="N1">The first nat type</typeparam>
        /// <typeparam name="N2">The second nat type</typeparam>
        public interface Different<N1,N2> : Demand<N1,N2>
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
     public readonly struct Same<T1,T2> : Demands.Same<T1,T2>
        where T1: TypeNat, new()
        where T2: TypeNat, new()
    {
        public Same(T1 n1, T2 n2)
            => valid = demand(n1.value == n2.value);
        
        public bool valid {get;}
    }

    /// <summary>
    /// Reifies evidence that n1:T1 & n2:T2 => n1 != n2
    /// </summary>
    /// <typeparam name="T1">The first nat type</typeparam>
    /// <typeparam name="N2">The second nat type</typeparam>
     public readonly struct Different<T1,T2> : Demands.Different<T1,T2>
        where T1: TypeNat, new()
        where T2: TypeNat, new()
    {
        public Different(T1 n1, T2 n2)
            => valid = demand(n1.value != n2.value);
        
        public bool valid {get;}
    }


}