//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Collections.Generic;

    using static zcore;

    public delegate BenchComparison BenchComparer(OpKind op, PrimalKind prim);

    public class GenericBench : Context<App>
    {
        public static GenericBench Init(BenchConfig config = null)
            => new GenericBench(config ?? BenchConfig.Default);

        GenericBench(BenchConfig Config)
         : base(RandSeeds.BenchSeed)
        {
            gmath.init();
            this.Config = Config;
        }

        public BenchConfig Config {get;}

        BenchSummary Add<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => micromark("gmath", OpId.Define<T>(OpKind.Add), Config.Cycles, Config.Reps, r => Duration.define(gmath.addT(lhs,rhs,dst)));                

        public BenchComparison Run(OpKind op, PrimalKind prim)
        {
            switch(op)
            {
                case OpKind.Add:
                    return RunAdd(prim);
            }
            throw new Exception($"Operator {op} not supported");

        }

        BenchComparison RunAdd(PrimalKind kind)
        {
            switch(kind)
            {
                case PrimalKind.int8:
                    return RunI8(OpInfo.Add);
                case PrimalKind.uint8:
                    return RunU8(OpInfo.Add);
                case PrimalKind.int16:
                    return RunI16(OpInfo.Add);
                case PrimalKind.uint16:
                    return RunU16(OpInfo.Add);
                case PrimalKind.int32:
                    return RunI32(OpInfo.Add);
                case PrimalKind.uint32:
                    return RunU32(OpInfo.Add);
                case PrimalKind.int64:
                    return RunI64(OpInfo.Add);
                case PrimalKind.uint64:
                    return RunU64(OpInfo.Add);
                case PrimalKind.float32:
                    return RunF32(OpInfo.Add);
                case PrimalKind.float64:
                    return RunF64(OpInfo.Add);
            }
            throw new Exception($"Kind {kind} not supported");
        }

        T[] Sample<T>()
            where T : struct, IEquatable<T>        
                => RandomArray<T>(Config.Reps);

        T[] Target<T>()
            where T : struct, IEquatable<T>        
                => alloc<T>(Config.Reps);

         (T[] lhs, T[] rhs, T[] dDst, T[] gDst) SetupBinOp<T>()
            where T : struct, IEquatable<T>        
            => (Sample<T>(), Sample<T>(), Target<T>(), Target<T>());


        
        BenchComparison RunI8(OpInfo.AddInfo op)
        {
            var setup = SetupBinOp<sbyte>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison RunU8(OpInfo.AddInfo op)
        {
            var setup = SetupBinOp<byte>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison RunI16(OpInfo.AddInfo op)
        {
            var setup = SetupBinOp<short>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison RunU16(OpInfo.AddInfo op)
        {
            var setup = SetupBinOp<ushort>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison RunI32(OpInfo.AddInfo op)
        {
            var setup = SetupBinOp<int>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison RunU32(OpInfo.AddInfo op)
        {
            var setup = SetupBinOp<uint>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison RunI64(OpInfo.AddInfo op)
        {
            var setup = SetupBinOp<long>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison RunU64(OpInfo.AddInfo op)
        {
            var setup = SetupBinOp<ulong>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison RunF32(OpInfo.AddInfo op)
        {
            var setup = SetupBinOp<float>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison RunF64(OpInfo.AddInfo op)
        {
            var setup = SetupBinOp<double>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }    
    }

}