//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Diagnostics;
    using System.Collections.Generic;

    using static zcore;
    using static zfunc;

    public unsafe delegate long TimedFusedUnaryOp<T>(Index<T> src, out Index<T> dst)
        where T : struct, IEquatable<T>;

    public unsafe delegate long TimedFusedBinOp<T>(Index<T> lhs, Index<T> rhs, out Index<T> dst)
        where T : struct, IEquatable<T>;

    public unsafe delegate long TimedAtomicBinOp<T>(T lhs, T rhs, out T dst)
        where T : struct, IEquatable<T>;

    public unsafe delegate long TimedAtomicUnaryOp<T>(T src, out T dst)
        where T : struct, IEquatable<T>;

    public unsafe delegate long TimedFusedPred<T>(Index<T> lhs, Index<T> rhs, out Index<bool> dst)
        where T : struct, IEquatable<T>;

    public unsafe delegate long TimedAtomicPred<T>(T lhs, T rhs, out bool dst)
        where T : struct, IEquatable<T>;

    public unsafe delegate long TimedAggOp<T>(Index<T> src, out T dst)
        where T : struct, IEquatable<T>;


    public class TimedOpConvert<T>
            where T : struct, IEquatable<T>
    {
        public long TimedOp(Index<T> lhs, Index<T> rhs, out Index<T> dst, Func<T,T,T> Op)
        {
            var target = new T[lhs.Length];
            var sw = stopwatch();
            for(var i = 0; i< lhs.Length; i++)
                target[i] = Op(lhs[i],rhs[i]);
            dst = target;
            return elapsed(sw);
        }

        public long TimedOp(Index<T> lhs, out T dst, PrimalAggOp<T> Op)
        {
            var sw = stopwatch();
            dst = Op(lhs);
            return elapsed(sw);
        }

        public long TimedOp(Index<T> src, out Index<T> dst, PrimalFusedUnaryOp<T> Op)
        {
            var sw = stopwatch();
            dst = Op(src);
            return elapsed(sw);
        }

        public long TimedOp(Index<T> src, out Index<T> dst, PrimalUnaryOp<T> Op)
        {
            var target = new T[src.Length];
            var sw = stopwatch();
            for(var i = 0; i< src.Length; i++)
                target[i] = Op(src[i]);
            dst = target;
            return elapsed(sw);
        }

        public long TimedOp(Index<T> lhs, Index<T> rhs, out Index<T> dst, PrimalBinOp<T> Op)
        {
            var target = new T[lhs.Length];
            var sw = stopwatch();
            for(var i = 0; i< lhs.Length; i++)
                target[i] = Op(lhs[i],rhs[i]);
            dst = target;
            return elapsed(sw);
        }

        public long TimedOp(Index<T> lhs, Index<T> rhs, out Index<bool> dst, PrimalBinPred<T> Op)
        {
            var target = new bool[lhs.Length];
            var sw = stopwatch();
            for(var i = 0; i< lhs.Length; i++)
                target[i] = Op(lhs[i],rhs[i]);
            dst = target;
            return elapsed(sw);
        }

        public long TimedOp(Index<T> lhs, Index<T> rhs, out Index<T> dst, PrimalFusedBinOp<T> Op)
        {
            var sw = stopwatch();
            dst = Op(lhs,rhs);
            return elapsed(sw);
        }

        public long TimedOp(Index<T> lhs, Index<T> rhs, out Index<bool> dst, PrimalFusedPred<T> Op)
        {
            var sw = stopwatch();
            dst = Op(lhs,rhs);
            return elapsed(sw);
        }

        public unsafe long TimedOp(Index<T> lhs, Index<T> rhs, out Index<T> dst, Vec128BinOp<T> Op)
        {
            var sw = stopwatch();
            dst =  Vectorizer.vectorize(Op,lhs,rhs);
            return elapsed(sw);
        }


    }


}