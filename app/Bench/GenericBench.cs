//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zcore;
    using static OpInfo;
    using static PrimalInfo;

    public delegate BenchComparison BenchComparer(OpKind op, PrimalKind prim);
    
    public delegate BenchComparison BenchComparer<O,P>(O op, P prim);

    
    
    public class GenericBench : Context<App>        
    {
        public static GenericBench Init(BenchConfig config = null)
            => new GenericBench(config ?? BenchConfig.Default);


        IReadOnlyDictionary<(Type,Type),Delegate> Runners {get;  set;}

        void IndexRunners()
        {
            var methods = GetType().DeclaredMethods()
                                  .WithName(nameof(Run))
                                  .NonPublic()
                                  .Instance()
                                  .Concrete()
                                  .WithParameterCount(2)
                                  .Returns<BenchComparison>();

            var gTypeDef = typeof(BenchComparer<,>).GetGenericTypeDefinition();
            var runners = from m in methods
                             let opRepType = m.GetParameters().First().ParameterType
                             let primRepType = m.GetParameters().Second().ParameterType
                             let typeDef = gTypeDef.MakeGenericType(opRepType, primRepType)
                             let key = (opRepType, primRepType)
                             let value = Delegate.CreateDelegate(typeDef,this,m)
                             select (key, value);

            Runners = runners.ToDictionary();

        }

        GenericBench(BenchConfig Config)
         : base(RandSeeds.BenchSeed)
        {
            gmath.init();
            this.Config = Config;
            IndexRunners();
        }

        public BenchConfig Config {get;}

        BenchSummary benchmark<T>(OpKind op, T[] lhs, T[] rhs, T[] dst, Repeat repeater)
            where T : struct, IEquatable<T>        
                => micromark("gmath", OpId.Define<T>(op), Config.Cycles, Config.Reps, repeater);                

        public BenchComparison Run<K,P>(K opRep, P primalRep)
            where K : OpInfo<K>, new()
            where P : PrimalInfo<P>, new()
        {
            var key = (type<K>(),type<P>());
            if(Runners.ContainsKey(key))
            {
                var runner = (BenchComparer<K,P>)Runners[key];
                return runner.Invoke(opRep,primalRep);                
            }

            throw new NotSupportedException($"Lookup for operation ({opRep},{primalRep}) failed");

        }

        T[] Sample<T>(bool nonzero = false)
            where T : struct, IEquatable<T>        
                => nonzero 
                 ? RandomArray<T>(Config.Reps,x => gmath.neq(x,gmath.zero<T>())) 
                 : RandomArray<T>(Config.Reps);
        
        T[] Target<T>()
            where T : struct, IEquatable<T>        
                => alloc<T>(Config.Reps);

         (T[] lhs, T[] rhs, T[] dDst, T[] gDst) SetupBinOp<T>(bool nonzero = false)
            where T : struct, IEquatable<T>        
            => (Sample<T>(nonzero), Sample<T>(nonzero), Target<T>(), Target<T>());
        
        bool IsSelected(PrimalKind primitive)
            => Config.Primitives.Contains(primitive);

        #region Add

        BenchSummary Add<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Add, lhs,rhs,dst, r => Duration.define(gmath.addT(lhs,rhs,dst))); 

        BenchSummary AddF<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Add, lhs,rhs,dst, r => Duration.define(gfloat.addT(lhs,rhs,dst))); 

        public IEnumerable<BenchComparison> Compare(Add rep)
        {
            if(IsSelected(PrimalKind.int8))
                yield return Run(rep, PrimalInfo.I8Rep);
            
            if(IsSelected(PrimalKind.uint8))
                yield return Run(rep, PrimalInfo.U8Rep);

            if(IsSelected(PrimalKind.int16))
                yield return Run(rep, PrimalInfo.I16Rep);
            
            if(IsSelected(PrimalKind.uint16))
                yield return Run(rep, PrimalInfo.U16Rep);

            if(IsSelected(PrimalKind.int32))
                yield return Run(rep, PrimalInfo.I32Rep);
            
            if(IsSelected(PrimalKind.uint32))
                yield return Run(rep, PrimalInfo.U32Rep);
            
            if(IsSelected(PrimalKind.int64))
                yield return Run(rep, PrimalInfo.I64Rep);
            
            if(IsSelected(PrimalKind.uint64))
                yield return Run(rep, PrimalInfo.U64Rep);
            
            if(IsSelected(PrimalKind.float32))
                yield return Run(rep, PrimalInfo.F32Rep);

            if(IsSelected(PrimalKind.float64))
                yield return Run(rep, PrimalInfo.F64Rep);

        }

        BenchComparison Run(Add op, I8 prim)
        {
            var setup = SetupBinOp<sbyte>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Add op, U8 prim)
        {
            var setup = SetupBinOp<byte>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Add op, I16 prim)
        {
            var setup = SetupBinOp<short>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Add op, U16 prim)
        {
            var setup = SetupBinOp<ushort>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Add op, I32 prim)
        {
            var setup = SetupBinOp<int>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Add op, U32 prim)
        {
            var setup = SetupBinOp<uint>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Add op, I64 prim)
        {
            var setup = SetupBinOp<long>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Add op, U64 prim)
        {
            var setup = SetupBinOp<ulong>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Add(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Add op, F32 prim)
        {
            var setup = SetupBinOp<float>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.AddF(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Add op, F64 prim)
        {
            var setup = SetupBinOp<double>();
            return BenchComparison.Define(
                DirectBench.Add(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.AddF(setup.lhs, setup.rhs, setup.gDst));
        }    

        #endregion

        #region Sub

        BenchSummary Sub<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Sub, lhs,rhs,dst, r => Duration.define(gmath.subT(lhs,rhs,dst))); 

        BenchSummary SubF<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Sub, lhs,rhs,dst, r => Duration.define(gfloat.subT(lhs,rhs,dst))); 

        public IEnumerable<BenchComparison> Compare(Sub rep)
        {
            if(IsSelected(PrimalKind.int8))
                yield return Run(rep, PrimalInfo.I8Rep);
            
            if(IsSelected(PrimalKind.uint8))
                yield return Run(rep, PrimalInfo.U8Rep);

            if(IsSelected(PrimalKind.int16))
                yield return Run(rep, PrimalInfo.I16Rep);
            
            if(IsSelected(PrimalKind.uint16))
                yield return Run(rep, PrimalInfo.U16Rep);

            if(IsSelected(PrimalKind.int32))
                yield return Run(rep, PrimalInfo.I32Rep);
            
            if(IsSelected(PrimalKind.uint32))
                yield return Run(rep, PrimalInfo.U32Rep);
            
            if(IsSelected(PrimalKind.int64))
                yield return Run(rep, PrimalInfo.I64Rep);
            
            if(IsSelected(PrimalKind.uint64))
                yield return Run(rep, PrimalInfo.U64Rep);
            
            if(IsSelected(PrimalKind.float32))
                yield return Run(rep, PrimalInfo.F32Rep);

            if(IsSelected(PrimalKind.float64))
                yield return Run(rep, PrimalInfo.F64Rep);
            
        }


        BenchComparison Run(Sub op, I8 prim)
        {
            var setup = SetupBinOp<sbyte>();
            return BenchComparison.Define(
                DirectBench.Sub(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Sub(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Sub op, U8 prim)
        {
            var setup = SetupBinOp<byte>();
            return BenchComparison.Define(
                DirectBench.Sub(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Sub(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Sub op, I16 prim)
        {
            var setup = SetupBinOp<short>();
            return BenchComparison.Define(
                DirectBench.Sub(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Sub(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Sub op, U16 prim)
        {
            var setup = SetupBinOp<ushort>();
            return BenchComparison.Define(
                DirectBench.Sub(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Sub(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Sub op, I32 prim)
        {
            var setup = SetupBinOp<int>();
            return BenchComparison.Define(
                DirectBench.Sub(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Sub(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Sub op, U32 prim)
        {
            var setup = SetupBinOp<uint>();
            return BenchComparison.Define(
                DirectBench.Sub(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Sub(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Sub op, I64 prim)
        {
            var setup = SetupBinOp<long>();
            return BenchComparison.Define(
                DirectBench.Sub(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Sub(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Sub op, U64 prim)
        {
            var setup = SetupBinOp<ulong>();
            return BenchComparison.Define(
                DirectBench.Sub(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Sub(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Sub op, F32 prim)
        {
            var setup = SetupBinOp<float>();
            return BenchComparison.Define(
                DirectBench.Sub(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.SubF(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Sub op, F64 prim)
        {
            var setup = SetupBinOp<double>();
            return BenchComparison.Define(
                DirectBench.Sub(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.SubF(setup.lhs, setup.rhs, setup.gDst));
        }    

        #endregion


        #region Mul

        BenchSummary Mul<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Mul, lhs, rhs, dst, r => Duration.define(gmath.mulT(lhs,rhs,dst))); 

        BenchSummary MulF<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Mul, lhs, rhs, dst, r => Duration.define(gfloat.mulT(lhs,rhs,dst))); 


        public IEnumerable<BenchComparison> Compare(Mul rep)
        {
            if(IsSelected(PrimalKind.int8))
                yield return Run(rep, PrimalInfo.I8Rep);
            
            if(IsSelected(PrimalKind.uint8))
                yield return Run(rep, PrimalInfo.U8Rep);

            if(IsSelected(PrimalKind.int16))
                yield return Run(rep, PrimalInfo.I16Rep);
            
            if(IsSelected(PrimalKind.uint16))
                yield return Run(rep, PrimalInfo.U16Rep);

            if(IsSelected(PrimalKind.int32))
                yield return Run(rep, PrimalInfo.I32Rep);
            
            if(IsSelected(PrimalKind.uint32))
                yield return Run(rep, PrimalInfo.U32Rep);
            
            if(IsSelected(PrimalKind.int64))
                yield return Run(rep, PrimalInfo.I64Rep);
            
            if(IsSelected(PrimalKind.uint64))
                yield return Run(rep, PrimalInfo.U64Rep);
            
            if(IsSelected(PrimalKind.float32))
                yield return Run(rep, PrimalInfo.F32Rep);

            if(IsSelected(PrimalKind.float64))
                yield return Run(rep, PrimalInfo.F64Rep);

        }

        BenchComparison Run(Mul op, I8 prim)
        {
            var setup = SetupBinOp<sbyte>();
            return BenchComparison.Define(
                DirectBench.Mul(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mul(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mul op, U8 prim)
        {
            var setup = SetupBinOp<byte>();
            return BenchComparison.Define(
                DirectBench.Mul(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mul(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mul op, I16 prim)
        {
            var setup = SetupBinOp<short>();
            return BenchComparison.Define(
                DirectBench.Mul(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mul(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mul op, U16 prim)
        {
            var setup = SetupBinOp<ushort>();
            return BenchComparison.Define(
                DirectBench.Mul(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mul(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mul op, I32 prim)
        {
            var setup = SetupBinOp<int>();
            return BenchComparison.Define(
                DirectBench.Mul(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mul(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mul op, U32 prim)
        {
            var setup = SetupBinOp<uint>();
            return BenchComparison.Define(
                DirectBench.Mul(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mul(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mul op, I64 prim)
        {
            var setup = SetupBinOp<long>();
            return BenchComparison.Define(
                DirectBench.Mul(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mul(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mul op, U64 prim)
        {
            var setup = SetupBinOp<ulong>();
            return BenchComparison.Define(
                DirectBench.Mul(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mul(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mul op, F32 prim)
        {
            var setup = SetupBinOp<float>();
            return BenchComparison.Define(
                DirectBench.Mul(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.MulF(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mul op, F64 prim)
        {
            var setup = SetupBinOp<double>();
            return BenchComparison.Define(
                DirectBench.Mul(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.MulF(setup.lhs, setup.rhs, setup.gDst));
        }    

        #endregion


        #region Div

        public IEnumerable<BenchComparison> Compare(Div rep)
        {
            if(IsSelected(PrimalKind.int8))
                yield return Run(rep, PrimalInfo.I8Rep);
            
            if(IsSelected(PrimalKind.uint8))
                yield return Run(rep, PrimalInfo.U8Rep);

            if(IsSelected(PrimalKind.int16))
                yield return Run(rep, PrimalInfo.I16Rep);
            
            if(IsSelected(PrimalKind.uint16))
                yield return Run(rep, PrimalInfo.U16Rep);

            if(IsSelected(PrimalKind.int32))
                yield return Run(rep, PrimalInfo.I32Rep);
            
            if(IsSelected(PrimalKind.uint32))
                yield return Run(rep, PrimalInfo.U32Rep);
            
            if(IsSelected(PrimalKind.int64))
                yield return Run(rep, PrimalInfo.I64Rep);
            
            if(IsSelected(PrimalKind.uint64))
                yield return Run(rep, PrimalInfo.U64Rep);
            
            if(IsSelected(PrimalKind.float32))
                yield return Run(rep, PrimalInfo.F32Rep);

            if(IsSelected(PrimalKind.float64))
                yield return Run(rep, PrimalInfo.F64Rep);

        }

        BenchSummary Div<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Div, lhs, rhs, dst, r => Duration.define(gmath.divT(lhs,rhs,dst))); 

        BenchSummary DivF<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Div, lhs, rhs, dst, r => Duration.define(gfloat.divT(lhs,rhs,dst))); 

        BenchComparison Run(Div op, I8 prim)
        {
            var setup = SetupBinOp<sbyte>(true);
            return BenchComparison.Define(
                DirectBench.Div(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Div(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Div op, U8 prim)
        {
            var setup = SetupBinOp<byte>(true);
            return BenchComparison.Define(
                DirectBench.Div(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Div(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Div op, I16 prim)
        {
            var setup = SetupBinOp<short>(true);
            return BenchComparison.Define(
                DirectBench.Div(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Div(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Div op, U16 prim)
        {
            var setup = SetupBinOp<ushort>(true);
            return BenchComparison.Define(
                DirectBench.Div(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Div(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Div op, I32 prim)
        {
            var setup = SetupBinOp<int>(true);
            return BenchComparison.Define(
                DirectBench.Div(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Div(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Div op, U32 prim)
        {
            var setup = SetupBinOp<uint>(true);
            return BenchComparison.Define(
                DirectBench.Div(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Div(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Div op, I64 prim)
        {
            var setup = SetupBinOp<long>(true);
            return BenchComparison.Define(
                DirectBench.Div(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Div(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Div op, U64 prim)
        {
            var setup = SetupBinOp<ulong>(true);
            return BenchComparison.Define(
                DirectBench.Div(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Div(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Div op, F32 prim)
        {
            var setup = SetupBinOp<float>(true);
            return BenchComparison.Define(
                DirectBench.Div(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.DivF(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Div op, F64 prim)
        {
            var setup = SetupBinOp<double>(true);
            return BenchComparison.Define(
                DirectBench.Div(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.DivF(setup.lhs, setup.rhs, setup.gDst));
        }    

        #endregion


        #region Mod

        BenchSummary Mod<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Mod, lhs, rhs, dst, r => Duration.define(gmath.modT(lhs,rhs,dst))); 

        BenchSummary ModF<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Mod, lhs, rhs, dst, r => Duration.define(gfloat.modT(lhs,rhs,dst))); 


        public IEnumerable<BenchComparison> Compare(Mod rep)
        {
            if(IsSelected(PrimalKind.int8))
                yield return Run(rep, PrimalInfo.I8Rep);
            
            if(IsSelected(PrimalKind.uint8))
                yield return Run(rep, PrimalInfo.U8Rep);

            if(IsSelected(PrimalKind.int16))
                yield return Run(rep, PrimalInfo.I16Rep);
            
            if(IsSelected(PrimalKind.uint16))
                yield return Run(rep, PrimalInfo.U16Rep);

            if(IsSelected(PrimalKind.int32))
                yield return Run(rep, PrimalInfo.I32Rep);
            
            if(IsSelected(PrimalKind.uint32))
                yield return Run(rep, PrimalInfo.U32Rep);
            
            if(IsSelected(PrimalKind.int64))
                yield return Run(rep, PrimalInfo.I64Rep);
            
            if(IsSelected(PrimalKind.uint64))
                yield return Run(rep, PrimalInfo.U64Rep);
            
            if(IsSelected(PrimalKind.float32))
                yield return Run(rep, PrimalInfo.F32Rep);

            if(IsSelected(PrimalKind.float64))
                yield return Run(rep, PrimalInfo.F64Rep);

        }

        BenchComparison Run(Mod op, I8 prim)
        {
            var setup = SetupBinOp<sbyte>(true);
            return BenchComparison.Define(
                DirectBench.Mod(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mod(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mod op, U8 prim)
        {
            var setup = SetupBinOp<byte>(true);
            return BenchComparison.Define(
                DirectBench.Mod(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mod(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mod op, I16 prim)
        {
            var setup = SetupBinOp<short>(true);
            return BenchComparison.Define(
                DirectBench.Mod(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mod(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mod op, U16 prim)
        {
            var setup = SetupBinOp<ushort>(true);
            return BenchComparison.Define(
                DirectBench.Mod(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mod(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mod op, I32 prim)
        {
            var setup = SetupBinOp<int>(true);
            return BenchComparison.Define(
                DirectBench.Mod(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mod(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mod op, U32 prim)
        {
            var setup = SetupBinOp<uint>(true);
            return BenchComparison.Define(
                DirectBench.Mod(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mod(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mod op, I64 prim)
        {
            var setup = SetupBinOp<long>(true);
            return BenchComparison.Define(
                DirectBench.Mod(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mod(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mod op, U64 prim)
        {
            var setup = SetupBinOp<ulong>(true);
            return BenchComparison.Define(
                DirectBench.Mod(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.Mod(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mod op, F32 prim)
        {
            var setup = SetupBinOp<float>(true);
            return BenchComparison.Define(
                DirectBench.Mod(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.ModF(setup.lhs, setup.rhs, setup.gDst));
        }

        BenchComparison Run(Mod op, F64 prim)
        {
            var setup = SetupBinOp<double>(true);
            return BenchComparison.Define(
                DirectBench.Mod(Config.Cycles, Config.Reps, setup.lhs, setup.rhs, setup.dDst), 
                this.ModF(setup.lhs, setup.rhs, setup.gDst));
        }    

        #endregion

    }
}