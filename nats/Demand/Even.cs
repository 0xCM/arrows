//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static nfunc;
    

    /// <summary>
    /// Captures evidence that k:K => k % 2 == 0
    /// </summary>
    /// <typeparam name="K">An even natural type</typeparam>
    public readonly struct NatEven<K> : INatEven<K>
        where K: ITypeNat, new()
    {
        static readonly K k = default;
        static readonly string description = $"{k} % {2} = {0}";
        
        public NatEven(K n)
            => valid = demand(n.value % 2 == 0);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();
    }



}