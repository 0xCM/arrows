namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static zcore;

    public interface IBenchMark
    {

    }

    public interface IBenchMark<D> : IBenchMark
        where D : Delegate
    {
        BenchResult Run(D Op);

    }

    public static class Benchmark
    {
        public static BenchResult Run<T>(string opname, Func<T,T,T> binop, BenchConfig config = null)
            where T : struct, IEquatable<T>
                => BinOpBenchmark.Runner<T>(opname,config).Run(binop);

        public static BenchResult Run<T>(string opname, Vec128BinOp<T> binop, BenchConfig config = null)
            where T : struct, IEquatable<T>
                => BinOpBenchmark.Runner<T>(opname,config).Run(binop);

    }

    public abstract class BenchmarkContext : Context<BenchmarkContext>
    {
         protected BenchmarkContext()
         : base(RandSeeds.BenchSeed)
         {

         
         }

        Task V128Stream(Func<bool> stop, uint batchSize = Pow2.T18, int delay = 0, bool diagnostic = false)
        {   
            void worker()
            {
                var counter = 1;
                while(!stop())
                {
                    var domain = Settings.Domain<long>();
                    var batch = Randomizer<long>().stream(domain.left, domain.right).TakeArray((int)batchSize);
                    foreach(var v in Vec128.stream<long>(batch))
                    {
                        //var sum = InX.add(v,v);
                        //var vAnd = InX.and(v, sum);
                        //var vOr = InX.or(v, sum);
                        
                        // if(diagnostic)
                        //     inform($"{v} + {v} = {sum}");
                    }

                    if(diagnostic)
                        inform($"Completed batch {counter++}");
                    else
                        write(".");

                    if(delay != 0)
                        Task.Delay(delay).Wait();
                }}
            ;
            
            return Task.Factory.StartNew(worker);                
        }

        void RunStream()
        {
            var stop = false;

            var task = V128Stream(() => stop);

            read();
            stop = true;
            task.Wait();

        }
    }

    public abstract class Benchmark<T> : Context<Benchmark<T>>, IBenchMark
        where T : struct, IEquatable<T>
    {
        protected Benchmark(string OpName, BenchConfig config, Interval<T>? Domain = null)
            : base(RandSeeds.BenchSeed)
        {
            this.Config = config ?? BenchConfig.Default;
            this.Domain = Domain ?? Settings.Domain<T>();            
            this.RVar = Z0.RVar.define<T>(this.Domain, RandSeeds.BenchSeed);

            var kind = PrimKinds.kind<T>();
            this.OpId = $"{OpName}/{kind}";

        }

        protected string OpId {get;}

        protected Interval<T> Domain {get;}
        
        protected RVar<T> RVar {get;}

        protected BenchConfig Config {get;}

        protected int SampleSize 
            => Config.SampleSize;

        protected int Reps
            => Config.Reps;

        public PrimKind PrimalKind 
            => PrimKinds.kind<T>();

        protected IEnumerable<T> Samples()
            => RVar.sample();

        protected Index<T> Sample(int? size = null)
            => RVar.sample(size ?? SampleSize);
            
        protected void LogCycleStart(int cycle)
            => zcore.hilite($"{OpId} Start Cycle | Cycle = {cycle} | Samples = {Config.SampleSize}", SeverityLevel.HiliteCL);

        protected void LogCycleFinish(BenchResult result)
            => zcore.hilite($"{OpId} Finish Cycle | {result}", SeverityLevel.Perform);

        protected void LogStart()
            => zcore.hilite($"{OpId} Executing {Config.Cycles} cycles", SeverityLevel.HiliteCL);

        protected void LogFinish(BenchResult result)
            =>  zcore.hilite($"{result}", SeverityLevel.HiliteCL);
    }
}