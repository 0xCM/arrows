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
    using static global::mfunc;

    public class PrimalBench : BenchContext
    {
        public static PrimalBench Create(IRandomizer random, BenchConfig config = null)
            => new PrimalBench(random, config);

        static readonly BenchConfig DefaultConfig = new BenchConfig(Cycles: Pow2.T14, Reps: 1, SampleSize: Pow2.T13, AnnounceRate: Pow2.T11);

        PrimalBench(IRandomizer random, BenchConfig config = null)
            : base(random, config ?? DefaultConfig)
            {

            }


        #region Add

        public IBenchComparison AddI16()
        {
            var data = BinOpInit<short>();
            var opid = OpKind.Add.OpId<short>();

            var direct = Measure(opid, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AddU16()
        {
            var data = BinOpInit<ushort>();
            var opid = OpKind.Add.OpId<ushort>();

            var direct = Measure(opid, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AddI32()
        {
            var data = BinOpInit<int>();
            var opid = OpKind.Add.OpId<int>();

            var direct = Measure(opid, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AddU32()
        {
            var data = BinOpInit<uint>();
            var opid = OpKind.Add.OpId<uint>();

            var direct = Measure(opid, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AddI64()
        {
            var data = BinOpInit<long>();
            var opid = OpKind.Add.OpId<long>();

            var direct = Measure(opid, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AddU64()
        {
            var data = BinOpInit<ulong>();
            var opid = OpKind.Add.OpId<ulong>();

            var direct = Measure(opid, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AddF32()
        {
            var data = BinOpInit<float>();
            var opid = OpKind.Add.OpId<float>();

            var direct = Measure(opid, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AddF64()
        {
            var data = BinOpInit<double>();
            var opid = OpKind.Add.OpId<double>();

            var direct = Measure(opid, () => 
                math.add(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.add(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region Sub
        public IBenchComparison SubI16()
        {
            var data = BinOpInit<short>();
            var opid = OpKind.Sub.OpId<short>();

            var direct = Measure(opid, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison SubU16()
        {
            var data = BinOpInit<ushort>();
            var opid = OpKind.Sub.OpId<ushort>();

            var direct = Measure(opid, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison SubI32()
        {
            var data = BinOpInit<int>();
            var opid = OpKind.Sub.OpId<int>();

            var direct = Measure(opid, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison SubU32()
        {
            var data = BinOpInit<uint>();
            var opid = OpKind.Sub.OpId<uint>();

            var direct = Measure(opid, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison SubI64()
        {
            var data = BinOpInit<long>();
            var opid = OpKind.Sub.OpId<long>();

            var direct = Measure(opid, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison SubU64()
        {
            var data = BinOpInit<ulong>();
            var opid = OpKind.Sub.OpId<ulong>();

            var direct = Measure(opid, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison SubF32()
        {
            var data = BinOpInit<float>();
            var opid = OpKind.Sub.OpId<float>();

            var direct = Measure(opid, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison SubF64()
        {
            var data = BinOpInit<double>();
            var opid = OpKind.Sub.OpId<double>();

            var direct = Measure(opid, () => 
                math.sub(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.sub(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
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


        public IBenchComparison MulI16()
        {
            var opid = OpKind.Mul.OpId<short>();
            var src = BinOpInit<short>(true);

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

        public IBenchComparison MulU16()
        {
            var opid = OpKind.Mul.OpId<ushort>();
            var src = BinOpInit<ushort>(true);

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

        public IBenchComparison MulI32()
        {
            var opid = OpKind.Mul.OpId<int>();
            var src = BinOpInit<int>(true);

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

        public IBenchComparison MulU32()
        {
            var opid = OpKind.Mul.OpId<uint>();
            var src = BinOpInit<uint>(true);

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

        public IBenchComparison MulI64()
        {
            var opid = OpKind.Mul.OpId<long>();
            var src = BinOpInit<long>(true);

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

        public IBenchComparison MulU64()
        {
            var opid = OpKind.Mul.OpId<ulong>();
            var src = BinOpInit<ulong>(true);

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


        public IBenchComparison MulF32()
        {
            var opid = OpKind.Mul.OpId<float>();
            var src = BinOpInit<float>(true);

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

        public IBenchComparison MulF64()
        {
            var opid = OpKind.Mul.OpId<double>();
            var src = BinOpInit<double>(true);

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

        public IBenchComparison DivI16()
        {
            var data = BinOpInit<short>(true);
            var opid = OpKind.Div.OpId<short>();

            var direct = Measure(opid, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison DivU16()
        {
            var data = BinOpInit<ushort>(true);
            var opid = OpKind.Div.OpId<ushort>();

            var direct = Measure(opid, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public IBenchComparison DivI32()
        {
            var data = BinOpInit<int>(true);
            var opid = OpKind.Div.OpId<int>();

            var direct = Measure(opid, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison DivU32()
        {
            var data = BinOpInit<uint>(true);
            var opid = OpKind.Div.OpId<uint>();

            var direct = Measure(opid, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public IBenchComparison DivI64()
        {
            var data = BinOpInit<long>(true);
            var opid = OpKind.Div.OpId<long>();

            var direct = Measure(opid, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison DivU64()
        {
            var data = BinOpInit<ulong>(true);
            var opid = OpKind.Div.OpId<ulong>();

            var direct = Measure(opid, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison DivF32()
        {
            var data = BinOpInit<float>(true);
            var opid = OpKind.Div.OpId<float>();

            var direct = Measure(opid, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison DivF64()
        {
            var data = BinOpInit<double>(true);
            var opid = OpKind.Div.OpId<double>();

            var direct = Measure(opid, () => 
                math.div(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.div(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        #endregion

        #region Mod

        public IBenchComparison ModI16()
        {
            var data = BinOpInit<short>(true);
            var opid = OpKind.Mod.OpId<short>();

            var direct = Measure(opid, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU16()
        {
            var data = BinOpInit<ushort>(true);
            var opid = OpKind.Mod.OpId<ushort>();

            var direct = Measure(opid, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public IBenchComparison ModI32()
        {
            var data = BinOpInit<int>(true);
            var opid = OpKind.Mod.OpId<int>();

            var direct = Measure(opid, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU32()
        {
            var data = BinOpInit<uint>(true);
            var opid = OpKind.Mod.OpId<uint>();

            var direct = Measure(opid, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public IBenchComparison ModI64()
        {
            var data = BinOpInit<long>(true);
            var opid = OpKind.Mod.OpId<long>();

            var direct = Measure(opid, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison ModU64()
        {
            var data = BinOpInit<ulong>(true);
            var opid = OpKind.Mod.OpId<ulong>();

            var direct = Measure(opid, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison ModF32()
        {
            var data = BinOpInit<float>(true);
            var opid = OpKind.Mod.OpId<float>();

            var direct = Measure(opid, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison ModF64()
        {
            var data = BinOpInit<double>(true);
            var opid = OpKind.Mod.OpId<double>();

            var direct = Measure(opid, () => 
                math.mod(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.mod(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }



        #endregion

        #region Max

        public IBenchComparison MaxF64(int? cycles = null,  int? samples = null)
        {
            var src = Init<double>();
            var opid = OpKind.Max.OpId<double>();
            var zero = default(double);

            var dResult = zero;
            var gResult = zero;

            var direct = Measure(opid, () => dResult = math.max(src));
            var generic = Measure(~opid, () => gResult = gmath.max(src));
            
            var comparison = Compare(opid, direct, generic);
            Claim.eq(dResult, gResult);            
            return Finish(comparison);
            
        }

        public IBenchComparison MaxI32()
        {
            var src = Init<int>();
            var opid = OpKind.Max.OpId<int>();
            var zero = default(int);
            
            var dResult = zero;
            var gResult = zero;

            var direct = Measure(opid, () => {dResult = math.max(src);});
            var generic = Measure(~opid, () => {gResult = gmath.max(src);});
            
            var comparison = Compare(opid, direct, generic);
            Claim.eq(dResult, gResult);            
            return Finish(comparison);
        }

        #endregion

        #region And

        public IBenchComparison AndI16()
        {
            var data = BinOpInit<short>();
            var opid = OpKind.And.OpId<short>();

            var direct = Measure(opid, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AndU16()
        {
            var data = BinOpInit<ushort>();
            var opid = OpKind.And.OpId<ushort>();

            var direct = Measure(opid, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AndI32()
        {
            var data = BinOpInit<int>();
            var opid = OpKind.And.OpId<int>();

            var direct = Measure(opid, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AndU32()
        {
            var data = BinOpInit<uint>();
            var opid = OpKind.And.OpId<uint>();

            var direct = Measure(opid, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AndI64()
        {
            var data = BinOpInit<long>();
            var opid = OpKind.And.OpId<long>();

            var direct = Measure(opid, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison AndU64()
        {
            var data = BinOpInit<ulong>();
            var opid = OpKind.And.OpId<ulong>();

            var direct = Measure(opid, () => 
                math.and(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.and(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region Or

        public IBenchComparison OrI16()
        {
            var data = BinOpInit<short>();
            var opid = OpKind.Or.OpId<short>();

            var direct = Measure(opid, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison OrU16()
        {
            var data = BinOpInit<ushort>();
            var opid = OpKind.Or.OpId<ushort>();

            var direct = Measure(opid, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison OrI32()
        {
            var data = BinOpInit<int>();
            var opid = OpKind.Or.OpId<int>();

            var direct = Measure(opid, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison OrU32()
        {
            var data = BinOpInit<uint>();
            var opid = OpKind.Or.OpId<uint>();

            var direct = Measure(opid, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison OrI64()
        {
            var data = BinOpInit<long>();
            var opid = OpKind.Or.OpId<long>();

            var direct = Measure(opid, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison OrU64()
        {
            var data = BinOpInit<ulong>();
            var opid = OpKind.Or.OpId<ulong>();

            var direct = Measure(opid, () => 
                math.or(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.or(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region XOr

        public IBenchComparison XOrI16()
        {
            var data = BinOpInit<short>();
            var opid = OpKind.XOr.OpId<short>();

            var direct = Measure(opid, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrU16()
        {
            var data = BinOpInit<ushort>();
            var opid = OpKind.XOr.OpId<ushort>();

            var direct = Measure(opid, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrI32()
        {
            var data = BinOpInit<int>();
            var opid = OpKind.XOr.OpId<int>();

            var direct = Measure(opid, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrU32()
        {
            var data = BinOpInit<uint>();
            var opid = OpKind.XOr.OpId<uint>();

            var direct = Measure(opid, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrI64()
        {
            var data = BinOpInit<long>();
            var opid = OpKind.XOr.OpId<long>();

            var direct = Measure(opid, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison XOrU64()
        {
            var data = BinOpInit<ulong>();
            var opid = OpKind.XOr.OpId<ulong>();

            var direct = Measure(opid, () => 
                math.xor(data.LeftSource, data.RightSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.xor(data.LeftSource, data.RightSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region Flip

        public IBenchComparison FlipI16()
        {
            var data = BinOpInit<short>();
            var opid = OpKind.Flip.OpId<short>();

            var direct = Measure(opid, () => 
                math.flip(data.LeftSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.flip(data.LeftSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }
        
        public IBenchComparison FlipU16()
        {
            var data = BinOpInit<ushort>();
            var opid = OpKind.Flip.OpId<ushort>();

            var direct = Measure(opid, () => 
                math.flip(data.LeftSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.flip(data.LeftSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison FlipI32()
        {
            var data = BinOpInit<int>();
            var opid = OpKind.Flip.OpId<int>();

            var direct = Measure(opid, () => 
                math.flip(data.LeftSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.flip(data.LeftSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison FlipU32()
        {
            var data = BinOpInit<uint>();
            var opid = OpKind.Flip.OpId<uint>();

            var direct = Measure(opid, () => 
                math.flip(data.LeftSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.flip(data.LeftSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public IBenchComparison FlipI64()
        {
            var data = BinOpInit<long>();
            var opid = OpKind.Flip.OpId<long>();

            var direct = Measure(opid, () => 
                math.flip(data.LeftSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.flip(data.LeftSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison FlipU64()
        {
            var data = BinOpInit<ulong>();
            var opid = OpKind.Flip.OpId<ulong>();

            var direct = Measure(opid, () => 
                math.flip(data.LeftSource, data.LeftTarget), data.Length);

            var generic = Measure(~opid, () => 
                gmath.flip(data.LeftSource, data.RightTarget), data.Length);

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion
    }
}