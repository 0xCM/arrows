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



    public abstract class InXContext<T> : MetricContext<T>         
        where T : InXConfig
    {
        public InXContext(T config, IRandomizer random = null)
            : base(config, random)
        {

        }

        public InXDContext128 ToDirect128()
            => new InXDContext128(Config.ToDirect128(), Random);

        public InXGContext128 ToGeneric128()
            => new InXGContext128(Config.ToGeneric128(), Random);

        public InXDContext256 ToDirect256()
            => new InXDContext256(Config.ToDirect256(), Random);

        public InXGContext256 ToGeneric256()
            => new InXGContext256(Config.ToGeneric256(), Random);

    }


    public sealed class InXDContext128 : InXContext<InXDConfig128>         
    {
        public InXDContext128(InXDConfig128 config, IRandomizer random = null)
            : base(config, random)
        {

        }
    }

    public sealed class InXGContext128 : InXContext<InXGConfig128>         
    {
        public InXGContext128(InXGConfig128 config, IRandomizer random = null)
            : base(config, random)
        {

        }
    }

    public sealed class InXDContext256 : InXContext<InXDConfig256>         
    {
        public InXDContext256(InXDConfig256 config, IRandomizer random = null)
            : base(config, random)
        {

        }
    }

    public sealed class InXGContext256 : InXContext<InXGConfig256>         
    {
        public InXGContext256(InXGConfig256 config, IRandomizer random = null)
            : base(config, random)
        {

        }
    }

}