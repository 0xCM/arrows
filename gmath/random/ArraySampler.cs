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
                        
            bool Filter<T>(T value)                        
                where T : struct
            {
                if(nonzero)                    
                {
                    if(value.Equals(default(T)))
                        return false;
                }
                return true;

            }

            Int8Samples = Random.Array<sbyte>(samples,Filter);            
            UInt8Samples = Random.Array<byte>(samples,Filter);
            Int16Samples = Random.Array<short>(samples,Filter);            
            UInt16Samples = Random.Array<ushort>(samples,Filter);
            Int32Samples = Random.Array<int>(samples,Filter);            
            UInt32Samples = Random.Array<uint>(samples,Filter);
            Int64Samples = Random.Array<long>(samples,Filter);            
            UInt64Samples = Random.Array<ulong>(samples,Filter);
            Float32Samples = Random.Array<float>(samples,Filter);
            Float64Samples = Random.Array<double>(samples,Filter);            
 
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
        /// <returns></returns>
        public T[] Sampled<T>(T specimen = default(T))
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