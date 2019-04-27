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

    public enum OpSet
    {
        All,
        
        Primal, // PrimalAtomic & PrimalFused
        
        Intrisic,   // IntricFused & IntrinsicAtomic
        
        Fused,      //IntrinsicFused & PrimalFused

        Atomic    //IntrinsicAtomic & PrimalAtomic
        
    }

    public class BenchSpecs
    {
        public static Specs All(OpSet? set = null, params PrimKind[] kinds)
            => concat(Eq(set, kinds), Gt(set, kinds), Add(set, kinds), And(set, kinds),
                Or(set, kinds), XOr(set, kinds), Sum(set, kinds), Abs(set, kinds));

        public static Specs Eq(OpSet? set = null, params PrimKind[] kinds)
        {
            if(kinds.Length == 0 || kinds.Contains(PrimKind.int8))            
                foreach(var f in Eq<sbyte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint8))            
                foreach(var f in Eq<byte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int16))            
                foreach(var f in Eq<short>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint16))            
                foreach(var f in Eq<ushort>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int32))            
                foreach(var f in Eq<int>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint32))            
                foreach(var f in Eq<uint>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int64))            
                foreach(var f in Eq<long>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint64))            
                foreach(var f in Eq<ulong>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.float32))            
                foreach(var f in Eq<float>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.float64))            
                foreach(var f in Eq<double>(set))
                    yield return f;
        }

        public static Specs Gt(OpSet? set = null, params PrimKind[] kinds)
        {
            if(kinds.Length == 0 || kinds.Contains(PrimKind.int8))            
                foreach(var f in Gt<sbyte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint8))            
                foreach(var f in Gt<byte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int16))            
                foreach(var f in Gt<short>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint16))            
                foreach(var f in Gt<ushort>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int32))            
                foreach(var f in Gt<int>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint32))            
                foreach(var f in Gt<uint>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int64))            
                foreach(var f in Gt<long>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint64))            
                foreach(var f in Gt<ulong>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.float32))            
                foreach(var f in Gt<float>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.float64))            
                foreach(var f in Gt<double>(set))
                    yield return f;

        }


        public static Specs Add(OpSet? set = null, params PrimKind[] kinds)
        {
            if(kinds.Length == 0 || kinds.Contains(PrimKind.int8))            
                foreach(var f in Add<sbyte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint8))            
                foreach(var f in Add<byte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int16))            
                foreach(var f in Add<short>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint16))            
                foreach(var f in Add<ushort>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int32))            
                foreach(var f in Add<int>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint32))            
                foreach(var f in Add<uint>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int64))            
                foreach(var f in Add<long>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint64))            
                foreach(var f in Add<ulong>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.float32))            
                foreach(var f in Add<float>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.float64))            
                foreach(var f in Add<double>(set))
                    yield return f;

        }

        public static Specs And(OpSet? set = null, params PrimKind[] kinds)
        {
            if(kinds.Length == 0 || kinds.Contains(PrimKind.int8))            
                foreach(var f in And<sbyte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint8))            
                foreach(var f in And<byte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int16))            
                foreach(var f in And<short>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint16))            
                foreach(var f in And<ushort>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int32))            
                foreach(var f in And<int>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint32))            
                foreach(var f in And<uint>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int64))            
                foreach(var f in And<long>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint64))            
                foreach(var f in And<ulong>(set))
                    yield return f;
        }

        public static Specs Or(OpSet? set = null, params PrimKind[] kinds)
        {
            if(kinds.Length == 0 || kinds.Contains(PrimKind.int8))            
                foreach(var f in Or<sbyte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint8))            
                foreach(var f in Or<byte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int16))            
                foreach(var f in Or<short>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint16))            
                foreach(var f in Or<ushort>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int32))            
                foreach(var f in Or<int>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint32))            
                foreach(var f in Or<uint>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int64))            
                foreach(var f in Or<long>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint64))            
                foreach(var f in Or<ulong>(set))
                    yield return f;
        }

        public static Specs XOr(OpSet? set = null, params PrimKind[] kinds)
        {
            if(kinds.Length == 0 || kinds.Contains(PrimKind.int8))            
                foreach(var f in XOr<sbyte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint8))            
                foreach(var f in XOr<byte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int16))            
                foreach(var f in XOr<short>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint16))            
                foreach(var f in XOr<ushort>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int32))            
                foreach(var f in XOr<int>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint32))            
                foreach(var f in XOr<uint>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int64))            
                foreach(var f in XOr<long>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.uint64))            
                foreach(var f in XOr<ulong>(set))
                    yield return f;
        }

        public static Specs Sum(OpSet? set = null,params PrimKind[] kinds)        
        {      

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int16))            
                foreach(var f in Sum<short>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int32))            
                foreach(var f in Sum<int>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.float32))            
                foreach(var f in Sum<float>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.float64))            
                foreach(var f in Sum<double>(set))
                    yield return f;            
        }
        
        public static Specs Abs(OpSet? set = null, params PrimKind[] kinds)  
        {      
            if(kinds.Length == 0 || kinds.Contains(PrimKind.int8))            
                foreach(var f in Abs<sbyte>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int16))            
                foreach(var f in Abs<short>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int32))            
                foreach(var f in Abs<int>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.int64))            
                foreach(var f in Abs<long>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.float32))            
                foreach(var f in Abs<float>(set))
                    yield return f;

            if(kinds.Length == 0 || kinds.Contains(PrimKind.float64))            
                foreach(var f in Abs<double>(set))
                    yield return f;            
        }

        static bool all(OpSet? set)
            => set == null || set == OpSet.All;

        static bool allOrOneOf(OpSet? set, params OpSet[] others)
            => all(set) || (set != null && others.Contains(set.Value));

        public static Specs Eq<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.eq<T>().Measure(P.primops + P.eq + P.fused);

        }

        public static Specs Gt<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.gt<T>().Measure(P.primops + P.fused + P.gt);

        }

        public static Specs Add<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.add<T>().Measure(P.primops + P.add + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.add<T>().Measure(P.primops + P.add + P.fused);
            
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Intrisic))
                yield return InXVec128Ops.add<T>().Measure(P.intrinsics + P.add + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.add<T>().Measure(P.intrinsics + P.add + P.fused);
        }
            
        public static Specs And<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.and<T>().Measure(P.primops + P.and + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.and<T>().Measure(P.primops + P.and + P.fused);
            
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Intrisic))
                yield return InXVec128Ops.and<T>().Measure(P.intrinsics + P.and + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.and<T>().Measure(P.intrinsics + P.and + P.fused);
        }

        public static Specs Or<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.or<T>().Measure(P.primops + P.or + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.or<T>().Measure(P.primops + P.or + P.fused);
            
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Intrisic))
                yield return InXVec128Ops.or<T>().Measure(P.intrinsics + P.or + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.or<T>().Measure(P.intrinsics + P.or + P.fused);
        }

        public static Specs XOr<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.xor<T>().Measure(P.primops + P.xor + P.atomic);
            
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalFusion.xor<T>().Measure(P.primops + P.xor + P.fused);
            
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Intrisic))
                yield return InXVec128Ops.xor<T>().Measure(P.intrinsics + P.xor + P.atomic);

            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.xor<T>().Measure(P.intrinsics + P.xor + P.fused);

        }

        public static Specs Abs<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Atomic, OpSet.Primal))
                yield return PrimalOps.abs<T>().Measure(P.primops + P.abs + P.atomic);
            
            if(allOrOneOf(set, OpSet.Fused, OpSet.Primal))
                yield return PrimalFusion.abs<T>().Measure(P.primops + P.abs + P.fused);
        }

         public static Specs Sum<T>(OpSet? set = null)
            where T : struct, IEquatable<T>
        {
            if(allOrOneOf(set, OpSet.Fused, OpSet.Intrisic))
                yield return InXFusionOps.sum<T>().Measure(P.intrinsics + P.sum + P.fused);

        }
    }
}