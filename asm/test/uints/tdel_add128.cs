//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using System.Reflection.Emit;
    using static zfunc;


    public class tdel_add128 : AsmOpTest<tdel_add128>
    {        
        protected override int CycleCount => Pow2.T16;


        public void add_128x8u_bench()
            => add_bench<byte>();


        void add_bench<T>(SystemCounter subject = default, SystemCounter compare = default)
            where T : unmanaged
        {
            var last = default(Vector128<T>);
            var del = new Asm128BinOp<T>(ginx.add);
            
            for(var i=0; i<OpCount; i++)
            {
                var a = Random.CpuVector128<T>();
                var b = Random.CpuVector128<T>();
                subject.Start();
                last = del(a,b);
                subject.Stop();

                var c = Random.CpuVector128<T>();
                var d = Random.CpuVector128<T>();
                compare.Start();
                last = ginx.add(c,d);
                compare.Stop();

            }

            Benchmark($"add{moniker<T>()}_del", subject);
            Benchmark($"add{moniker<T>()}", compare);
        }

    }

}


