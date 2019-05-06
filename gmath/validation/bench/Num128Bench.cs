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

    using static zcore;
    using static zfunc;

    public class Num128Bench : BenchContext
    {   
        public static Num128Bench Create(BenchConfig Config, IRandomizer random)
            => new Num128Bench(Config, random);
        
        Num128Bench(BenchConfig Config, IRandomizer Randomizer)
            : base(Config, Randomizer)
        {



        }

        public BenchComparison MulF32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<float>(samples);
            var opid = OpKind.Mul.Num128OpId<float>();
            var sw = stopwatch(false);

            var left = MeasureCycles(opid, data.Length, () => 
                Num128.mul(data.LeftSource, data.RightSource, data.LeftTarget)); 
                            
            var right = MeasureCycles(~opid, data.Length, () => 
                Num128.mul<float>(data.LeftSource, data.RightSource, data.RightTarget)); 
            
            var comparison = Run("title", left, right, cycles);            
            Claim.eq(data.LeftTarget, data.RightTarget);

            return comparison;

        }

        public BenchComparison MulF64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<double>(samples);
            var opid = OpKind.Mul.Num128OpId<double>();
            var sw = stopwatch(false);

            var left = Measure(opid, () => { 
                Num128.mul(data.LeftSource, data.RightSource, data.LeftTarget); 
                return data.Length;
                });
            
            var right = Measure(~opid, () => { 
                Num128.mul<double>(data.LeftSource, data.RightSource, data.RightTarget); 
                return data.Length;});
            
            var comparison = Run("title", left, right, cycles);            
            Claim.eq(data.LeftTarget, data.RightTarget);

            return comparison;

        }

    }

}
