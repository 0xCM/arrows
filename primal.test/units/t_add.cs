//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using D = PrimalDelegates;
    

    public class t_add : UnitTest<t_add>
    {


        public void polyadd()
        {
            polyadd_check(in StructOps.add<sbyte>());
            polyadd_check(in StructOps.add<byte>());
            polyadd_check(in StructOps.add<short>());
            polyadd_check(in StructOps.add<ushort>());
            polyadd_check(in StructOps.add<int>());
            polyadd_check(in StructOps.add<uint>());
            polyadd_check(in StructOps.add<long>());
            polyadd_check(in StructOps.add<ulong>());
            polyadd_check(in StructOps.add<float>());
            polyadd_check(in StructOps.add<double>());

            
        }
        public void polyadd_bench()
        {
            Collect(polyadd_bench(in StructOps.add<sbyte>()));
            Collect(polyadd_bench(in StructOps.add<byte>()));
            Collect(polyadd_bench(in StructOps.add<short>()));
            Collect(polyadd_bench(in StructOps.add<ushort>()));
            Collect(polyadd_bench(in StructOps.add<int>()));
            Collect(polyadd_bench(in StructOps.add<uint>()));
            Collect(polyadd_bench(in StructOps.add<long>()));
            Collect(polyadd_bench(in StructOps.add<ulong>()));
            Collect(polyadd_bench(in StructOps.add<float>()));
            Collect(polyadd_bench(in StructOps.add<double>()));

        }

        public void gadd_bench()
        {
            Collect(gadd_bench<sbyte>());
            Collect(gadd_bench<byte>());
            Collect(gadd_bench<short>());
            Collect(gadd_bench<ushort>());
            Collect(gadd_bench<int>());
            Collect(gadd_bench<uint>());
            Collect(gadd_bench<long>());
            Collect(gadd_bench<ulong>());
            Collect(gadd_bench<float>());
            Collect(gadd_bench<double>());

        }

        OpTime gadd_bench<T>()
            where T : unmanaged
        {
            var sw = stopwatch(false);
            var accum = gmath.zero<T>();
            for(var i = 0; i < OpCount; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                
                sw.Start();
                accum = gmath.add(a,b);
                sw.Stop();
            }
            return (OpCount, sw, $"add{moniker<T>()}");
        }


        public void Add()
        {
            VerifyOp((x,y) => (sbyte)(x + y), D.add<sbyte>());
            VerifyOp((x,y) => (byte)(x + y), D.add<byte>());
            VerifyOp((x,y) => (short)(x + y), D.add<short>());
            VerifyOp((x,y) => (ushort)(x + y), D.add<ushort>());
            VerifyOp((x,y) => (x + y), D.add<int>());
            VerifyOp((x,y) => (x + y), D.add<uint>());
            VerifyOp((x,y) => (x + y), D.add<long>());
            VerifyOp((x,y) => (x + y), D.add<ulong>());
            VerifyOp((x,y) => (x + y), D.add<float>());
            VerifyOp((x,y) => (x + y), D.add<double>());              
        }


        public void addi32_fused()
        {
            var lhsSrc = Random.ReadOnlySpan<int>(Pow2.T10);  
            var lhs = lhsSrc.Replicate();
            var rhs = Random.ReadOnlySpan<int>(lhsSrc.Length);
            math.add(lhs, rhs);           

            var expect = span<int>(lhs.Length);
            for(var i =0; i< lhsSrc.Length; i++)
                expect[i] = lhsSrc[i] + rhs[i];
            
            Claim.yea(lhs.Identical(expect));

        }

        public void addi64_fused()
        {
            var lhsSrc = Random.ReadOnlySpan<long>(Pow2.T10);  
            var lhs = lhsSrc.Replicate();
            var rhs = Random.ReadOnlySpan<long>(lhsSrc.Length);
            math.add(lhs,rhs);

            var expect = span<long>(lhs.Length);
            for(var i =0; i< lhsSrc.Length; i++)
                expect[i] = lhsSrc[i] + rhs[i];
            
            Claim.yea(lhs.Identical(expect));
        }

        void polyadd_check<T>(in AddOp<T> op)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                var a = op.apply(x,y);
                var b = gmath.add(x,y);
                Claim.eq(a,b);
            }
        }

        OpTime polyadd_bench<T>(in AddOp<T> op)
            where T : unmanaged
        {
            var sw = stopwatch(false);
            var applied = default(T);
            for(var i=0; i< OpCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                sw.Start();
                applied = op.apply(x,y);
                sw.Stop();
            }
            return (OpCount, sw, $"add{moniker<T>()}");
        }

    }

}

