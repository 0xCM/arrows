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
        public static Span128Sampler Sample(IRandomizer random, int blocks)
            => new Span128Sampler(random, blocks);


        void CollectSamples(int blocks)
        {
            Int8Samples = Random.Array128<sbyte>(blocks);            
            UInt8Samples = Random.Array128<byte>(blocks);
            Int16Samples = Random.Array128<short>(blocks);            
            UInt16Samples = Random.Array128<ushort>(blocks);
            Int32Samples = Random.Array128<int>(blocks);            
            UInt32Samples = Random.Array128<uint>(blocks);
            Int64Samples = Random.Array128<long>(blocks);            
            UInt64Samples = Random.Array128<ulong>(blocks);
            Float32Samples = Random.Array128<float>(blocks);
            Float64Samples = Random.Array128<double>(blocks);            

        }

        Span128Sampler(IRandomizer random, int blocks)
            : base(random)
        {
            CollectSamples(blocks);
        }

        /// <summary>
        /// Returns values for which samples have already been drawn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public Span128<T> Sampled<T>(T specimen = default(T))
            where T : struct
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
    }
}