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
    using static mfunc;

    public class Span128Sampler : Sampler<Span128Sampler> 
    {
        /// <summary>
        /// Returns a set of Span128 primitive samples
        /// </summary>
        /// <param name="random">The randomizer from which data will be obtained</param>
        /// <param name="blocks">The number of blocks to sample for each primitive</param>
        public static Span128Sampler Sample(IRandomizer random, int blocks, bool nonzero = false)
            => new Span128Sampler(random, blocks, nonzero);

        T[] CollectSamples<T>(int blocks, bool nonzero)
            where T : struct
        {
            Func<T,bool> filter = nonzero ? new Func<T,bool>(gmath.nonzero) : null;
            return Random.Array128<T>(blocks, null, filter);
        }
        void CollectSamples(int blocks, bool nonzero)
        {            
            Int8Samples =  CollectSamples<sbyte>(blocks, nonzero);               
            UInt8Samples = CollectSamples<byte>(blocks, nonzero);
            Int16Samples = CollectSamples<short>(blocks, nonzero);            
            UInt16Samples = CollectSamples<ushort>(blocks, nonzero);
            Int32Samples = CollectSamples<int>(blocks, nonzero);            
            UInt32Samples = CollectSamples<uint>(blocks, nonzero);
            Int64Samples = CollectSamples<long>(blocks, nonzero);            
            UInt64Samples = CollectSamples<ulong>(blocks, nonzero);
            Float32Samples = CollectSamples<float>(blocks, nonzero);
            Float64Samples = CollectSamples<double>(blocks, nonzero);            
        }

        Span128Sampler(IRandomizer random, int blocks, bool nonzero)
            : base(random)
        {
            CollectSamples(blocks, nonzero);
        }

        /// <summary>
        /// Returns values for which samples have already been drawn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public Span128<T> Sampled<T>(T specimen = default(T))
            where T : struct
            => PrimalKinds.kind<T>() switch {
                PrimalKind.int8 => As.generic<T>(Span128.load(Int8Samples)),
                PrimalKind.uint8 => As.generic<T>(Span128.load(UInt8Samples)),
                PrimalKind.int16 => As.generic<T>(Span128.load(Int16Samples)),
                PrimalKind.uint16 => As.generic<T>(Span128.load(UInt16Samples)),
                PrimalKind.int32 => As.generic<T>(Span128.load(Int32Samples)),
                PrimalKind.uint32 => As.generic<T>(Span128.load(UInt32Samples)),
                PrimalKind.int64 => As.generic<T>(Span128.load(Int64Samples)),
                PrimalKind.uint64 => As.generic<T>(Span128.load(UInt64Samples)),
                PrimalKind.float32 => As.generic<T>(Span128.load(Float32Samples)),
                PrimalKind.float64 => As.generic<T>(Span128.load(Float64Samples)),
                _ => throw new Exception($"Kind not supported")
            };
    }
}