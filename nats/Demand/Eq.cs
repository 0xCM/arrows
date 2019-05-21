//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static nfunc;


    /// <summary>
    /// Captures evidence that n1:T1 & n2:T2 => n1 = n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="N2">The second nat type</typeparam>
     public readonly struct NatEq<K1,K2> : INatEq<K1,K2>
        where K1: ITypeNat, new()
        where K2: ITypeNat, new()
    {
        static readonly K1 k1 = default;
        static readonly K2 k2 = default;
        static readonly string description = $"{k1} == {k2}";
        
        public NatEq(K1 n1, K2 n2)
            => valid = demand(n1.value == n2.value);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();
    }


}