//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    public interface IUnitTest : ITestContext
    {
        bool Enabled {get;}
    }

    public abstract class UnitTest<T> : TestContext<T>, IUnitTest
        where T : UnitTest<T>
    {
        protected const int DefaltCycleCount = Pow2.T03;

        protected const int DefaultSampleSize = Pow2.T08;

        protected static readonly N256 DefaultSampleNat = default;

        protected const int DefaultScale = 4;

        protected UnitTest(ITestConfig config = null)
            : base(config)
            {

            }
        
        public virtual bool Enabled 
            => true;
        
        protected virtual int Samples
            => DefaultSampleSize;
        
        public virtual int Cycles
            => DefaltCycleCount;

        public virtual int Scale
            => DefaultScale;

    }


}