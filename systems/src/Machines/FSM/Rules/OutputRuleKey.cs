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
    /// Defines a key for efficient/predicatable output rule indexing/lookup
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    public readonly struct OutputRuleKey<S>
    {
        public static implicit operator OutputRuleKey<S>((S src, S dst) x)
            => new OutputRuleKey<S>(x.src, x.dst);
        
        public OutputRuleKey(S source, S target)
        {
            this.Source = source;
            this.Target = target;
            this.Hash = HashCode.Combine(source,target);
        }

        readonly int Hash;

        public readonly S Source;

        public readonly S Target;

        public override string ToString() 
            => $"{Source} -> {Target}";

    }

}