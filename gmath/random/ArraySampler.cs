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

    public class ArraySampler : Sampler<ArraySampler>
    {
        /// <summary>
        /// Returns a set of Span256 primitive samples
        /// </summary>
        /// <param name="random">The randomizer from which data will be obtained</param>
        /// <param name="samples">The number of blocks to sample for each primitive</param>
        public static ArraySampler Sample(IRandomizer random, int samples, bool nonzero = false)
            => new ArraySampler(random, samples, nonzero);

        void TakeSamples(int samples,bool nonzero)
        {                        

            Int8Samples = nonzero 
                ? Random.NonZeroArray<sbyte>(samples) 
                : Random.Array<sbyte>(samples);

            UInt8Samples = nonzero 
                ? Random.NonZeroArray<byte>(samples) 
                : Random.Array<byte>(samples);

            Int16Samples = nonzero 
                ? Random.NonZeroArray<short>(samples) 
                : Random.Array<short>(samples);

            UInt16Samples = nonzero 
                ? Random.NonZeroArray<ushort>(samples) 
                : Random.Array<ushort>(samples);
                
            Int32Samples = nonzero ? Random.NonZeroArray<int>(samples) : Random.Array<int>(samples);
            UInt32Samples = nonzero ? Random.NonZeroArray<uint>(samples) : Random.Array<uint>(samples);
            Int64Samples = nonzero ? Random.NonZeroArray<long>(samples) : Random.Array<long>(samples);            
            UInt64Samples = nonzero ? Random.NonZeroArray<ulong>(samples) : Random.Array<ulong>(samples);
            Float32Samples = nonzero ? Random.NonZeroArray<float>(samples) : Random.Array<float>(samples);
            Float64Samples = nonzero ? Random.NonZeroArray<double>(samples) : Random.Array<double>(samples);
 
        }

        ArraySampler(IRandomizer random, int samples, bool nonzero)
            : base(random)
        {
            TakeSamples(samples,nonzero);
            this.SampleSize  = samples;        
        }

        public int SampleSize {get;}                

        public T[] Sampled<T>(OpId<T> op)
            where T : struct
                => Sampled<T>();

        /// <summary>
        /// Returns values for which samples have already been drawn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T[] Sampled<T>()
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