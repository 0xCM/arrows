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


       [MethodImpl(Inline)]
        public static uint32_t pcg_output_rxs_m_64_32_debug(uint64_t state)
        {
            print($"state = {state}");
            
            int32_t a = (int32_t)state >> 59;
            print($"a = {a}");
            
            int32_t b = a + 5;
            print($"b = {b}");
            
            uint64_t c = state >> b;
            print($"c = {c}");

            uint64_t d = c ^ state;
            print($"d = {d}");
            
            uint64_t e = (d * 12605985483714917081ul) >> 32;
            print($"e = {e}");
            
            uint32_t f = (uint32_t)e;
            print($"f = {f}");

            return f;        
        }


    }

}