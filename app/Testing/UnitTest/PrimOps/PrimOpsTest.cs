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


    public class PrimOpsTest : Context<PrimOpsTest>
    {
        public PrimOpsTest()
            : base(RandSeeds.TestSeed)
        {

        }

        
        public void Verify<T>(string OpName, PrimalBinOp<T> PrimOp, PrimalBinOp<T> RefOp, Func<T,bool> filter = null)
            where T : struct, IEquatable<T>
        {
            var kind = PrimKinds.kind<T>();            
            var sw = begin($"Verifying {OpName}{kind} operator");
            
            var config = Defaults.get<T>();
            var lhs = RandomIndex<T>(config.Domain, config.SampleSize, filter);
            var rhs = RandomIndex<T>(config.Domain, config.SampleSize, filter);
            for(var i = 0; i<lhs.Count; i++)
            {
                var x = lhs[i];
                var y = rhs[i];
                Claim.eq(RefOp(x,y),PrimOp(x,y));
            }
            
            end($"Verified {OpName}{kind} operator",sw);


            EmitMessages();
        }

    }


    public abstract class PrimOpsTest<S,T> : UnitTest<S>
        where S : PrimOpsTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected static readonly Operative.PrimOps<T> Prim = primops.typeops<T>();

            

        protected Interval<T> Domain {get;}

        protected T MinPrimVal 
            => Domain.left;

        protected T MaxPrimVal
            => Domain.right;

        protected Func<T,bool> Filter {get;}

        protected PrimOpsTest(Interval<T>? domain = null, Func<T,bool> filter = null, int? sampleSize = null)
            : base(sampleSize)
        {
            this.Domain = domain ?? Defaults.get<T>().Domain;
            this.Filter = filter ?? (x => true);            
        }

        protected T[] target() 
            => array<T>(SampleSize);
        
        protected Index<T> sample()
            => Randomizer<T>().stream(MinPrimVal,MaxPrimVal).Where(Filter).Take(SampleSize).ToIndex();

      
        [Repeat(Defaults.Reps)]
        public virtual Index<T> Compute() 
            => new T[]{};
      
        [Repeat(Defaults.Reps)]
        public virtual Index<T> Baseline()
            => new T[]{};

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Compute();            
            iter((int)SampleSize, i => Claim.eq(expect[i], actual[i]));
        }
    }
}