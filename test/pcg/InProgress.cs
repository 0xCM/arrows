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

        /*
            inline uint8_t pcg_output_xsh_rs_16_8(uint16_t state)
            {
                return (uint8_t)(((state >> 7u) ^ state) >> ((state >> 14u) + 3u));
            }
        */
        [MethodImpl(Inline)]
        public static uint8_t pcg_output_xsh_rs_16_8(uint16_t state)
        {
            uint16_t src = (uint16_t)(state >> 7 ^ state);
            int32_t shift = state >> 14 + 3;
            uint16_t dst = (uint16_t)(src >> shift);
            return (uint8_t)dst;                            
        }

        /*
            inline uint16_t pcg_output_xsh_rs_32_16(uint32_t state)
            {
                return (uint16_t)(((state >> 11u) ^ state) >> ((state >> 30u) + 11u));
            }        
        */


        [MethodImpl(Inline)]
        public static uint16_t pcg_output_xsh_rs_32_16(uint32_t state)
        {
            uint32_t src = (state >> 11) ^ state;
            int32_t shift = (int32_t) ((state >> 30) + 11);
            uint32_t dst = src >> shift;
            return (uint16_t)dst;
        }

        /*
            inline uint32_t pcg_output_xsh_rs_64_32(uint64_t state)
            {

                return (uint32_t)(((state >> 22u) ^ state) >> ((state >> 61u) + 22u));
            }
        
         */
        [MethodImpl(Inline)]
        public static uint16_t pcg_output_xsh_rr_32_16(uint32_t state)        
        {   
            uint32_t xor = (state >> 10) ^ state;
            int32_t shift = (int32_t)((state >> 12) + 28);
            uint32_t c = xor >> shift;
            return (uint16_t)c;
        }
            
        /**  
            inline uint32_t pcg_output_xsh_rs_64_32(uint64_t state)
            {
                return (uint32_t)(((state >> 22u) ^ state) >> ((state >> 61u) + 22u));
            }                
        **/
        [MethodImpl(Inline)]
        public static uint32_t pcg_output_xsh_rs_64_32(uint64_t state)
        {
            uint64_t xor = (state >> 22) ^ state;
            int32_t shift = (int32_t)((state >> 61) + 22);
            uint64_t c = xor >> shift;
            return (uint32_t)c;
        }


        [MethodImpl(Inline)]
        public static uint32_t pcg_oneseq_64_xsh_rs_32_random_r(pcg_state_64 rng)
        {
            uint64_t oldstate = rng.state;
            pcg_oneseq_64_step_r(rng);
            return pcg_output_xsh_rs_64_32(oldstate);
        }


        [MethodImpl(Inline)]
        public static void pcg_oneseq_64_step_r(pcg_state_64 rng)            
            =>  rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_64 + PCG_DEFAULT_INCREMENT_64;
            
        /*
            inline uint32_t pcg_output_xsh_rr_64_32(uint64_t state)
            {
                return pcg_rotr_32(((state >> 18u) ^ state) >> 27u, state >> 59u);
            }
        
         */

        [MethodImpl(Inline)]
        public static uint32_t pcg_output_xsh_rr_64_32(uint64_t state)
        {
            uint64_t src = ((state >> 18) ^ state) >> 27;
            uint32_t rot = (uint32_t)(state >> 59);
            uint32_t dst = pcg_rotr_32((uint32_t)src, rot);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static void pcg_mcg_16_step_r(pcg_state_16 rng)        
            => rng.state = (uint16_t)(rng.state * PCG_DEFAULT_MULTIPLIER_16);
        
        [MethodImpl(Inline)]
        public static uint8_t pcg_mcg_16_xsh_rs_8_random_r(pcg_state_16 rng)
        {
            uint16_t oldstate = rng.state;
            pcg_mcg_16_step_r(rng);
            return pcg_output_xsh_rs_16_8(oldstate);
        }

        
        [MethodImpl(Inline)]
        public static uint16_t pcg_mcg_32_xsh_rs_16_random_r(pcg_state_32 rng)
        {
            uint32_t oldstate = rng.state;
            pcg_mcg_32_step_r(rng);
            return pcg_output_xsh_rs_32_16(oldstate);
        }


        [MethodImpl(Inline)]
        public static uint32_t pcg_setseq_64_rxs_m_32_random_r(pcg_state_setseq_64 rng)
        {
            uint64_t oldstate = rng.state;
            pcg_setseq_64_step_r(rng);
            return pcg_output_rxs_m_64_32(oldstate);
        }


        [MethodImpl(Inline)]
        public static void pcg_mcg_32_srandom_r(pcg_state_32 rng, uint32_t initstate)
            => rng.state = initstate | 1u;
        
        [MethodImpl(Inline)]
        public static void pcg_mcg_32_step_r(pcg_state_32 rng)
            => rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_32;

        [MethodImpl(Inline)]
        public static void pcg_mcg_32_advance_r(pcg_state_32 rng, uint32_t delta)
            => rng.state = pcg_advance_lcg_32(rng.state, delta, PCG_DEFAULT_MULTIPLIER_32, 0u);

        [MethodImpl(Inline)]
        public static uint32_t pcg_output_rxs_m_xs_32_32(uint32_t state)
        {
            uint32_t word = ((state >> (int)((state >> 28) + 4)) ^ state) * 277803737u;
            return (word >> 22) ^ word;
        }

        [MethodImpl(Inline)]
        public static void pcg_setseq_64_step_r(pcg_state_setseq_64 rng)        
            => rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_64 + rng.inc;
        

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
        public static uint32_t pcg_setseq_64_xsh_rr_32_random_r(pcg_state_setseq_64 rng)
        {
            uint64_t oldstate = rng.state;
            pcg_setseq_64_step_r(rng);
            return pcg_output_xsh_rr_64_32(oldstate);
        }

        [MethodImpl(Inline)]
        public static void pcg_setseq_64_advance_r(pcg_state_setseq_64 rng, uint64_t delta)        
            => rng.state = pcg_advance_lcg_64(rng.state, delta, PCG_DEFAULT_MULTIPLIER_64, rng.inc);
        
        [MethodImpl(Inline)]
        public static void pcg_mcg_64_step_r(pcg_state_64 rng)
            => rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_64;

        [MethodImpl(Inline)]
        public static uint32_t pcg_mcg_64_xsh_rr_32_random_r(pcg_state_64 rng)
        {
            uint64_t oldstate = rng.state;
            pcg_mcg_64_step_r(rng);
            return pcg_output_xsh_rr_64_32(oldstate);
        }

        [MethodImpl(Inline)]
        public static void pcg_mcg_64_srandom_r(pcg_state_64 rng, uint64_t initstate)        
            => rng.state = initstate | 1u;

        [MethodImpl(Inline)]
        public static void pcg_mcg_64_advance_r(pcg_state_64 rng, uint64_t delta)
            => rng.state = pcg_advance_lcg_64(rng.state, delta, PCG_DEFAULT_MULTIPLIER_64, 0u);

        
        [MethodImpl(Inline)]
        public static uint16_t pcg_output_rxs_m_32_16(uint32_t state)
        {
            var m = 277803737u;
            int32_t a = (int32_t) ((state >> 28) + 4);
            uint32_t b = (state >> a) ^ state;
            uint64_t c = (b * m) >> 16;            
            return (uint16_t)c;

        }
            

        [MethodImpl(Inline)]
        public static uint32_t pcg_output_rxs_m_64_32(uint64_t state)
        {
            var m = 12605985483714917081ul;
            int32_t a = (int32_t) ((state >> 59) + 5);
            uint64_t b = (state >> a) ^ state;
            uint64_t c = (b * m) >> 32;            
            return (uint32_t)c;        
        }


        [MethodImpl(Inline)]
        public static uint32_t pcg_mcg_64_rxs_m_32_random_r(pcg_state_64 rng)
        {
            uint64_t oldstate = rng.state;
            pcg_mcg_64_step_r(rng);
            return pcg_output_rxs_m_64_32(oldstate);
        }
 
    }

 
}