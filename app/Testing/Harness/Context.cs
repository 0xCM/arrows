//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Collections.Generic;

    public abstract class Context<T>
    {                
        IRandomizer Randomizer {get;}

        /// <summary>
        /// Constructs a context-specific/local randomizer that should not be shared across threads
        /// </summary>
        /// <typeparam name="R">The primal type</typeparam>
        public IRandom<R> Random<R>()
            where R : struct, IEquatable<R>
            => Randomizer.Primal<R>();
        
        public IEnumerable<R> Rand<R>(R min, R max)
            where R : struct, IEquatable<R>
                => Random<R>().stream(min,max);

        public IEnumerable<R> Rand<R>(Interval<R> domain)
            where R : struct, IEquatable<R>
                => Rand(domain.left,domain.right);

        public R[] RandArray<R>(R min, R max, int len)
            where R : struct, IEquatable<R>
                => Rand(min,max).TakeArray(len);

        public R[] RandArray<R>(Interval<R> domain, int len)
            where R : struct, IEquatable<R>
                => Rand(domain).TakeArray(len);

        public IEnumerable<R[]> RandArrays<R>(R min, R max, int len)
            where R : struct, IEquatable<R>
        {
            while(true)
                yield return RandArray<R>(min,max,len);
        }

        protected Context(ulong[] seed)
        {
            Randomizer = Z0.Randomizer.define(seed);
        }
    }   

    public static class TestContext
    {
        /// <summary>
        /// Defines a new test context
        /// </summary>
        /// <param name="seed">The seed to use for random value generation</param>
        /// <typeparam name="T">The type for which the context is created</typeparam>
        public static TestContext<T> define<T>(ulong[] seed)
            => new TestContext<T>(seed);
    }

    public class TestContext<T> : Context<T>
    {
        public TestContext(ulong[] seed)
            : base(seed)
        {

        }
    }
}