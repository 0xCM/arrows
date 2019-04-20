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

    public abstract class PrimOpsTest<S,T> : UnitTest<S>
        where S : PrimOpsTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected static readonly Operative.PrimOps<T> Prim = primops.typeops<T>();

            
        protected T MinPrimVal {get;}

        protected T MaxPrimVal {get;}

        protected Func<T,bool> Filter {get;}

        protected PrimOpsTest(Interval<T> bounds, Func<T,bool> filter, int? sampleSize = null)
            : base(sampleSize)
        {
            this.MinPrimVal = bounds.left;
            this.MaxPrimVal = bounds.right;
            this.Filter = filter ?? (x => true);            
        }

        protected T[] target() => array<T>(SampleSize);
        
        protected IReadOnlyList<T> sample()
            => Context.Random<T>().stream(MinPrimVal,MaxPrimVal).Where(Filter).Freeze(SampleSize);

      
        [Repeat(Defaults.Reps)]
        public virtual IReadOnlyList<T> Compute() 
            => new T[]{};
      
        [Repeat(Defaults.Reps)]
        public virtual IReadOnlyList<T> Baseline()
            => new T[]{};


        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Compute();            
            iter((int)SampleSize, i => Claim.eq(expect[i], actual[i]));
        }

    }


}