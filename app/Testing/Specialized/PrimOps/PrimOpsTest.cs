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
    using static zfunc;



    public class PrimOpsTest : Context<PrimOpsTest>
    {
        public PrimOpsTest()
            : base(RandSeeds.TestSeed)
        {

        }

        public void Verify<T>(string OpName, PrimalUnaryOp<T> PrimOp, PrimalUnaryOp<T> RefOp, Func<T,bool> filter = null)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();            
            var timing = stopwatch();
                        
            var config = SampleDefaults.get<T>();
            var src = Randomizer.Array<T>(config.SampleDomain, config.SampleSize, filter);
            for(var i = 0; i<src.Length; i++)
            {
                var x = src[i];
                Claim.eq(RefOp(x),PrimOp(x));
            }
            
            elapsed(timing);


            Emit();
        }

        public void Verify<T>(string OpName, PrimalBinPred<T> PrimOp, PrimalBinPred<T> RefOp, Func<T,bool> filter = null)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();            
            var timing = stopwatch();
            
            var config = SampleDefaults.get<T>();
            var lhs = Randomizer.Array<T>(config.SampleDomain, config.SampleSize, filter);
            var rhs = Randomizer.Array<T>(config.SampleDomain, config.SampleSize, filter);
            for(var i = 0; i<lhs.Length; i++)
            {
                var x = lhs[i];
                var y = rhs[i];
                Claim.eq(RefOp(x,y),PrimOp(x,y));
            }
            
            elapsed(timing);


            Emit();
        }
        
        public void Verify<T>(string OpName, PrimalBinOp<T> PrimOp, PrimalBinOp<T> RefOp, Func<T,bool> filter = null)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();            
            var timing = stopwatch();
            
            var config = SampleDefaults.get<T>();
            var lhs = Randomizer.Array<T>(config.SampleDomain, config.SampleSize, filter);
            var rhs = Randomizer.Array<T>(config.SampleDomain, config.SampleSize, filter);
            for(var i = 0; i<lhs.Length; i++)
            {
                var x = lhs[i];
                var y = rhs[i];
                Claim.eq(RefOp(x,y),PrimOp(x,y));
            }
            
            elapsed(timing);


            Emit();
        }

    }


    public abstract class PrimOpsTest<S,T> : UnitTest<S>
        where S : PrimOpsTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected static readonly Operative.PrimOps<T> Prim = primops.typeops<T>();

            

        protected Interval<T> Domain {get;}

        protected T MinPrimVal 
            => Domain.Left;

        protected T MaxPrimVal
            => Domain.Right;

        protected Func<T,bool> Filter {get;}

        protected PrimOpsTest(Interval<T>? domain = null, Func<T,bool> filter = null, int? sampleSize = null)
            : base(sampleSize)
        {
            this.Domain = domain ?? SampleDefaults.get<T>().SampleDomain;
            this.Filter = filter ?? (x => true);            
        }

        protected T[] target() 
            => array<T>(SampleSize);
        
        protected Index<T> sample()
            => Randomizer.Random<T>().stream(MinPrimVal,MaxPrimVal).Where(Filter).Take(SampleSize).ToIndex();

      
        public virtual Index<T> Compute() 
            => new T[]{};
      
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