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
        
        void CaptureSamples(int blocks, bool nonzero)
        {            
            Int8Samples =  Random.Span128<sbyte>(blocks, null, nonzero).ToArray();               
            UInt8Samples = Random.Span128<byte>(blocks, null, nonzero).ToArray();
            Int16Samples = Random.Span128<short>(blocks, null, nonzero).ToArray();            
            UInt16Samples = Random.Span128<ushort>(blocks, null, nonzero).ToArray();
            Int32Samples = Random.Span128<int>(blocks, null, nonzero).ToArray();            
            UInt32Samples = Random.Span128<uint>(blocks, null, nonzero).ToArray();
            Int64Samples = Random.Span128<long>(blocks, null, nonzero).ToArray();            
            UInt64Samples = Random.Span128<ulong>(blocks, null, nonzero).ToArray();
            Float32Samples = Random.Span128<float>(blocks, null, nonzero).ToArray();
            Float64Samples = Random.Span128<double>(blocks, null, nonzero).ToArray();            
        }

        Span128Sampler(IRandomizer random, int blocks, bool nonzero)
            : base(random)
        {
            CaptureSamples(blocks, nonzero);
        }

        /// <summary>
        /// Returns values for which samples have already been drawn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public Span128<T> Sampled<T>()
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