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
        public static VslStream vslStream(BRNG brng, uint seed, int index = 0)
        {
            IntPtr stream = IntPtr.Zero;
            VSL.vslNewStream(ref stream, brng + index, seed).ThrowOnError();
            return stream;
        }

        [MethodImpl(Inline)]    
        public static RngStream stream(BRNG brng, uint seed, int index = 0)
            => RngStream.Define(brng, seed, index);

        /// <summary>
        /// Describes stream partitioning capabilies of an identifed generator
        /// </summary>
        /// <param name="sub">Indicates whether stream independed substream creation (Leapfrogging) is suppored</param>
        /// <param name="skip">Indicates whether elements can be skipped</param>
        public static (bool sub, bool skip) rngSeekInfo(BRNG brng)
            => brng switch {
                    BRNG.MCG31 => (true,true),
                    BRNG.MRG32K3A => (false,true),
                    BRNG.MCG59 => (true,true),
                    BRNG.WH => (true,true),
                    BRNG.MT19937 => (false,true),
                    BRNG.SFMT19937 => (false,true),
                    BRNG.PHILOX4X32X10 => (false,true),
                    BRNG.ARS5 => (false,true),
                    BRNG.SOBOL => (true,true),
                    BRNG.NIEDERR => (true,true),
                    _ => (false,false)
            };
                

        /// <summary>
        /// Creates a stream predicated on the VSL_BRNG_MCG31, A 31-bit multiplicative congruential generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static RngStream gMcg31(uint seed)
            => stream(BRNG.MCG31, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_R250, A generalized feedback shift register generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream gR250(uint seed)
            => stream(BRNG.R250, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MRG32K3A, A combined multiple recursive generator with two components of order 3.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream gMrg32K31(uint seed)
            => stream(BRNG.MRG32K3A, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MCG59, A 59-bit multiplicative congruential generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream gMcg59(uint seed)
            => stream(BRNG.MCG59, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MT19937, A Mersenne Twister pseudorandom number generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream gMt19937(uint seed)
            => stream(BRNG.MT19937, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_SFMT19937, A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream gSfmt19937(uint seed)
            => stream(BRNG.SFMT19937, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_SOBOL, A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 40
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream gSobol(uint seed)
            => stream(BRNG.SOBOL, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_PHILOX4X32X10, A Philox4x32-10 counter-based pseudorandom number generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream gPhilox(uint seed)
            => stream(BRNG.PHILOX4X32X10, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_ARS5, an ARS-5 counter-based pseudorandom number generator that uses instructions from the AES-NI set
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]    
        public static RngStream gArs5(uint seed)
            => stream(BRNG.ARS5, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_NONDETERM, A non-deterministic random number generator.
        /// </summary>
        [MethodImpl(Inline)]    
        public static RngStream gRandom()
            => stream(BRNG.NONDETERM, 0);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_WH, A set of 273 Wichmann-Hill combined multiplicative congruential generators.
        /// </summary>
        /// <param name="seed">A seed</param>
        /// <param name="index">A value between 0 and 272 that identifies the desired generator</param>
        [MethodImpl(Inline)]    
        public static RngStream gWh(uint seed, int index = 0)
            => stream(BRNG.WH, seed, index);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MT2203, A set of 6024 Mersenne Twister pseudorandom number generators
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        /// <param name="index">A value between 0 and 6023 that identifies the desired generator</param>
        [MethodImpl(Inline)]    
        public static RngStream gMt2203(uint seed, int index = 0)
            => stream(BRNG.MT2203, seed, index);

   }

}