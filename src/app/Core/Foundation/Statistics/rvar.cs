//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using MathNet.Numerics.Random;
    using MathNet.Numerics.Distributions;

    using C = Contracts;

    using static corefunc;
    using static Operations;

    public readonly struct Entropy
    {
        static IEnumerable<int> next(RandomSource random, int min, int max)
            => random.NextInt32Sequence(min, max + 1);

        static IEnumerable<double> next(RandomSource random, double min, double max)
        {
            var dist = new ContinuousUniform(min, max, random);
            for(;;)
                yield return dist.Sample();
        }


        readonly RandomSource random;

        public Entropy(RandomSource source)
        {
            this.random = source;
        }
    }

    public static class rvar
    {
        public static rvar<T> define<T>(C.Distribution<T> dist)
            => new rvar<T>(); 
    }

    public readonly struct rvar<T>
    {


    }

}