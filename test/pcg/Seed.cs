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
        public static void pcg_unique_8_srandom_r(pcg_state_8 rng, uint8_t initstate)
        {
            rng.state = 0;
            pcg_unique_8_step_r(rng);
            rng.state += initstate;
            pcg_unique_8_step_r(rng);
        }

        [MethodImpl(Inline)]
        public static void pcg_mcg_32_srandom_r(pcg_state_32 rng, uint32_t initstate)
            => rng.state = initstate | 1u;
        

        [MethodImpl(Inline)]
        public static void pcg_setseq_64_srandom_r(pcg_state_setseq_64 rng, uint64_t initstate, uint64_t initseq)
        {
            rng.state = 0;
            rng.inc = (initseq << 1) | 1u;
            pcg_setseq_64_step_r(rng);
            rng.state += initstate;
            pcg_setseq_64_step_r(rng);
        }

        [MethodImpl(Inline)]
        public static void pcg_mcg_64_srandom_r(pcg_state_64 rng, uint64_t initstate)        
            => rng.state = initstate | 1u;


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