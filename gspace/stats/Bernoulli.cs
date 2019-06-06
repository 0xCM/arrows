//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static zfunc;

    public interface IDistributionSpec
    {
        
    }

    public class BernoulliSpec : IDistributionSpec
    {
        public BernoulliSpec(double Alpha)
        {
            this.Alpha = Alpha;
        }
        
        public double Alpha {get;}
    }

    public static class Distributions
    {
        public static IDistribtion<T> Bernoulli<T>(double alpha, IRandomizer random = null)   
            where T : struct
                => new BernoulliDistribution<T>(new BernoulliSpec(alpha), random);
    }

    public interface IDistribtion<T>
        where T : struct
    {
        IEnumerable<T> Sample();
    }

    public interface IDistribtion<S,T> : IDistribtion<T>
        where S : IDistributionSpec
        where T : struct
    {
        
    }

    public abstract class Distribution<S,T> : IDistribtion<S,T>
        where S : IDistributionSpec
        where T : struct
    {
        protected static readonly T Zero = gmath.zero<T>();

        protected static readonly T One = gmath.one<T>();

        public abstract IEnumerable<T> Sample();
    }
    public class BernoulliDistribution<T> : Distribution<BernoulliSpec,T>
        where T : struct
    {

        IRandomizer Random {get;}

        public BernoulliDistribution(BernoulliSpec spec, IRandomizer random = null)
        {
            this.Spec = spec;
            this.Random = random ?? RNG.XOrShift256(Seed256.Bernoulli01);
        }

        public BernoulliSpec Spec {get;}

        public override IEnumerable<T> Sample()
            => Random.Stream<double>().Select(x => x < Spec.Alpha ? One : Zero);
                        
    }
}