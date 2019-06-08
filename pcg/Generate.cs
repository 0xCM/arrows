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
    using static PCG;
    using uint8_t = System.Byte;
    using uint16_t = System.UInt16;
    using uint32_t = System.UInt32;
    using uint64_t = System.UInt64;

    partial class PCG
    {

        [MethodImpl(Inline)]
        public static byte pcg_mcg_16_xsh_rs_8_random_r(pcg_state_16 rng)
        {
            var oldstate = rng.state;
            pcg_mcg_16_step_r(rng);
            return pcg_output_xsh_rs_16_8(oldstate);
        }

        public static byte pcg_mcg_16_rxs_m_8_boundedrand_r(pcg_state_16 rng, uint8_t bound)
        {
            var threshold = (byte)(((~bound) + 1) % bound);
            for (;;) {
                uint8_t r = pcg_mcg_16_rxs_m_8_random_r(rng);
                if (r >= threshold)
                    return (byte)(r % bound);
            }
        }

        public static uint8_t pcg_mcg_16_rxs_m_8_random_r(pcg_state_16 rng)
        {
            uint16_t oldstate = rng.state;
            pcg_mcg_16_step_r(rng);
            return pcg_output_rxs_m_16_8(oldstate);
        }

        public static byte pcg_mcg_16_xsh_rs_8_boundedrand_r(pcg_state_16 rng, byte bound)
        {
            var threshold = (byte)(((~bound) + 1) % bound);
            for (;;) 
            {
                var r = pcg_mcg_16_xsh_rs_8_random_r(rng);
                if (r >= threshold)
                    return (byte) (r % bound);
            }
        }
        

        [MethodImpl(Inline)]
        public static uint32_t pcg_setseq_64_xsh_rr_32_random_r(pcg_state_setseq_64 rng)
        {
            uint64_t oldstate = rng.state;
            pcg_setseq_64_step_r(rng);
            return pcg_output_xsh_rr_64_32(oldstate);
        }

        [MethodImpl(Inline)]
        public static uint pcg_mcg_64_xsh_rr_32_random_r(pcg_state_64 rng)
        {
            var oldstate = rng.state;
            pcg_mcg_64_step_r(rng);
            return pcg_output_xsh_rr_64_32(oldstate);
        }

        [MethodImpl(Inline)]
        public static uint pcg_oneseq_64_xsh_rs_32_random_r(pcg_state_64 rng)
        {
            var oldstate = rng.state;
            pcg_oneseq_64_step_r(rng);
            return pcg_output_xsh_rs_64_32(oldstate);
        }


        [MethodImpl(Inline)]
        public static ushort pcg_mcg_32_xsh_rs_16_random_r(pcg_state_32 rng)
        {
            var oldstate = rng.state;
            pcg_mcg_32_step_r(rng);
            return pcg_output_xsh_rs_32_16(oldstate);
        }


        [MethodImpl(Inline)]
        public static uint pcg_setseq_64_rxs_m_32_random_r(pcg_state_setseq_64 rng)
        {
            var oldstate = rng.state;
            pcg_setseq_64_step_r(rng);
            return pcg_output_rxs_m_64_32(oldstate);
        }

        [MethodImpl(Inline)]
        public static uint pcg_mcg_64_rxs_m_32_random_r(pcg_state_64 rng)
        {
            var oldstate = rng.state;
            pcg_mcg_64_step_r(rng);
            return pcg_output_rxs_m_64_32(oldstate);
        }

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
        public static ulong pcg_oneseq_64_xsl_rr_rr_64_random_r(pcg_state_64 rng)
        {
            var oldstate = rng.state;
            pcg_oneseq_64_step_r(rng);
            return pcg_output_xsl_rr_rr_64_64(oldstate);
        }

        public static uint pcg_mcg_64_rxs_m_32_boundedrand_r(pcg_state_64 rng, uint bound)
        {
            var threshold = (~bound + 1) % bound;
            for (;;) 
            {
                var r = pcg_mcg_64_rxs_m_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

        public static ushort pcg_unique_32_xsh_rr_16_boundedrand_r(pcg_state_32 rng, ushort bound)
        {
            var threshold = (ushort)(((~bound) + 1) % bound);
            for (;;) 
            {
                var r = pcg_unique_32_xsh_rr_16_random_r(rng);
                if (r >= threshold)
                    return (ushort)(r % bound);
            }
        }

        public static uint pcg_mcg_64_xsl_rr_32_random_r(pcg_state_64 rng)
        {
            uint64_t oldstate = rng.state;
            pcg_mcg_64_step_r(rng);
            return pcg_output_xsl_rr_64_32(oldstate);
        }

        public static uint pcg_mcg_64_xsl_rr_32_boundedrand_r(pcg_state_64 rng, uint32_t bound)
        {
            uint32_t threshold = (~bound + 1) % bound;
            for (;;) {
                uint32_t r = pcg_mcg_64_xsl_rr_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

        public static uint pcg_mcg_64_xsh_rr_32_boundedrand_r(pcg_state_64 rng, uint bound)
        {
            var threshold = (~bound + 1) % bound;
            for (;;) 
            {
                var r = pcg_mcg_64_xsh_rr_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

        public static uint pcg_oneseq_64_xsh_rs_32_boundedrand_r(pcg_state_64 rng, uint bound)
        {
            var threshold = (~bound + 1) % bound;
            for (;;) 
            {
                var r = pcg_oneseq_64_xsh_rs_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

        public static ushort pcg_mcg_32_xsh_rs_16_boundedrand_r(pcg_state_32 rng, ushort bound)
        {
            var threshold = (ushort)(((~bound) + 1) % bound);
            for (;;) 
            {
                var r = pcg_mcg_32_xsh_rs_16_random_r(rng);
                if (r >= threshold)
                    return (ushort) (r % bound);
            }
        }

        public static uint pcg_setseq_64_rxs_m_32_boundedrand_r(pcg_state_setseq_64 rng, uint bound)
        {
            var threshold = (~bound + 1) % bound;
            for (;;) 
            {
                var r = pcg_setseq_64_rxs_m_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

        public static ushort pcg_unique_32_xsh_rs_16_boundedrand_r(pcg_state_32 rng, ushort bound)
        {
            var threshold = (ushort)(((~bound) + 1) % bound);
            for (;;) 
            {
                var r = pcg_unique_32_xsh_rs_16_random_r(rng);
                if (r >= threshold)
                    return (ushort)(r % bound);
            }
        }

        public static uint pcg_setseq_64_xsh_rr_32_boundedrand_r(pcg_state_setseq_64 rng, uint bound)
        {
            var threshold = (~bound + 1) % bound;
            for (;;) 
            {
                var r = pcg_setseq_64_xsh_rr_32_random_r(rng);
                if (r >= threshold)
                return r % bound;
            }
        }

        public static uint pcg_unique_32_rxs_m_xs_32_boundedrand_r(pcg_state_32 rng, uint bound)
        {
            var threshold = (uint)((~bound + 1) % bound);
            for (;;) 
            {
                var r = pcg_unique_32_rxs_m_xs_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }
  
        public static uint64_t pcg_oneseq_64_xsl_rr_rr_64_boundedrand_r(pcg_state_64 rng, uint64_t bound)
        {
            uint64_t threshold = (~bound + 1) % bound;
            for (;;) {
                uint64_t r = pcg_oneseq_64_xsl_rr_rr_64_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

 
    }
}