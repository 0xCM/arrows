//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
 
    using static zfunc;
    
    /// <summary>
    /// Defines a key for efficient/predicatable entry rule indexing/lookup
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    public readonly struct EntryRuleKey<S>
    {
        public static implicit operator EntryRuleKey<S>(S source)
            => new EntryRuleKey<S>(source);
        
        public EntryRuleKey(S source)
        {
            this.Source = source;
            this.Hash = source.GetHashCode();
        }

        readonly int Hash;

        public readonly S Source;

        public override string ToString() 
            => $"({Source})";
    }
}