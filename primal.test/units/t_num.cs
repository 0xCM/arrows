//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    using D = PrimalDelegates;

    public class t_num : UnitTest<t_num>
    {

        public void add_num()
        {
            add_num_check<sbyte>();
            add_num_check<byte>();
            add_num_check<short>();
            add_num_check<ushort>();
            add_num_check<int>();
            add_num_check<uint>();
            add_num_check<long>();
            add_num_check<ulong>();
            add_num_check<float>();
            add_num_check<double>();
        }

        public void add_num_bench()
        {
            Collect(add_num_bench<sbyte>());
            Collect(add_num_bench<byte>());
            Collect(add_num_bench<short>());
            Collect(add_num_bench<ushort>());
            Collect(add_num_bench<int>());
            Collect(add_num_bench<uint>());
            Collect(add_num_bench<long>());
            Collect(add_num_bench<ulong>());
            Collect(add_num_bench<float>());
            Collect(add_num_bench<double>());

        }



        public void add_direct_bench()
        {
            Collect(add_direct_bench<int>());
            Collect(add_direct_bench<long>());
            Collect(add_direct_bench<ulong>());
            Collect(add_direct_bench<double>());

        }

        void add_num_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var a = Polyrand.Next<T>();
                var b = Polyrand.Next<T>();
                var c = gmath.add(a,b);

                var n1 = Num.from(a);
                var n2 = Num.from(b);
                var n3 = n1 + n2;
                Claim.eq(c, n3.Scalar());
            }
        }


        OpTime add_num_bench<T>()
            where T : unmanaged
        {
            var sw = stopwatch(false);
            var accum = num<T>.Zero;
            for(var cycle = 0; cycle < CycleCount; cycle++)
            for(var sample=0; sample < SampleSize; sample++)
            {
                var a = Polyrand.Next<T>();
                var b = Polyrand.Next<T>();
                
                var n1 = Num.from(a);
                var n2 = Num.from(b);
                sw.Start();
                accum = n1 + n2;
                sw.Stop();
            }
            var opname = $"num<{typeof(T).DisplayName()}>_add";
            return (CycleCount*SampleSize, sw, opname);
        }


        OpTime add_direct_bench<T>()
            where T : unmanaged
        {
            var time = Duration.Zero;

            if(typeof(T) == typeof(int))
                time = add32i_bench();
            else if(typeof(T) == typeof(long))
                time = add64i_bench();
            else if(typeof(T) == typeof(ulong))
                time = add64u_bench();
            else if(typeof(T) == typeof(double))
                time = add64f_bench();
            
            var opname = $"direct<{typeof(T).DisplayName()}>_add";
            return (CycleCount*SampleSize, time, opname);
        }

        Duration add32i_bench()
        {
            var accum = 0;
            var sw = stopwatch(false);
            for(var cycle = 0; cycle < CycleCount; cycle++)
            for(var sample=0; sample < SampleSize; sample++)
            {
                var a = Polyrand.Next<int>();
                var b = Polyrand.Next<int>();
                
                sw.Start();
                accum = a + b;
                sw.Stop();
            }

            return snapshot(sw);
        }

        Duration add64i_bench()
        {
            var accum = 0L;
            var sw = stopwatch(false);
            for(var cycle = 0; cycle < CycleCount; cycle++)
            for(var sample=0; sample < SampleSize; sample++)
            {
                var a = Polyrand.Next<long>();
                var b = Polyrand.Next<long>();
                
                sw.Start();
                accum = a + b;
                sw.Stop();
            }

            return snapshot(sw);
        }

        Duration add64u_bench()
        {
            var accum = 0ul;
            var sw = stopwatch(false);
            for(var cycle = 0; cycle < CycleCount; cycle++)
            for(var sample=0; sample < SampleSize; sample++)
            {
                var a = Polyrand.Next<ulong>();
                var b = Polyrand.Next<ulong>();
                
                sw.Start();
                accum = a + b;
                sw.Stop();
            }

            return snapshot(sw);
        }

        Duration add64f_bench()
        {
            var accum = 0d;
            var sw = stopwatch(false);
            for(var cycle = 0; cycle < CycleCount; cycle++)
            for(var sample=0; sample < SampleSize; sample++)
            {
                var a = Polyrand.Next<double>();
                var b = Polyrand.Next<double>();
                
                sw.Start();
                accum = a + b;
                sw.Stop();
            }

            return snapshot(sw);
        }

    }

}