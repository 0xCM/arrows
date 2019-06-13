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


    public interface IInXContext
    {        
        InXConfig Config {get;}
    }
    
    public interface IInXContext<T> : IInXContext
        where T : InXConfig
    {
        new T Config {get;}

        IRandomSource Random {get;}
    }

    public abstract class InXContext<T> : BenchContext<T>, IInXContext<T>         
        where T : InXConfig
    {
        public InXContext(T config, IRandomSource random = null)
            : base(config, random)
        {

        }

        public int Blocks 
            => Config.Blocks;

        InXConfig IInXContext.Config 
            => Config;

        public InXDContext128 ToDirect128()
            => new InXDContext128(Config.ToDirect128(), Random);

        public InXGContext128 ToGeneric128()
            => new InXGContext128(Config.ToGeneric128(), Random);

        public InXDContext256 ToDirect256()
            => new InXDContext256(Config.ToDirect256(), Random);

        public InXGContext256 ToGeneric256()
            => new InXGContext256(Config.ToGeneric256(), Random);

        public Metrics<M> CaptureMetrics<M>(OpId<M> OpId, Duration WorkTime, Span128<M> results)
            where M : struct
                => new Metrics<M>(OpId, ((long)Config.Cycles) * ((long)results.Length), WorkTime, results.Unblock());


        public Metrics<M> CaptureMetrics<M>(OpId<M> OpId, Duration WorkTime, Span256<M> results)
            where M : struct
                => new Metrics<M>(OpId, ((long)Config.Cycles) * ((long)results.Length), WorkTime, results.Unblock());
    }

}