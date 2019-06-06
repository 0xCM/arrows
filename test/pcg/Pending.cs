namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using uint8_t = System.Byte;
    using int16_t = System.Int16;
    using uint16_t = System.UInt16;
    using int32_t = System.Int32;
    using uint32_t = System.UInt32;
    using uint64_t = System.UInt64;
    using pcg32_random_t = PCG.pcg_state_setseq_64;
    using static PCG;

   public static class PCGPending
    {
       [MethodImpl(Inline)]
        public static uint8_t pcg_output_xsh_rr_16_8(uint16_t state)        
            => pcg_rotr_8((uint8_t)(((state >> 5) ^ state) >> 5), (uint)(state >> 13));

 
        [MethodImpl(Inline)]
        public static void pcg_oneseq_8_step_r(pcg_state_8 rng)        
            => rng.state = (uint8_t)(rng.state * PCG_DEFAULT_MULTIPLIER_8 + PCG_DEFAULT_INCREMENT_8);

        [MethodImpl(Inline)]
        public static void pcg_oneseq_8_advance_r(pcg_state_8 rng, uint8_t delta)
            => rng.state = pcg_advance_lcg_8(rng.state, delta, PCG_DEFAULT_MULTIPLIER_8, PCG_DEFAULT_INCREMENT_8);

        [MethodImpl(Inline)]
        public static void pcg_mcg_8_step_r(pcg_state_8 rng)
            => rng.state = (uint8_t)(rng.state * PCG_DEFAULT_MULTIPLIER_8);
        
        [MethodImpl(Inline)]
        public static void pcg_setseq_8_step_r(pcg_state_setseq_8 rng)
            =>  rng.state = (uint8_t)(rng.state * PCG_DEFAULT_MULTIPLIER_8 + rng.inc);

        [MethodImpl(Inline)]
        public static void pcg_mcg_8_advance_r(pcg_state_8 rng, uint8_t delta)
            => rng.state = pcg_advance_lcg_8(rng.state, delta, PCG_DEFAULT_MULTIPLIER_8, 0);

        [MethodImpl(Inline)]
        public static void pcg_unique_8_advance_r(pcg_state_8 rng, uint8_t delta)        
            => rng.state = pcg_advance_lcg_8(rng.state, delta, PCG_DEFAULT_MULTIPLIER_8, (uint8_t)(rng.oid | 1u));

        [MethodImpl(Inline)]
        public static void pcg_unique_8_srandom_r(pcg_state_8 rng, uint8_t initstate)
        {
            rng.state = 0;
            pcg_unique_8_step_r(rng);
            rng.state += initstate;
            pcg_unique_8_step_r(rng);
        }

        
        [MethodImpl(Inline)]
        public static void pcg_unique_8_step_r(pcg_state_8 rng)
            => rng.state = (uint8_t)(rng.state * PCG_DEFAULT_MULTIPLIER_8 + (rng.oid | 1u));
    }    



}