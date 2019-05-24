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
            CaptureSamples(blocks);
        }

        void CaptureSamples(int blocks)
        {
            Int8Samples = Random.Span256<sbyte>(blocks).ToArray();
            UInt8Samples = Random.Span256<byte>(blocks).ToArray();
            Int16Samples = Random.Span256<short>(blocks).ToArray();            
            UInt16Samples = Random.Span256<ushort>(blocks).ToArray();
            Int32Samples = Random.Span256<int>(blocks).ToArray();            
            UInt32Samples = Random.Span256<uint>(blocks).ToArray();
            Int64Samples = Random.Span256<long>(blocks).ToArray();            
            UInt64Samples = Random.Span256<ulong>(blocks).ToArray();
            Float32Samples = Random.Span256<float>(blocks).ToArray();
            Float64Samples = Random.Span256<double>(blocks).ToArray(); 
        }

        /// <summary>
        /// Returns values for which samples have already been drawn
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public Span256<T> Sampled<T>()
            where T : struct
                => PrimalKinds.kind<T>() switch {
                PrimalKind.int8 => As.generic<T>(Span256.load(Int8Samples)),
                PrimalKind.uint8 => As.generic<T>(Span256.load(UInt8Samples)),
                PrimalKind.int16 => As.generic<T>(Span256.load(Int16Samples)),
                PrimalKind.uint16 => As.generic<T>(Span256.load(UInt16Samples)),
                PrimalKind.int32 => As.generic<T>(Span256.load(Int32Samples)),
                PrimalKind.uint32 => As.generic<T>(Span256.load(UInt32Samples)),
                PrimalKind.int64 => As.generic<T>(Span256.load(Int64Samples)),
                PrimalKind.uint64 => As.generic<T>(Span256.load(UInt64Samples)),
                PrimalKind.float32 => As.generic<T>(Span256.load(Float32Samples)),
                PrimalKind.float64 => As.generic<T>(Span256.load(Float64Samples)),
                    _ => throw new Exception($"Kind not supported")
                };
    }
}