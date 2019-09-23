//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class tasm_negate : AsmOpTest<tasm_negate>
    {        
        public void VerifyNegate()
        {
            VerifyOp(AsmOps.Negate<sbyte>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<byte>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<short>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<ushort>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<int>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<uint>(), math.negate, SampleSize);            
            VerifyOp(AsmOps.Negate<long>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<ulong>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<float>(), math.negate, SampleSize);
            VerifyOp(AsmOps.Negate<double>(), math.negate, SampleSize);
        }


        void negate_bench<T>(SystemCounter subject = default, SystemCounter compare = default)
            where T : unmanaged
        {
            var last = default(T);
            var asmop = AsmOps.Negate<T>();
            
            for(var i=0; i<OpCount; i++)
            {
                var a = Random.Next<T>();
                subject.Start();
                last = asmop(a);
                subject.Stop();

                var b = Random.Next<T>();                
                compare.Start();
                last = gmath.negate(b);
                compare.Stop();

            }

            Benchmark($"negate{moniker<T>()}_asm", subject);
            Benchmark($"negate{moniker<T>()}", compare);

        }

    }

}
