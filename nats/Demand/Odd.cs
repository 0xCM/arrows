//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static nfunc;


    /// <summary>
    /// Captures evidence that k:K => k % 2 != 0
    /// </summary>
    /// <typeparam name="K">An odd natural type</typeparam>
    public readonly struct NatOdd<K> : INatOdd<K>
        where K: ITypeNat, new()
    {
        static readonly K k = default;
        
        static readonly string description = $"{k} % {2} != {0}";
        
        public NatOdd(K n)
            => valid = demand(n.value % 2 != 0);
        
        public bool valid {get;}

        public ulong value 
            => k.value;

        public NatSeq seq 
            => k.seq;

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();
    }


}