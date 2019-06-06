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

        public static IEnumerable<uint32_t> pcg_mcg_64_rxs_m_32_boundedrand_r_stream(pcg_state_64 rng, uint32_t bound)
        {
            while(true)            
                yield return pcg_mcg_64_rxs_m_32_boundedrand_r(rng, bound);
        }
        public static IEnumerable<uint32_t> pcg_setseq_64_xsh_rr_32_random_r_stream(pcg_state_setseq_64 rng)
        {
            while(true)
                yield return pcg_setseq_64_xsh_rr_32_random_r(rng);
        }

        public static IEnumerable<uint32_t> pcg_mcg_64_rxs_m_32_random_r_stream(pcg_state_64 rng)
        {
            while(true)
                yield return pcg_mcg_64_rxs_m_32_random_r(rng);
        }

        public static IEnumerable<uint32_t> pcg_setseq_64_xsh_rr_32_boundedrand_r_stream(pcg_state_64 rng, uint32_t bound)
        {
            while(true)
                yield return pcg_mcg_64_rxs_m_32_boundedrand_r(rng, bound);
        }


        public static IEnumerable<uint32_t> pcg_setseq_64_xsh_rr_32_boundedrand_r_stream(pcg_state_setseq_64 rng, uint32_t bound)
        {
            while(true)
                yield return pcg_setseq_64_xsh_rr_32_boundedrand_r(rng, bound);
        }

        public static IEnumerable<uint16_t> pcg_unique_32_xsh_rs_16_random_r_stream(pcg_state_32 rng)
        {
            while(true)
                yield return pcg_unique_32_xsh_rs_16_random_r(rng);
        }


    }

}