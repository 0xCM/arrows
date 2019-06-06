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

    partial class PCG
    {

        public static uint32_t pcg_mcg_64_rxs_m_32_boundedrand_r(pcg_state_64 rng, uint32_t bound)
        {
            uint32_t threshold = (~bound + 1) % bound;
            for (;;) 
            {
                uint32_t r = pcg_mcg_64_rxs_m_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }


        public static uint16_t pcg_unique_32_xsh_rr_16_boundedrand_r(ref pcg_state_32 rng, uint16_t bound)
        {
            uint16_t threshold = (uint16_t)(((~bound) + 1) % bound);
            for (;;) 
            {
                uint16_t r = pcg_unique_32_xsh_rr_16_random_r(rng);
                if (r >= threshold)
                    return (uint16_t)(r % bound);
            }
        }

        public static uint8_t pcg_mcg_16_xsh_rs_8_boundedrand_r(pcg_state_16 rng, uint8_t bound)
        {
            uint8_t threshold = (uint8_t)(((~bound) + 1) % bound);
            for (;;) 
            {
                uint8_t r = pcg_mcg_16_xsh_rs_8_random_r(rng);
                if (r >= threshold)
                    return (uint8_t) (r % bound);
            }
        }
        
        public static uint32_t pcg_mcg_64_xsh_rr_32_boundedrand_r(pcg_state_64 rng, uint32_t bound)
        {
            uint32_t threshold = (~bound + 1) % bound;
            for (;;) 
            {
                uint32_t r = pcg_mcg_64_xsh_rr_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

        public static uint32_t pcg_oneseq_64_xsh_rs_32_boundedrand_r(pcg_state_64 rng, uint32_t bound)
        {
            uint32_t threshold = (~bound + 1) % bound;
            for (;;) 
            {
                uint32_t r = pcg_oneseq_64_xsh_rs_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

        public static uint16_t pcg_mcg_32_xsh_rs_16_boundedrand_r(pcg_state_32 rng, uint16_t bound)
        {
            uint16_t threshold = (uint16_t)(((~bound) + 1) % bound);
            for (;;) 
            {
                uint16_t r = pcg_mcg_32_xsh_rs_16_random_r(rng);
                if (r >= threshold)
                    return (uint16_t) (r % bound);
            }
        }

        public static uint32_t pcg_setseq_64_rxs_m_32_boundedrand_r(pcg_state_setseq_64 rng, uint32_t bound)
        {
            uint32_t threshold = (~bound + 1) % bound;
            for (;;) 
            {
                uint32_t r = pcg_setseq_64_rxs_m_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

        public static uint16_t pcg_unique_32_xsh_rs_16_boundedrand_r(pcg_state_32 rng, uint16_t bound)
        {
            uint16_t threshold = (uint16_t)(((~bound) + 1) % bound);
            for (;;) 
            {
                uint16_t r = pcg_unique_32_xsh_rs_16_random_r(rng);
                if (r >= threshold)
                    return (uint16_t)(r % bound);
            }
        }

        public static uint32_t pcg_setseq_64_xsh_rr_32_boundedrand_r(pcg_state_setseq_64 rng, uint32_t bound)
        {
            uint32_t threshold = (~bound + 1) % bound;
            for (;;) 
            {
                uint32_t r = pcg_setseq_64_xsh_rr_32_random_r(rng);
                if (r >= threshold)
                return r % bound;
            }
        }

        public static uint32_t pcg_unique_32_rxs_m_xs_32_boundedrand_r(pcg_state_32 rng, uint32_t bound)
        {
            uint32_t threshold = (uint32_t)((~bound + 1) % bound);
            for (;;) 
            {
                uint32_t r = pcg_unique_32_rxs_m_xs_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }
    }
}