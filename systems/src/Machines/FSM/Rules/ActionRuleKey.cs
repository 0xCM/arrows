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
    /// Defines a key for efficient action rule lookup
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    public readonly struct ActionRuleKey<S> : IRuleKey
    {
        public static implicit operator ActionRuleKey<S>(S source)
            => new ActionRuleKey<S>(source);
        
        public ActionRuleKey(S source)
        {
            this.Source = source;
            this.Hash = source.GetHashCode();
        }

        public readonly int Hash {get;}

        public readonly S Source;

        public readonly override string ToString() 
            => $"({Source})";
    }
}