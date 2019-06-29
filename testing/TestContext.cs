//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    
    using static zfunc;

    public interface ITestContext : IContext
    {
        ITestConfig Config {get;}

        void Configure(ITestConfig config);
        
    }


    public abstract class TestContext<T> : Context<T>, ITestContext
        where T : TestContext<T>
    {
        public TestContext(ITestConfig config = null, IRandomSource random = null)
            : base(RNG.XOrShift1024(Seed1024.TestSeed))
        {
            this.Config = config ?? TestConfigDefaults.Default();
        }

        public ITestConfig Config {get; private set;}

        protected override bool TraceEnabled
            => Config.TraceEnabled;

        public void Configure(ITestConfig config)
            {
                
            }

       protected K[] Sample<K>(bool nonzero = false)
            where K : struct
        {
            var config = Config.Get<K>();
             return nonzero 
                ? Random.NonZeroArray<K>(config.SampleSize, config.SampleDomain) 
                : Random.Array<K>(config.SampleSize, config.SampleDomain);
        }

        protected void VerifyOp<K>(OpKind opKind, UnaryOp<K> subject, UnaryOp<K> baseline, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : struct
        {
            var kind = PrimalKinds.kind<K>();            
            var opid = opKind.PrimalGOpId<K>();           
            var src = Sample<K>(nonzero);
            var timing = stopwatch();                        

            for(var i = 0; i<src.Length; i++)
                Claim.eq(baseline(src[i]),subject(src[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(OpKind opKind, BinaryPredicate<K> baseline, BinaryPredicate<K> op, bool nonzero = false, 
            [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : struct
        {
            var kind = PrimalKinds.kind<K>();            
            var opid = opKind.PrimalGOpId<K>();           
            var lhs = Sample<K>();
            var rhs = Sample<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();            

            for(var i = 0; i<len; i++)
                Claim.eq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(OpKind opKind, BinaryOp<K> baseline, BinaryOp<K> op, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : struct
        {
            var kind = PrimalKinds.kind<K>(); 
            var opid = opKind.PrimalGOpId<K>();           
            var lhs = Sample<K>();
            var rhs = Sample<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();
            
            for(var i = 0; i<len; i++)
                Require.numeq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }
             
    }
}