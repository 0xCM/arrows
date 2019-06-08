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
    using uint32_t = System.UInt32;
    using uint64_t = System.UInt64;
    using pcg32_random_t = PCG.pcg_state_setseq_64;
    using static PCG;

    public static partial class PCG
    {


        [MethodImpl(Inline)]
        public static uint8_t pcg_output_rxs_m_16_8(uint16_t state)
            => (byte)((((state >> ((state >> 13) + 3)) ^ state) * 62169u) >> 8);


       [MethodImpl(Inline)]
        public static uint16_t pcg_output_rxs_m_32_16(uint state)
        {
            var m = 277803737u;
            int a = (int) ((state >> 28) + 4);
            uint b = (state >> a) ^ state;
            uint64_t c = (b * m) >> 16;            
            return (uint16_t)c;
        }            

        [MethodImpl(Inline)]
        public static uint pcg_output_rxs_m_64_32(uint64_t state)
        {
            var m = 12605985483714917081ul;
            int a = (int) ((state >> 59) + 5);
            uint64_t b = (state >> a) ^ state;
            uint64_t c = (b * m) >> 32;            
            return (uint)c;        
        }

        [MethodImpl(Inline)]
        public static uint8_t pcg_output_xsh_rr_16_8(uint16_t state)        
            => pcg_rotr_8((uint8_t)(((state >> 5) ^ state) >> 5), (uint)(state >> 13));

        [MethodImpl(Inline)]
        public static uint32_t pcg_output_xsl_rr_64_32(uint64_t state)
            => pcg_rotr_32(((uint)(state >> 32)) ^ (uint)state, (uint)(state >> 59));


        [MethodImpl(Inline)]
        public static uint pcg_output_rxs_m_xs_32_32(uint state)
        {
            uint word = ((state >> (int)((state >> 28) + 4)) ^ state) * 277803737u;
            return (word >> 22) ^ word;
        }

        /*
            inline uint pcg_output_xsh_rr_64_32(uint64_t state)
            {
                return pcg_rotr_32(((state >> 18u) ^ state) >> 27u, state >> 59u);
            }
        
         */


        [MethodImpl(Inline)]
        public static uint pcg_output_xsh_rr_64_32(uint64_t state)
        {
            uint64_t src = ((state >> 18) ^ state) >> 27;
            uint rot = (uint)(state >> 59);
            uint dst = pcg_rotr_32((uint)src, rot);
            return dst;            
        }


        /*
            inline uint16_t pcg_output_xsh_rs_32_16(uint state)
            {
                return (uint16_t)(((state >> 11u) ^ state) >> ((state >> 30u) + 11u));
            }        
        */
        [MethodImpl(Inline)]
        public static uint16_t pcg_output_xsh_rs_32_16(uint state)
        {
            uint src = (state >> 11) ^ state;
            int shift = (int) ((state >> 30) + 11);
            uint dst = src >> shift;
            return (uint16_t)dst;
        }

        /*
            inline uint pcg_output_xsh_rs_64_32(uint64_t state)
            {

                return (uint)(((state >> 22u) ^ state) >> ((state >> 61u) + 22u));
            }
        
         */
        [MethodImpl(Inline)]
        public static uint16_t pcg_output_xsh_rr_32_16(uint state)        
        {   
            uint xor = (state >> 10) ^ state;
            int shift = (int)((state >> 12) + 28);
            uint c = xor >> shift;
            return (uint16_t)c;
        }
            
        /**  
            inline uint pcg_output_xsh_rs_64_32(uint64_t state)
            {
                return (uint)(((state >> 22u) ^ state) >> ((state >> 61u) + 22u));
            }                
        **/
        [MethodImpl(Inline)]
        public static uint pcg_output_xsh_rs_64_32(uint64_t state)
        {
            var xor = (state >> 22) ^ state;
            var shift = (int)((state >> 61) + 22);
            var c = xor >> shift;
            return (uint)c;
        }


        /*
            inline uint8_t pcg_output_xsh_rs_16_8(uint16_t state)
            {
                return (uint8_t)(((state >> 7u) ^ state) >> ((state >> 14u) + 3u));
            }
        */
        [MethodImpl(Inline)]
        public static uint8_t pcg_output_xsh_rs_16_8(uint16_t state)
        {
            var src = (uint16_t)(state >> 7 ^ state);
            var shift = state >> 14 + 3;
            var dst = (uint16_t)(src >> shift);
            return (uint8_t)dst;                            
        }

        public static uint64_t pcg_output_xsl_rr_rr_64_64(uint64_t state)
        {
            var rot1 = (uint)(state >> 59);
            var high = (uint)(state >> 32);
            var low  = (uint)state;
            var xored = high ^ low;
            var newlow  = pcg_rotr_32(xored, rot1);
            var newhigh = pcg_rotr_32(high, newlow & 31u);
            return (((uint64_t)newhigh) << 32) | newlow;
        }


    }
}