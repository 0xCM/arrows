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
    
    using static zfunc;    

    public static class RVar
    {
        public static RVar<T> Define<T>(Interval<T> domain, IPolyrand random)
            where T : struct
                => new RVar<T>(domain,random);
    }

    /// <summary>
    /// Defines a random variable
    /// </summary>
    public class RVar<T>
        where T : struct
    {        
        public RVar(Interval<T> domain, IPolyrand random)
        {
            this.Domain = domain;
            this.stream = random.Stream<T>(domain);
        }

        readonly IEnumerable<T> stream;

        public Interval<T> Domain {get;}

        /// <summary>
        /// Samples a specified number of values
        /// </summary>
        /// <param name="count">The sample count</param>
        public T[] Sample(int count)
            => stream.TakeArray(count);

        /// <summary>
        /// Samples an arbitrary number of values
        /// </summary>
        /// <param name="count">The sample count</param>
        public IEnumerable<T> Sample()
            => stream;

        /// <summary>
        /// Samples exactly one value
        /// </summary>
        [MethodImpl(Inline)]
        public T Next()
            => stream.First();
    }
}