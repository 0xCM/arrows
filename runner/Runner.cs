//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Bench;

    using static zfunc;    

    public enum RunKind
    {
        All,
        Bench,
        Test
    }

    class Runner : Context
    {

        public Runner()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
        }
        

         // Converts an array of bytes into a long.  
        static long ToInt64(byte[] value, int startIndex)
        {
            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }

        public void BenchBitVector()
        {
            var n = N8192.Rep;
            var lhsData = Randomizer.Span<int>((int)n.value);            
            var rhsData = Randomizer.Span<int>((int)n.value);
            var lhs = BitVector.Load(ref lhsData[0], n);
            var rhs = BitVector.Load(ref rhsData[0], n);
            var opcount = 0L;
            var time = Duration.Zero;
            var opsPerCycle = (long)n.value * 5L;
            while(true)
            {
                var sw = stopwatch();            
                for(var cycle = 1; cycle <= Pow2.T16; cycle++)
                {
                    lhs &= rhs;
                    lhs ^= rhs;
                    lhs |= rhs;
                    lhs >>= 4;
                    lhs <<= 4;
                    opcount += opsPerCycle;
                }
                time += snapshot(sw);
                print(AppMsg.Define($"Total Ops = {opcount} |".PadRight(30) + $"Total Time = {time.Ms} ms", SeverityLevel.Perform));
            }

        }

        void RunTests()
            => TestRunner.Run();

        void RunBench()
        {
            //MetricKind.VecG.Measure();
            //MetricKind.PrimalG.Measure();
            
            //app.Measure(MetricKind.InX128GFused);
            //app.Measure(MetricKind.InX256GFused);
            //app.Measure(MetricKind.NumG);
            //app.Measure(MetricKind.BitG);
            //app.BenchBitVector();                

        }

        public static void Run(RunKind kind = RunKind.All)
        {
            var app = new Runner();
            try
            {
                gmath.init();
                if (kind == RunKind.Test)
                    app.RunTests();
                else if (kind == RunKind.Bench)
                    app.RunBench();
                else
                {
                    app.RunTests();
                    app.RunBench();
                }

            }
            catch (Exception e)
            {
                app.NotifyError(e);
            }
        }

        static void Dispatch(params string[] args)
        {
            if(args.Length == 0)
                Run(RunKind.All);
            else
                foreach (var arg in args)
                    Run(parseEnum<RunKind>(arg));

        }

        
        static void Main(params string[] args)
        {
            Dispatch(args);
        }

    }

}