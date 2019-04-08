//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;

    using static zcore;
    using static ztest;

    public abstract class ClrPrimOpsTest<T>
        where T : struct, IEquatable<T>
    {
        protected const uint VectorSize = Pow2.T20;
    
        protected const uint Repetitions = Pow2.T03;
    
        protected const bool PLL = false;

        protected static T[] target() => array<T>(VectorSize);
        
        protected static IReadOnlyList<T> source(T min, T max)
            => Rand.primal(min,max).Freeze(VectorSize);

        protected T MinPrimVal {get;}

        protected T MaxPrimVal {get;}


        protected ClrPrimOpsTest(T MinPrimVal, T MaxPrimVal)
        {
            this.MinPrimVal = MinPrimVal;
            this.MaxPrimVal = MaxPrimVal;
        }

        protected static readonly Operative.PrimOps<T> Prim = primops.type<T>();

        [Repeat(5)]
        public abstract IReadOnlyList<T> Discretized();
      
        [Repeat(5)]
        public abstract IReadOnlyList<T> Vectorized();
      
        [Repeat(5)]
        public abstract IReadOnlyList<T> Baseline();        

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Vectorized();            
            iter((int)VectorSize, i => Claim.equals(expect[i], actual[i]));
        }

    }

    public abstract class ClrBinaryPrimOpsTest<T> : ClrPrimOpsTest<T>
        where T : struct, IEquatable<T>
    {
        protected IReadOnlyList<T> LeftSrc;
        
        protected IReadOnlyList<T> RightSrc;

        protected ClrBinaryPrimOpsTest(T MinPrimVal, T MaxPrimVal)
            : base(MinPrimVal,MaxPrimVal)
        {
            this.LeftSrc = source(MinPrimVal,MaxPrimVal);
            this.RightSrc = source(MinPrimVal,MaxPrimVal);

        }
    }

}