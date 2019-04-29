//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using static zcore;

    public class DirectBench : Context<App>
    {

        public DirectBench()
         : base(RandSeeds.BenchSeed)
        {

        }

        public static BenchSummary Add(int cycles, int reps, sbyte[] lhs, sbyte[] rhs, sbyte[] dst)        
            => micromark("direct",  OpId.Define(OpKind.Add,  PrimalKind.int8), cycles, reps, r => Duration.define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, byte[] lhs, byte[] rhs, byte[] dst)        
            => micromark("direct", OpId.Define(OpKind.Add,  PrimalKind.uint8), cycles, reps, r => Duration.define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, short[] lhs, short[] rhs, short[] dst)        
            => micromark("direct", OpId.Define(OpKind.Add,  PrimalKind.int16), cycles, reps, r => Duration.define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, ushort[] lhs, ushort[] rhs, ushort[] dst)        
            => micromark("direct", OpId.Define(OpKind.Add,  PrimalKind.uint16), cycles, reps, r => Duration.define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, int[] lhs, int[] rhs, int[] dst)        
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.int32), cycles, reps, r => Duration.define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, uint[] lhs, uint[] rhs, uint[] dst)        
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.uint32), cycles, reps, r => Duration.define(math.addT(lhs,rhs,dst)));                            
        
        public static BenchSummary Add(int cycles, int reps, long[] lhs, long[] rhs, long[] dst)
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.int64),  cycles, reps, r => Duration.define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, ulong[] lhs, ulong[] rhs, ulong[] dst)
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.uint64), cycles, reps, r => Duration.define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, float[] lhs, float[] rhs, float[] dst)
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.float32), cycles, reps, r => Duration.define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, double[] lhs, double[] rhs, double[] dst)
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.float64), cycles, reps, r => Duration.define(math.addT(lhs,rhs,dst)));                            

    }

}