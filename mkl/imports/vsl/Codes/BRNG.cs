//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

	using static zfunc;
    using static VslRngConstants;
    using static VslRngMethod;

    static class VslRngConstants
    {
        public const int VSL_BRNG_SHIFT = 20;

        public const int  VSL_BRNG_INC = 1 << VSL_BRNG_SHIFT;

    }

    public enum BRNG
    {
        /// <summary>
        /// A 31-bit multiplicative congruential generator.
        /// </summary>
        [MklCode("A 31-bit multiplicative congruential generator.")]
        MCG31 = VSL_BRNG_INC,

        /// <summary>
        /// A generalized feedback shift register generator.
        /// </summary>
        [MklCode("A generalized feedback shift register generator.")]
        R250 = MCG31 + VSL_BRNG_INC,
        
        /// <summary>
        /// A combined multiple recursive generator with two components of order 3.
        /// </summary>
        [MklCode("A combined multiple recursive generator with two components of order 3.")]
        MRG32K3A = R250 + VSL_BRNG_INC,

        /// <summary>
        /// A 59-bit multiplicative congruential generator.
        /// </summary>
        [MklCode("A 59-bit multiplicative congruential generator.")]
        MCG59 = MRG32K3A + VSL_BRNG_INC,
        
        /// <summary>
        /// A set of 273 Wichmann-Hill combined multiplicative congruential generators.
        /// </summary>
        [MklCode("A set of 273 Wichmann-Hill combined multiplicative congruential generators.")]
        WH = MCG59 + VSL_BRNG_INC,
        
        /// <summary>
        /// A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 40
        /// User-defined dimensions are also available
        /// </summary>
        [MklCode("A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 40")]
        SOBOL = WH + VSL_BRNG_INC,

        /// <summary>
        /// A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 318.
        /// User-defined dimensions are also available.
        /// </summary>
        [MklCode("A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 318.")]
        NIEDERR = SOBOL + VSL_BRNG_INC,
        
        /// <summary>
        /// A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
        /// </summary>
        [MklCode("A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.")]
        MT19937 = NIEDERR + VSL_BRNG_INC,

        /// <summary>
        /// A set of 6024 Mersenne Twister pseudorandom number generators
        /// </summary>
        [MklCode("A set of 6024 Mersenne Twister pseudorandom number generators")]
        MT2203 = MT19937 + VSL_BRNG_INC,
        
        /// <summary>
        /// An abstract random number generator for integer arrays.
        /// </summary>
        [MklCode("An abstract random number generator for integer arrays.")]
        IABSTRACT = MT2203 + VSL_BRNG_INC,
        
        /// <summary>
        /// An abstract random number generator for double precision floating-point arrays.
        /// </summary>
        [MklCode("An abstract random number generator for double precision floating-point arrays.")]
        DABSTRACT = IABSTRACT + VSL_BRNG_INC,

        /// <summary>
        /// An abstract random number generator for single precision floating-point arrays.
        /// </summary>
        [MklCode("An abstract random number generator for single precision floating-point arrays.")]
        SABSTRACT = DABSTRACT + VSL_BRNG_INC,

        /// <summary>
        /// A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
        /// </summary>
        [MklCode("A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.")]
        SFMT19937 = SABSTRACT+ VSL_BRNG_INC,

        /// <summary>
        /// A non-deterministic random number generator.
        /// </summary>
        [MklCode("A non-deterministic random number generator.")]
        NONDETERM = SFMT19937+ VSL_BRNG_INC,

        /// <summary>
        /// An ARS-5 counter-based pseudorandom number generator that uses instructions from the AES-NI set
        /// </summary>
        [MklCode("An ARS-5 counter-based pseudorandom number generator that uses instructions from the AES-NI set")]
        ARS5 = NONDETERM+ VSL_BRNG_INC,

        /// <summary>
        /// A Philox4x32-10 counter-based pseudorandom number generator.
        /// </summary>
        [MklCode("A Philox4x32-10 counter-based pseudorandom number generator.")]
        PHILOX4X32X10  = ARS5     + VSL_BRNG_INC            
    }
}