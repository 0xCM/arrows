//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    
    using static zfunc;

    public class Num128Bench : BenchContext
    {   
        static readonly BenchConfig DefaultConfig = new BenchConfig(Cycles: Pow2.T14, Reps: 1, SampleSize: Pow2.T12, AnnounceRate: Pow2.T10);

        public static Num128Bench Create(IRandomizer random, BenchConfig config = null)
            => new Num128Bench(random, config ?? DefaultConfig);
        
        Num128Bench(IRandomizer random, BenchConfig config)
            : base(random, config)
        {



        }

        public IBenchComparison MulF32()
        {
            var data = BinOpInit<float>();
            var opid = OpKind.Mul.Num128OpId<float>();
            var sw = stopwatch(false);

            var left = MeasureCycles(opid, data.Length, () => 
                Num128.mul(data.LeftSource, data.RightSource, data.LeftTarget)); 
                            
            var right = MeasureCycles(~opid, data.Length, () => 
                Num128.mul<float>(data.LeftSource, data.RightSource, data.RightTarget)); 
            
            var comparison = Run("title", left, right);            
            Claim.eq(data.LeftTarget, data.RightTarget);

            return comparison;

        }

        public IBenchComparison MulF64()
        {
            var data = BinOpInit<double>();
            var opid = OpKind.Mul.Num128OpId<double>();
            var sw = stopwatch(false);

            var left = Measure(opid, () => { 
                Num128.mul(data.LeftSource, data.RightSource, data.LeftTarget); 
                return data.Length;
                });
            
            var right = Measure(~opid, () => { 
                Num128.mul<double>(data.LeftSource, data.RightSource, data.RightTarget); 
                return data.Length;});
            
            var comparison = Run("title", left, right);            
            Claim.eq(data.LeftTarget, data.RightTarget);

            return comparison;

        }

    }

}
