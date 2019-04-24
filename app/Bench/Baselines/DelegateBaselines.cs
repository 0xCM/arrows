//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zcore;
    using static primops;


    public class DelegateBaselines : Benchmark
    {
        [MethodImpl(Inline)]
        public static int add(int x, int y)
            => x + y;

        [MethodImpl(Inline)]
        public static float add(float x, float y)
            => x + y;

        [MethodImpl(Inline)]
        public static double add(double x, double y)
            => x + y;

        public long Run()
        {
           Func<float,float,float> f = add;
           Func<double, double, double> d = add; 
           Func<int,int,int> i = add;
           var ix = PrimKinds.index<object>(@int : i, @float: f, @double : d); 
           var addi32 = ix.lookup<int,Func<int,int,int>>();
           var addf32 = ix.lookup<float,Func<float,float,float>>();
           var addf64 = ix.lookup<double,Func<double,double,double>>();

            var rVari32 = RVar.define(Settings.Domain<int>());
            var rVarf32 = RVar.define(Settings.Domain<float>());
            var rVarf64 = RVar.define(Settings.Domain<double>());

            var size = (int)Pow2.T20;

            var sumi32 = alloc<int>(size);
            var sumf32 = alloc<float>(size);
            var sumf64 = alloc<double>(size);
        
            var reps = 15;
            var i32Values = rVari32.sample(size);
            var f32Values = rVarf32.sample(size);
            var f64Values = rVarf64.sample(size);

            void validate()
            {
                inform($"Validation operation correctness");
                
                iter(size, i => Claim.eq(i32Values[i] + i32Values[i], addi32(i32Values[i], i32Values[i])));
                iter(size, i => Claim.eq(f32Values[i] + f32Values[i], addf32(f32Values[i], f32Values[i])));
                iter(size, i => Claim.eq(f64Values[i] + f64Values[i], addf64(f64Values[i], f64Values[i])));

                inform($"Validated operation correctness");
            }
            
            void measurei32d()
            {
                for(var i = 0; i < reps; i++)
                    for(var j = 0; j < size; j++)
                        sumi32[j] = addi32(i32Values[j], i32Values[j]);
            }

            void measurei32()
            {
                for(var i = 0; i< reps; i++)
                    for(var j = 0; j<size; j++)
                        sumi32[j] = i32Values[j] + i32Values[j];
            }

            void measuref32d()
            {
                for(var i = 0; i< reps; i++)
                    for(var j = 0; j<size; j++)
                        sumf32[j] = addf32(f32Values[j], f32Values[j]);
            }

            void measuref32()
            {
                for(var i = 0; i< reps; i++)
                    for(var j = 0; j<size; j++)
                        sumf32[j] = f32Values[j] + f32Values[j];
            }

            void measuref64d()
            {
                for(var i = 0; i< reps; i++)
                    for(var j = 0; j<size; j++)
                        sumf64[j] = addf64(f64Values[j], f64Values[j]);
            }

            void measuref64()
            {
                for(var i = 0; i< reps; i++)
                    for(var j = 0; j<size; j++)
                        sumf64[j] = f64Values[j] + f64Values[j];
            }


            void measureAll()
            {
                inform($"Measuring delegate-based addition");

                var totalD = 0L;
                var total = 0L;
                totalD += measure(measurei32d,nameof(measurei32d),reps);
                total += measure(measurei32,nameof(measurei32),reps);
                totalD += measure(measuref32d,nameof(measuref32d),reps);
                total += measure(measuref32,nameof(measuref32),reps);
                totalD += measure(measuref64d,nameof(measuref64d),reps);
                total += measure(measuref64,nameof(measuref64),reps);

                inform($"Direct addition: {total}ms | Delegate addition: {totalD}ms");
            }

            validate();
            
            measureAll();

            return 0;
        }

    }

}
