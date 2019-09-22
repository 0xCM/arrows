//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class AsmAddTest : AsmOpTest<AsmAddTest>
    {        
        protected override int CycleCount => Pow2.T14;

        public void VerifyAdd()
        {
            VerifyOp(AsmOps.Add<sbyte>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<byte>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<short>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<ushort>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<int>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<uint>(), math.add, SampleSize);            
            VerifyOp(AsmOps.Add<long>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<ulong>(), math.add, SampleSize);
            VerifyOp(AsmOps.Add<float>(), fmath.fadd, SampleSize);
            VerifyOp(AsmOps.Add<double>(), fmath.fadd, SampleSize);
        }

        static readonly AsmBinOp<int> add32i = AsmOps.Add<int>();     

        static readonly AsmBinOp<long> add64i = AsmOps.Add<long>();     

        public void add32i_bench()
        {
            var opcount = RoundCount*CycleCount;
            var opname = "add32i";
            var sw = stopwatch(false);
            var last = 0;
            
            for(var i=0; i<opcount; i++)
            {
                var a = Random.Next<int>();
                var b = Random.Next<int>();
                
                sw.Start();
                last = a + b;
                sw.Stop();
            }

            Collect((opcount, sw, opname));

        }

        public void asm_add32i_bench()
        {
            var opcount = RoundCount*CycleCount;
            var opname = "asm_add32i";
            var sw = stopwatch(false);
            var last = 0;
            
            for(var i=0; i<opcount; i++)
            {
                var a = Random.Next<int>();
                var b = Random.Next<int>();
                
                sw.Start();
                last = add32i(a,b);
                sw.Stop();
            }

            Collect((opcount, sw, opname));

        }

        public void add64i_bench()
        {
            var opcount = RoundCount*CycleCount;
            var opname = "add64i";
            var sw = stopwatch(false);
            var last = 0L;
            
            for(var i=0; i<opcount; i++)
            {
                var a = Random.Next<long>();
                var b = Random.Next<long>();
                
                sw.Start();
                last = a + b;
                sw.Stop();
            }

            Collect((opcount, sw, opname));

        }

        public void asm_add64i_bench()
        {
            var opcount = RoundCount*CycleCount;
            var opname = "asm_add64i";
            var sw = stopwatch(false);
            var last = 0L;
            
            for(var i=0; i<opcount; i++)
            {
                var a = Random.Next<long>();
                var b = Random.Next<long>();
                
                sw.Start();
                last = add64i(a,b);
                sw.Stop();
            }

            Collect((opcount, sw, opname));

        }

    }


}
