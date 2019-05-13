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

    
    using static zfunc;    
    using static mfunc;
    
    using static math;

    class Benchmark : Context
    {

        public Benchmark()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
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

        void TestNumbers()
        {
            var leftSrc = Randomizer.Span<long>(Pow2.T11);
            var rightSrc = Randomizer.Span<long>(Pow2.T11);
            var dstA = span<long>(Pow2.T11);

            var leftNumbers = numbers(leftSrc);
            var rightNumbers = numbers(rightSrc);

            var sum1 = math.add(leftSrc,rightSrc, dstA);
            var sum2 = leftNumbers + rightNumbers;
            
            Claim.eq(sum1.Freeze(), sum2.Extract());
        }


        void TestAdd3()
        {
            var lSrc = Randomizer.Span256<long>(Pow2.T14);
            var rSrc = Randomizer.Span256<long>(Pow2.T14);                      
            var blocks = global::mfunc.blocks(lSrc, rSrc);
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
                dinx.add(lSrc,rSrc, ref dstB);
            var bTime = snapshot(sw);
            inform($"Intrinsic: {bTime}");

            Claim.eq(dstA, dstB);



        }

        void TestParse()
        {
            var src = Randomizer.Array<int>(Pow2.T20);
            var sw = stopwatch();
            var dst = map(src, x => gmath.parse<int>(x.ToString()));
            inform($"{snapshot(sw)}");
        }

        // void RunBench(BenchKind kind, params  OpKind[] opkinds)
        // {                    
        //     var ops = opkinds.Select(o => o.ToString()).ToHashSet();
        //     var bench = kind.CreateBench(Randomizer);
        //     bench.Run(x => ops.Any(o => x.StartsWith(o)));
        // }

        void RunBench(BenchKind kind,  Func<string, bool> filter = null, BenchConfig config = null)
        {            
            var bench = kind.CreateBench(Randomizer,config);
            bench.Run(filter);
        }

        void Bench51<T>()
            where T : struct, IEquatable<T>
        {
            var samples = Pow2.T19;
            var cycles = Pow2.T12;
            var src = (Left: Randomizer.Array<T>(samples),  Right: Randomizer.Array<T>(samples));
            var dst = (Left: alloc<T>(samples), Right: alloc<T>(samples));
            var leftTime = Duration.Zero;
            var rightTime = Duration.Zero;

            Duration LeftBench()
            {
                var sw = stopwatch();
                gmath.add(src.Left, src.Right, dst.Left);
                return snapshot(sw);
            }

            Duration RightBench()
            {
                var sw = stopwatch();
                for(var i = 0; i< samples; i++)
                    dst.Right[i] = gmath.add(src.Left[i], src.Right[i]);
                return snapshot(sw);
            }

            for(var i=1; i<=cycles; i++)
            {
                leftTime += LeftBench();
                rightTime += RightBench();
            }

            inform($"Left: {leftTime} | Right: {rightTime}");
            

        }

        void Bench51()
        {
            Bench51<byte>();
        }
        // void Bench50<T>()
        //     where T : struct, IEquatable<T>
        // {
        //     var lhs = Randomizer.Array<T>(Pow2.T19);
        //     var rhs = Randomizer.Array<T>(Pow2.T19);
        //     var len = Pow2.T19;
        //     var dst = span<T>(len);
        //     var lhsBytes = As.uint8(lhs);
        //     var rhsBytes = As.uint8(rhs);
        //     var dstBytes = alloc<byte>(len);

        //     void add(byte[] lhs, byte[] rhs, byte[] dst)
        //     {
        //         for(var i =0; i<lhs.Length; i++)
        //         {
        //             ref var x = ref lhs[i];
        //             ref var y = ref rhs[i];
        //             dst[i] = (byte)(x + y);                 
        //         }
        //     }

        //     var sw = stopwatch();
        //     for(var i = 0; i<Pow2.T12; i++)
        //     {
        //         fused.addU8(lhs, rhs, dst);
        //     }
        //     inform($"Generic: {snapshot(sw)}");

        //     sw.Restart();
        //     for(var i = 0; i<Pow2.T12; i++)
        //     {
        //         add(lhsBytes, rhsBytes, dstBytes);
        //     }
        //     inform($"Direct: {snapshot(sw)}");

        // }

        // void Bench50()
        // {
        //     Bench50<byte>();
        // }

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

        public void TestInlining()
        {
            var lhs = Randomizer.Span<byte>(Pow2.T19);
            var rhs = Randomizer.Span<byte>(Pow2.T19);
            var len = Pow2.T19;
            var dst = span<byte>(len);

            var sw = stopwatch();
            for(var i = 0; i<Pow2.T12; i++)
            {
                math.add(lhs, rhs, dst);
            }
            inform($"Inline: {snapshot(sw)}");

            sw.Restart();
            for(var i = 0; i<Pow2.T12; i++)
            {
                //math.addNI(lhs,rhs,dst);
            }
            inform($"Not Inline: {snapshot(sw)}");

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
                    
        const byte Reverse =  0b00_01_10_11;
        const byte DCBA = (D << 0) | (C << 2) | (B << 4) | (A << 6) ;

        void AdHocTests()
        {
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

            void RunGMathBench()
            {
                var operators = set(OpKind.Mul.ToString());
                var bench = PrimalFusedBench.Create(Randomizer);
                bench.Run(name => name.ContainsAny(operators));
            }
            
            void RunAdHocBench()
            {
                var bench = PrimalFusedBench.Create(Randomizer);
                var comparisons = new List<IBenchComparison>();
                comparisons.Add(bench.MulF32());
                comparisons.Add(bench.MulF64());
                var q = from c in comparisons
                        select c.Describe();
                print(q);
            }

            unsafe void TestRandom()
            {
                var arrDst = alloc<double>(Pow2.T20);
                fixed(double* pDst = &arrDst[0])                
                    Randomizer.StreamTo<double>(closed(-250.0, 250.0), arrDst.Length, pDst);
                inform($"Captured {arrDst.Length} elements into an array");

                var spanDst = span<double>(Pow2.T20);
                fixed(double* pDst = &spanDst[0])
                    Randomizer.StreamTo<double>(closed(-250.0, 250.0), arrDst.Length, pDst);
                inform($"Captured {spanDst.Length} elements into a span");
                
            }
           
            //TestPermutation();                        
            TestMutation();
            RunGMathBench();
            RunAdHocBench();
            TestRandom();
        }

        static readonly byte[] PopCounts = new byte[]
        {
            0, 1, 1, 2, 1, 2, 2, 3, 1, 2, 2, 3, 2, 3, 3, 4, 
            1, 2, 2, 3, 2, 3, 3, 4, 2, 3, 3, 4, 3, 4, 4, 5, 
            1, 2, 2, 3, 2, 3, 3, 4, 2, 3, 3, 4, 3, 4, 4, 5, 
            2, 3, 3, 4, 3, 4, 4, 5, 3, 4, 4, 5, 4, 5, 5, 6, 
            1, 2, 2, 3, 2, 3, 3, 4, 2, 3, 3, 4, 3, 4, 4, 5, 
            2, 3, 3, 4, 3, 4, 4, 5, 3, 4, 4, 5, 4, 5, 5, 6, 
            2, 3, 3, 4, 3, 4, 4, 5, 3, 4, 4, 5, 4, 5, 5, 6, 
            3, 4, 4, 5, 4, 5, 5, 6, 4, 5, 5, 6, 5, 6, 6, 7, 
            1, 2, 2, 3, 2, 3, 3, 4, 2, 3, 3, 4, 3, 4, 4, 5, 
            2, 3, 3, 4, 3, 4, 4, 5, 3, 4, 4, 5, 4, 5, 5, 6, 
            2, 3, 3, 4, 3, 4, 4, 5, 3, 4, 4, 5, 4, 5, 5, 6, 
            3, 4, 4, 5, 4, 5, 5, 6, 4, 5, 5, 6, 5, 6, 6, 7, 
            2, 3, 3, 4, 3, 4, 4, 5, 3, 4, 4, 5, 4, 5, 5, 6, 
            3, 4, 4, 5, 4, 5, 5, 6, 4, 5, 5, 6, 5, 6, 6, 7, 
            3, 4, 4, 5, 4, 5, 5, 6, 4, 5, 5, 6, 5, 6, 6, 7, 
            4, 5, 5, 6, 5, 6, 6, 7, 5, 6, 6, 7, 6, 7, 7, 8
        };

        static readonly byte[] Mask = Pow2.powers<byte>(0, 7);
        

        void Pop()
        {
            var counts = Bits.popcounts(0u, Byte.MaxValue);
            var text = counts.Format();
            inform(text);
            
            inform(Mask.Format());

        }

        public void NumberTest()
        {
            var x = num(3u);
            var y = num(4u);
            Claim.eq(7, x + y);
        }
        public void TestEqual()
        {
            var v1 = Vec256.define(2u, 4u, 8u, 10u, 20u, 30u, 40u, 50u);
            var v2 = Vec256.define(1u, 4u, 7u, 11u, 20u, 1u, 1u, 50u);
            var v3 = dinx.eq(v1,v2);
            for(var i = 0; i< Vec256<uint>.Length; i++)
            {
                inform($"{v1[i]} == {v2[i]} => {v3[i]}");
                Claim.eq(v1[i] == v2[i], v3[i]);
            }

        }

        public void BitTest()
        {

            var bs1 = "10001000111";
            var value = Bits.parse<ulong>(bs1).ToBitVector();
            inform(value);
        }

        void RunTests()
        {
            var tm = new TestManager();
            tm.Run();
        }

        void TestRange()
        {
            range(1, 100);
        }

        void Test32()
        {
            var cycles = Pow2.T12;
            var samples = Pow2.T19;

            void RunTest<T>()
                where T : struct, IEquatable<T>
            {
                var lhsA = Randomizer.Array<T>(samples);
                var lhsS = lhsA.ToReadOnlySpan();
                var rhsA = Randomizer.Array<T>(samples);
                var rhsS = rhsA.ToReadOnlySpan();
                var dstA = alloc<T>(samples);
                var dstS = span<T>(samples);

                var sw = stopwatch();
                for(var i = 0; i<cycles; i++)
                    fused.add(lhsS, rhsS, dstS);
                inform($"Spans A: {snapshot(sw)}");

                sw.Restart();
                for(var i = 0; i<cycles; i++)
                    gmath.add(lhsS, rhsS, dstS);
                inform($"Spans B: {snapshot(sw)}");

            }

            RunTest<byte>();

        }

        static ref T DoFlip<T>(ref T val)
            where T : struct, IEquatable<T>
            => ref atoms.flipU8(ref val);

        void ConvertTest()
        {
            var samples = Pow2.T20;
            var src = Randomizer.Array<double>(samples);
            var lhs = span<long>(samples);
            var rhs = span<long>(samples);
            var it = -1;
            var sw = stopwatch();
            while(++it < samples)
                Converter.convert(src[it], ref lhs[it]);
            inform($"Converters: {snapshot(sw)}");

            it = -1;
            sw.Restart();
            while(++it < samples)
                rhs[it] = Convert.ToInt64(src[it]);
            inform($"System.Convert: {snapshot(sw)}");

            //Claim.eq(lhs,rhs);

        }

        void AbsSqrtGeneric<T>()
            where T : struct, IEquatable<T>
        {

            var samples = Pow2.T21;
            var src0 = Randomizer.Span<T>(samples).ToReadOnlySpan();
            var dst0 = src0.Replicate();
            var srcA = src0.Replicate();
            var srcC = Number.many(src0.Replicate()); 
            var dstB = span<T>(samples);

            var srcD = srcC.Replicate().ToReadOnlySpan();           
            var dstD = span<num<T>>(samples);

            for(var i=0; i<samples; i++)
                gmath.sqrt(ref gmath.abs(ref dst0[i]));

            var sw = stopwatch();
            for(var i=0; i < samples; i++)
               gmath.sqrt(ref  gmath.abs(ref srcA[i]));
            inform($"Abs+Sqrt Generic | By Reference: {snapshot(sw)}");

            sw.Restart();
            for(var i = 0; i< samples; i++)
                dstB[i] = gmath.sqrt(gmath.abs(src0[i]));

            inform($"Abs+Sqrt Generic | By Value: {snapshot(sw)}");
            Claim.eq(dst0, dstB);

            sw.Restart();
            for(var i = 0; i< samples; i++)
                srcC[i].Abs().Sqrt();

            inform($"Abs+Sqrt Generic Num | By Reference: {snapshot(sw)}");

            sw.Restart();
            for(var i = 0; i< samples; i++)
                dstD[i] = sqrt(abs(srcD[i]));
            inform($"Abs+Sqrt Generic Num | By Value: {snapshot(sw)}");
            Claim.eq(dst0, dstD.Extract());
        }

        void Distance<T>()
            where T : struct, IEquatable<T>
        {
            var samples = Pow2.T21;
            var src = Randomizer.Span<T>(samples);
            var dst = span<T>(samples);
            
            var sw = stopwatch();
            for(var i=0; i<samples; i++)
                dst[i] = gmath.sqrt(gmath.add(gmath.square(src[i]), gmath.square(src[i])));
            inform($"Distance | Generic | Atomic | By Value: {snapshot(sw)}");

        }

        void DistanceF64()
        {
            var samples = Pow2.T21;
            var src = Randomizer.Span<double>(samples);
            var dst = span<double>(samples);
            
            var sw = stopwatch();
            for(var i=0; i<samples; i++)
                dst[i] = Math.Sqrt(src[i]*src[i] + src[i]*src[i]);
            inform($"Distance | Direct | Atomic | By Value: {snapshot(sw)}");

        }

        void AbsSqrtAtomic()
        {
            var samples = Pow2.T21;
            var srcA = Randomizer.Span<int>(samples, leftclosed(Int32.MinValue, Int32.MaxValue));
            var srcB = srcA.Replicate().ToReadOnlySpan();            
            var dstB = span<int>(samples);
            
            var sw = stopwatch();
            for(var i=0; i < samples; i++)
                srcA[i].Abs().Sqrt();
            inform($"Abs+Sqrt Direct | Atomic | By Reference: {snapshot(sw)}");


            sw.Restart();
            for(var i = 0; i< samples; i++)
                dstB[i] = math.sqrt(math.abs(srcB[i]));
            inform($"Abs+Sqrt Direct | Atomic | By Value: {snapshot(sw)}");
        }
        void AbsSqrtFused()
        {
            var samples = Pow2.T21;
            var srcA = Randomizer.Span<int>(samples, leftclosed(Int32.MinValue, Int32.MaxValue));
            var srcB = srcA.Replicate().ToReadOnlySpan();            
            var dstB = span<int>(samples);
            
            var sw = stopwatch();
            srcA.Abs().Sqrt();            
            inform($"Abs+Sqrt Direct | Fused | By Reference: {snapshot(sw)}");


            sw.Restart();
            srcB.Abs(dstB).Sqrt(dstB);
            inform($"Abs+Sqrt Direct | Fused | By Value: {snapshot(sw)}");
            
            //Claim.eq(srcA, dstB);

        }

        void Distance()
        {
            DistanceF64();
            Distance<double>();
        }
        void AbsSqrt()
        {
            AbsSqrtAtomic();
            AbsSqrtFused();
            AbsSqrtGeneric<int>();
        }
        static void Main(params string[] args)
        {            
            var app = new Benchmark();
            try
            {     
                //app.ConvertTest();
                app.Distance();
                //BenchSelector.RunBench(BenchKind.PrimalAtomic);
                //BenchSelector.RunBench(BenchKind.PrimalFused);

            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
        }

    }

}