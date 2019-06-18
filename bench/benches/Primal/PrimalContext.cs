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
        public PrimalContext(T config, IRandomSource random = null)
            : base(config, random)
        {

        }

        public PrimalDContext ToDirect()
            => new PrimalDContext(Config.ToDirect(), Random);

        public PrimalGContext ToGeneric()
            => new PrimalGContext(Config.ToGeneric(), Random);

    }

    public sealed class PrimalDContext : PrimalContext<PrimalDConfig>         
    {
        public PrimalDContext(PrimalDConfig config, IRandomSource random = null)
            : base(config, random)
        {

        }
    }

    public sealed class PrimalGContext : PrimalContext<PrimalGConfig>         
    {
        public PrimalGContext(PrimalGConfig config, IRandomSource random = null)
            : base(config, random)
        {

        }
    }

}