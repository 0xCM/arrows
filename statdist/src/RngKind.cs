//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Numerics;

    using static zfunc;
    
    public enum RngKind
    {
        
        /// <summary>
        /// A crypto-sourced nondeterministic generator
        /// </summary>
        EntropicCrypto,

        /// <summary>
        /// A 32-bit PCG generator
        /// </summary>
        Pcg32,

        /// <summary>
        /// A suite of 32-bit PCG generators
        /// </summary>
        Pcg32Suite,

        /// <summary>
        /// A 64-bit PCG generator
        /// </summary>
        Pcg64,

        /// <summary>
        /// A suite of 64-bit PCG generators
        /// </summary>
        Pcg64Suite,

        /// <summary>
        /// A 64-bit SplitMix generator
        /// </summary>
        SplitMix64,

        /// <summary>
        /// A 16-bit WyHash generator
        /// </summary>
        WyHash16,

        /// <summary>
        /// A 64-bit WyHash generator
        /// </summary>
        WyHash64,

        /// <summary>
        /// A suite of 64-bit WyHash generators
        /// </summary>
        WyHash64Suite,
        
        /// <summary>
        /// A 256-bit xor/shift generator that produces 64 bits in a go
        /// </summary>
        XOrShift256,

        /// <summary>
        /// A 1024-bit xor/shift generator that produces 64 bits in a go
        /// </summary>
        XOrShift1024,
        
        /// <summary>
        /// Indentifes a hardware level entropic source driven by
        /// the RDRAND instruction
        /// </summary>
        MklEntropic = 14680064,

        /// <summary>
        /// A 31-bit multiplicative congruential generator provided by MKL
        /// </summary>
        MklMcg31 = 1048576,

        /// <summary>
        /// A generalized feedback shift register generator provided by MKL
        /// </summary>
        MklR250 = 2097152,

        /// <summary>
        /// A combined multiple recursive generator with two components of order 3 provided by MKL
        /// </summary>
        MklMrg32K3A = 3145728,

        /// <summary>
        /// A 59-bit multiplicative congruential generator provided by MKL
        /// </summary>
        MklMcg59 = 4194304,
        
        /// <summary>
        /// A set of 273 Wichmann-Hill combined multiplicative congruential generators provided by MKL
        /// </summary>
        MklWH = 5242880,
        
        /// <summary>
        /// A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 40 provided by MKL
        /// </summary>
        MklSobol = 6291456,

        /// <summary>
        /// A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 318 provided by MKL
        /// </summary>
        MklNiederr = 7340032,
        
        /// <summary>
        /// A SIMD-oriented Fast Mersenne Twister pseudorandom number generator provided by MKL
        /// </summary>
        MklMt19937 = 8388608,

        /// <summary>
        /// A set of 6024 Mersenne Twister pseudorandom number generators provided by MKL
        /// </summary>
        MklMt2203 = 9437184,
        
        /// <summary>
        /// A SIMD-oriented Fast Mersenne Twister pseudorandom number generator provided by MKL
        /// </summary>
        MklSfmt19937 = 13631488,

        /// <summary>
        /// An ARS-5 counter-based pseudorandom number generator that uses instructions from the AES-NI set
        /// </summary>
        MklARS5 = 13631488,

        /// <summary>
        /// A Philox4x32-10 counter-based pseudorandom number generator.
        /// </summary>
        MklPhilox4X32X10 = 16777216


    }

}