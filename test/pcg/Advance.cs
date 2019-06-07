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

       public static byte pcg_advance_lcg_8(byte state, byte delta, byte cur_mult, byte cur_plus)
        {
            byte acc_mult = 1;
            byte acc_plus = 0;
            while (delta > 0) 
            {
                if ((delta & 1) !=0) 
                {
                    acc_mult *= cur_mult;
                    acc_plus = (byte) (acc_plus * cur_mult + cur_plus);
                }
                cur_plus = (byte) ((cur_mult + 1) * cur_plus);
                cur_mult *= cur_mult;
                delta /= 2;
            }
            return (byte) (acc_mult * state + acc_plus);
        }

        public static ushort pcg_advance_lcg_16(ushort state, ushort delta, ushort cur_mult, ushort cur_plus)
        {
            ushort acc_mult = 1;
            ushort acc_plus = 0;
            while (delta > 0) 
            {
                if ((delta & 1) !=0) 
                {
                    acc_mult *= cur_mult;
                    acc_plus = (ushort) (acc_plus * cur_mult + cur_plus);
                }
                cur_plus = (ushort) ((cur_mult + 1) * cur_plus);
                cur_mult *= cur_mult;
                delta /= 2;
            }
            return (ushort) (acc_mult * state + acc_plus);
        }

        public static uint pcg_advance_lcg_32(uint state, uint delta, uint cur_mult, uint cur_plus)
        {
            uint acc_mult = 1;
            uint acc_plus = 0;
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

        public static ulong pcg_advance_lcg_64(ulong state, ulong delta, ulong cur_mult, ulong cur_plus)
        {
            ulong acc_mult = 1u;
            ulong acc_plus = 0u;
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
 
 
        [MethodImpl(Inline)]
        public static void pcg_mcg_32_advance_r(pcg_state_32 rng, uint delta)
            => rng.state = pcg_advance_lcg_32(rng.state, delta, PCG_DEFAULT_MULTIPLIER_32, 0u);

        [MethodImpl(Inline)]
        public static void pcg_setseq_64_advance_r(pcg_state_setseq_64 rng, ulong delta)        
            => rng.state = pcg_advance_lcg_64(rng.state, delta, PCG_DEFAULT_MULTIPLIER_64, rng.inc);

        [MethodImpl(Inline)]
        public static void pcg_mcg_64_advance_r(pcg_state_64 rng, ulong delta)
            => rng.state = pcg_advance_lcg_64(rng.state, delta, PCG_DEFAULT_MULTIPLIER_64, 0u); 
 
         [MethodImpl(Inline)]
        public static void pcg_oneseq_8_advance_r(pcg_state_8 rng, byte delta)
            => rng.state = pcg_advance_lcg_8(rng.state, delta, PCG_DEFAULT_MULTIPLIER_8, PCG_DEFAULT_INCREMENT_8);

        [MethodImpl(Inline)]
        public static void pcg_mcg_8_advance_r(pcg_state_8 rng, byte delta)
            => rng.state = pcg_advance_lcg_8(rng.state, delta, PCG_DEFAULT_MULTIPLIER_8, 0);

        [MethodImpl(Inline)]
        public static void pcg_unique_8_advance_r(pcg_state_8 rng, byte delta)        
            => rng.state = pcg_advance_lcg_8(rng.state, delta, PCG_DEFAULT_MULTIPLIER_8, (byte)(rng.oid | 1u));

        [MethodImpl(Inline)]
        public static void pcg_unique_32_advance_r(pcg_state_32 rng, uint delta)        
            => rng.state = pcg_advance_lcg_32(rng.state, delta, PCG_DEFAULT_MULTIPLIER_32, rng.oid | 1u);

    }

}