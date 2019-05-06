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
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using Z0.Test;

    using static zcore;
    using static zfunc;    
    using static mfunc;
    
    using static math;

    class Benchmark : Context
    {
        static BenchConfig ConfigureGInX(int? cycles = null, int? samples = null)
            => new BenchConfig(cycles ?? Pow2.T14, 1, samples ?? Pow2.T12, AnnounceRate: Pow2.T10);
        
        static BenchConfig ConfigureGMath(int? cycles = null, int? reps = null)        
            => new BenchConfig(cycles ?? Pow2.T11, reps ?? Pow2.T18, reps ?? Pow2.T18, primitives: Primitives);            

        protected void print(BenchComparison c)
        {
            zcore.print(c.LeftBench.Description);
            zcore.print(c.RightBench.Description);
            zcore.print(c.CalcDelta().Description);
        }

        public Benchmark()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
        }

        static readonly PrimalKind[] Primitives = new PrimalKind[]{
                PrimalKind.int32, PrimalKind.uint32,
                PrimalKind.int64, PrimalKind.uint64,
                PrimalKind.float32, PrimalKind.float64,
        };

        static BenchConfig ConfigureVec128<T>(int cycles, int reps)
            where T : struct, IEquatable<T>
        {
            var vLen = Vec128<T>.Length;
            var primKind = PrimalKinds.kind<T>();
            var domain = Defaults.get<T>().Domain;
            var samples = vLen * reps;
            return new BenchConfig(cycles, reps, samples);
        }

        void RunAdHocInXBench()
        {
            
            var comparisons = new List<BenchComparison>();
            var bench = Num128Bench.Create(ConfigureGInX(), Randomizer);
            comparisons.Add(bench.MulF32());
            comparisons.Add(bench.MulF64());
            iter(comparisons,print);

        }
        
        void RunInXBench()
        {
            var bench = GInXBench.Create(ConfigureGInX(), Randomizer);
            var comparisons = new List<BenchComparison>();
            foreach(var runner in bench.Runners().Select(r => r.Value))
                comparisons.Add(runner());
            iter(comparisons,print);

        }

        static HashSet<T> set<T>(params T[] src)
            => new HashSet<T>(src);

        void RunGMathBench()
        {
            var operators = set(OpKind.Mul.ToString());
            var bench = GMathBench.Create(Randomizer);
            bench.Run(name => name.ContainsAny(operators));
        }
        void RunAdHocBench()
        {
            var bench = GMathBench.Create(Randomizer);
            var comparisons = new List<BenchComparison>();
            comparisons.Add(bench.MulF32());
            comparisons.Add(bench.MulF64());
            iter(comparisons,print);
        }

        unsafe void TestRandom()
        {
            var arrDst = alloc<double>(Pow2.T20);
            fixed(double* pDst = &arrDst[0])                
                Randomizer.StreamTo<double>(Interval.closed(-250.0, 250.0), arrDst.Length, pDst);
            inform($"Captured {arrDst.Length} elements into an array");

            var spanDst = span<double>(Pow2.T20);
            fixed(double* pDst = &spanDst[0])
                Randomizer.StreamTo<double>(Interval.closed(-250.0, 250.0), arrDst.Length, pDst);
            inform($"Captured {spanDst.Length} elements into a span");
            
        }

        void TestScalar()
        {
            {
                var vec1 = Vec128.single(2,0,3,0);
                var vec2 = Vec128.single(5,0,7,0);
                var expect = Vec128.single(10L,21L);
                var result = Vec128<long>.Zero;
                ginx.mul(vec1, vec2,ref result);
                Claim.eq(expect,result);
            }

            {
                var vec1 = Vec128.single(2,0,3,0);
                var vec2 = Vec128.single(5,0,7,0);                            
                var result = Vec128<long>.Zero;
                ginx.mul(vec1, vec2,ref result);
                var expect =  Vec128.single<long>(vec1.Scalar(0) * vec2.Scalar(0), vec1.Scalar(2) * vec2.Scalar(2));
                Claim.eq(expect, result);                        
            
            }

            {
                var vec1 = Vec128.single(2.0, 3.0, 4.0, 5.0);
                var vec2 = Vec128.single(5.0, 2.0, 8.0, 4.0);
                var expect = Vec128.single(10.0, 6.0, 32.0, 20.0);
                var result = Vec128<double>.Zero;
                ginx.mul(vec1, vec2,ref result);
                Claim.eq(expect,result);
            }
        }
        
        void TestAdd()
        {
            var lhsVecs = Randomizer.Vec128<long>(Pow2.T10);
            var rhsVecs = Randomizer.Vec128<long>(Pow2.T10);            
            var len = length(lhsVecs, rhsVecs);
            Claim.eq(Pow2.T10, len);
            for(var i = 0; i< len; i++)
            {
                var lVec = lhsVecs[i];
                var rVec = rhsVecs[i];
                var result = dinx.add(lVec,rVec);
                var lX = lVec.Scalar(0).value;
                var lY = lVec.Scalar(1).value;

                var rX = rVec.Scalar(0).value;
                var rY = rVec.Scalar(1).value;
                Claim.eq(lX + rX, result.Scalar(0).value);
                Claim.eq(lY + rY, result.Scalar(1).value);            
            }

        }



        void TestAdd3()
        {
            var lSrc = Randomizer.Span256<long>(Pow2.T14);
            var rSrc = Randomizer.Span256<long>(Pow2.T14);                      
            var blocks = zcore.blocks(lSrc, rSrc);
            var cells = Span256.blocklength<long>(blocks);
            var cycles = Pow2.T14;
            inform($"Operating on {blocks} blocks = {cells} cells for {cycles} cycles");

            var dstA = Span256.blockalloc<long>(blocks);
            var dstB = Span256.blockalloc<long>(blocks);
            var cycle = 0;
            
            var sw = stopwatch();
            while(++cycle <= cycles)
                math.add(lSrc,rSrc, dstA);
            var aTime = snapshot(sw);
            inform($"Primal: {aTime}");


            sw.Restart();
            cycle = 0;
            while(++cycle <= cycles)
            {
                for(var i = 0; i< blocks; i++)
                {
                    var lVec = Vec256.define(lSrc,i);
                    var rVec = Vec256.define(rSrc,i);
                    ginx.add(lVec,rVec, dstB, i);
                }
            }
            var bTime = snapshot(sw);
            inform($"Intrinsic: {bTime}");

            Claim.eq(dstA, dstB);



        }
        

        void TestAdd2()
        {
            var lSrc = Randomizer.Span128<long>(Pow2.T10);
            var rSrc = Randomizer.Span128<long>(Pow2.T10);  
            var count = blocks(lSrc, rSrc);
            for(var i = 0; i< count; i++)
            {
                var lVec = Vec128.define(lSrc,i);
                var rVec = Vec128.single(rSrc,i);
                var result = dinx.add(lVec,rVec);
                var lX = lVec.Scalar(0).value;
                var lY = lVec.Scalar(1).value;

                var rX = rVec.Scalar(0).value;
                var rY = rVec.Scalar(1).value;
                Claim.eq(lX + rX, result.Scalar(0).value);
                Claim.eq(lY + rY, result.Scalar(1).value);            
            }
          

        }
        void PrimalMul(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i =0; i < len; i++)
                dst[i] = (long) lhs[i] * (long) rhs[i];
        
        }

        void PrimalMul(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i =0; i < len; i++)
                dst[i] = (long) lhs[i] * (long) rhs[i];        
        }



        void TestMulFloat(int? count = null)
        {
            var blocks = count ?? Pow2.T18;
            var lhs = Randomizer.Span256<float>(blocks);
            var rhs = Randomizer.Span256<float>(blocks);
            var dstA = Span256.blockalloc<float>(blocks);
            var dstB = Span256.blockalloc<float>(blocks);

            var len = length(lhs, rhs);
            var cycles = 100;

            var cycle = 0;
            var sw = stopwatch();
            while(++cycle <= cycles)
                MS.ML.Mul256(lhs,rhs, dstA, len);            

            inform($"Completed ML multiplication: {snapshot(sw)}");

            cycle = 0;
            sw.Restart();            
            while(++cycle <= cycles)
                dinx.mul(lhs, rhs, ref dstB);     

            inform($"Completed vector multiplication: {snapshot(sw)}");
            
            Claim.@true(Span256.eq(dstA,dstB));


        }

        void TestMulDouble(int? count = null)
        {
            var blocks = count ?? Pow2.T18;
            var lhs = Randomizer.Span256<double>(blocks);
            var rhs = Randomizer.Span256<double>(blocks);
            var dstA = Span256.blockalloc<double>(blocks).Unblock();
            var dstB = Span256.blockalloc<double>(blocks);

            var len = length(lhs, rhs);
            var cycles = 100;
            var cycle = 0;
            var sw = stopwatch(false);

            cycle = 0;
            sw.Restart();
            while(++cycle <= cycles)
                math.mul(lhs, rhs, ref dstA);     
            
            inform($"Completed primal multiplication: {snapshot(sw)}");

            cycle = 0;
            sw.Restart();
            while(++cycle <= cycles)
                dinx.mul(lhs, rhs, ref dstB);     
            
            inform($"Completed vector multiplication: {snapshot(sw)}");
            
            Claim.@true(Span256.eq(dstA.ToSpan256(), dstB));


        }

        void TestMulInt32(int? count = null)
        {
            var blocks = count ?? Pow2.T18;
            var lhs = Randomizer.Span256<int>(blocks);
            var rhs = Randomizer.Span256<int>(blocks);
            var dstA = Span256.blockalloc<int>(blocks).Unblock();
            var dstB = Span256.blockalloc<long>(blocks);
            Claim.eq(dstA.Length, dstB.Length * 2);

            var len = length(lhs, rhs);
            var cycles = 100;
            var cycle = 0;
            var sw = stopwatch(false);

            cycle = 0;
            sw.Restart();
            while(++cycle <= cycles)
                math.mul(lhs, rhs, ref dstA);     
            
            inform($"Completed primal multiplication: {snapshot(sw)}");

            cycle = 0;
            sw.Restart();
            while(++cycle <= cycles)
                dinx.mul(lhs, rhs, ref dstB);     
            
            inform($"Completed vector multiplication: {snapshot(sw)}");
            
            //Claim.eq(dstA.ToArray(), dstB.ToArray().Select(x => (int)x).ToArray());
        }

        const byte A = 0b00;

        const byte B = 0b01;

        const byte C = 0b10;

        const byte D = 0b11;
        

        void BenchGM()
        {
            var bench = GMathBench.Create(Randomizer);
            print(bench.MulF64());
        }
            
        const byte Reverse =  0b00_01_10_11;
        const byte DCBA = (D << 0) | (C << 2) | (B << 4) | (A << 6) ;

        void TestPermutation()
        {
            var x = Vec128.define(1f,2f,3f,4f);
            var y1 = dinx.permute(x, Reverse); 
            var c1 = PermuteControl.Identity();
            var y2 = dinx.permute(x,c1);
            inform($" P({x}) = {y1}");
            inform($" P({x}) = {y2}");

        }

        void TestMutation()
        {
            var v1 = Vec128.define(1,2,3,4);
            var v2 = Vec128.define(4,5,6,7);
            var v3 = Vec128.add(ref v1, v2);
        }
        static void Main(params string[] args)
        {            
            var app = new Benchmark();
            try
            {                        
                //app.RunGMathBench();
                app.TestAdd3();
                // app.TestMulFloat();
                // GC.Collect();
                // app.TestMulDouble();
                // GC.Collect();
                // app.TestMulInt32();
            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
            //bench.TestRandom();
            //bench.TestMul3();
            //bench.TestAdd2();
            //bench.RunAdHocInXBench();
            //bench.TestPermutation();
        }

    }

}