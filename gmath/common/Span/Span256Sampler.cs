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


    public class Span256Sampler : Sampler<Span256Sampler>
    {
        /// <summary>
        /// Returns a set of Span256 primitive samples
        /// </summary>
        /// <param name="random">The randomizer from which data will be obtained</param>
        /// <param name="blocks">The number of blocks to sample for each primitive</param>
        public static Span256Sampler Sample(IRandomizer random, int blocks)
            => new Span256Sampler(random, blocks);

        Span256Sampler(IRandomizer random, int blocks)
            : base(random)
        {
            TakeSamples(blocks);
        }

        void TakeSamples(int blocks)
        {
           Int8Samples = Random.Array256<sbyte>(blocks);            
            UInt8Samples = Random.Array256<byte>(blocks);
            Int16Samples = Random.Array256<short>(blocks);            
            UInt16Samples = Random.Array256<ushort>(blocks);
            Int32Samples = Random.Array256<int>(blocks);            
            UInt32Samples = Random.Array256<uint>(blocks);
            Int64Samples = Random.Array256<long>(blocks);            
            UInt64Samples = Random.Array256<ulong>(blocks);
            Float32Samples = Random.Array256<float>(blocks);
            Float64Samples = Random.Array256<double>(blocks);            
 
        }


        /// <summary>
        /// Returns values for which samples have already been drawn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Span256<T> Sampled<T>(T specimen = default(T))
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


    }
}