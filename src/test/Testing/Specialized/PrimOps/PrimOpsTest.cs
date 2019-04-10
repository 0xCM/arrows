//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;

    using static zcore;

    public abstract class PrimOpsTest<T>
        where T : struct, IEquatable<T>
    {
        protected readonly uint SampleSize = Pow2.T20;
    
        protected readonly uint Repetitions = Pow2.T03;
    

        protected T[] target() => array<T>(SampleSize);
        
        protected IReadOnlyList<T> source(T min, T max)
            => Rand.primal(min,max).Freeze(SampleSize);

        protected T MinPrimVal {get;}

        protected T MaxPrimVal {get;}


        protected PrimOpsTest(T MinPrimVal, T MaxPrimVal, uint SampleSize = Pow2.T20)
        {
            this.MinPrimVal = MinPrimVal;
            this.MaxPrimVal = MaxPrimVal;
            this.SampleSize = SampleSize;
        }

        protected static readonly Operative.PrimOps<T> Prim = primops.type<T>();

        [Repeat(5)]
        public virtual IReadOnlyList<T> Discretized() 
            => new T[]{};
      
        [Repeat(5)]
        public abstract IReadOnlyList<T> Vectorized();
      
        [Repeat(5)]
        public abstract IReadOnlyList<T> Baseline();        

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Vectorized();            
            iter((int)SampleSize, i => Claim.equals(expect[i], actual[i]));
        }

    }


}