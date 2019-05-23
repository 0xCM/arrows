//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static mfunc;

    public static class RVar
    {
        public static RVar<T> define<T>(Interval<T> domain)
            where T : struct
                => define(domain, Randomizer.define<T>(RandSeeds.AppSeed));

        public static RVar<T> define<T>(Interval<T> domain, ulong[] seed)
            where T : struct
                => define(domain, Randomizer.define<T>(seed));

        public static RVar<T> define<T>(Interval<T> domain, IRandomizer<T> random)
            where T : struct
                => new RVar<T>(domain,random);
    }

    public readonly struct RVar<T>
        where T : struct
    {
        readonly IEnumerable<T> stream;

        public readonly Interval<T> domain;
        
        public RVar(Interval<T> domain, IRandomizer<T> random)
        {
            this.domain = domain;
            this.stream = random.Stream(domain);
        }

        /// <summary>
        /// Samples a specified number of values
        /// </summary>
        /// <param name="count">The sample count</param>
        public T[] sample(int count)
            => stream.TakeArray(count);


        /// <summary>
        /// Samples an arbitrary number of values
        /// </summary>
        /// <param name="count">The sample count</param>
        public IEnumerable<T> sample()
            => stream;

        /// <summary>
        /// Samples exactly one value
        /// </summary>
        [MethodImpl(Inline)]
        public T one()
            => stream.First();
    }

}