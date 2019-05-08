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

    
    using static zfunc;
    using static global::mfunc;

    using Aligned = Span128;

    public class Vec128Bench : BenchContext
    {   
        static readonly BenchConfig DefaultConfig = new BenchConfig(Cycles: Pow2.T12, Reps: 1, SampleSize: Pow2.T11, AnnounceRate: Pow2.T11);        
        
        public static Vec128Bench Create(IRandomizer random, BenchConfig config = null)
            => new Vec128Bench(random, config ?? DefaultConfig);
        
        Vec128Bench(IRandomizer random, BenchConfig config)
            : base(random, config)
        {

            LeftSamples = Span128Sampler.Sample(random, config.SampleSize);   
            RightSamples = Span128Sampler.Sample(random, config.SampleSize);
            

        }

        readonly Span128Sampler LeftSamples;   

        readonly Span128Sampler RightSamples;   

        public IBenchComparison CreateI8()
        {
            var data = UnaryOpInit<sbyte>();
            var opid = OpKind.Create.OpId<sbyte>(intrinsic: true);

            var src = data.Source;
            var direct = Measure(opid, () => 
                {
                    var i =0;
                    dinx.store(Vec128.define(
                        src[i++], src[i++], src[i++], src[i++],
                        src[i++], src[i++], src[i++], src[i++],
                        src[i++], src[i++], src[i++], src[i++],
                        src[i++], src[i++], src[i++], src[i++]),
                        data.RightTarget);
                });

            var generic = Measure(~opid, () => 
                dinx.store(Vec128.define(data.Source), data.LeftTarget));

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison CreateI32()
        {
            var data = UnaryOpInit<int>();
            var opid = OpKind.Create.OpId<int>(intrinsic: true);

            var src = data.Source;
            var direct = Measure(opid, () => 
                dinx.store(Vec128.define(src[0], src[1], src[2], src[3]), data.RightTarget));

            var generic = Measure(~opid, () => 
                dinx.store(Vec128.define(data.Source), data.LeftTarget));

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison CreateF64()
        {
            var data = UnaryOpInit<double>();
            var opid = OpKind.Create.OpId<double>(intrinsic: true);

            var src = data.Source;
            var direct = Measure(opid, () => 
                dinx.store(Vec128.define(src[0], src[1]), data.RightTarget));

            var generic = Measure(~opid, () => 
                dinx.store(Vec128.define(data.Source), data.LeftTarget));

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        
        (T[] Left,T[] Right) Targets<T>(T specimen = default(T))
            where T : struct, IEquatable<T>
                => (Span128.blockalloc<T>(Config.SampleSize).ToArray(),
                    Span128.blockalloc<T>(Config.SampleSize).ToArray());                

        static T head<T>(T[] src)
            => src.FirstOrDefault();

        #region Add


        OpMeasure gadd<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = LeftSamples.Sampled(head(dst));
            var rhs = RightSamples.Sampled(head(dst));
            var sw = stopwatch();
            ginx.add(lhs, rhs, dst.ToSpan128());
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span128<byte> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span128<sbyte> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span128<short> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span128<ushort> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span128<int> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span128<uint> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span128<long> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span128<ulong> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span128<float> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span128<double> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }


        public IBenchComparison AddI8()
        {
            var opid = OpKind.Add.Vec128OpId<sbyte>();
            (var lDst, var rDst) = Targets<sbyte>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU8()        
        {
            var opid = OpKind.Add.Vec128OpId<byte>();
            (var lDst, var rDst) = Targets<byte>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddI16()
        {
            var opid = OpKind.Add.Vec128OpId<short>();
            (var lDst, var rDst) = Targets<short>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU16()        
        {
            var opid = OpKind.Add.Vec128OpId<ushort>();
            (var lDst, var rDst) = Targets<ushort>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddI32()
        {
            var opid = OpKind.Add.Vec128OpId<int>();
            (var lDst, var rDst) = Targets<int>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU326()        
        {
            var opid = OpKind.Add.Vec128OpId<uint>();
            (var lDst, var rDst) = Targets<uint>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddI64()
        {
            var opid = OpKind.Add.Vec128OpId<long>();
            (var lDst, var rDst) = Targets<long>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU64()        
        {
            var opid = OpKind.Add.Vec128OpId<ulong>();
            (var lDst, var rDst) = Targets<ulong>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }


        public IBenchComparison AddF32()        
        {
            var opid = OpKind.Add.Vec128OpId<float>();
            (var lDst, var rDst) = Targets<float>();

            var comparison = Run(opid, 
                Measure(opid, () => dadd(lDst)), 
                Measure(~opid, () => gadd(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddF64()        
        {
            var opid = OpKind.Add.Vec128OpId<double>();
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
            ginx.sub(lhs, rhs, dst.ToSpan128());
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span128<byte> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span128<sbyte> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span128<short> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span128<ushort> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span128<int> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span128<uint> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span128<long> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span128<ulong> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span128<float> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dsub(Span128<double> dst)
        {
            var lhs = LeftSamples.Sampled(dst.Head);
            var rhs = RightSamples.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }


        public IBenchComparison SubI8()
        {
            var opid = OpKind.Sub.Vec128OpId<sbyte>();
            (var lDst, var rDst) = Targets<sbyte>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU8()        
        {
            var opid = OpKind.Sub.Vec128OpId<byte>();
            (var lDst, var rDst) = Targets<byte>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI16()
        {
            var opid = OpKind.Sub.Vec128OpId<short>();
            (var lDst, var rDst) = Targets<short>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU16()        
        {
            var opid = OpKind.Sub.Vec128OpId<ushort>();
            (var lDst, var rDst) = Targets<ushort>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI32()
        {
            var opid = OpKind.Sub.Vec128OpId<int>();
            (var lDst, var rDst) = Targets<int>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU326()        
        {
            var opid = OpKind.Sub.Vec128OpId<uint>();
            (var lDst, var rDst) = Targets<uint>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI64()
        {
            var opid = OpKind.Sub.Vec128OpId<long>();
            (var lDst, var rDst) = Targets<long>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU64()        
        {
            var opid = OpKind.Sub.Vec128OpId<ulong>();
            (var lDst, var rDst) = Targets<ulong>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }


        public IBenchComparison SubF32()        
        {
            var opid = OpKind.Sub.Vec128OpId<float>();
            (var lDst, var rDst) = Targets<float>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubF64()        
        {
            var opid = OpKind.Sub.Vec128OpId<double>();
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