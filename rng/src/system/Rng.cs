//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using Z0.Mkl;

    using System.Runtime.CompilerServices;

    using static zfunc;
    using mkl = Z0.Mkl.rng;

    public static class Rng
    {
        /// <summary>
        /// Creates a random stream based on supplied parameters
        /// </summary>
        /// <param name="generator"The generator type</param>
        /// <param name="seed">The initial state of the generator, if applicable</param>
        /// <param name="index">The selected substream, if applicable</param>
        [MethodImpl(Inline)]    
        static IRandomSource mklStream(BRNG generator, uint seed = 0, int index = 0)
            => RngStream.Define(generator, seed, index);    

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MRG32K3A, A combined multiple recursive generator with two components of order 3.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream mrg32K31(uint seed)
            => mkl.mrg32K31(seed);

        /// <summary>
        /// Creates a stream predicated on the VSL_BRNG_MCG31, A 31-bit multiplicative congruential generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static RngStream mcg31(uint seed)
            => mkl.mcg31(seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MCG59, A 59-bit multiplicative congruential generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream mcg59(uint seed)
            => mkl.mcg59(seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_NONDETERM, A non-deterministic random number generator.
        /// </summary>
        [MethodImpl(Inline)]    
        public static RngStream entropy()
            => mkl.entropy();

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_R250, A generalized feedback shift register generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream r250(uint seed)
            => mkl.r250(seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MT19937, A Mersenne Twister pseudorandom number generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream mt19937(uint seed)
            => mkl.mt19937(seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_SFMT19937, A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream sfmt19937(uint seed)
            => mkl.sfmt19937(seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_WH, A set of 273 Wichmann-Hill combined multiplicative congruential generators.
        /// </summary>
        /// <param name="seed">A seed</param>
        /// <param name="index">A value between 0 and 272 that identifies the desired generator</param>
        [MethodImpl(Inline)]    
        public static RngStream wh(uint seed, int index = 0)
            => mkl.wh(seed, index);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MT2203, A set of 6024 Mersenne Twister pseudorandom number generators
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        /// <param name="index">A value between 0 and 6023 that identifies the desired generator</param>
        [MethodImpl(Inline)]    
        public static RngStream mt2203(uint seed, int index = 0)
            => mkl.mt2203(seed, index);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_PHILOX4X32X10, A Philox4x32-10 counter-based pseudorandom number generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream philox(uint seed)
            => mkl.philox(seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_ARS5, an ARS-5 counter-based pseudorandom number generator that uses instructions from the AES-NI set
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream ars5(uint seed)
            => mkl.ars5(seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_SOBOL, A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 40
        /// </summary>
        /// <param name="dimension">The selected dimension in the inclusive integral range [1,40]</param>
        [MethodImpl(Inline)]    
        public static RngStream sobol(uint dimension)
            => mkl.sobol(dimension);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_NIEDERR, A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 318
        /// </summary>
        /// <param name="dimension">The selected dimension in the inclusive integral range [1,318]</param>
        public static RngStream niederr(uint dimension)
            => mkl.niederr(dimension);
    }
}
