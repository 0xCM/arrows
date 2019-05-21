//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static nfunc;


   /// <summary>
   // Captures evidence that k:K => k is prime
   // </summary>
   public readonly struct NatPrime<K> : INatPrime<K>
        where K : ITypeNat, new()
    {
        static readonly K k = default;

        public NatPrime(K n)
            => valid = demand(prime(n.value));

        public bool valid {get;}

        public string format()
            => valid ? $"{k} is prime" : $"INVALID({k} is prime)";    
        
        public override string ToString()
            => format();

    }


}