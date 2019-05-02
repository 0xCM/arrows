//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zcore;
    using static OpInfo;
    using static PrimalInfo;

    public delegate BenchComparison BenchComparer(OpKind op, PrimalKind prim);
    
    public delegate BenchComparison BenchComparer<O,P>(O op, P prim);

    public class PrimalBench : BenchContext
    {
        public static readonly BenchConfig DefaultConfig  = new BenchConfig(1400,Pow2.T18,Pow2.T18);

        public static PrimalBench Create(BenchConfig config, IRandomizer random)
            => new PrimalBench(config, random);


        IReadOnlyDictionary<(Type,Type),Delegate> Runners {get;  set;}


        public void Run()
        {
            var comparisons = InnerSuite().ToList();
            iter(comparisons, print);

        }

        IEnumerable<BenchComparison> InnerSuite()
        {                        

            if(Continue(OpKind.Add))
                foreach(var result in Run(OpInfo.AddRep))
                    yield return result;

            if(Continue(OpKind.Sub))
                foreach(var result in Run(OpInfo.SubRep))
                    yield return result;

            if(Continue(OpKind.Mul))
                foreach(var result in Run(OpInfo.MulRep))
                    yield return result;

            if(Continue(OpKind.Div))
                foreach(var result in Run(OpInfo.DivRep))
                    yield return result;

            if(Continue(OpKind.Mod))
                foreach(var result in Run(OpInfo.ModRep))
                    yield return result;

        }

        void IndexRunners()
        {
            var methods = GetType().GetMethods().Where(
                    m => m.Name == nameof(Run) 
                    && !m.IsPublic && !m.IsStatic && !m.IsAbstract 
                    && m.GetParameters().Length == 2 
                    && m.ReturnType == typeof(BenchComparison)
                    );

            var gTypeDef = typeof(BenchComparer<,>).GetGenericTypeDefinition();
            var runners = from m in methods
                             let opRepType = m.GetParameters().First().ParameterType
                             let primRepType = m.GetParameters().Skip(1).First().ParameterType
                             let typeDef = gTypeDef.MakeGenericType(opRepType, primRepType)
                             let key = (opRepType, primRepType)
                             let value = Delegate.CreateDelegate(typeDef,this,m)
                             select (key, value);

            Runners = runners.ToDictionary();

        }

        PrimalBench(BenchConfig Config, IRandomizer random)
         : base(Config,random)
        {
            gmath.init();
            IndexRunners();
        }

        BenchSummary benchmark<T>(OpKind op, BinOpData<T> data, Repeat repeater)
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
        
        BinOpData<T> BinOpData<T>(bool nonzero = false)
            where T : struct, IEquatable<T>        
            => Z0.BinOpData.Configure<T>(Config, Randomizer,nonzero);


        bool Continue(PrimalKind primitive)
        {
             GC.Collect();
             return Config.Primitives.Contains(primitive);
        }

        bool Continue(OpKind op)
        {
             GC.Collect();
            return Config.Operators.Contains(op);
        }

        BenchComparison BenchCompare(OpKind op, PrimalKind prim, Duration dTotal, Duration gTotal)
        {
            var opid = OpId.Define(op,prim);
            var dSummary = new BenchSummary("dmath", opid, 0, dTotal, 0);
            var gSummary = new BenchSummary("gmath", opid, 0, gTotal, 0);
            return Compare(dSummary, gSummary);
        }

        BenchComparison Compare(BenchSummary direct, BenchSummary generic)
            => BenchComparison.Define(direct,generic);

        #region Add

        public IEnumerable<BenchComparison> Run(Add rep)
        {

            if(Continue(PrimalKind.int8))
                yield return Run(rep, PrimalInfo.I8Rep);
            
            if(Continue(PrimalKind.uint8))
                yield return Run(rep, PrimalInfo.U8Rep);

            if(Continue(PrimalKind.int16))
                yield return Run(rep, PrimalInfo.I16Rep);
            
            if(Continue(PrimalKind.uint16))
                yield return Run(rep, PrimalInfo.U16Rep);

            if(Continue(PrimalKind.int32))
                yield return Run(rep, PrimalInfo.I32Rep);
            
            if(Continue(PrimalKind.uint32))
                yield return Run(rep, PrimalInfo.U32Rep);
            
            if(Continue(PrimalKind.int64))
                yield return Run(rep, PrimalInfo.I64Rep);
            
            if(Continue(PrimalKind.uint64))
                yield return Run(rep, PrimalInfo.U64Rep);
            
            if(Continue(PrimalKind.float32))
                yield return Run(rep, PrimalInfo.F32Rep);

            if(Continue(PrimalKind.float64))
                yield return Run(rep, PrimalInfo.F64Rep);

        }

        BenchSummary Add<T>(BinOpData<T> data)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Add, data, r => Duration.Define(gmath.addT(data.LeftSource, data.RightSource, data.GenericTarget))); 

        BenchComparison Run(Add op, I8 prim)
        {
            var data = BinOpData<sbyte>();
            return Compare(
                PrimalDirect.Add(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Add(data));
        }

        BenchComparison Run(Add op, U8 prim)
        {
            var data = BinOpData<byte>();
            return Compare(
                PrimalDirect.Add(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Add(data));
        }

        BenchComparison Run(Add op, I16 prim)
        {
            var data = BinOpData<short>();
            return Compare(
                PrimalDirect.Add(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Add(data));
        }

        BenchComparison Run(Add op, U16 prim)
        {
            var data = BinOpData<ushort>();
            return Compare(
                PrimalDirect.Add(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Add(data));
        }

        BenchComparison Run(Add op, I32 prim)
        {
            var data = BinOpData<int>();
            return Compare(
                PrimalDirect.Add(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Add(data));
        }

        BenchComparison Run(Add op, U32 prim)
        {
            var data = BinOpData<uint>();
            return Compare(
                PrimalDirect.Add(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Add(data));
        }

        BenchComparison Run(Add op, I64 prim)
        {
            var data = BinOpData<long>();
            return Compare(
                PrimalDirect.Add(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Add(data));
        }

        BenchComparison Run(Add op, U64 prim)
        {
            var data = BinOpData<ulong>();
            return Compare(
                PrimalDirect.Add(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Add(data));
        }

        BenchComparison Run(Add op, F32 prim)
        {
            var data = BinOpData<float>();
            return Compare(
                PrimalDirect.Add(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Add(data));
        }


        BenchComparison Run(Add op, F64 prim)
        {
            var data = BinOpData<double>();
            return Compare(
                PrimalDirect.Add(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Add(data));
        }    

        #endregion

        #region Sub

        public IEnumerable<BenchComparison> Run(Sub rep)
        {

            if(Continue(PrimalKind.int8))
                yield return Run(rep, PrimalInfo.I8Rep);
            
            if(Continue(PrimalKind.uint8))
                yield return Run(rep, PrimalInfo.U8Rep);

            if(Continue(PrimalKind.int16))
                yield return Run(rep, PrimalInfo.I16Rep);
            
            if(Continue(PrimalKind.uint16))
                yield return Run(rep, PrimalInfo.U16Rep);

            if(Continue(PrimalKind.int32))
                yield return Run(rep, PrimalInfo.I32Rep);
            
            if(Continue(PrimalKind.uint32))
                yield return Run(rep, PrimalInfo.U32Rep);
            
            if(Continue(PrimalKind.int64))
                yield return Run(rep, PrimalInfo.I64Rep);
            
            if(Continue(PrimalKind.uint64))
                yield return Run(rep, PrimalInfo.U64Rep);
            
            if(Continue(PrimalKind.float32))
                yield return Run(rep, PrimalInfo.F32Rep);

            if(Continue(PrimalKind.float64))
                yield return Run(rep, PrimalInfo.F64Rep);            
        }

        BenchSummary Sub<T>(BinOpData<T> data)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Sub, data, r => Duration.Define(gmath.subT(data.LeftSource, data.RightSource, data.GenericTarget))); 


        BenchComparison Run(Sub op, I8 prim)
        {
            var data = BinOpData<sbyte>();
            return Compare(
                PrimalDirect.Sub(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Sub(data));
        }

        BenchComparison Run(Sub op, U8 prim)
        {
            var data = BinOpData<byte>();
            return Compare(
                PrimalDirect.Sub(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Sub(data));
        }

        BenchComparison Run(Sub op, I16 prim)
        {
            var data = BinOpData<short>();
            return Compare(
                PrimalDirect.Sub(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Sub(data));
        }

        BenchComparison Run(Sub op, U16 prim)
        {
            var data = BinOpData<ushort>();
            return Compare(
                PrimalDirect.Sub(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Sub(data));
        }

        BenchComparison Run(Sub op, I32 prim)
        {
            var data = BinOpData<int>();
            return Compare(
                PrimalDirect.Sub(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Sub(data));
        }

        BenchComparison Run(Sub op, U32 prim)
        {
            var data = BinOpData<uint>();
            return Compare(
                PrimalDirect.Sub(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Sub(data));
        }

        BenchComparison Run(Sub op, I64 prim)
        {
            var data = BinOpData<long>();
            return Compare(
                PrimalDirect.Sub(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Sub(data));
        }

        BenchComparison Run(Sub op, U64 prim)
        {
            var data = BinOpData<ulong>();
            return Compare(
                PrimalDirect.Sub(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Sub(data));
        }

        BenchComparison Run(Sub op, F32 prim)
        {
            var data = BinOpData<float>();
            return Compare(
                PrimalDirect.Sub(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Sub(data));
        }

        BenchComparison Run(Sub op, F64 prim)
        {
            var data = BinOpData<double>();
            return Compare(
                PrimalDirect.Sub(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Sub(data));
        }    

        #endregion

        #region Mul

        BenchSummary Mul<T>(BinOpData<T> data)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Mul, data, r => Duration.Define(gmath.mulT(data.LeftSource, data.RightSource, data.GenericTarget))); 

        BenchSummary MulF<T>(BinOpData<T> data)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Mul, data, r => Duration.Define(gfloat.mulT(data.LeftSource, data.RightSource, data.GenericTarget))); 


        public IEnumerable<BenchComparison> Run(Mul rep)
        {

            if(Continue(PrimalKind.int8))
                yield return Run(rep, PrimalInfo.I8Rep);
            
            if(Continue(PrimalKind.uint8))
                yield return Run(rep, PrimalInfo.U8Rep);

            if(Continue(PrimalKind.int16))
                yield return Run(rep, PrimalInfo.I16Rep);
            
            if(Continue(PrimalKind.uint16))
                yield return Run(rep, PrimalInfo.U16Rep);

            if(Continue(PrimalKind.int32))
                yield return Run(rep, PrimalInfo.I32Rep);
            
            if(Continue(PrimalKind.uint32))
                yield return Run(rep, PrimalInfo.U32Rep);
            
            if(Continue(PrimalKind.int64))
                yield return Run(rep, PrimalInfo.I64Rep);
            
            if(Continue(PrimalKind.uint64))
                yield return Run(rep, PrimalInfo.U64Rep);
            
            if(Continue(PrimalKind.float32))
                yield return Run(rep, PrimalInfo.F32Rep);

            if(Continue(PrimalKind.float64))
                yield return Run(rep, PrimalInfo.F64Rep);

        }

        BenchComparison Run(Mul op, I8 prim)
        {
            var data = BinOpData<sbyte>();
            return Compare(
                PrimalDirect.Mul(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Mul(data));
        }

        BenchComparison Run(Mul op, U8 prim)
        {
            var data = BinOpData<byte>();
            return Compare(
                PrimalDirect.Mul(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Mul(data));
        }

        BenchComparison Run(Mul op, I16 prim)
        {
            var data = BinOpData<short>();
            return Compare(
                PrimalDirect.Mul(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Mul(data));
        }

        BenchComparison Run(Mul op, U16 prim)
        {
            var data = BinOpData<ushort>();
            return Compare(
                PrimalDirect.Mul(Config.Cycles, Config.Reps, data.LeftSource, data.RightSource, data.DirectTarget), 
                this.Mul(data));
        }

        BenchComparison Run(Mul op, I32 prim)
        {
            var setup = BinOpData<int>();
            return Compare(
                PrimalDirect.Mul(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mul(setup));
        }

        BenchComparison Run(Mul op, U32 prim)
        {
            var setup = BinOpData<uint>();
            return Compare(
                PrimalDirect.Mul(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mul(setup));
        }

        BenchComparison Run(Mul op, I64 prim)
        {
            var setup = BinOpData<long>();
            return Compare(
                PrimalDirect.Mul(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mul(setup));
        }

        BenchComparison Run(Mul op, U64 prim)
        {
            var setup = BinOpData<ulong>();
            return Compare(
                PrimalDirect.Mul(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mul(setup));
        }

        BenchComparison Run(Mul op, F32 prim)
        {
            var setup = BinOpData<float>();
            return Compare(
                PrimalDirect.Mul(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.MulF(setup));
        }

        BenchComparison Run(Mul op, F64 prim)
        {
            var setup = BinOpData<double>();
            return Compare(
                PrimalDirect.Mul(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.MulF(setup));
        }    

        #endregion


        #region Div

        public IEnumerable<BenchComparison> Run(Div rep)
        {

            if(Continue(PrimalKind.int8))
                yield return Run(rep, PrimalInfo.I8Rep);


            if(Continue(PrimalKind.uint8))
                yield return Run(rep, PrimalInfo.U8Rep);

            if(Continue(PrimalKind.int16))
                yield return Run(rep, PrimalInfo.I16Rep);
            
            if(Continue(PrimalKind.uint16))
                yield return Run(rep, PrimalInfo.U16Rep);

            if(Continue(PrimalKind.int32))
                yield return Run(rep, PrimalInfo.I32Rep);
            
            if(Continue(PrimalKind.uint32))
                yield return Run(rep, PrimalInfo.U32Rep);
            
            if(Continue(PrimalKind.int64))
                yield return Run(rep, PrimalInfo.I64Rep);
            
            if(Continue(PrimalKind.uint64))
                yield return Run(rep, PrimalInfo.U64Rep);
            
            if(Continue(PrimalKind.float32))
                yield return Run(rep, PrimalInfo.F32Rep);

            if(Continue(PrimalKind.float64))
                yield return Run(rep, PrimalInfo.F64Rep);

        }

        BenchSummary Div<T>(BinOpData<T> data)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Div, data, r => Duration.Define(gmath.divT(data.LeftSource, data.RightSource, data.GenericTarget))); 

        BenchSummary DivF<T>(BinOpData<T> data)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Div, data, r => Duration.Define(gfloat.divT(data.LeftSource, data.RightSource, data.GenericTarget))); 

        BenchComparison Run(Div op, I8 prim)
        {
            var setup = BinOpData<sbyte>(true);
            return Compare(
                PrimalDirect.Div(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Div(setup));
        }

        BenchComparison Run(Div op, U8 prim)
        {
            var setup = BinOpData<byte>(true);
            return Compare(
                PrimalDirect.Div(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Div(setup));
        }

        BenchComparison Run(Div op, I16 prim)
        {
            var setup = BinOpData<short>(true);
            return Compare(
                PrimalDirect.Div(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Div(setup));
        }

        BenchComparison Run(Div op, U16 prim)
        {
            var setup = BinOpData<ushort>(true);
            return Compare(
                PrimalDirect.Div(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Div(setup));
        }

        BenchComparison Run(Div op, I32 prim)
        {
            var setup = BinOpData<int>(true);
            return Compare(
                PrimalDirect.Div(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Div(setup));
        }

        BenchComparison Run(Div op, U32 prim)
        {
            var setup = BinOpData<uint>(true);
            return Compare(
                PrimalDirect.Div(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Div(setup));
        }

        BenchComparison Run(Div op, I64 prim)
        {
            var setup = BinOpData<long>(true);
            return Compare(
                PrimalDirect.Div(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Div(setup));
        }

        BenchComparison Run(Div op, U64 prim)
        {
            var setup = BinOpData<ulong>(true);
            return Compare(
                PrimalDirect.Div(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Div(setup));
        }

        BenchComparison Run(Div op, F32 prim)
        {
            var setup = BinOpData<float>(true);
            return Compare(
                PrimalDirect.Div(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.DivF(setup));
        }

        BenchComparison Run(Div op, F64 prim)
        {
            var setup = BinOpData<double>(true);
            return Compare(
                PrimalDirect.Div(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.DivF(setup));
        }    

        #endregion


        #region Mod

        public IEnumerable<BenchComparison> Run(Mod rep)
        {

            if(Continue(PrimalKind.int8))
                yield return Run(rep, PrimalInfo.I8Rep);

            if(Continue(PrimalKind.uint8))
                yield return Run(rep, PrimalInfo.U8Rep);

            if(Continue(PrimalKind.int16))
                yield return Run(rep, PrimalInfo.I16Rep);

            if(Continue(PrimalKind.uint16))
                yield return Run(rep, PrimalInfo.U16Rep);

            if(Continue(PrimalKind.int32))
                yield return Run(rep, PrimalInfo.I32Rep);

            if(Continue(PrimalKind.uint32))
                yield return Run(rep, PrimalInfo.U32Rep);

            if(Continue(PrimalKind.int64))
                yield return Run(rep, PrimalInfo.I64Rep);
            
            if(Continue(PrimalKind.uint64))
                yield return Run(rep, PrimalInfo.U64Rep);
            
            if(Continue(PrimalKind.float32))
                yield return Run(rep, PrimalInfo.F32Rep);

            if(Continue(PrimalKind.float64))
                yield return Run(rep, PrimalInfo.F64Rep);

        }

        BenchSummary Mod<T>(BinOpData<T> data)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Mod, data, r => Duration.Define(gmath.modT(data.LeftSource, data.RightSource, data.GenericTarget))); 

        BenchSummary ModF<T>(BinOpData<T> data)
            where T : struct, IEquatable<T>        
                => benchmark(OpKind.Mod, data, r => Duration.Define(gfloat.modT(data.LeftSource, data.RightSource, data.GenericTarget))); 

        BenchComparison Run(Mod op, I8 prim)
        {
            var setup = BinOpData<sbyte>(true);
            return Compare(
                PrimalDirect.Mod(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mod(setup));
        }

        BenchComparison Run(Mod op, U8 prim)
        {
            var setup = BinOpData<byte>(true);
            return Compare(
                PrimalDirect.Mod(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mod(setup));
        }

        BenchComparison Run(Mod op, I16 prim)
        {
            var setup = BinOpData<short>(true);
            return Compare(
                PrimalDirect.Mod(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mod(setup));
        }

        BenchComparison Run(Mod op, U16 prim)
        {
            var setup = BinOpData<ushort>(true);
            return Compare(
                PrimalDirect.Mod(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mod(setup));
        }

        BenchComparison Run(Mod op, I32 prim)
        {
            var setup = BinOpData<int>(true);
            return Compare(
                PrimalDirect.Mod(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mod(setup));
        }

        BenchComparison Run(Mod op, U32 prim)
        {
            var setup = BinOpData<uint>(true);
            return Compare(
                PrimalDirect.Mod(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mod(setup));
        }

        BenchComparison Run(Mod op, I64 prim)
        {
            var setup = BinOpData<long>(true);
            return Compare(
                PrimalDirect.Mod(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mod(setup));
        }

        BenchComparison Run(Mod op, U64 prim)
        {
            var setup = BinOpData<ulong>(true);
            return Compare(
                PrimalDirect.Mod(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.Mod(setup));
        }

        BenchComparison Run(Mod op, F32 prim)
        {
            var setup = BinOpData<float>(true);
            return Compare(
                PrimalDirect.Mod(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.ModF(setup));
        }

        BenchComparison Run(Mod op, F64 prim)
        {
            var setup = BinOpData<double>(true);
            return Compare(
                PrimalDirect.Mod(Config.Cycles, Config.Reps, setup.LeftSource, setup.RightSource, setup.DirectTarget), 
                this.ModF(setup));
        }    

        #endregion



    }
}