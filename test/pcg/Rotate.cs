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
        [MethodImpl(Inline)]
        public static uint8_t pcg_rotr_8(uint8_t value, uint rot)
        {
            var lhs = value >> (int)rot;
            var rhs = value << (int)((~rot & 7))  + 1;
            return (uint8_t)(lhs | rhs);
        }            

        [MethodImpl(Inline)]
        public static uint16_t pcg_rotr_16(uint16_t value, uint rot)
        {
            var lhs = value >> (int)rot;
            var rhs = value << (int)((~rot & 15))  + 1;
            return (uint16_t)(lhs | rhs);
        }            

        [MethodImpl(Inline)]
        public static uint32_t pcg_rotr_32(uint32_t value, uint rot)
        {            
            var lhs = value >> (int)rot;
            var rhs = value << (int)(~rot & 31) + 1;
            return lhs | rhs;
        }            

        [MethodImpl(Inline)]
        public static uint64_t pcg_rotr_64(uint64_t value, uint rot)
        {
            var lhs = value >> (int)rot;
            var rhs = value << (int)(~(rot& 63) ) + 1;
            return lhs | rhs;
        }            
    }

}