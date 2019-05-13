//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static nfunc;

    partial class Demands
    {
        /// <summary>
        /// Requires k1:K1 & k2:K2 => k1 + 1 = k2
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        public interface Next<K1,K2> : ISmaller<K1,K2> 
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
        {

        } 


    }

    /// <summary>
    /// Captures evidence that k1:K1 & k2:K2 => k1 + 1 = k2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public readonly struct Next<K1,K2> : Demands.Next<K1,K2>
        where K1: ITypeNat, new()
        where K2: ITypeNat, new()
    {
        static readonly K1 k1 = default;
        static readonly K2 k2 = default;
        static readonly string description = $"++{k1} = {k2}";

        public Next(K1 n1, K2 n2)
            => valid = demand(n1.value + 1 == n2.value);

        public bool valid {get;}

        public string format()
            => valid ? description : $"INVALID({description})";    
        
        public override string ToString()
            => format();

    }


}