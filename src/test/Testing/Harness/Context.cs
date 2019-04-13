//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;




    public abstract class Context<T>
    {                
        //static readonly IRandomizer random = Z0.Randomizer.define(RandSeeds.Seed002);

        IRandomizer Randomizer {get;}

        /// <summary>
        /// Constructs a context-specific/local randomizer that should not be shared across threads
        /// </summary>
        /// <typeparam name="R">The primal type</typeparam>
        public PrimalRand<R> Random<R>()
            where R : struct, IEquatable<R>
            => Randomizer.Primal<R>();
        
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