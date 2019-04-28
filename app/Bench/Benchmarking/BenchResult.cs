namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static zcore;

    public class BenchResult
    {
        public static BenchResult operator +(BenchResult lhs, BenchResult rhs)
            => lhs.Merge(rhs);

        public static BenchResult Init(int CycleNumber, string OpId, int InnerReps)
            => Define(CycleNumber, OpId,InnerReps,0);

        public static BenchResult Define(int CycleNumber, string OpId, int InnerReps, long TickCount)
            => new BenchResult(CycleNumber, OpId, InnerReps, TickCount);

        public static BenchResult Define(int CycleNumber, string OpId, int InnerReps, IEnumerable<BenchResult> src)
            => Init(CycleNumber, OpId, InnerReps).Merge(src);
            
        public static readonly BenchResult Empty = Init(0,string.Empty,0);
        
        BenchResult(int CycleNumber, string OpId, int InnerReps, long TickCount)
        {
            this.OpId = OpId;
            this.CycleNumber = CycleNumber;
            this.InnerReps = InnerReps;
            this.TickCount = TickCount;
        }
        
        public int CycleNumber {get;}

        public string OpId {get;}

        public int InnerReps {get;}

        public long TickCount {get;}

        public long Duration
            => ticksToMs(TickCount);        

        public BenchResult AppendTicks(long TickCount)
            => Define(this.CycleNumber, this.OpId, this.InnerReps, this.TickCount + TickCount);
   
        public BenchResult Merge(BenchResult src)
        {
            return Define(
                    this.CycleNumber, 
                    ifBlank(this.OpId, src.OpId),
                    this.InnerReps, 
                    this.TickCount + src.TickCount
                    );
        }

        public BenchResult Merge(IEnumerable<BenchResult> rhs)
        {
            var src = rhs.Select(x => (x.CycleNumber, x.InnerReps, x.TickCount)).Freeze();            
            return Define(
                    this.CycleNumber, 
                    this.OpId,
                    this.InnerReps, 
                    this.TickCount + src.Select(x => x.TickCount).Sum() 
                    );
        }

        public override string ToString()
            => $"{OpId}: Duration = {Duration}ms";
    }

    public static class BenchResultX
    {
        public static BenchResult Merge(this IEnumerable<BenchResult> results)
        {
            var frozen = results.Freeze();
            if(frozen.Length == 0)
                return BenchResult.Empty;

            var first = frozen[0];
            var result = BenchResult.Define(0, first.OpId, first.InnerReps, 0);
            return result.Merge(results);
        }

    }
}