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
    using uint16_t = System.UInt16;
    using uint32_t = System.UInt32;
    using uint64_t = System.UInt64;
    using pcg32_random_t = PCG.pcg_state_setseq_64;

    public static class PCG
    {
        public static void Demo1()
        {
            print("Demo 1");
            print("--------------------------------------");

            pcg32_random_t rng = new pcg32_random_t();
            pcg32_srandom_r(rng, 42, 54);
            
            var src = pcg32_random_r_stream(rng);
            
            var batch1 = src.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch1);


            pcg32_advance_r(rng, ~5ul);
            var batch2 = src.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch2);

            // var batch3 = pcg32_bounded_rand_r_stream(rng, 9).Take(10).Select(x => x.ToHexString()).Concat(" | ");
            // print(batch3);

            // var batch4 = pcg32_bounded_rand_r_stream(rng, 100).Take(100000);
            // var h = Histogram.define<uint>(closed(0u,100u));
            // h.Deposit(batch4,false);
            // foreach(var b in h.Buckets())
            //     print(b.ToString());
            

        }

        public static void Demo2()
        {
            print("Demo 2");
            print("pcg_mcg_64_rxs_m_32--------------------");

            var rng = new pcg_state_64();
            pcg_mcg_64_srandom_r(rng,42);
            var stream = pcg_mcg_64_rxs_m_32_random_r_stream(rng);
            
            var batch1 = stream.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch1);
            
            pcg_mcg_64_advance_r(rng, ~5ul);
            var batch2 = stream.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch2);
            
        }

        public static void Demo3()
        {
            print("Demo 3");
            print("--------------------------------------");

            var rng = new pcg_state_32();            
            pcg_unique_32_srandom_r(rng,42);
            var stream = pcg_unique_32_xsh_rs_16_random_r_stream(rng);

            var batch1 = stream.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch1);
            
            pcg_unique_32_advance_r(rng, ~5u);            
            var batch2 = stream.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch2);
            
            
        }

        public static IEnumerable<uint32_t> pcg32_random_r_stream(pcg_state_setseq_64 rng)
        {
            while(true)
                yield return pcg32_random_r(rng);
        }

        public static IEnumerable<uint32_t> pcg32_bounded_rand_r_stream(pcg_state_setseq_64 rng, uint32_t bound)
        {
            while(true)
                yield return pcg_setseq_64_xsh_rr_32_boundedrand_r(rng, bound);
        }

        public static IEnumerable<uint16_t> pcg_unique_32_xsh_rs_16_random_r_stream(pcg_state_32 rng)
        {
            while(true)
                yield return pcg_unique_32_xsh_rs_16_random_r(rng);
        }

        public static IEnumerable<uint32_t> pcg_mcg_64_rxs_m_32_random_r_stream(pcg_state_64 rng)
        {
            while(true)
                yield return pcg_mcg_64_rxs_m_32_random_r(rng);
        }

        [MethodImpl(Inline)]
        public static uint8_t pcg_rotr_8(uint8_t value, uint rot)    
            => (uint8_t)((value >> (int)rot) | (value << (int)(~ rot & 7)));

        [MethodImpl(Inline)]
        public static uint16_t pcg_rotr_16(uint16_t value, uint rot)    
            => (uint16_t)((value >> (int)rot) | (value << (int)(~ rot & 15)));

        [MethodImpl(Inline)]
        public static uint32_t pcg_rotr_32(uint32_t value, uint rot)    
            => (value >> (int)rot) | (value << (int)(~ rot & 31u));

        [MethodImpl(Inline)]
        public static uint64_t pcg_rotr_64(uint64_t value, uint rot)    
            => (value >> (int)rot) | (value << (int)(~ rot & 63));

        [MethodImpl(Inline)]
        public static uint8_t pcg_output_xsh_rs_16_8(uint16_t state)
            => (uint8_t)(((state >> 7) ^ state) >> ((state >> 14) + 3));

        [MethodImpl(Inline)]
        public static uint16_t pcg_output_xsh_rs_32_16(uint32_t state)
            => (uint16_t)(((state >> 11) ^ state) >> (int)((state >> 30) + 11u));

        [MethodImpl(Inline)]
        public static uint32_t pcg_output_xsh_rs_64_32(uint64_t state)
            => (uint32_t)(((state >> 22) ^ state) >> (int)((state >> 61) + 22u));

        [MethodImpl(Inline)]
        public static uint8_t pcg_output_xsh_rr_16_8(uint16_t state)        
            => pcg_rotr_8((uint8_t)(((state >> 5) ^ state) >> 5), (uint)(state >> 13));
        
        [MethodImpl(Inline)]
        public static uint16_t pcg_output_xsh_rr_32_16(uint32_t state)        
            => pcg_rotr_16((uint16_t)(((state >> 10) ^ state) >> 12), state >> 28);        


        [MethodImpl(Inline)]
        public static uint32_t pcg_output_xsh_rr_64_32(uint64_t state)
            => pcg_rotr_32((uint)((state >> 18) ^ state) >> 27, (uint)(state >> 59));            
        
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
        public static void pcg_unique_8_step_r(pcg_state_8 rng)
            => rng.state = (uint8_t)(rng.state * PCG_DEFAULT_MULTIPLIER_8 + (rng.oid | 1u));

        [MethodImpl(Inline)]
        public static void pcg_unique_8_srandom_r(pcg_state_8 rng, uint8_t initstate)
        {
            rng.state = 0;
            pcg_unique_8_step_r(rng);
            rng.state += initstate;
            pcg_unique_8_step_r(rng);
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

        public static uint8_t pcg_mcg_16_xsh_rs_8_boundedrand_r(pcg_state_16 rng, uint8_t bound)
        {
            uint8_t threshold = (uint8_t)(~bound % bound);
            for (;;) {
                uint8_t r = pcg_mcg_16_xsh_rs_8_random_r(rng);
                if (r >= threshold)
                    return (uint8_t) (r % bound);
            }
        }
        
        public static uint32_t pcg_mcg_64_xsh_rr_32_boundedrand_r(pcg_state_64 rng, uint32_t bound)
        {
            uint32_t threshold = ~bound % bound;
            for (;;) 
            {
                uint32_t r = pcg_mcg_64_xsh_rr_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }


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
        public static uint16_t pcg_unique_32_xsh_rs_16_boundedrand_r(pcg_state_32 rng, uint16_t bound)
        {
            uint16_t threshold = (uint16_t)(~bound % bound);
            for (;;) 
            {
                uint16_t r = pcg_unique_32_xsh_rs_16_random_r(rng);
                if (r >= threshold)
                    return (uint16_t)(r % bound);
            }
        }

        [MethodImpl(Inline)]
        public static uint16_t pcg_unique_32_xsh_rr_16_random_r(pcg_state_32 rng)
        {
            uint32_t oldstate = rng.state;
            pcg_unique_32_step_r(rng);
            return pcg_output_xsh_rr_32_16(oldstate);
        }

        [MethodImpl(Inline)]
        public static uint16_t pcg_unique_32_xsh_rr_16_boundedrand_r(ref pcg_state_32 rng, uint16_t bound)
        {
            uint16_t threshold = (uint16_t) (~bound % bound);
            for (;;) {
                uint16_t r = pcg_unique_32_xsh_rr_16_random_r(rng);
                if (r >= threshold)
                    return (uint16_t)(r % bound);
            }
        }

        [MethodImpl(Inline)]
        public static uint32_t pcg_output_rxs_m_xs_32_32(uint32_t state)
        {
            uint32_t word = ((state >> (int)((state >> 28) + 4)) ^ state) * 277803737u;
            return (word >> 22) ^ word;
        }

        [MethodImpl(Inline)]
        public static uint32_t pcg_unique_32_rxs_m_xs_32_random_r(pcg_state_32 rng)
        {
            uint32_t oldstate = rng.state;
            pcg_unique_32_step_r(rng);
            return pcg_output_rxs_m_xs_32_32(oldstate);
        }

        public static uint32_t pcg_unique_32_rxs_m_xs_32_boundedrand_r(pcg_state_32 rng, uint32_t bound)
        {
            uint32_t threshold = (uint32_t)(~bound % bound);
            for (;;) {
                uint32_t r = pcg_unique_32_rxs_m_xs_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

        [MethodImpl(Inline)]
        public static void pcg_unique_32_srandom_r(pcg_state_32 rng, uint32_t initstate)
        {
            rng.state = 0;
            pcg_unique_32_step_r(rng);
            rng.state += initstate;
            pcg_unique_32_step_r(rng);
        }

        public static uint32_t pcg_setseq_64_xsh_rr_32_boundedrand_r(pcg_state_setseq_64 rng, uint32_t bound)
        {
            uint32_t threshold = ~bound % bound;
            for (;;) 
            {
                uint32_t r = pcg_setseq_64_xsh_rr_32_random_r(rng);
                if (r >= threshold)
                return r % bound;
            }
        }

        [MethodImpl(Inline)]
        public static uint32_t pcg32_bounded_rand_r(pcg_state_setseq_64 rng, uint32_t bound)
            => pcg_setseq_64_xsh_rr_32_boundedrand_r(rng, bound);

        [MethodImpl(Inline)]
        public static void pcg_setseq_64_step_r(pcg_state_setseq_64 rng)        
            => rng.state = rng.state * PCG_DEFAULT_MULTIPLIER_64 + rng.inc;
        

        [MethodImpl(Inline)]
        static void pcg_setseq_64_srandom_r(pcg_state_setseq_64 rng, uint64_t initstate, uint64_t initseq)
        {
            rng.state = 0;
            rng.inc = (initseq << 1) | 1u;
            pcg_setseq_64_step_r(rng);
            rng.state += initstate;
            pcg_setseq_64_step_r(rng);
        }

        [MethodImpl(Inline)]
        public static void pcg32_srandom_r(pcg_state_setseq_64 rng, uint64_t initstate, uint64_t initseq)
            => pcg_setseq_64_srandom_r(rng, initstate, initseq);


        [MethodImpl(Inline)]
        public static uint32_t pcg_setseq_64_xsh_rr_32_random_r(pcg_state_setseq_64 rng)
        {
            uint64_t oldstate = rng.state;
            pcg_setseq_64_step_r(rng);
            return pcg_output_xsh_rr_64_32(oldstate);
        }

        [MethodImpl(Inline)]
        public static uint32_t pcg32_random_r(pcg_state_setseq_64 rng)
            => pcg_setseq_64_xsh_rr_32_random_r(rng);


        [MethodImpl(Inline)]
        public static void pcg_setseq_64_advance_r(pcg_state_setseq_64 rng, uint64_t delta)        
            => rng.state = pcg_advance_lcg_64(rng.state, delta, PCG_DEFAULT_MULTIPLIER_64, rng.inc);
        
        [MethodImpl(Inline)]
        public static void pcg32_advance_r(pcg_state_setseq_64 rng, uint64_t delta)
            => pcg_setseq_64_advance_r(rng, delta);


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
            => (uint16_t) ((((state >> (int)((state >> 28) + 4u)) ^ state) * 277803737u) >> 16);
        
        [MethodImpl(Inline)]
        public static uint32_t pcg_output_rxs_m_64_32(uint64_t state)
            => (uint32_t)(((state >> (int)((state >> 59) + 5u)) ^ state) * 12605985483714917081ul) >> 32;

        [MethodImpl(Inline)]
        public static uint32_t pcg_mcg_64_rxs_m_32_random_r(pcg_state_64 rng)
        {
            uint64_t oldstate = rng.state;
            pcg_mcg_64_step_r(rng);
            return pcg_output_rxs_m_64_32(oldstate);
        }

        public static uint32_t pcg_mcg_64_rxs_m_32_boundedrand_r(pcg_state_64 rng, uint32_t bound)
        {
            uint32_t threshold = ~bound % bound;
            for (;;) {
                uint32_t r = pcg_mcg_64_rxs_m_32_random_r(rng);
                if (r >= threshold)
                    return r % bound;
            }
        }

        public static uint8_t pcg_advance_lcg_8(uint8_t state, uint8_t delta, uint8_t cur_mult, uint8_t cur_plus)
        {
            uint8_t acc_mult = 1;
            uint8_t acc_plus = 0;
            while (delta > 0) 
            {
                if ((delta & 1) !=0) 
                {
                    acc_mult *= cur_mult;
                    acc_plus = (uint8_t) (acc_plus * cur_mult + cur_plus);
                }
                cur_plus = (uint8_t) ((cur_mult + 1) * cur_plus);
                cur_mult *= cur_mult;
                delta /= 2;
            }
            return (uint8_t) (acc_mult * state + acc_plus);
        }

        public static uint16_t pcg_advance_lcg_16(uint16_t state, uint16_t delta, uint16_t cur_mult, uint16_t cur_plus)
        {
            uint16_t acc_mult = 1;
            uint16_t acc_plus = 0;
            while (delta > 0) 
            {
                if ((delta & 1) !=0) 
                {
                    acc_mult *= cur_mult;
                    acc_plus = (uint16_t) (acc_plus * cur_mult + cur_plus);
                }
                cur_plus = (uint16_t) ((cur_mult + 1) * cur_plus);
                cur_mult *= cur_mult;
                delta /= 2;
            }
            return (uint16_t) (acc_mult * state + acc_plus);
        }

        public static uint32_t pcg_advance_lcg_32(uint32_t state, uint32_t delta, uint32_t cur_mult, uint32_t cur_plus)
        {
            uint32_t acc_mult = 1;
            uint32_t acc_plus = 0;
            while (delta > 0) 
            {
                if ((delta & 1) !=0) 
                {
                    acc_mult *= cur_mult;
                    acc_plus =  (acc_plus * cur_mult + cur_plus);
                }
                cur_plus = ((cur_mult + 1) * cur_plus);
                cur_mult *= cur_mult;
                delta /= 2;
            }
            return  (acc_mult * state + acc_plus);
        }

        public static uint64_t pcg_advance_lcg_64(uint64_t state, uint64_t delta, uint64_t cur_mult, uint64_t cur_plus)
        {
            uint64_t acc_mult = 1u;
            uint64_t acc_plus = 0u;
            while (delta > 0) 
            {
                if ((delta & 1)  != 0)
                {
                    acc_mult *= cur_mult;
                    acc_plus = acc_plus * cur_mult + cur_plus;
                }
                cur_plus = (cur_mult + 1) * cur_plus;
                cur_mult *= cur_mult;
                delta /= 2;
            }
            return acc_mult * state + acc_plus;
        }

        const byte PCG_DEFAULT_MULTIPLIER_8  = 141;
        
        const ushort PCG_DEFAULT_MULTIPLIER_16  = 12829;
        
        const uint PCG_DEFAULT_MULTIPLIER_32 = 747796405;
        
        const ulong PCG_DEFAULT_MULTIPLIER_64 = 6364136223846793005;

        const byte PCG_DEFAULT_INCREMENT_8 = 77;
        
        const ushort PCG_DEFAULT_INCREMENT_16 = 47989;
        
        const uint PCG_DEFAULT_INCREMENT_32 = 2891336453;
        
        const ulong PCG_DEFAULT_INCREMENT_64 = 1442695040888963407;


        public class pcg_state_8 
        {
            public pcg_state_8()
            {
                oid = (uint)GetHashCode();
            }

            public uint oid {get;}
                
            public uint8_t state;
        };

        public class pcg_state_16 
        {
            public pcg_state_16()
            {
                oid = (uint)GetHashCode();
            }

            public uint oid {get;}

            public uint16_t state;
        };

        public class pcg_state_32 
        {
            public pcg_state_32()
            {
                oid = (uint)GetHashCode();
            }

            public uint oid {get;}
            
            public uint32_t state;
        };

        public class pcg_state_64 
        {
            public pcg_state_64()
            {
                oid = (uint)GetHashCode();
            }

            public uint oid {get;}

            public uint64_t state;
        };

        public class pcg_state_setseq_8 
        {
            public uint8_t state;

            public uint8_t inc;
        };

        public class pcg_state_setseq_16 
        {
            public uint16_t state;

            public uint16_t inc;
        };

        public class pcg_state_setseq_32 
        {
            public uint32_t state;

            public uint32_t inc;
        };

        public class pcg_state_setseq_64 
        {

            public uint64_t state;

            public uint64_t inc;
        };

    }

}