//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    
    using static zfunc;
    using static nfunc;

    public interface ITestContext : IContext
    {
        ITestConfig Config {get;}

        void Configure(ITestConfig config);

        IEnumerable<OpTime> Benchmarks {get;}        
    }

    public abstract class TestContext<T> : Context<T>, ITestContext
        where T : TestContext<T>
    {
        public TestContext(ITestConfig config = null, IPolyrand random = null)
            : base(random ?? RNG.XOrShift1024(Seed1024.TestSeed).ToPolyrand())
        {
            this.Config = config ?? TestConfigDefaults.Default();
        }

        protected static readonly N256 DefaultSampleNat = default;

        /// <summary>
        /// The default number of elements to be selected from some sort of stream
        /// </summary>
        protected const int DefaultSampleSize = Pow2.T08;

        /// <summary>
        /// The default number times to repeat an activity
        /// </summary>
        protected const int DefaltCycleCount = Pow2.T03;

        /// <summary>
        /// The default number times to repeat a cycle
        /// </summary>
        protected const int DefaultRoundCount = Pow2.T01;

        /// <summary>
        /// The default rouding precision
        /// </summary>
        protected const int DefaultScale = 6;

        public ITestConfig Config {get; private set;}

        public void Configure(ITestConfig config)
            => Config = config;

       protected K[] RandArray<K>(bool nonzero = false)
            where K : struct
        {
            var config = Config.Get<K>();
             return nonzero 
                ? Random.NonZeroArray<K>(config.SampleSize, config.SampleDomain)                
                : Random.Array<K>(config.SampleSize, config.SampleDomain);
        }

        protected void Verify(Action a)
        {
            for(var i=0; i< CycleCount; i++)
                a();
        }

        protected override bool TraceEnabled
            => Config.TraceEnabled;
        
        /// <summary>
        /// The number of elements to be selected from some sort of stream
        /// </summary>
        protected virtual int SampleSize
            => DefaultSampleSize;
        
        /// <summary>
        /// The number times to repeat an action
        /// </summary>
        protected virtual int CycleCount
            => DefaltCycleCount;

        /// <summary>
        /// The number of times to repeat a cycle
        /// </summary>
        protected virtual int RoundCount
            => DefaultRoundCount;

        /// <summary>
        /// Specifies the number of decimal places that relevant for some purpose
        /// </summary>
        protected virtual int Scale
            => DefaultScale;
        
        protected virtual Interval<byte> ShiftRange<K>()
            where K : unmanaged
        {
            var offsetMin = (byte)1;
            var offsetMax = (byte)(PrimalInfo.Get<K>().BitSize - 2);
            return closed(offsetMin,offsetMax);                
        }

        protected virtual OpTime Iterate<K>(Action<K> f, [CallerMemberName] string caller = null)
            where K : unmanaged
        {
            var buffer = new K[SampleSize];
            var sw = stopwatch(false);
            for(var round = 0; round < RoundCount; round++)
            {
                for(var cycle=0; cycle < CycleCount; cycle++)
                {                
                    Random.StreamTo(buffer.Length, ref buffer[0]);

                    sw.Start();
                    for(var k=0; k<buffer.Length; k++)
                        f(buffer[k]);
                    sw.Stop();
                }
            }
            return (SampleSize*CycleCount*RoundCount, sw, caller);
        }

        protected virtual OpTime Iterate<K1,K2>(Func<K1,K2> f, Action<K2> g, [CallerMemberName] string caller = null)
            where K1 : unmanaged
            where K2 : unmanaged
        {
            var buffer = new K1[SampleSize];
            var sw = stopwatch(false);
            for(var round = 0; round < RoundCount; round++)
            {
                for(var cycle=0; cycle < CycleCount; cycle++)
                {                
                    Random.StreamTo(buffer.Length, ref buffer[0]);

                    sw.Start();
                    for(var k=0; k<buffer.Length; k++)
                        g(f(buffer[k]));
                    sw.Stop();
                }
            }
            return (SampleSize*CycleCount*RoundCount, sw, caller);
        }

        protected void VerifyOp<K>(UnaryOp<K> subject, UnaryOp<K> baseline, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : struct
        {
            var kind = PrimalKinds.kind<K>();            
            var src = RandArray<K>(nonzero);
            var timing = stopwatch();                        

            for(var i = 0; i<src.Length; i++)
                Claim.eq(baseline(src[i]),subject(src[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(OpKind opKind, UnaryOp<K> subject, UnaryOp<K> baseline, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : struct
        {
            var kind = PrimalKinds.kind<K>();            
            var opid = opKind.PrimalGOpId<K>();           
            var src = RandArray<K>(nonzero);
            var timing = stopwatch();                        

            for(var i = 0; i<src.Length; i++)
                Claim.eq(baseline(src[i]),subject(src[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(BinaryPredicate<K> baseline, BinaryPredicate<K> op, bool nonzero = false, 
            [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : struct
        {
            var kind = PrimalKinds.kind<K>();            
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();            

            for(var i = 0; i<len; i++)
                Claim.eq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(OpKind opKind, BinaryPredicate<K> baseline, BinaryPredicate<K> op, bool nonzero = false, 
            [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : struct
        {
            var kind = PrimalKinds.kind<K>();            
            var opid = opKind.PrimalGOpId<K>();           
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();            

            for(var i = 0; i<len; i++)
                Claim.eq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(BinaryOp<K> baseline, BinaryOp<K> op, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : struct
        {
            var kind = PrimalKinds.kind<K>(); 
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();
            
            for(var i = 0; i<len; i++)
                Claim.numeq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(OpKind opKind, BinaryOp<K> baseline, BinaryOp<K> op, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : struct
        {
            var kind = PrimalKinds.kind<K>(); 
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();
            
            for(var i = 0; i<len; i++)
                Claim.numeq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

        protected void TypeCaseStart<C>([CallerMemberName] string caller = null)
            => Enqueue(AppMsg.Define($"{typeof(T).DisplayName()}/{caller}<{typeof(C).DisplayName()}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<C>([CallerMemberName] string caller = null)
            => Enqueue(AppMsg.Define($"{typeof(T).DisplayName()}/{caller}<{typeof(C).DisplayName()}> succeeded", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<C>(AppMsg msg, [CallerMemberName] string caller = null)
            => Enqueue(AppMsg.Define($"{typeof(T).DisplayName()}/{caller}<{typeof(C).DisplayName()}> succeeded: {msg}", SeverityLevel.HiliteCL));

        protected void TypeCaseStart<A,B>([CallerMemberName] string caller = null)
            => Enqueue(AppMsg.Define($"{typeof(T).DisplayName()}/{caller}<{typeof(A).DisplayName()},{typeof(B).DisplayName()}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<A,B>([CallerMemberName] string caller = null)
            => Enqueue(AppMsg.Define($"{typeof(T).DisplayName()}/{caller}<{typeof(A).DisplayName()},{typeof(B).DisplayName()}> succeeded", SeverityLevel.HiliteCL));

        protected void NatCaseStart<N,A>([CallerMemberName] string caller = null)
            where N : ITypeNat, new()
            => Enqueue(AppMsg.Define($"{typeof(T).DisplayName()}/{caller}<N{nati<N>()},{typeof(A).DisplayName()}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseStart<M,N,S>([CallerMemberName] string caller = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where S : struct
                => Enqueue(AppMsg.Define($"{typeof(T).DisplayName()}/{caller}<N{nati<M>()}xN{nati<N>()}:{typeof(S).DisplayName()}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<M,N,S>([CallerMemberName] string caller = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where S : struct
                => Enqueue(AppMsg.Define($"{typeof(T).Name}/{caller}<N{nati<M>()}xN{nati<N>()}:{typeof(S).DisplayName()}> succeeded", SeverityLevel.HiliteCL));
    }
}