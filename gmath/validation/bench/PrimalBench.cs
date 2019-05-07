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
    using static global::mfunc;

    public class PrimalBench : BenchContext
    {
        public static PrimalBench Create(IRandomizer random, BenchConfig config = null)
            => new PrimalBench(random, config);

        static readonly BenchConfig DefaultConfig = new BenchConfig(Cycles: Pow2.T14, Reps: Pow2.T09, SampleSize: Pow2.T13, AnnounceRate: Pow2.T11);

        PrimalBench(IRandomizer random, BenchConfig config = null)
            : base(random, config ?? DefaultConfig)
            {

            }


        #region Add

        public BenchComparison AddI16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<short>(samples);
            var opid = OpKind.Add.OpId<short>();

            var direct = Measure(opid, samples, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddU16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ushort>(samples);
            var opid = OpKind.Add.OpId<ushort>();

            var direct = Measure(opid, samples, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddI32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<int>(samples);
            var opid = OpKind.Add.OpId<int>();

            var direct = Measure(opid, samples, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddU32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<uint>(samples);
            var opid = OpKind.Add.OpId<uint>();

            var direct = Measure(opid, samples, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddI64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<long>(samples);
            var opid = OpKind.Add.OpId<long>();

            var direct = Measure(opid, samples, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddU64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ulong>(samples);
            var opid = OpKind.Add.OpId<ulong>();

            var direct = Measure(opid, samples, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddF32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<float>(samples);
            var opid = OpKind.Add.OpId<float>();

            var direct = Measure(opid, samples, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddF64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<double>(samples);
            var opid = OpKind.Add.OpId<double>();

            var direct = Measure(opid, samples, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region Sub
        public BenchComparison SubI16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<short>(samples);
            var opid = OpKind.Sub.OpId<short>();

            var direct = Measure(opid, samples, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubU16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ushort>(samples);
            var opid = OpKind.Sub.OpId<ushort>();

            var direct = Measure(opid, samples, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubI32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<int>(samples);
            var opid = OpKind.Sub.OpId<int>();

            var direct = Measure(opid, samples, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubU32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<uint>(samples);
            var opid = OpKind.Sub.OpId<uint>();

            var direct = Measure(opid, samples, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubI64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<long>(samples);
            var opid = OpKind.Sub.OpId<long>();

            var direct = Measure(opid, samples, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubU64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ulong>(samples);
            var opid = OpKind.Sub.OpId<ulong>();

            var direct = Measure(opid, samples, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubF32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<float>(samples);
            var opid = OpKind.Sub.OpId<float>();

            var direct = Measure(opid, samples, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubF64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<double>(samples);
            var opid = OpKind.Sub.OpId<double>();

            var direct = Measure(opid, samples, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region Mul


        [MethodImpl(Inline)]
        public static OpMeasure gmul<T>(BinOpData<T> src)
            where T : struct, IEquatable<T>
        {
            var lhs = rospan(src.LeftSource);
            var rhs = rospan(src.RightSource);
            var dst = span(src.RightTarget);
            var sw = stopwatch();
            gmath.mul(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }


        public BenchComparison MulI16(int? cycles = null, int? samples = null)
        {
            var opid = OpKind.Mul.OpId<short>();
            var src = BinOpInit<short>(samples,true);

            OpMeasure dmul()
            {
                var lhs = rospan(src.LeftSource);
                var rhs = rospan(src.RightSource);
                var dst = span(src.LeftTarget);
                var sw = stopwatch();
                math.mul(lhs, rhs, ref dst);
                return(src.LeftSource.Length, snapshot(sw));
            }
            
            var comparison = Run(opid, Measure(opid, dmul), 
                Measure(~opid, () => gmul(src)));

            Claim.eq(src.LeftTarget, src.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison MulU16(int? cycles = null, int? samples = null)
        {
            var opid = OpKind.Mul.OpId<ushort>();
            var src = BinOpInit<ushort>(samples,true);

            OpMeasure dmul()
            {
                var lhs = rospan(src.LeftSource);
                var rhs = rospan(src.RightSource);
                var dst = span(src.LeftTarget);
                var sw = stopwatch();
                math.mul(lhs, rhs, ref dst);
                return(src.LeftSource.Length, snapshot(sw));
            }
            
            var comparison = Run(opid, Measure(opid, dmul), 
                Measure(~opid, () => gmul(src)));

            Claim.eq(src.LeftTarget, src.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison MulI32(int? cycles = null, int? samples = null)
        {
            var opid = OpKind.Mul.OpId<int>();
            var src = BinOpInit<int>(samples,true);

            OpMeasure dmul()
            {
                var lhs = rospan(src.LeftSource);
                var rhs = rospan(src.RightSource);
                var dst = span(src.LeftTarget);
                var sw = stopwatch();
                math.mul(lhs, rhs, ref dst);
                return(src.LeftSource.Length, snapshot(sw));
            }
            
            var comparison = Run(opid, Measure(opid, dmul), 
                Measure(~opid, () => gmul(src)));

            Claim.eq(src.LeftTarget, src.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison MulU32(int? cycles = null, int? samples = null)
        {
            var opid = OpKind.Mul.OpId<uint>();
            var src = BinOpInit<uint>(samples,true);

            OpMeasure dmul()
            {
                var lhs = rospan(src.LeftSource);
                var rhs = rospan(src.RightSource);
                var dst = span(src.LeftTarget);
                var sw = stopwatch();
                math.mul(lhs, rhs, ref dst);
                return(src.LeftSource.Length, snapshot(sw));
            }
            
            var comparison = Run(opid, Measure(opid, dmul), 
                Measure(~opid, () => gmul(src)));

            Claim.eq(src.LeftTarget, src.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison MulI64(int? cycles = null, int? samples = null)
        {
            var opid = OpKind.Mul.OpId<long>();
            var src = BinOpInit<long>(samples,true);

            OpMeasure dmul()
            {
                var lhs = rospan(src.LeftSource);
                var rhs = rospan(src.RightSource);
                var dst = span(src.LeftTarget);
                var sw = stopwatch();
                math.mul(lhs, rhs, ref dst);
                return(src.LeftSource.Length, snapshot(sw));
            }
            
            var comparison = Run(opid, Measure(opid, dmul), 
                Measure(~opid, () => gmul(src)));

            Claim.eq(src.LeftTarget, src.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison MulU64(int? cycles = null, int? samples = null)
        {
            var opid = OpKind.Mul.OpId<ulong>();
            var src = BinOpInit<ulong>(samples,true);

            OpMeasure dmul()
            {
                var lhs = rospan(src.LeftSource);
                var rhs = rospan(src.RightSource);
                var dst = span(src.LeftTarget);
                var sw = stopwatch();
                math.mul(lhs, rhs, ref dst);
                return(src.LeftSource.Length, snapshot(sw));
            }
            
            var comparison = Run(opid, Measure(opid, dmul), 
                Measure(~opid, () => gmul(src)));

            Claim.eq(src.LeftTarget, src.RightTarget);        
            return Finish(comparison);            
        }


        public BenchComparison MulF32(int? cycles = null, int? samples = null)
        {
            var opid = OpKind.Mul.OpId<float>();
            var src = BinOpInit<float>(samples,true);

            OpMeasure dmul()
            {
                var lhs = rospan(src.LeftSource);
                var rhs = rospan(src.RightSource);
                var dst = span(src.LeftTarget);
                var sw = stopwatch();
                math.mul(lhs, rhs, ref dst);
                return(src.LeftSource.Length, snapshot(sw));
            }
            
            var comparison = Run(opid, Measure(opid, dmul), 
                Measure(~opid, () => gmul(src)));

            Claim.eq(src.LeftTarget, src.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison MulF64(int? cycles = null, int? samples = null)
        {
            var opid = OpKind.Mul.OpId<double>();
            var src = BinOpInit<double>(samples,true);

            OpMeasure dmul()
            {
                var lhs = rospan(src.LeftSource);
                var rhs = rospan(src.RightSource);
                var dst = span(src.LeftTarget);
                var sw = stopwatch();
                math.mul(lhs, rhs, ref dst);
                return(src.LeftSource.Length, snapshot(sw));
            }
            
            var comparison = Run(opid, Measure(opid, dmul), 
                Measure(~opid, () => gmul(src)));

            Claim.eq(src.LeftTarget, src.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region Div

        public BenchComparison DivI16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<short>(samples,true);
            var opid = OpKind.Div.OpId<short>();

            var direct = Measure(opid, samples, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison DivU16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ushort>(samples,true);
            var opid = OpKind.Div.OpId<ushort>();

            var direct = Measure(opid, samples, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public BenchComparison DivI32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<int>(samples,true);
            var opid = OpKind.Div.OpId<int>();

            var direct = Measure(opid, samples, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison DivU32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<uint>(samples,true);
            var opid = OpKind.Div.OpId<uint>();

            var direct = Measure(opid, samples, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public BenchComparison DivI64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<long>(samples,true);
            var opid = OpKind.Div.OpId<long>();

            var direct = Measure(opid, samples, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison DivU64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ulong>(samples,true);
            var opid = OpKind.Div.OpId<ulong>();

            var direct = Measure(opid, samples, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison DivF32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<float>(samples,true);
            var opid = OpKind.Div.OpId<float>();

            var direct = Measure(opid, samples, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison DivF64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<double>(samples,true);
            var opid = OpKind.Div.OpId<double>();

            var direct = Measure(opid, samples, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        #endregion

        #region Mod

        public BenchComparison ModI16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<short>(samples, true);
            var opid = OpKind.Mod.OpId<short>();

            var direct = Measure(opid, samples, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison ModU16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ushort>(samples, true);
            var opid = OpKind.Mod.OpId<ushort>();

            var direct = Measure(opid, samples, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public BenchComparison ModI32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<int>(samples, true);
            var opid = OpKind.Mod.OpId<int>();

            var direct = Measure(opid, samples, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison ModU32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<uint>(samples, true);
            var opid = OpKind.Mod.OpId<uint>();

            var direct = Measure(opid, samples, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public BenchComparison ModI64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<long>(samples, true);
            var opid = OpKind.Mod.OpId<long>();

            var direct = Measure(opid, samples, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison ModU64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ulong>(samples, true);
            var opid = OpKind.Mod.OpId<ulong>();

            var direct = Measure(opid, samples, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison ModF32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<float>(samples,true);
            var opid = OpKind.Mod.OpId<float>();

            var direct = Measure(opid, samples, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison ModF64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<double>(samples, true);
            var opid = OpKind.Mod.OpId<double>();

            var direct = Measure(opid, samples, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }



        #endregion

        #region Max

        public BenchComparison MaxF64(int? cycles = null,  int? samples = null)
        {
            var src = Init<double>(samples);
            var opid = OpKind.Max.OpId<double>();
            var zero = default(double);

            var dResult = zero;
            var gResult = zero;

            var direct = Measure(opid, samples, () => dResult = math.max(src));
            var generic = Measure(~opid, samples, () => gResult = gmath.max(src));
            
            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(dResult, gResult);            
            return Finish(comparison);
            
        }

        public BenchComparison MaxI32(int? cycles = null, int? samples = null)
        {
            var src = Init<int>(samples);
            var opid = OpKind.Max.OpId<int>();
            var zero = default(int);
            
            var dResult = zero;
            var gResult = zero;

            var direct = Measure(opid, samples, () => dResult = math.max(src));
            var generic = Measure(~opid, samples, () => gResult = gmath.max(src));
            
            var comparison = Compare(opid, direct, generic, cycles, 1, samples);            
            Claim.eq(dResult, gResult);            
            return Finish(comparison);
        }

        #endregion

        #region And

        public BenchComparison AndI16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<short>(samples);
            var opid = OpKind.And.OpId<short>();

            var direct = Measure(opid, samples, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AndU16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ushort>(samples);
            var opid = OpKind.And.OpId<ushort>();

            var direct = Measure(opid, samples, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AndI32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<int>(samples);
            var opid = OpKind.And.OpId<int>();

            var direct = Measure(opid, samples, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AndU32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<uint>(samples);
            var opid = OpKind.And.OpId<uint>();

            var direct = Measure(opid, samples, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AndI64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<long>(samples);
            var opid = OpKind.And.OpId<long>();

            var direct = Measure(opid, samples, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AndU64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ulong>(samples);
            var opid = OpKind.And.OpId<ulong>();

            var direct = Measure(opid, samples, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region Or

        public BenchComparison OrI16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<short>(samples);
            var opid = OpKind.Or.OpId<short>();

            var direct = Measure(opid, samples, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison OrU16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ushort>(samples);
            var opid = OpKind.Or.OpId<ushort>();

            var direct = Measure(opid, samples, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison OrI32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<int>(samples);
            var opid = OpKind.Or.OpId<int>();

            var direct = Measure(opid, samples, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison OrU32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<uint>(samples);
            var opid = OpKind.Or.OpId<uint>();

            var direct = Measure(opid, samples, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison OrI64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<long>(samples);
            var opid = OpKind.Or.OpId<long>();

            var direct = Measure(opid, samples, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison OrU64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ulong>(samples);
            var opid = OpKind.Or.OpId<ulong>();

            var direct = Measure(opid, samples, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region XOr

        public BenchComparison XOrI16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<short>(samples);
            var opid = OpKind.XOr.OpId<short>();

            var direct = Measure(opid, samples, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison XOrU16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ushort>(samples);
            var opid = OpKind.XOr.OpId<ushort>();

            var direct = Measure(opid, samples, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison XOrI32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<int>(samples);
            var opid = OpKind.XOr.OpId<int>();

            var direct = Measure(opid, samples, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison XOrU32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<uint>(samples);
            var opid = OpKind.XOr.OpId<uint>();

            var direct = Measure(opid, samples, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison XOrI64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<long>(samples);
            var opid = OpKind.XOr.OpId<long>();

            var direct = Measure(opid, samples, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison XOrU64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ulong>(samples);
            var opid = OpKind.XOr.OpId<ulong>();

            var direct = Measure(opid, samples, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region Flip

        public BenchComparison FlipI16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<short>(samples);
            var opid = OpKind.Flip.OpId<short>();

            var direct = Measure(opid, samples, () => 
                math.flip(data.LeftSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.flip(data.LeftSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }
        
        public BenchComparison FlipU16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ushort>(samples);
            var opid = OpKind.Flip.OpId<ushort>();

            var direct = Measure(opid, samples, () => 
                math.flip(data.LeftSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.flip(data.LeftSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison FlipI32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<int>(samples);
            var opid = OpKind.Flip.OpId<int>();

            var direct = Measure(opid, samples, () => 
                math.flip(data.LeftSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.flip(data.LeftSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison FlipU32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<uint>(samples);
            var opid = OpKind.Flip.OpId<uint>();

            var direct = Measure(opid, samples, () => 
                math.flip(data.LeftSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.flip(data.LeftSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public BenchComparison FlipI64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<long>(samples);
            var opid = OpKind.Flip.OpId<long>();

            var direct = Measure(opid, samples, () => 
                math.flip(data.LeftSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.flip(data.LeftSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison FlipU64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ulong>(samples);
            var opid = OpKind.Flip.OpId<ulong>();

            var direct = Measure(opid, samples, () => 
                math.flip(data.LeftSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                gmath.flip(data.LeftSource, data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, 1, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion
    }
}