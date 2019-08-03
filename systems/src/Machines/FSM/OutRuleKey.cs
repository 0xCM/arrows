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

    public static class OutRuleKey
    {
        /// <summary>
        /// Specifies an input-dependent output rule key
        /// </summary>
        /// <param name="source">The antecedent state</param>
        /// <param name="input">The output value</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="I">The output symbol type</typeparam>
        public static OutRuleKey<I,S> Define<I,S>(I input, S source)
            => (input, source);
    }

    
    public readonly struct OutRuleKey<I,S>
    {
        public static implicit operator OutRuleKey<I,S>((I input, S source) x)
            => new OutRuleKey<I,S>(x.input, x.source);
        public OutRuleKey(I input, S source)
        {
            this.Input = input;
            this.Source = source;
            this.Hash = HashCode.Combine(input,source);
        }

        readonly int Hash;

        public readonly I Input;

        public readonly S Source;

        public override string ToString() 
            => $"({Input}, {Source})";

    }

}