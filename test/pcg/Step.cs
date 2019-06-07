namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    using uint8_t = System.Byte;
    using uint16_t = System.UInt16;
    using uint32_t = System.UInt32;
    using uint64_t = System.UInt64;
    using static PCG;

    public static partial class PCG
    {
        [MethodImpl(Inline)]
        public static void pcg_oneseq_8_step_r(pcg_state_8 rng)        
            => rng.state = (uint8_t)(rng.state * PCG_DEFAULT_MULTIPLIER_8 + PCG_DEFAULT_INCREMENT_8);


        [MethodImpl(Inline)]
        public static void pcg_mcg_8_step_r(pcg_state_8 rng)
            => rng.state = (uint8_t)(rng.state * PCG_DEFAULT_MULTIPLIER_8);
        
        [MethodImpl(Inline)]
        public static void pcg_setseq_8_step_r(pcg_state_setseq_8 rng)
            =>  rng.state = (uint8_t)(rng.state * PCG_DEFAULT_MULTIPLIER_8 + rng.inc);


        [MethodImpl(Inline)]
        public static void pcg_unique_8_step_r(pcg_state_8 rng)
            => rng.state = (uint8_t)(rng.state * PCG_DEFAULT_MULTIPLIER_8 + (rng.oid | 1u));

        [MethodImpl(Inline)]
        public static void pcg_oneseq_64_step_r(pcg_state_64 rng)            
            =>  rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_64 + PCG_DEFAULT_INCREMENT_64;            

        [MethodImpl(Inline)]
        public static void pcg_mcg_16_step_r(pcg_state_16 rng)        
            => rng.state = (uint16_t)(rng.state * PCG_DEFAULT_MULTIPLIER_16);    

        [MethodImpl(Inline)]
        public static void pcg_mcg_32_step_r(pcg_state_32 rng)
            => rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_32;

        [MethodImpl(Inline)]
        public static void pcg_mcg_64_step_r(pcg_state_64 rng)
            => rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_64;

        [MethodImpl(Inline)]
        public static void pcg_setseq_64_step_r(pcg_state_setseq_64 rng)        
            => rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_64 + rng.inc;
        
        [MethodImpl(Inline)]
        public static void pcg_unique_32_step_r(pcg_state_32 rng)
            => rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_32 + (uint32_t)(rng.oid | 1u);
    }

}