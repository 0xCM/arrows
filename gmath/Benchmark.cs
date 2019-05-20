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

        void RunBench(MetricKind kind,  Func<string, bool> filter = null, BenchConfig config = null)
        {            
            var bench = kind.CreateBench(Randomizer,config);
            bench.Run(filter);
        }

        void Bench51<T>()
            where T : struct
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
                fused.add<T>(src.Left, src.Right, dst.Left);
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
            TestRandom();
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


        void RunTests()
        {
            TestRunner.RunTests(string.Empty, false);
        
            // var tm = new TestManager();
            // tm.Run();
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
                where T : struct
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
                    fused.add(lhsS, rhsS, dstS);
                inform($"Spans B: {snapshot(sw)}");

            }

            RunTest<byte>();

        }


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
            where T : struct
        {

            var samples = Pow2.T21;
            var src0 = Randomizer.Span<T>(samples).ToReadOnlySpan();
            var dst0 = src0.Replicate();
            var srcA = src0.Replicate();
            var srcC = Num.many(src0.Replicate()); 
            var dstB = span<T>(samples);

            var srcD = srcC.Replicate().ToReadOnlySpan();           
            var dstD = span<num<T>>(samples);

            for(var i=0; i<samples; i++)
                gmath.sqrt(ref gmath.abs(ref dst0[i]));

            var sw = stopwatch();
            for(var i=0; i < samples; i++)
               gmath.sqrt(ref  gmath.abs(ref srcA[i]));
            inform($"Abs+Sqrt Generic | By Ref: {snapshot(sw)}");

            sw.Restart();
            for(var i = 0; i< samples; i++)
                dstB[i] = gmath.sqrt(gmath.abs(src0[i]));

            inform($"Abs+Sqrt Generic | By Val: {snapshot(sw)}");
            Claim.eq(dst0, dstB);

            sw.Restart();
            for(var i = 0; i< samples; i++)
                srcC[i].Abs().Sqrt();

            inform($"Abs+Sqrt Generic Num | By Ref: {snapshot(sw)}");

            sw.Restart();
            for(var i = 0; i< samples; i++)
                dstD[i] = sqrt(abs(srcD[i]));
            inform($"Abs+Sqrt Generic Num | By Val: {snapshot(sw)}");
            Claim.eq(dst0, dstD.Extract());
        }

        Duration DistanceByValue<T>(int cycles, int samples)
            where T : struct
        {
            var src = Randomizer.Span<T>(samples);
            var dst = span<T>(samples);
            var opcount = 0L;     
            var opsPerCycle = 4*samples;

            var sw = stopwatch();            
            for(var cycle = 1; cycle <= cycles; cycle++)
            {
                for(var i=0; i<samples; i++)
                    dst[i] = gmath.sqrt(gmath.add(gmath.square(src[i]), gmath.square(src[i])));
                opcount += opsPerCycle;
            }

            var time = snapshot(sw);
            var msg = AppMsg.Define($"dist | Generic | Native  | Atomic | By Val | Cycles = {cycles} | Samples = {samples} | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
            print(msg);
            return time;
        }

        Duration DistanceByRef2<T>(int cycles, int samples)
            where T : struct
        {

            var leftSrc = Randomizer.Span<T>(samples);
            var rightSrc = Randomizer.Span<T>(samples);
            var lhs = leftSrc.Replicate();
            var rhs = rightSrc.Replicate(); 
            var dst = span<T>(samples);
            var opcount = 0L;     
            var opsPerCycle = 4*samples;

            var sw = stopwatch(false);
            for(var cycle = 1; cycle <= cycles; cycle++)
            {
                sw.Start();
                for(var i=0; i<samples; i++)
                {
                    ref var x = ref gmath.square(ref lhs[i]);
                    ref var y = ref gmath.square(ref rhs[i]);                    
                    ref var z = ref gmath.add(ref x, y);
                    dst[i] = gmath.sqrt(ref z);                    
                }
                sw.Stop();
                
                opcount += opsPerCycle;

                leftSrc.CopyTo(lhs);
                rightSrc.CopyTo(rhs);            
            }
            var time = snapshot(sw);
            var msg = AppMsg.Define($"dist | Generic | Derived | Atomic | By Ref | Cycles = {cycles} | Samples = {samples} | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
            print(msg);            
            return time;

        }

        Duration DistanceByRef<T>(int cycles, int samples)
            where T : struct
        {
            var leftSrc = Num.many(Randomizer.Span<T>(samples)).ToReadOnlySpan();
            var rightSrc = Num.many(Randomizer.Span<T>(samples)).ToReadOnlySpan();
            var lhs = leftSrc.Replicate();
            var rhs = rightSrc.Replicate();       
            var opcount = 0L;     
            var opsPerCycle = 4*samples;

            var sw = stopwatch(false);
            for(var cycle = 1; cycle <= cycles; cycle++)
            {
                sw.Start();
                for(var i=0; i<samples; i++)
                    lhs[i].Square().Add(rhs[i].Square()).Sqrt();                
                sw.Stop();
                
                opcount += opsPerCycle;

                leftSrc.CopyTo(lhs);
                rightSrc.CopyTo(rhs);            
            }
            var time = snapshot(sw);
            var msg = AppMsg.Define($"dist | Generic | Derived | Atomic | By Ref | Cycles = {cycles} | Samples = {samples} | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
            print(msg);            
            return time;

        }

        Duration Distance3<T>(int cycles, int samples)
            where T : struct
        {
            var lhs = Num.many(Randomizer.Span<T>(samples)).ToReadOnlySpan();
            var rhs = Num.many(Randomizer.Span<T>(samples)).ToReadOnlySpan();
            var opcount = 0L;     
            var opsPerCycle = 4*samples;

            var sw = stopwatch(false);
            for(var cycle = 1; cycle <= cycles; cycle++)
            {
                sw.Start();
                for(var i=0; i<samples; i++)
                {
                    var x = lhs[i]*lhs[i] + rhs[i]*rhs[i];
                    x.Sqrt();
                }
                    
                sw.Stop();
                
                opcount += opsPerCycle;

            }
            var time = snapshot(sw);
            var msg = AppMsg.Define($"dist | Generic | Derived | Atomic | By Val | Cycles = {cycles} | Samples = {samples} | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
            print(msg);            
            return time;

        }


        Duration DistanceF64A(int cycles, int samples)
        {
            var lhs = Randomizer.Span<double>(samples);
            var rhs = Randomizer.Span<double>(samples);
            var dst = span<double>(samples);
            
            var opcount = 0L;     
            var opsPerCycle = 4*samples;

            var sw = stopwatch();            
            for(var cycle = 1; cycle <= cycles; cycle++)
            {
                for(var i=0; i<samples; i++)
                    dst[i] = Math.Sqrt(math.add(math.square(lhs[i]), math.square(rhs[i])));

                opcount += opsPerCycle;
            }
            var time = snapshot(sw);
            var msg = AppMsg.Define($"dist | Primal  | Native  | Atomic | By Val | Cycles = {cycles} | Samples = {samples} | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
            print(msg);            
            return time;

        }

        Duration DistanceF64B(int cycles, int samples)
        {
            var lhs = Randomizer.Span<double>(samples);
            var rhs = Randomizer.Span<double>(samples);
            var dst = span<double>(samples);
            
            var opcount = 0L;     
            var opsPerCycle = 4*samples;

            var sw = stopwatch();            
            for(var cycle = 1; cycle <= cycles; cycle++)
            {
                for(var i=0; i<samples; i++)
                    dst[i] = Math.Sqrt(lhs[i]*lhs[i] + rhs[i]*rhs[i]);

                opcount += opsPerCycle;
            }
            var time = snapshot(sw);
            var msg = AppMsg.Define($"dist | Primal  | Native  | Atomic | By Val | Cycles = {cycles} | Samples = {samples} | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
            print(msg);            
            return time;

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
            inform($"Abs+Sqrt Direct | Fused | By Ref: {snapshot(sw)}");


            sw.Restart();
            srcB.Abs(dstB).Sqrt(dstB);
            inform($"Abs+Sqrt Direct | Fused | By Val: {snapshot(sw)}");
            
            //Claim.eq(srcA, dstB);

        }

        void Distance()
        {
            var cycles = Pow2.T12;
            var samples = Pow2.T14;
            var leftTime = Duration.Zero;
            var rightTime = Duration.Zero;
            for(var i = 0; i<20; i++)
            {
                leftTime += DistanceF64A(cycles,samples);
                rightTime += DistanceByRef<double>(cycles, samples);
                //rightTime += DistanceByValue<double>(cycles, samples);

            }

            inform($"Performance Ratio {leftTime/rightTime}");
        }

        void AbsSqrt()
        {
            AbsSqrtAtomic();
            AbsSqrtFused();
            AbsSqrtGeneric<int>();
        }

        static string BinOpSig<T>(string OpSymbol)
            {
                var domain = type<T>().Name;
                return $"{OpSymbol}:{domain} -> {domain} -> {domain}".PadRight(30);
            }
        void TestU32()
        {
            var cycles = Pow2.T14;
            var samples = Pow2.T12;
            var lhs = Randomizer.Array<uint>(samples);
            var rhs = Randomizer.Array<uint>(samples);
            var dst = alloc<uint>(samples);
            var xDst = alloc<U32>(samples);
            var xLhs = U32.Many(lhs).ToArray();
            var xRhs = U32.Many(rhs).ToArray();

            void Native()
            {
                var sw = stopwatch();
                var opcount = 0L;
                var sig = BinOpSig<uint>("&");

                for(var cycle = 0; cycle< cycles; cycle++)
                {
                    for(var sample = 0; sample < samples; sample++)
                        lhs[sample] &= rhs[sample];
                    opcount += samples;
                }
                var time = snapshot(sw);
                var msg = AppMsg.Define($"{sig} | Primal | Native  | Atomic | By Val | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
                print(msg);
            }

            void Derived()
            {
                var sw = stopwatch();
                var opcount = 0L;
                var sig = BinOpSig<U32>("&");

                for(var cycle = 0; cycle< cycles; cycle++)
                {
                    for(var sample = 0; sample < samples; sample++)
                        xLhs[sample].And(rhs[sample]);
                    opcount += samples;
                }
                var time = snapshot(sw);
                var msg = AppMsg.Define($"{sig} | Primal | Derived | Atomic | By Val | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
                print(msg);
            }

            Native();
            Derived();
            Native();
            Derived();
            Native();
            Derived();
            Native();
            Derived();

        }


        void TestI64()
        {
            var cycles = Pow2.T14;
            var samples = Pow2.T12;
            var lhs = Randomizer.Array<long>(samples);
            var rhs = Randomizer.Array<long>(samples);
            var dst = alloc<long>(samples);
            var xDst = alloc<I64>(samples);
            var xLhs = I64.Many(lhs).ToArray();
            var xRhs = I64.Many(rhs).ToArray();

            void Native()
            {
                var sw = stopwatch();
                var opcount = 0L;
                var sig = BinOpSig<long>("&");

                for(var cycle = 0; cycle< cycles; cycle++)
                {
                    for(var sample = 0; sample < samples; sample++)
                        lhs[sample] &= rhs[sample];
                    opcount += samples;
                }
                var time = snapshot(sw);
                var msg = AppMsg.Define($"{sig} | Primal | Native  | Atomic | By Value | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
                print(msg);
            }

            void Derived()
            {
                var sw = stopwatch();
                var opcount = 0L;
                var sig = BinOpSig<I64>("&");

                for(var cycle = 0; cycle< cycles; cycle++)
                {
                    for(var sample = 0; sample < samples; sample++)
                        xLhs[sample].And(rhs[sample]);
                    opcount += samples;
                }
                var time = snapshot(sw);
                var msg = AppMsg.Define($"{sig} | Primal | Derived | Atomic | By Value | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
                print(msg);
            }

            Native();
            Derived();
            Native();
            Derived();
            Native();
            Derived();
            Native();
            Derived();

        }



        void TestU8()
        {
            var cycles = Pow2.T14;
            var samples = Pow2.T12;
            var lhs = Randomizer.Array<byte>(samples);
            var rhs = Randomizer.Array<byte>(samples);
            var dst = alloc<byte>(samples);
            var xDst = alloc<U8>(samples);
            var xLhs = U8.Many(lhs).ToArray();
            var xRhs = U8.Many(rhs).ToArray();

            void Native()
            {
                var sw = stopwatch();
                var opcount = 0L;
                var sig = BinOpSig<byte>("&");

                for(var cycle = 0; cycle< cycles; cycle++)
                {
                    for(var sample = 0; sample < samples; sample++)
                        lhs[sample] &= rhs[sample];
                    opcount += samples;
                }
                var time = snapshot(sw);
                var msg = AppMsg.Define($"{sig} | Primal | Native  | Atomic | By Value | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
                print(msg);
            }

            void Derived()
            {
                var sw = stopwatch();
                var opcount = 0L;
                var sig = BinOpSig<U8>("&");

                for(var cycle = 0; cycle< cycles; cycle++)
                {
                    for(var sample = 0; sample < samples; sample++)
                        xLhs[sample].And(rhs[sample]);
                    opcount += samples;
                }
                var time = snapshot(sw);
                var msg = AppMsg.Define($"{sig} | Primal | Derived | Atomic | By Value | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
                print(msg);
            }

            Native();
            Derived();
            Native();
            Derived();
            Native();
            Derived();
            Native();
            Derived();

        }

        void TestIncrement()
        {
            void Num()
            {
                var start = 0L;
                var sw = stopwatch();
                for(var i = 0; i< Pow2.T26; i++, gmath.inc(ref start))
                {

                }
                var opcount = start;
                var time = snapshot(sw);
                var msg = AppMsg.Define($"dist | Generic  | Derived  | Atomic | By Value | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
                print(msg);
            }

            void Native()
            {
                var start = 0L;
                var sw = stopwatch();
                for(var i = 0; i< Pow2.T26; i++, start++)
                {

                }
                var opcount = start;
                var time = snapshot(sw);
                var msg = AppMsg.Define($"dist | Generic  | Native  | Atomic | By Value | OpCount = {opcount} | Time = {time.Ms} ms", SeverityLevel.Perform);
                print(msg);
            }
            Num();
            Native();

        }


       void BenchNumG()
       {
            var config = MetricConfig.Define(runs: Pow2.T03, cycles: Pow2.T13, samples: Pow2.T12, dops: true);
            var comparisons = items(
                // MetricKind.PrimalDirect.DefineComparison(MetricKind.NumG, PrimalKind.int64, OpKind.Add),
                // MetricKind.PrimalDirect.DefineComparison(MetricKind.NumG, PrimalKind.int64, OpKind.Sub),
                // MetricKind.PrimalDirect.DefineComparison(MetricKind.NumG, PrimalKind.uint32, OpKind.Add),
                // MetricKind.PrimalDirect.DefineComparison(MetricKind.NumG, PrimalKind.uint32, OpKind.Sub),
                MetricKind.PrimalDirect.DefineComparison(MetricKind.Number, PrimalKind.float32, OpKind.Eq),
                MetricKind.PrimalDirect.DefineComparison(MetricKind.Number, PrimalKind.float32, OpKind.Gt),
                MetricKind.PrimalDirect.DefineComparison(MetricKind.Number, PrimalKind.float32, OpKind.GtEq),
                MetricKind.PrimalDirect.DefineComparison(MetricKind.Number, PrimalKind.float32, OpKind.Lt),
                MetricKind.PrimalDirect.DefineComparison(MetricKind.Number, PrimalKind.float32, OpKind.LtEq)
                );
            var records = comparisons.Run(config).ToList();

       }

        public static IEnumerable<IOpMetrics> Run(IEnumerable<MetricKind> metrics, IEnumerable<OpKind> ops, 
            IEnumerable<PrimalKind> primitives, MetricConfig config = null, IRandomizer random = null)
        {
            var query = from m in metrics
                        from o in ops
                        from p in primitives
                        select m.Run(o,p, config, random);
            return query;
        }

        public static void TryThis()
        {
            gmath.init();
            var baselines = new List<IOpMetrics>();
            var benchmarks = new List<IOpMetrics>();
            var config = MetricConfig.Define(runs: Pow2.T04, cycles: Pow2.T14, samples: Pow2.T13, dops: false);
            var metrics = items(MetricKind.PrimalDirect, MetricKind.Number, MetricKind.PrimalGeneric);
            var ops = items(OpKind.Add);
            var primitives = items(PrimalKind.int32);
            var runs = Run(metrics, ops, primitives, config);            
            foreach(var run in runs)
            {
                print(run.Describe());
                if(run.PrimalDirect)
                    baselines.Add(run);
                else
                    benchmarks.Add(run);

                GC.Collect();
            }

        }

       void MeasurePrimalGeneric()
       {
            var config = MetricConfig.Define(runs: Pow2.T04, cycles: Pow2.T14, samples: Pow2.T13, dops: false);
            
            var m1 = MetricKind.PrimalDirect.Run(OpKind.And, PrimalKind.int32, config);
            print(m1.Describe());

            var m2 = MetricKind.PrimalGeneric.Run(OpKind.And, PrimalKind.int32, config);
            print(m2.Describe());

            print(items(m1.Compare(m2).ToRecord()).FormatMessages());

       }

        void RunForever()
        {
            gmath.init();
            var config128 = InXMetricConfig128.Define(runs: Pow2.T04, cycles: Pow2.T14, blocks: Pow2.T09);            
            var config256 = InXMetricConfig256.Define(runs: Pow2.T04, cycles: Pow2.T14, blocks: Pow2.T12);            
            while(true)
            {
                iter(InXBench.Compare(OpKind.XOr, PrimalKind.uint64, config128), x => {});
                iter(InXBench.Compare(OpKind.XOr, PrimalKind.uint64, config256), x => {});
            }
        }

        unsafe void TestInline()
        {
            var blocks = Pow2.T13;
            var cycles = Pow2.T08;
            var blocklen = Span128.blocklength<int>();
            var lhs = Randomizer.Span128<int>(blocks);
            var rhs = Randomizer.Span128<int>(blocks);
            var dst = Span128.blockalloc<int>(blocks);
            var run = 0L;
            var timeTotal = Duration.Zero;
            while(++run > 0)
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= cycles; cycle++)
                {
                    fixed(int* pDst = &first(dst))
                    {
                        int* pDstIt = pDst;
                        for(var block = 0; block < blocks; block++, pDstIt += blocklen)
                        {
                            var x = Vec128.single(lhs, block);
                            var y = Vec128.single(rhs, block);
                            dinx.store(ginx.add(x,y), pDstIt);                    
                        }
                    }
                }
                var time = snapshot(sw);
                timeTotal += time;
                var timeAvg = ticksToMs((long)( (double)timeTotal.Ticks / (double)run));
                inform($"Run {run} {time}, Total Runs = {run}, Average Run Time = {timeAvg}");
            }
        }

        void Compare50()
        {
            var config = MetricConfig.Define(runs: Pow2.T04, cycles: Pow2.T14, samples: Pow2.T13, dops: false);
            var lhs = Randomizer.Array<int>(config.Samples);
            var rhs = Randomizer.Array<int>(config.Samples);
            var dst = alloc<int>(config.Samples);

            void Version1()
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= config.Cycles; cycle++)
                {
                    for(var i = 0; i<dst.Length; i++)
                    {
                        var x = lhs[i];
                        var y = rhs[i];
                        dst[i] = math.add(ref x, y);                                    
                    }
                }
                inform($"Version1: {snapshot(sw)}");
            }

            void Version2()
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= config.Cycles; cycle++)
                {
                    for(var i = 0; i<dst.Length; i++)
                    {
                        var x = lhs[i];
                        var y = rhs[i];
                        dst[i] = math.add(x, y);                                    
                    }
                }
                inform($"Version2: {snapshot(sw)}");
            }
            for(var i =1; i<=config.Runs; i++)
            {
                Version1();
                Version2();
            }
        }


        public readonly struct UnaryFunc<S,T>
            where S : struct            
        {
            public static readonly UnaryFunc<S,T> TheOnly = default;
            
            public T Eval(S arg)
                => throw new NotImplementedException();

        }

        public readonly struct BitString<S,T>
            where S : struct            
        {
            public static readonly BitString<S,T> TheOnly = default;

            [MethodImpl(Inline)]
            public string Eval(S arg)
                => Bits.bitstring(arg);
        }

        [MethodImpl(Optimize)]
        void Measure<S,T>(string name, int cycles, int samples, UnaryFunc<S,T> f)
            where S : struct
        {
            var _f = Unsafe.As<UnaryFunc<S,T>, BitString<S,T>>(ref f);
            var src = Randomizer.Span<S>(samples);                
            var sw = stopwatch(false);
            sw.Start();
            for(var cycle=1; cycle<= cycles; cycle++)
            for(var i = 0; i < samples; i++)
                _f.Eval(src[i]);                            
            sw.Stop();
            var time1 = snapshot(sw);

            sw.Restart();
            for(var cycle=1; cycle<= cycles; cycle++)
            for(var i = 0; i < samples; i++)
                Bits.bitstring(src[i]);
            sw.Stop();
            var time2 = snapshot(sw);


            print($"{name} | Time1 = {time1.Ms} ms | Time2 = {time2.Ms} ms");
        }


        [MethodImpl(Optimize)]
        void Measure<S,T>(string name, int cycles, int samples, Func<S,T> f, Func<S,T> g)
            where S : struct
        {
            var src = Randomizer.Span<S>(samples);
            var fDst = span<T>(samples);
            var gDst = span<T>(samples);
                

            var sw = stopwatch(false);
            sw.Start();
            for(var cycle=1; cycle<= cycles; cycle++)
            for(var i = 0; i < samples; i++)
                fDst[i] = f(src[i]);
                
            sw.Stop();
            var time1 = snapshot(sw);

            sw.Restart();
            for(var cycle=1; cycle<= cycles; cycle++)
            for(var i = 0; i < samples; i++)
                gDst[i] = g(src[i]);
                
            sw.Stop();
            var time2 = snapshot(sw);

            print($"{name} | Time1 = {time1.Ms} ms | Time2 = {time2.Ms} ms");
        }


        void Measure<S>(string name, int cycles, int samples, bool verify = true)
            where S : struct
        {
            var src = Randomizer.Span<S>(samples);
            if(verify)
                for(var i = 0; i<samples; i++)
                {
                    var x = Bits.bitspan(src[i]);
                    var y = Bits.bitstring(src[i]);
                    var len = length<Bit,char>(x,y);
                    for(var j = 0; j < len; j++)
                        Claim.eq(x[j], y[j]);                
                }
                

            var sw = stopwatch(false);
            sw.Start();
            for(var cycle=1; cycle<= cycles; cycle++)
            for(var i = 0; i < samples; i++)
                Bits.bitspan(src[i]);
                                
            sw.Stop();
            var time1 = snapshot(sw);

            sw.Restart();
            for(var cycle=1; cycle<= cycles; cycle++)
            for(var i = 0; i < samples; i++)
                Bits.bitstring(src[i]);
                
            sw.Stop();
            var time2 = snapshot(sw);

            print($"{name} | Time1 = {time1.Ms} ms | Time2 = {time2.Ms} ms");
        }

        static void GenPow2Bits()
        {
            for(var pos = 0; pos < 64; pos++)
                print($"1 << {pos} = {(1ul << pos).ToBitString()}");

        }

        void BitVectors<T>(int cycles, int samples)
            where T : struct
        {
            var src = Randomizer.Span<T>(samples);

            var sw = stopwatch(false);
            sw.Start();
            for(var cycle=1; cycle<= cycles; cycle++)
            for(var i = 0; i < samples; i++)
            {
                var x = Bits.bitspan(src[i]);
                Bits.bitpack<T>(x, out T y);
                Claim.eq(src[i], y);
                
                // var bvX = BitVectorU64.Define(src[i]);
                // var bvY = bvX.BitSpan();
                // var bvZ = BitVectorU64.Define(bvY);
                // Claim.@true(bvX.Eq(bvZ), $"{bvX.Format()} != {bvZ.Format()}");
            }
                

            sw.Stop();
            var time1 = snapshot(sw);
            print($"{time1.Ms} ms");

            // sw.Restart();
            // for(var cycle=1; cycle<= cycles; cycle++)
            // for(var i = 0; i < samples; i++)
            //     Bits.bitstring(src[i]);
                
            // sw.Stop();
            // var time2 = snapshot(sw);

            // print($"{nameof(BitVectors)} | Time1 = {time1.Ms} ms | Time2 = {time2.Ms} ms");

        }
        void BitTests()
        {
            var cycles = Pow2.T06;
            var samples = Pow2.T16;
            var loop = true;            
        
            if(!loop)
                return;

            while(loop)
                BitVectors<byte>(cycles,samples);

            while(loop)
                Measure<ulong>("bits", cycles, samples);
            
            while(loop)
                Measure<uint,string>("bitstring", cycles, samples, UnaryFunc<uint,string>.TheOnly); 



            // byte src = 0b1010100;
            // var dst = src;
            // var bv1 = src.ToBitVector().Format();
            // var bv2 = Bits.loOff(ref src).ToBitVector().Format();
            // print($"{nameof(Bits.loOff)}({bv1}) = {bv2}");

            // print($"{nameof(Bits.loOff)}({Pow2.T09.ToBitVector().Format()}) = {Bits.loOff(Pow2.T09).ToBitVector().Format()}");

        }       
        static void Main(params string[] args)
        {            
            var app = new Benchmark();
            try
            {     
                gmath.one<byte>();
                app.BitTests();
                //app.Distance();
                //app.RunForever();
                //app.Compare50();
                                
                //app.RunTests();
                //BenchSelector.RunBench(BenchKind.PrimalAtomic);
                // BenchSelector.RunBench(BenchKind.PrimalFused);
                // BenchSelector.RunBench(BenchKind.Vec128);
                //app.RunNumG();   

            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
        }

    }

}