//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static BenchRunner;

    public abstract class PrimalContext<T> : BenchContext<T>         
        where T : PrimalConfig
    {
        public PrimalContext(T config, IRandomizer random = null)
            : base(config, random)
        {

        }

        public PrimalDContext ToDirect()
            => new PrimalDContext(Config.ToDirect(), Randomizer);

        public PrimalGContext ToGeneric()
            => new PrimalGContext(Config.ToGeneric(), Randomizer);

    }

    public sealed class PrimalDContext : PrimalContext<PrimalDConfig>         
    {
        public PrimalDContext(PrimalDConfig config, IRandomizer random = null)
            : base(config, random)
        {

        }
    }

    public sealed class PrimalGContext : PrimalContext<PrimalGConfig>         
    {
        public PrimalGContext(PrimalGConfig config, IRandomizer random = null)
            : base(config, random)
        {

        }
    }

}