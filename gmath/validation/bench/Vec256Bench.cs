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

    using static zfunc;
    using static global::mfunc;
    using Aligned = Span256;

    public class Vec256Bench : BenchContext
    {   
        static readonly BenchConfig DefaultConfig = new BenchConfig(Cycles: Pow2.T14, Reps: 1, SampleSize: Pow2.T13, AnnounceRate: Pow2.T13);

        public static Vec256Bench Create(IRandomizer random, BenchConfig config = null)
            => new Vec256Bench(random, config ?? DefaultConfig);
        
        Vec256Bench(IRandomizer random, BenchConfig config)
            : base(random, config)
        {

            LeftSamples = Span256Sampler.Sample(random, config.SampleSize);   
            RightSamples = Span256Sampler.Sample(random, config.SampleSize);

        }

        readonly Span256Sampler LeftSamples;   

        readonly Span256Sampler RightSamples;   

        (T[] Left,T[] Right) Targets<T>(T specimen = default(T))
            where T : struct, IEquatable<T>
                => (Span256.blockalloc<T>(Config.SampleSize).ToArray(),
                    Span256.blockalloc<T>(Config.SampleSize).ToArray());                

        static T head<T>(T[] src)
            => src.FirstOrDefault();

        #region Add


        OpMeasure gadd<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = LeftSamples.Sampled(head(dst));
            var rhs = RightSamples.Sampled(head(dst));
            var sw = stopwatch();
            ginx.add(lhs, rhs, dst.ToSpan256());
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<byte> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<sbyte> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<short> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<ushort> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<int> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<uint> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<long> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<ulong> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<float> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<double> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }


        public BenchComparison AddI8()
        {
            var opid = OpKind.Add.Vec256OpId<sbyte>();
            (var lDst, var rDst) = Targets<sbyte>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison AddU8()        
        {
            var opid = OpKind.Add.Vec256OpId<byte>();
            (var lDst, var rDst) = Targets<byte>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison AddI16()
        {
            var opid = OpKind.Add.Vec256OpId<short>();
            (var lDst, var rDst) = Targets<short>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison AddU16()        
        {
            var opid = OpKind.Add.Vec256OpId<ushort>();
            (var lDst, var rDst) = Targets<ushort>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison AddI32()
        {
            var opid = OpKind.Add.Vec256OpId<int>();
            (var lDst, var rDst) = Targets<int>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison AddU326()        
        {
            var opid = OpKind.Add.Vec256OpId<uint>();
            (var lDst, var rDst) = Targets<uint>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison AddI64()
        {
            var opid = OpKind.Add.Vec256OpId<long>();
            (var lDst, var rDst) = Targets<long>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison AddU64()        
        {
            var opid = OpKind.Add.Vec256OpId<ulong>();
            (var lDst, var rDst) = Targets<ulong>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }


        public BenchComparison AddF32()        
        {
            var opid = OpKind.Add.Vec256OpId<float>();
            (var lDst, var rDst) = Targets<float>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison AddF64()        
        {
            var opid = OpKind.Add.Vec256OpId<double>();
            (var lDst, var rDst) = Targets<double>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }


        #endregion
    
        #region Sub


        OpMeasure gsub<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = LeftSamples.Sampled(head(dst));
            var rhs = RightSamples.Sampled(head(dst));
            var sw = stopwatch();
            ginx.sub(lhs, rhs, dst.ToSpan256());
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span256<byte> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span256<sbyte> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span256<short> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span256<ushort> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span256<int> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span256<uint> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span256<long> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span256<ulong> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span256<float> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span256<double> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }


        public BenchComparison SubI8()
        {
            var opid = OpKind.Sub.Vec256OpId<sbyte>();
            (var lDst, var rDst) = Targets<sbyte>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison SubU8()        
        {
            var opid = OpKind.Sub.Vec256OpId<byte>();
            (var lDst, var rDst) = Targets<byte>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison SubI16()
        {
            var opid = OpKind.Sub.Vec256OpId<short>();
            (var lDst, var rDst) = Targets<short>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison SubU16()        
        {
            var opid = OpKind.Sub.Vec256OpId<ushort>();
            (var lDst, var rDst) = Targets<ushort>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison SubI32()
        {
            var opid = OpKind.Sub.Vec256OpId<int>();
            (var lDst, var rDst) = Targets<int>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison SubU326()        
        {
            var opid = OpKind.Sub.Vec256OpId<uint>();
            (var lDst, var rDst) = Targets<uint>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison SubI64()
        {
            var opid = OpKind.Sub.Vec256OpId<long>();
            (var lDst, var rDst) = Targets<long>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison SubU64()        
        {
            var opid = OpKind.Sub.Vec256OpId<ulong>();
            (var lDst, var rDst) = Targets<ulong>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }


        public BenchComparison SubF32()        
        {
            var opid = OpKind.Sub.Vec256OpId<float>();
            (var lDst, var rDst) = Targets<float>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public BenchComparison SubF64()        
        {
            var opid = OpKind.Sub.Vec256OpId<double>();
            (var lDst, var rDst) = Targets<double>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }


        #endregion
    

    }
}