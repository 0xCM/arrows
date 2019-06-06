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
    }

}