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



    public class BenchmarkResult
    {
        public static readonly BenchmarkResult Empty = new BenchmarkResult(0,0,0,0);

        BenchmarkResult(int CycleCount, int RepCount, int OpCount, long Duration)
        {
            this.CycleCount = CycleCount;
            this.RepCount = RepCount;
            this.OpCount = OpCount;
            this.Duration = Duration;
        }
        public int CycleCount {get;}

        public int RepCount {get;}

        public int OpCount {get;}

        public long Duration {get;}

        public BenchmarkResult AppendDuration(long Duration)
            => new BenchmarkResult(this.CycleCount, this.RepCount, this.OpCount, this.Duration + Duration);

        public BenchmarkResult AppendRepCount(long Duration)
            => new BenchmarkResult(this.CycleCount, this.RepCount + 1, this.OpCount, this.Duration + Duration);

    }


}