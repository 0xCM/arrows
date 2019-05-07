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
    using static mfunc;

    public class Span128Sampler : Sampler<Span128Sampler> 
    {
        /// <summary>
        /// Returns a set of Span128 primitive samples
        /// </summary>
        /// <param name="random">The randomizer from which data will be obtained</param>
        /// <param name="blocks">The number of blocks to sample for each primitive</param>
        public static Span128Sampler Sample(IRandomizer random, int blocks)
            => new Span128Sampler(random, blocks);

        /// <summary>
        /// Returns values for which samples have already been drawn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Span128<T> Sampled<T>(T specimen = default(T))
            where T : struct, IEquatable<T>
            => PrimalKinds.kind<T>() switch {
                PrimalKind.int8 => As.generic<T>(Int8Samples),
                PrimalKind.uint8 => As.generic<T>(UInt8Samples),
                PrimalKind.int16 => As.generic<T>(Int16Samples),
                PrimalKind.uint16 => As.generic<T>(UInt16Samples),
                PrimalKind.int32 => As.generic<T>(Int32Samples),
                PrimalKind.uint32 => As.generic<T>(UInt32Samples),
                PrimalKind.int64 => As.generic<T>(Int64Samples),
                PrimalKind.uint64 => As.generic<T>(UInt64Samples),
                PrimalKind.float32 => As.generic<T>(Float32Samples),
                PrimalKind.float64 => As.generic<T>(Float64Samples),
                _ => throw new Exception($"Kind not supported")
            };

        Span128Sampler(IRandomizer random, int blocks)
        {
            this.Int8Samples = random.Array128<sbyte>(blocks);            
            this.UInt8Samples = random.Array128<byte>(blocks);
            this.Int16Samples = random.Array128<short>(blocks);            
            this.UInt16Samples = random.Array128<ushort>(blocks);
            this.Int32Samples = random.Array128<int>(blocks);            
            this.UInt32Samples = random.Array128<uint>(blocks);
            this.Int64Samples = random.Array128<long>(blocks);            
            this.UInt64Samples = random.Array128<ulong>(blocks);
            this.Float32Samples = random.Array128<float>(blocks);
            this.Float64Samples = random.Array128<double>(blocks);            
        }

        readonly byte[] UInt8Samples;

        readonly sbyte[] Int8Samples;
        
        readonly short[] Int16Samples;

        readonly ushort[] UInt16Samples;

        readonly int[] Int32Samples;

        readonly uint[] UInt32Samples;

        readonly long[] Int64Samples;

        readonly ulong[] UInt64Samples;

        readonly float[] Float32Samples;

        readonly double[] Float64Samples;

    }
}