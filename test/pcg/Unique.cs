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

    public static partial class PCG
    {

        [MethodImpl(Inline)]
        public static void pcg_unique_32_step_r(pcg_state_32 rng)
            => rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_32 + (uint32_t)(rng.oid | 1u);

        [MethodImpl(Inline)]
        public static void pcg_unique_32_advance_r(pcg_state_32 rng, uint32_t delta)        
            => rng.state = pcg_advance_lcg_32(rng.state, delta, PCG_DEFAULT_MULTIPLIER_32, rng.oid | 1u);
        
        [MethodImpl(Inline)]
        public static uint16_t pcg_unique_32_xsh_rs_16_random_r(pcg_state_32 rng)
        {
            uint32_t oldstate = rng.state;
            pcg_unique_32_step_r(rng);
            return pcg_output_xsh_rs_32_16(oldstate);
        }        
        
        [MethodImpl(Inline)]
        public static uint16_t pcg_unique_32_xsh_rr_16_random_r(pcg_state_32 rng)
        {
            uint32_t oldstate = rng.state;
            pcg_unique_32_step_r(rng);
            return pcg_output_xsh_rr_32_16(oldstate);
        }

        [MethodImpl(Inline)]
        public static uint32_t pcg_unique_32_rxs_m_xs_32_random_r(pcg_state_32 rng)
        {
            uint32_t oldstate = rng.state;
            pcg_unique_32_step_r(rng);
            return pcg_output_rxs_m_xs_32_32(oldstate);
        }

        [MethodImpl(Inline)]
        public static void pcg_unique_32_srandom_r(pcg_state_32 rng, uint32_t initstate)
        {
            rng.state = 0;
            pcg_unique_32_step_r(rng);
            rng.state += initstate;
            pcg_unique_32_step_r(rng);
        } 
    }

}