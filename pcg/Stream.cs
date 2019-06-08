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
  
    partial class PCG
    {
        public static IEnumerable<byte> pcg_mcg_16_rxs_m_8_random_r_stream(pcg_state_16 rng)
        {
            while(true)
                yield return pcg_mcg_16_rxs_m_8_random_r(rng);
        }

        public static IEnumerable<byte> pcg_mcg_16_rxs_m_8_boundedrand_r_stream(pcg_state_16 rng, byte bound)
        {
            while(true)
                yield return pcg_mcg_16_rxs_m_8_boundedrand_r(rng, bound);
        }

        public static IEnumerable<byte> pcg_mcg_16_xsh_rs_8_boundedrand_r_stream(pcg_state_16 rng, byte bound)        
        {
            while(true)
                yield return pcg_mcg_16_xsh_rs_8_boundedrand_r(rng,bound);
        }
        
        public static IEnumerable<uint> pcg_mcg_64_rxs_m_32_boundedrand_r_stream(pcg_state_64 rng, uint bound)
        {
            while(true)            
                yield return pcg_mcg_64_rxs_m_32_boundedrand_r(rng, bound);
        }
        public static IEnumerable<uint> pcg_setseq_64_xsh_rr_32_random_r_stream(pcg_state_setseq_64 rng)
        {
            while(true)
                yield return pcg_setseq_64_xsh_rr_32_random_r(rng);
        }

        public static IEnumerable<uint> pcg_mcg_64_rxs_m_32_random_r_stream(pcg_state_64 rng)
        {
            while(true)
                yield return pcg_mcg_64_rxs_m_32_random_r(rng);
        }

        public static IEnumerable<uint> pcg_setseq_64_xsh_rr_32_boundedrand_r_stream(pcg_state_64 rng, uint bound)
        {
            while(true)
                yield return pcg_mcg_64_rxs_m_32_boundedrand_r(rng, bound);
        }


        public static IEnumerable<uint> pcg_setseq_64_xsh_rr_32_boundedrand_r_stream(pcg_state_setseq_64 rng, uint bound)
        {
            while(true)
                yield return pcg_setseq_64_xsh_rr_32_boundedrand_r(rng, bound);
        }

        public static IEnumerable<ushort> pcg_unique_32_xsh_rs_16_random_r_stream(pcg_state_32 rng)
        {
            while(true)
                yield return pcg_unique_32_xsh_rs_16_random_r(rng);
        }
 
    }

}