namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
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
    using static PCG;

    public static partial class PCGTest
    {

        public static void pcg_setseq_64_xsh_rr_32_test()
        {
            PrintHeader();

            Func<pcg_state_setseq_64> factory = () => new pcg_state_setseq_64();
            Action<pcg_state_setseq_64, ulong, ulong> init = pcg_setseq_64_srandom_r;
            Func<pcg_state_setseq_64, uint> rand = pcg_setseq_64_xsh_rr_32_random_r;
            Action<pcg_state_setseq_64, ulong> advance = pcg_setseq_64_advance_r;
            Func<pcg_state_setseq_64, IEnumerable<uint>> stream = pcg_setseq_64_xsh_rr_32_random_r_stream;
            Func<pcg_state_setseq_64, uint, IEnumerable<uint>> bounded = pcg_setseq_64_xsh_rr_32_boundedrand_r_stream;
            
            var rng = factory();
            init(rng, 42, 54);

            void Cycle(int cycle)
            {
                
                print(stream(rng).TakeSpan(6).FormatHexColumns());

                advance(rng, ~5ul);
                
                print(stream(rng).TakeSpan(6).FormatHexColumns());

                var coins = bounded(rng,2).Take(65).Select(x => x == 1 ? 'H' : 'T').Concat();
                print(Labels.Label(coins, "Coins"));


                var rolls = bounded(rng,6).Take(33).Select(x =>  (x + 1)).ToCharDigits().Concat(' ');
                print(Labels.Label(rolls, "Rolls"));                

                advance(rng, 51ul);

            }

            Cycles(5, Cycle);            
        }

        public static void Demo4()
        {
            var x = 27ul;
            var result = pcg_output_rxs_m_64_32(x);
            print($"pcg_output_rxs_m_64_32({x}) = {result}");

        }




    }

}