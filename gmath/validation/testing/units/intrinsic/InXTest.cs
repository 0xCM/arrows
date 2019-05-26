//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static zfunc;
    using static mfunc;

    public abstract class InXTest<S,T> : UnitTest<S>
        where S : InXTest<S,T>
        where T : struct
    {
        protected static readonly int ComponentSize = Vec128<T>.CellSize;

        protected static readonly int VecLength = Vec128<T>.Length;


        /// Produces an array of random values
        /// </summary>
        /// <param name="count">The number of values in the produced array</param>
        protected T[] RandArray()
            => Randomizer.Array<T>(Config.SampleSize,Config.Get<T>().SampleDomain);

        protected InXTest(OpId<T> OpId, ITestConfig config = null)
            : base((config ?? TestConfigDefaults.Default()).WithSampleSize(4 * Pow2.T08))
        {
            this.OpId = OpId;
            this.VecCount = Config.SampleSize / VecLength;            
            this.UnarySrc = RandArray();
            this.LeftSamples = RandArray();
            this.RightSamples = RandArray();

            Claim.eq(VecLength,  16 / ComponentSize);
            Claim.eq(VecLength*VecCount, Config.SampleSize);
        }

        protected int VecCount {get;}

        public OpId<T> OpId {get;}
        
        protected Index<T> UnarySrc {get;}

        protected T[] LeftSamples;

        protected T[] RightSamples;

        protected Vec128<T> LeftVector(int index)
            => Vec128.single<T>(LeftSamples, index*VecLength);

        protected Vec128<T> RightVector(int index)
            => Vec128.single<T>(RightSamples, index*VecLength);



    }    
}