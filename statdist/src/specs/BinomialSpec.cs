//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public readonly struct BinomialSpec : IDistributionSpec
    {
        public static BinomialSpec Define(int trials, double success)
            => new BinomialSpec(trials,success);
        
        public BinomialSpec(int trials, double success)
        {
            this.Trials = trials;
            this.Success = success;
        }
        
        public readonly int Trials;

        public readonly double Success;
    }
}