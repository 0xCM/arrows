//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zcore;

    public static class PrimalDirect 
    {


        #region Add

        //! Add
        //! -------------------------------------------------------------------
        public static BenchSummary Add(int cycles, int reps, sbyte[] lhs, sbyte[] rhs, sbyte[] dst)        
            => micromark("direct",  OpId.Define(OpKind.Add,  PrimalKind.int8), cycles, reps, 
                r => Duration.Define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, byte[] lhs, byte[] rhs, byte[] dst)        
            => micromark("direct", OpId.Define(OpKind.Add,  PrimalKind.uint8), cycles, reps, 
                r => Duration.Define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, short[] lhs, short[] rhs, short[] dst)        
            => micromark("direct", OpId.Define(OpKind.Add,  PrimalKind.int16), cycles, reps, 
                r => Duration.Define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, ushort[] lhs, ushort[] rhs, ushort[] dst)        
            => micromark("direct", OpId.Define(OpKind.Add,  PrimalKind.uint16), cycles, reps, 
                r => Duration.Define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, int[] lhs, int[] rhs, int[] dst)        
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.int32), cycles, reps, 
                r => Duration.Define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, uint[] lhs, uint[] rhs, uint[] dst)        
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.uint32), cycles, reps, 
                r => Duration.Define(math.addT(lhs,rhs,dst)));                            
        
        public static BenchSummary Add(int cycles, int reps, long[] lhs, long[] rhs, long[] dst)
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.int64),  cycles, reps, 
                r => Duration.Define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, ulong[] lhs, ulong[] rhs, ulong[] dst)
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.uint64), cycles, reps, 
                r => Duration.Define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, float[] lhs, float[] rhs, float[] dst)
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.float32), cycles, reps, 
                r => Duration.Define(math.addT(lhs,rhs,dst)));                            

        public static BenchSummary Add(int cycles, int reps, double[] lhs, double[] rhs, double[] dst)
            => micromark("direct", OpId.Define(OpKind.Add, PrimalKind.float64), cycles, reps, 
                r => Duration.Define(math.addT(lhs,rhs,dst)));                            

        #endregion

        #region Sub

        //! Sub
        //! -------------------------------------------------------------------
        public static BenchSummary Sub(int cycles, int reps, sbyte[] lhs, sbyte[] rhs, sbyte[] dst)        
            => micromark("direct",  OpId.Define(OpKind.Sub,  PrimalKind.int8), cycles, reps, 
                r => Duration.Define(math.subT(lhs,rhs,dst)));                            

        public static BenchSummary Sub(int cycles, int reps, byte[] lhs, byte[] rhs, byte[] dst)        
            => micromark("direct", OpId.Define(OpKind.Sub,  PrimalKind.uint8), cycles, reps, 
                r => Duration.Define(math.subT(lhs,rhs,dst)));                            

        public static BenchSummary Sub(int cycles, int reps, short[] lhs, short[] rhs, short[] dst)        
            => micromark("direct", OpId.Define(OpKind.Sub,  PrimalKind.int16), cycles, reps, 
                r => Duration.Define(math.subT(lhs,rhs,dst)));                            

        public static BenchSummary Sub(int cycles, int reps, ushort[] lhs, ushort[] rhs, ushort[] dst)        
            => micromark("direct", OpId.Define(OpKind.Sub,  PrimalKind.uint16), cycles, reps, 
                r => Duration.Define(math.subT(lhs,rhs,dst)));                            

        public static BenchSummary Sub(int cycles, int reps, int[] lhs, int[] rhs, int[] dst)        
            => micromark("direct", OpId.Define(OpKind.Sub, PrimalKind.int32), cycles, reps, 
                r => Duration.Define(math.subT(lhs,rhs,dst)));                            

        public static BenchSummary Sub(int cycles, int reps, uint[] lhs, uint[] rhs, uint[] dst)        
            => micromark("direct", OpId.Define(OpKind.Sub, PrimalKind.uint32), cycles, reps, 
                r => Duration.Define(math.subT(lhs,rhs,dst)));                            
        
        public static BenchSummary Sub(int cycles, int reps, long[] lhs, long[] rhs, long[] dst)
            => micromark("direct", OpId.Define(OpKind.Sub, PrimalKind.int64),  cycles, reps, 
                r => Duration.Define(math.subT(lhs,rhs,dst)));                            

        public static BenchSummary Sub(int cycles, int reps, ulong[] lhs, ulong[] rhs, ulong[] dst)
            => micromark("direct", OpId.Define(OpKind.Sub, PrimalKind.uint64), cycles, reps, 
                r => Duration.Define(math.subT(lhs,rhs,dst)));                            

        public static BenchSummary Sub(int cycles, int reps, float[] lhs, float[] rhs, float[] dst)
            => micromark("direct", OpId.Define(OpKind.Sub, PrimalKind.float32), cycles, reps, 
                r => Duration.Define(math.subT(lhs,rhs,dst)));                            

        public static BenchSummary Sub(int cycles, int reps, double[] lhs, double[] rhs, double[] dst)
            => micromark("direct", OpId.Define(OpKind.Sub, PrimalKind.float64), cycles, reps, 
                r => Duration.Define(math.subT(lhs,rhs,dst)));                            

        #endregion

        #region Mul

        //! Mul
        //! -------------------------------------------------------------------
        public static BenchSummary Mul(int cycles, int reps, sbyte[] lhs, sbyte[] rhs, sbyte[] dst)        
            => micromark("direct",  OpId.Define(OpKind.Mul,  PrimalKind.int8), cycles, reps, 
                r => Duration.Define(math.mulT(lhs,rhs,dst)));                            

        public static BenchSummary Mul(int cycles, int reps, byte[] lhs, byte[] rhs, byte[] dst)        
            => micromark("direct", OpId.Define(OpKind.Mul,  PrimalKind.uint8), cycles, reps, 
                r => Duration.Define(math.mulT(lhs,rhs,dst)));                            

        public static BenchSummary Mul(int cycles, int reps, short[] lhs, short[] rhs, short[] dst)        
            => micromark("direct", OpId.Define(OpKind.Mul,  PrimalKind.int16), cycles, reps, 
                r => Duration.Define(math.mulT(lhs,rhs,dst)));                            

        public static BenchSummary Mul(int cycles, int reps, ushort[] lhs, ushort[] rhs, ushort[] dst)        
            => micromark("direct", OpId.Define(OpKind.Mul,  PrimalKind.uint16), cycles, reps, 
                r => Duration.Define(math.mulT(lhs,rhs,dst)));                            

        public static BenchSummary Mul(int cycles, int reps, int[] lhs, int[] rhs, int[] dst)        
            => micromark("direct", OpId.Define(OpKind.Mul, PrimalKind.int32), cycles, reps, 
                r => Duration.Define(math.mulT(lhs,rhs,dst)));                            

        public static BenchSummary Mul(int cycles, int reps, uint[] lhs, uint[] rhs, uint[] dst)        
            => micromark("direct", OpId.Define(OpKind.Mul, PrimalKind.uint32), cycles, reps, 
                r => Duration.Define(math.mulT(lhs,rhs,dst)));                            
        
        public static BenchSummary Mul(int cycles, int reps, long[] lhs, long[] rhs, long[] dst)
            => micromark("direct", OpId.Define(OpKind.Mul, PrimalKind.int64),  cycles, reps, 
                r => Duration.Define(math.mulT(lhs,rhs,dst)));                            

        public static BenchSummary Mul(int cycles, int reps, ulong[] lhs, ulong[] rhs, ulong[] dst)
            => micromark("direct", OpId.Define(OpKind.Mul, PrimalKind.uint64), cycles, reps, 
                r => Duration.Define(math.mulT(lhs,rhs,dst)));                            

        public static BenchSummary Mul(int cycles, int reps, float[] lhs, float[] rhs, float[] dst)
            => micromark("direct", OpId.Define(OpKind.Mul, PrimalKind.float32), cycles, reps, 
                r => Duration.Define(math.mulT(lhs,rhs,dst)));                            

        public static BenchSummary Mul(int cycles, int reps, double[] lhs, double[] rhs, double[] dst)
            => micromark("direct", OpId.Define(OpKind.Mul, PrimalKind.float64), cycles, reps, 
                r => Duration.Define(math.mulT(lhs,rhs,dst)));                            

        #endregion

        #region Div

        //! Div
        //! -------------------------------------------------------------------
        public static BenchSummary Div(int cycles, int reps, sbyte[] lhs, sbyte[] rhs, sbyte[] dst)        
            => micromark("direct",  OpId.Define(OpKind.Div,  PrimalKind.int8), cycles, reps, 
                r => Duration.Define(math.divT(lhs,rhs,dst)));                            

        public static BenchSummary Div(int cycles, int reps, byte[] lhs, byte[] rhs, byte[] dst)        
            => micromark("direct", OpId.Define(OpKind.Div,  PrimalKind.uint8), cycles, reps, 
                r => Duration.Define(math.divT(lhs,rhs,dst)));                            

        public static BenchSummary Div(int cycles, int reps, short[] lhs, short[] rhs, short[] dst)        
            => micromark("direct", OpId.Define(OpKind.Div,  PrimalKind.int16), cycles, reps, 
                r => Duration.Define(math.divT(lhs,rhs,dst)));                            

        public static BenchSummary Div(int cycles, int reps, ushort[] lhs, ushort[] rhs, ushort[] dst)        
            => micromark("direct", OpId.Define(OpKind.Div,  PrimalKind.uint16), cycles, reps, 
                r => Duration.Define(math.divT(lhs,rhs,dst)));                            

        public static BenchSummary Div(int cycles, int reps, int[] lhs, int[] rhs, int[] dst)        
            => micromark("direct", OpId.Define(OpKind.Div, PrimalKind.int32), cycles, reps, 
                r => Duration.Define(math.divT(lhs,rhs,dst)));                            

        public static BenchSummary Div(int cycles, int reps, uint[] lhs, uint[] rhs, uint[] dst)        
            => micromark("direct", OpId.Define(OpKind.Div, PrimalKind.uint32), cycles, reps, 
                r => Duration.Define(math.divT(lhs,rhs,dst)));                            
        
        public static BenchSummary Div(int cycles, int reps, long[] lhs, long[] rhs, long[] dst)
            => micromark("direct", OpId.Define(OpKind.Div, PrimalKind.int64),  cycles, reps, 
                r => Duration.Define(math.divT(lhs,rhs,dst)));                            

        public static BenchSummary Div(int cycles, int reps, ulong[] lhs, ulong[] rhs, ulong[] dst)
            => micromark("direct", OpId.Define(OpKind.Div, PrimalKind.uint64), cycles, reps, 
                r => Duration.Define(math.divT(lhs,rhs,dst)));                            

        public static BenchSummary Div(int cycles, int reps, float[] lhs, float[] rhs, float[] dst)
            => micromark("direct", OpId.Define(OpKind.Div, PrimalKind.float32), cycles, reps, 
                r => Duration.Define(math.divT(lhs,rhs,dst)));                            

        public static BenchSummary Div(int cycles, int reps, double[] lhs, double[] rhs, double[] dst)
            => micromark("direct", OpId.Define(OpKind.Div, PrimalKind.float64), cycles, reps, 
                r => Duration.Define(math.divT(lhs,rhs,dst)));                            

        #endregion

        #region Mod

        //! Mod
        //! -------------------------------------------------------------------
        public static BenchSummary Mod(int cycles, int reps, sbyte[] lhs, sbyte[] rhs, sbyte[] dst)        
            => micromark("direct",  OpId.Define(OpKind.Mod,  PrimalKind.int8), cycles, reps, 
                r => Duration.Define(math.modT(lhs,rhs,dst)));                            

        public static BenchSummary Mod(int cycles, int reps, byte[] lhs, byte[] rhs, byte[] dst)        
            => micromark("direct", OpId.Define(OpKind.Mod,  PrimalKind.uint8), cycles, reps, 
                r => Duration.Define(math.modT(lhs,rhs,dst)));                            

        public static BenchSummary Mod(int cycles, int reps, short[] lhs, short[] rhs, short[] dst)        
            => micromark("direct", OpId.Define(OpKind.Mod,  PrimalKind.int16), cycles, reps, 
                r => Duration.Define(math.modT(lhs,rhs,dst)));                            

        public static BenchSummary Mod(int cycles, int reps, ushort[] lhs, ushort[] rhs, ushort[] dst)        
            => micromark("direct", OpId.Define(OpKind.Mod,  PrimalKind.uint16), cycles, reps, 
                r => Duration.Define(math.modT(lhs,rhs,dst)));                            

        public static BenchSummary Mod(int cycles, int reps, int[] lhs, int[] rhs, int[] dst)        
            => micromark("direct", OpId.Define(OpKind.Mod, PrimalKind.int32), cycles, reps, 
                r => Duration.Define(math.modT(lhs,rhs,dst)));                            

        public static BenchSummary Mod(int cycles, int reps, uint[] lhs, uint[] rhs, uint[] dst)        
            => micromark("direct", OpId.Define(OpKind.Mod, PrimalKind.uint32), cycles, reps, 
                r => Duration.Define(math.modT(lhs,rhs,dst)));                            
        
        public static BenchSummary Mod(int cycles, int reps, long[] lhs, long[] rhs, long[] dst)
            => micromark("direct", OpId.Define(OpKind.Mod, PrimalKind.int64),  cycles, reps, 
                r => Duration.Define(math.modT(lhs,rhs,dst)));                            

        public static BenchSummary Mod(int cycles, int reps, ulong[] lhs, ulong[] rhs, ulong[] dst)
            => micromark("direct", OpId.Define(OpKind.Mod, PrimalKind.uint64), cycles, reps, 
                r => Duration.Define(math.modT(lhs,rhs,dst)));                            

        public static BenchSummary Mod(int cycles, int reps, float[] lhs, float[] rhs, float[] dst)
            => micromark("direct", OpId.Define(OpKind.Mod, PrimalKind.float32), cycles, reps, 
                r => Duration.Define(math.modT(lhs,rhs,dst)));                            

        public static BenchSummary Mod(int cycles, int reps, double[] lhs, double[] rhs, double[] dst)
            => micromark("direct", OpId.Define(OpKind.Mod, PrimalKind.float64), cycles, reps, 
                r => Duration.Define(math.modT(lhs,rhs,dst)));                            

        #endregion

    }

}