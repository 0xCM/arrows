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
        public TestContext(ITestConfig config = null, IRandomSource random = null)
            : base(RNG.XOrShift1024(Seed1024.TestSeed))
        {
            this.Config = config ?? TestConfigDefaults.Default();
        }

        protected const int DefaltCycleCount = Pow2.T03;

        protected const int DefaultSampleSize = Pow2.T08;

        protected static readonly N256 DefaultSampleNat = default;

        protected const int DefaultScale = 6;

        public ITestConfig Config {get; private set;}

        protected override bool TraceEnabled
            => Config.TraceEnabled;

        public void Configure(ITestConfig config)
            {
                
            }

       protected K[] RandArray<K>(bool nonzero = false)
            where K : struct
        {
            var config = Config.Get<K>();
             return nonzero 
                ? Random.NonZeroArray<K>(config.SampleSize, config.SampleDomain) 
                : Random.Array<K>(config.SampleSize, config.SampleDomain);
        }

        protected void Verify(Action a, int cycles = DefaltCycleCount)
        {
            for(var i=0; i< cycles; i++)
                a();

        }

        protected virtual int SampleSize
            => DefaultSampleSize;
        
        public virtual int CycleCount
            => DefaltCycleCount;

        public virtual int Scale
            => DefaultScale;
        
        protected virtual Interval<byte> ShiftRange<K>()
            where K : unmanaged
        {
            var offsetMin = (byte)1;
            var offsetMax = (byte)(PrimalInfo.Get<K>().BitSize - 2);
            return closed(offsetMin,offsetMax);                
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

        protected void VerifyOp<K>(OpKind opKind, BinaryOp<K> baseline, BinaryOp<K> op, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : struct
        {
            var kind = PrimalKinds.kind<K>(); 
            var opid = opKind.PrimalGOpId<K>();           
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();
            
            for(var i = 0; i<len; i++)
                Claim.numeq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

        protected void BlockSamplesStart(int blocks, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define($"{typeof(T).Name}/{caller} executing with {blocks} blocks", SeverityLevel.HiliteCL));
        protected void BlockSamplesEnd(int blocks, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define($"{typeof(T).Name}/{caller} completed with {blocks} blocks", SeverityLevel.HiliteCL));

        protected void TypeCaseStart<C>([CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define($"{typeof(T).Name}/{caller}<{typeof(C).Name}> executing", SeverityLevel.HiliteCL));

        static string GetTypeName<A>()
            => typeof(A).Realizes<ITypeNat>() ? $"N{Activator.CreateInstance(typeof(A)).ToString()}" : typeof(A).Name;
        
        protected void TypeCaseStart<A,B>([CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define($"{typeof(T).Name}/{caller}<{typeof(A).Name},{typeof(B).Name}> executing", SeverityLevel.HiliteCL));

        protected void NatCaseStart<N,A>([CallerMemberName] string caller = null)
            where N : ITypeNat, new()
            => Messages.Add(AppMsg.Define($"{typeof(T).Name}/{caller}<N{nati<N>()},{typeof(A).Name}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseStart<M,N,S>([CallerMemberName] string caller = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where S : struct
                => Messages.Add(AppMsg.Define($"{typeof(T).Name}/{caller}<N{nati<M>()}xN{nati<N>()}:{PrimalKinds.kind<S>()}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<C>([CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define($"{typeof(T).Name}/{caller}<{typeof(C).Name}> succeeded", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<A,B>([CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define($"{typeof(T).Name}/{caller}<{typeof(A).Name},{typeof(B).Name}> succeeded", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<C>(AppMsg msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define($"{typeof(T).Name}/{caller}<{typeof(C).Name}> succeeded: {msg}", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<M,N,S>([CallerMemberName] string caller = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where S : struct
                => Messages.Add(AppMsg.Define($"{typeof(T).Name}/{caller}<N{nati<M>()}xN{nati<N>()}:{PrimalKinds.kind<S>()}> succeeded", SeverityLevel.HiliteCL));

    }
}