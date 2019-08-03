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

    public static class TransRuleKey
    {
        /// <summary>
        /// Defines a key for a transition rule
        /// </summary>
        /// <param name="input">The intput value</param>
        /// <param name="source">The source state</param>
        /// <typeparam name="I">The input symbol type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static TransRuleKey<I,S> Define<I,S>(I input, S source)
            => (input,source);
    }

    /// <summary>
    /// Defines a key for a transition rule
    /// </summary>
    public readonly struct TransRuleKey<I,S>
    {
        public static implicit operator TransRuleKey<I,S>((I input, S source) x)
            => new TransRuleKey<I, S>(x.input,x.source);

        public TransRuleKey(I input, S source)
        {
            this.Input = input;
            this.Source = source;
            this.Hash = HashCode.Combine(input,source);
        }

        readonly int Hash;

        public readonly I Input;
        
        public readonly S Source;

        public override int GetHashCode()
            => Hash; 

        public override string ToString() 
            => $"({Source}, {Input})";
    }

}