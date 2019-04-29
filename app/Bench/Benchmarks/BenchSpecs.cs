//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zcore;
    using static primops;
    using Tests;
    using P = Z0.Paths;
    using Specs = System.Collections.Generic.IEnumerable<BenchSpec>;

    public class BenchSpecs
    {
        public static Specs Choose(OpKind opkind, OpSet? set = null, params PrimalKind[] primkinds)
        {
            return opkind switch {
                OpKind.Eq => Eq(set,primkinds),                
                OpKind.Add => Add(set,primkinds),                
                OpKind.Sub => Sub(set,primkinds),                
                OpKind.Gt => Gt(set,primkinds),                
                OpKind.And => And(set,primkinds),
                OpKind.Or => Or(set,primkinds),
                OpKind.XOr => XOr(set,primkinds),
                OpKind.Abs => Abs(set,primkinds),
                OpKind.Sum => Sum(set,primkinds),
                _ => new BenchSpec[]{}
            };

        }

        public static Specs Choose(IEnumerable<OpKind> opkinds, IEnumerable<OpSet> opsets, IEnumerable<PrimalKind> primkinds)
        {
            foreach(var opkind in opkinds)
            foreach(var opset in opsets)
            foreach(var spec in Choose(opkind,opset,primkinds.ToArray()))
                yield return spec;
        }

        static bool RunAtomicInX = false;

        delegate Specs OpPicker<T>(OpSet? set);

        delegate Specs OpPicker(OpSet? set);

        static Specs Pick<T>(OpPicker<T> picker, OpSet? set = null, params PrimalKind[] kinds)
        {
            if(kinds.Length == 0 || kinds.Contains(PrimalKinds.kind<T>()))
                foreach(var f in picker(set))
                    yield return f;            
        }

        static Specs Pick<X0,X1>(OpPicker<X0> p0, OpPicker<X1> p1, OpSet? set = null, params PrimalKind[] kinds)
        {
            if(kinds.Length == 0 || kinds.Contains(PrimalKinds.kind<X0>()))
                foreach(var f in p0(set))
                    yield return f;            

            if(kinds.Length == 0 || kinds.Contains(PrimalKinds.kind<X1>()))
                foreach(var f in p1(set))
                    yield return f;            
        }

        static Specs Pick<T>(OpPicker<T> picker, OpSet? set)
            where T : struct, IEquatable<T>
                => picker(set);        

        static bool all(OpSet? set)
            => set == null || set == OpSet.All;

        static bool allOrOneOf(OpSet? set, params OpSet[] others)
            => all(set) || (set != null && others.Contains(set.Value));

        public static Specs Eq(OpSet? set = null, params PrimalKind[] kinds)
        {
            OpPicker<T> picker<T>()
                where T : struct, IEquatable<T>            
                => Eq<T>;

            foreach(var f in Pick(picker<sbyte>(), picker<byte>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<short>(), picker<ushort>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<int>(), picker<uint>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<long>(), picker<ulong>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<float>(), picker<double>(),set,kinds))
                yield return f;
        }

        public static Specs Eq<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.eq<T>().Measure(P.primops + P.eq + P.fused);
        }

        public static Specs Gt(OpSet? set = null, params PrimalKind[] kinds)
        {
            OpPicker<T> picker<T>()
                where T : struct, IEquatable<T>            
                => Gt<T>;

            foreach(var f in Pick(picker<sbyte>(), picker<byte>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<short>(), picker<ushort>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<int>(), picker<uint>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<long>(), picker<ulong>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<float>(), picker<double>(),set,kinds))
                yield return f;
        }
        
        public static Specs Gt<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.gt<T>().Measure(P.primops + P.gt + P.fused);
        }

        public static Specs Add(OpSet? set = null, params PrimalKind[] kinds)
        {
            OpPicker<T> picker<T>()
                where T : struct, IEquatable<T>            
                => Add<T>;

            foreach(var f in Pick(picker<sbyte>(), picker<byte>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<short>(), picker<ushort>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<int>(), picker<uint>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<long>(), picker<ulong>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<float>(), picker<double>(),set,kinds))
                yield return f;
        }

        public static Specs Add<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.add<T>().Measure(P.primops + P.add + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.add<T>().Measure(P.primops + P.add + P.fused);
            
            if(RunAtomicInX && allOrOneOf(set, OpSet.Atomic, OpSet.Intrisic))
                yield return InXVec128Ops.add<T>().Measure(P.intrinsics + P.add + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.add<T>().Measure(P.intrinsics + P.add + P.fused);
        }

        public static Specs Sub(OpSet? set = null, params PrimalKind[] kinds)
        {
            OpPicker<T> picker<T>()
                where T : struct, IEquatable<T>            
                => Sub<T>;

            foreach(var f in Pick(picker<sbyte>(), picker<byte>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<short>(), picker<ushort>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<int>(), picker<uint>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<long>(), picker<ulong>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<float>(), picker<double>(),set,kinds))
                yield return f;
        }

        public static Specs Sub<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {

            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.sub<T>().Measure(P.primops + P.sub + P.atomic);

            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.sub<T>().Measure(P.primops + P.sub + P.fused);
            
            if(RunAtomicInX && allOrOneOf(set, OpSet.Atomic, OpSet.Intrisic))
                yield return InXVec128Ops.sub<T>().Measure(P.intrinsics + P.sub + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.sub<T>().Measure(P.intrinsics + P.sub + P.fused);
        }
  
         public static Specs Mul<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.mul<T>().Measure(P.primops + P.mul + P.atomic);
            
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalFusion.mul<T>().Measure(P.primops + P.mul + P.fused);            
        }

  
        public static Specs And(OpSet? set = null, params PrimalKind[] kinds)
        {
            OpPicker<T> picker<T>()
                where T : struct, IEquatable<T>            
                => And<T>;
            
            foreach(var f in Pick(picker<sbyte>(), picker<byte>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<short>(), picker<ushort>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<int>(), picker<uint>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<long>(), picker<ulong>(),set,kinds))
                yield return f;

        }

        public static Specs And<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.and<T>().Measure(P.primops + P.and + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.and<T>().Measure(P.primops + P.and + P.fused);
            
            if(RunAtomicInX && allOrOneOf(set, OpSet.Atomic, OpSet.Intrisic))
                yield return InXVec128Ops.and<T>().Measure(P.intrinsics + P.and + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.and<T>().Measure(P.intrinsics + P.and + P.fused);
        }

        public static Specs Or(OpSet? set = null, params PrimalKind[] kinds)
        {
            OpPicker<T> picker<T>()
                where T : struct, IEquatable<T>            
                => Or<T>;

            foreach(var f in Pick(picker<sbyte>(), picker<byte>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<short>(), picker<ushort>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<int>(), picker<uint>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<long>(), picker<ulong>(),set,kinds))
                yield return f;
        }

        public static Specs Or<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.or<T>().Measure(P.primops + P.or + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.or<T>().Measure(P.primops + P.or + P.fused);
            
            if(RunAtomicInX && allOrOneOf(set, OpSet.Atomic, OpSet.Intrisic))
                yield return InXVec128Ops.or<T>().Measure(P.intrinsics + P.or + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.or<T>().Measure(P.intrinsics + P.or + P.fused);
        }

        public static Specs XOr(OpSet? set = null, params PrimalKind[] kinds)
        {
            OpPicker<T> picker<T>()
                where T : struct, IEquatable<T>            
                => XOr<T>;

            foreach(var f in Pick(picker<sbyte>(), picker<byte>(),set, kinds))
                yield return f;

            foreach(var f in Pick(picker<short>(), picker<ushort>(),set, kinds))
                yield return f;

            foreach(var f in Pick(picker<int>(), picker<uint>(),set, kinds))
                yield return f;

            foreach(var f in Pick(picker<long>(), picker<ulong>(),set, kinds))
                yield return f;
        }


       public static Specs XOr<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.xor<T>().Measure(P.primops + P.xor + P.atomic);
            
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalFusion.xor<T>().Measure(P.primops + P.xor + P.fused);
            
            if(RunAtomicInX && allOrOneOf(set, OpSet.Atomic, OpSet.Intrisic))
                yield return InXVec128Ops.xor<T>().Measure(P.intrinsics + P.xor + P.atomic);

            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.xor<T>().Measure(P.intrinsics + P.xor + P.fused);
        }

        public static Specs Abs(OpSet? set = null, params PrimalKind[] kinds)  
        {      
            OpPicker<T> picker<T>()
                where T : struct, IEquatable<T>            
                => Abs<T>;

            foreach(var f in Pick(picker<sbyte>(), picker<short>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<int>(), picker<long>(),set,kinds))
                yield return f;

            foreach(var f in Pick(picker<float>(), picker<double>(),set,kinds))
                yield return f;
        }

        public static Specs Abs<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.abs<T>().Measure(P.primops + P.abs + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.abs<T>().Measure(P.primops + P.abs + P.fused);
        }

        public static Specs Sum(OpSet? set = null, params PrimalKind[] kinds)        
        {      

            OpPicker<T> picker<T>()
                where T : struct, IEquatable<T>            
                => Sum<T>;

            foreach(var f in Pick(picker<short>(), picker<int>(),set,kinds))
                yield return f;
        
            foreach(var f in Pick(picker<float>(), picker<double>(),set,kinds))
                yield return f;
        }

         public static Specs Sum<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.sum<T>().Measure(P.intrinsics + P.sum + P.fused);
        }
    }
}