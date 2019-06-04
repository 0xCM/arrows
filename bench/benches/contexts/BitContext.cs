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
    using Z0.Metrics;
    
    using static zfunc;
    using static As;
    using static BenchRunner;

    public abstract class BitContext<T> : MetricContext<T>         
        where T : BitConfig
    {
        public BitContext(T config, IRandomizer random = null)
            : base(config, random)
        {

        }

        public BitDContext ToDirect()
            => new BitDContext(Config.ToDirect(), Randomizer);

        public BitGContext ToGeneric()
            => new BitGContext(Config.ToGeneric(), Randomizer);

    }

    public sealed class BitDContext : BitContext<BitDConfig>         
    {
        public BitDContext(BitDConfig config, IRandomizer random = null)
            : base(config, random)
        {

        }
    }

    public sealed class BitGContext : BitContext<BitGConfig>         
    {
        public BitGContext(BitGConfig config, IRandomizer random = null)
            : base(config, random)
        {

        }
    }

}