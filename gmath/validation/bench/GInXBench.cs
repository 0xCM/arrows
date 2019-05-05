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
    using static inxfunc;

    public class GInXBench : BenchContext
    {   
        public static GInXBench Create(BenchConfig Config, IRandomizer random)
            => new GInXBench(Config, random);
        
        GInXBench(BenchConfig Config, IRandomizer Randomizer)
            : base(Config, Randomizer)
        {

            gmath.init();

        }

        public BenchComparison CreateI8(int? cycles = null, int? samples = null)
        {
            var data = UnaryOpInit<sbyte>(samples);
            var opid = OpKind.Create.OpId<sbyte>(intrinsic: true);

            var src = data.Source;
            var direct = Measure(opid, samples, () => 
                {
                    var i =0;
                    dinx.store(Vec128.define(
                        src[i++], src[i++], src[i++], src[i++],
                        src[i++], src[i++], src[i++], src[i++],
                        src[i++], src[i++], src[i++], src[i++],
                        src[i++], src[i++], src[i++], src[i++]),
                        data.RightTarget);
                });

            var generic = Measure(~opid, samples, () => 
                dinx.store(Vec128.define(data.Source), data.LeftTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison CreateI32(int? cycles = null, int? samples = null)
        {
            var data = UnaryOpInit<int>(samples);
            var opid = OpKind.Create.OpId<int>(intrinsic: true);

            var src = data.Source;
            var direct = Measure(opid, samples, () => 
                dinx.store(Vec128.define(src[0], src[1], src[2], src[3]), data.RightTarget));

            var generic = Measure(~opid, samples, () => 
                dinx.store(Vec128.define(data.Source), data.LeftTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison CreateF64(int? cycles = null, int? samples = null)
        {
            var data = UnaryOpInit<double>(samples);
            var opid = OpKind.Create.OpId<double>(intrinsic: true);

            var src = data.Source;
            var direct = Measure(opid, samples, () => 
                dinx.store(Vec128.define(src[0], src[1]), data.RightTarget));

            var generic = Measure(~opid, samples, () => 
                dinx.store(Vec128.define(data.Source), data.LeftTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        
        #region Add

        public BenchComparison AddI8(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<sbyte>(samples);
            var opid = OpKind.Add.OpId<sbyte>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.add(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.add(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddU8(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<byte>(samples);
            var opid = OpKind.Add.OpId<byte>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.add(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.add(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddI16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<short>(samples);
            var opid = OpKind.Add.OpId<short>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.add(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.add(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddU16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ushort>(samples);
            var opid = OpKind.Add.OpId<ushort>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.add(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.add(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddI32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<int>(samples);
            var opid = OpKind.Add.OpId<int>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.add(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.add(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddU32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<uint>(samples);
            var opid = OpKind.Add.OpId<uint>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.add(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.add(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddI64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<long>(samples);
            var opid = OpKind.Add.OpId<long>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.add(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.add(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddU64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ulong>(samples);
            var opid = OpKind.Add.OpId<ulong>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.add(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.add(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison AddF32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<float>(samples);
            var opid = OpKind.Add.OpId<float>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.add(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.add(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public BenchComparison AddF64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<double>(samples);
            var opid = OpKind.Add.OpId<double>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.add(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.add(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion
    
    
        #region Sub

        public BenchComparison SubI8(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<sbyte>(samples);
            var opid = OpKind.Add.OpId<sbyte>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.sub(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.sub(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubU8(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<byte>(samples);
            var opid = OpKind.Add.OpId<byte>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.sub(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.sub(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubI16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<short>(samples);
            var opid = OpKind.Add.OpId<short>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.sub(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.sub(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubU16(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ushort>(samples);
            var opid = OpKind.Add.OpId<ushort>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.sub(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.sub(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubI32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<int>(samples);
            var opid = OpKind.Add.OpId<int>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.sub(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.sub(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubU32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<uint>(samples);
            var opid = OpKind.Add.OpId<uint>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.sub(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.sub(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubI64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<long>(samples);
            var opid = OpKind.Add.OpId<long>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.sub(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.sub(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubU64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<ulong>(samples);
            var opid = OpKind.Add.OpId<ulong>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.sub(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.sub(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public BenchComparison SubF32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<float>(samples);
            var opid = OpKind.Add.OpId<float>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.sub(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.sub(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public BenchComparison SubF64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<double>(samples);
            var opid = OpKind.Add.OpId<double>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.sub(data.LeftSource, data.RightSource, ref data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.sub(data.LeftSource, data.RightSource, ref data.RightTarget));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion

        #region Mul


        public BenchComparison MulF32(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<float>(samples);
            var opid = OpKind.Mul.OpId<float>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.mul(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.mul(data.LeftSource, data.RightSource, span(data.RightTarget)));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }


        public BenchComparison MulF64(int? cycles = null, int? samples = null)
        {
            var data = BinOpInit<double>(samples);
            var opid = OpKind.Mul.OpId<double>(intrinsic: true);

            var direct = Measure(opid, samples, () => 
                dinx.mul(data.LeftSource, data.RightSource, data.LeftTarget));

            var generic = Measure(~opid, samples, () => 
                ginx.mul(data.LeftSource, data.RightSource, span(data.RightTarget)));

            var comparison = Compare(opid, direct, generic, cycles, Config.Reps, samples);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        #endregion
    
    }
}