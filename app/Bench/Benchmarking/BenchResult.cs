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
            => lhs.Append(rhs);

        public static BenchResult Init(string OpId)
            => Empty.Reidentify(OpId);

        public static BenchResult Define(string OpId, int CycleCount, int RepCount, long TickCount)
            => new BenchResult(OpId, CycleCount, RepCount, TickCount);

        public static BenchResult Define(string OpId, IEnumerable<BenchResult> src)
            => Init(OpId).Append(src);
            
        public static readonly BenchResult Empty = new BenchResult(string.Empty,0,0,0);
        

        BenchResult(string OpId, int CycleCount, int RepCount, long TickCount)
        {
            this.OpId = OpId;
            this.CycleCount = CycleCount;
            this.RepCount = RepCount;
            this.TickCount = TickCount;
        }

        public string OpId {get;}

        public int CycleCount {get;}

        public int RepCount {get;}

        public long TickCount {get;}

        public long Duration
            => ticksToMs(TickCount);        

        public BenchResult AppendTicks(long TickCount)
            => Define(this.OpId, this.CycleCount, this.RepCount, this.TickCount + TickCount);

        public BenchResult AppendRepTicks(int RepCount, long TickCount)
        {
            Claim.nonzero(RepCount);
            
            return Define(this.OpId, this.CycleCount, this.RepCount + RepCount, this.TickCount + TickCount);
        }

        public BenchResult AppendCycle(int Reps, long Ticks)
            => Define(this.OpId, this.CycleCount + 1, this.RepCount + Reps, this.TickCount + Ticks);
   
        public BenchResult Append(BenchResult src)
        {
            return Define(
                    ifBlank(this.OpId, src.OpId),
                    this.CycleCount + src.CycleCount, 
                    this.RepCount + src.RepCount, 
                    this.TickCount + src.TickCount
                    );
        }

        public BenchResult Append(IEnumerable<BenchResult> rhs)
        {
            var src = rhs.Select(x => (x.CycleCount, x.RepCount, x.TickCount)).Freeze();            
            return Define(
                    this.OpId,
                    this.CycleCount + src.Select(x => x.CycleCount).Sum(), 
                    this.RepCount + src.Select(x => x.RepCount).Sum(), 
                    this.TickCount + src.Select(x => x.TickCount).Sum() 
                    );
        }

        public BenchResult Reidentify(string OpId)
            => Define(OpId, this.CycleCount, this.RepCount, this.TickCount);


        public override string ToString()
            => $"{OpId} Summary: Reps = {RepCount} | Duration = {Duration}ms";
    }
}