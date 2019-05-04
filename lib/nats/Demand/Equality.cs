//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static nats;


    /// <summary>
    /// Requires n1:T1 & n2:T2 => n1 == n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface IEqual<K1,K2> : IDemand<K1,K2>
        where K1: TypeNat, new()
        where K2: TypeNat, new()
    {
        
    }

    /// <summary>
    /// Requires n1:T1 & n2:T2 => n1 != n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface IDifferent<K1,K2> : IDemand<K1,K2>
        where K1: TypeNat, new()
        where K2: TypeNat, new()
    {
        
    }

    /// <summary>
    /// Captures evidence that n1:T1 & n2:T2 => n1 = n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="N2">The second nat type</typeparam>
     public readonly struct Equal<K1,K2> : IEqual<K1,K2>
        where K1: TypeNat, new()
        where K2: TypeNat, new()
    {
        static readonly K1 k1 = default;
        static readonly K2 k2 = default;
        static readonly string description = $"{k1} == {k2}";
        
        public Equal(K1 n1, K2 n2)
            => valid = demand(n1.value == n2.value);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();
    }

    /// <summary>
    /// Captures evidence that n1:T1 & n2:T2 => n1 != n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="N2">The second nat type</typeparam>
     public readonly struct Different<K1,K2> : IDifferent<K1,K2>
        where K1: TypeNat, new()
        where K2: TypeNat, new()
    {
        static readonly K1 k1 = default;
        static readonly K2 k2 = default;
        static readonly string description = $"{k1} != {k2}";
        
        public Different(K1 n1, K2 n2)
            => valid = demand(n1.value != n2.value);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();
    }


}