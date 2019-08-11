//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    partial class mkl
    {            
        /// <summary>
        /// Allocates a stream predicated on a specified RNG and a seed
        /// </summary>
        /// <param name="brng">The RNG through which the data points will be constructed</param>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream stream(BRNG brng, uint seed)
        {
            IntPtr stream = IntPtr.Zero;
            VSL.vslNewStream(ref stream, brng, seed).ThrowOnError();
            return stream;
        }
                
        /// <summary>
        /// Gets the brng identifier associated with a stream
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        [MethodImpl(Inline)]    
        public static BRNG brng(VslStream stream)
            => VSL.vslGetStreamStateBrng(stream);

        /// <summary>
        /// Creates a stream predicated on the VSL_BRNG_MCG31, A 31-bit multiplicative congruential generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gMcg31(uint seed)
            => stream(BRNG.MCG31, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_R250, A generalized feedback shift register generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gR250(uint seed)
            => stream(BRNG.R250, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MCG59, A 59-bit multiplicative congruential generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gMcg59(uint seed)
            => stream(BRNG.MCG59, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MRG32K3A, A combined multiple recursive generator with two components of order 3.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gMrg32K31(uint seed)
            => stream(BRNG.MRG32K3A, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_NONDETERM, A non-deterministic random number generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gRandom()
            => stream(BRNG.NONDETERM, 0);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MT19937, A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gMt19937(uint seed)
            => stream(BRNG.MT19937, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_SOBOL, A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 40
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gSobol(uint seed)
            => stream(BRNG.SOBOL, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_PHILOX4X32X10, A Philox4x32-10 counter-based pseudorandom number generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gPhilox(uint seed)
            => stream(BRNG.PHILOX4X32X10, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_WH, A set of 273 Wichmann-Hill combined multiplicative congruential generators.
        /// </summary>
        /// <param name="seed">A seed</param>
        /// <param name="index">A value between 0 and 272 that identifies the desired generator</param>
        [MethodImpl(Inline)]    
        public static VslStream gWh(uint seed, int index = 0)
            => stream(BRNG.WH + index, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MT2203, A set of 6024 Mersenne Twister pseudorandom number generators
        /// </summary>
        /// <param name="seed">A seed</param>
        /// <param name="index">A value between 0 and 6023 that identifies the desired generator</param>
        [MethodImpl(Inline)]    
        public static VslStream gMt2203(uint seed, int index = 0)
            => stream(BRNG.MT2203 + index, seed);

   }

}