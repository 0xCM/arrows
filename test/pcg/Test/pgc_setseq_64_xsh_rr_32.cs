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
        /*
            #define XX_SRANDOM_SEEDCONSTS       42u, 54u
            #define XX_SRANDOM(...)             \
                        pcg_setseq_64_srandom_r(&rng, __VA_ARGS__)
            #define XX_RANDOM()                 \
                        pcg_setseq_64_xsh_rr_32_random_r(&rng)
            #define XX_BOUNDEDRAND(bound)       \
                        pcg_setseq_64_xsh_rr_32_boundedrand_r(&rng, bound)
            #define XX_ADVANCE(delta)           \
                        pcg_setseq_64_advance_r(&rng, delta)                
         */        


        static string FormatHexColumns<T>(Span<T> src)
            where T : struct                   
            => src.MapRange(0, src.Length, x => gmath.hexstring(x)).Concat(" | ");
            
        

        public static void test_pcg_setseq_64_xsh_rr_32()
        {
            print();    
            print($"{MethodBase.GetCurrentMethod().Name}");
            print(new string('-',80));

            Func<pcg_state_setseq_64> factory = () => new pcg_state_setseq_64();
            Action<pcg_state_setseq_64, ulong, ulong> init = pcg_setseq_64_srandom_r;
            Func<pcg_state_setseq_64, uint> rand = pcg_setseq_64_xsh_rr_32_random_r;
            Action<pcg_state_setseq_64, ulong> advance = pcg_setseq_64_advance_r;
            Func<pcg_state_setseq_64, IEnumerable<uint>> stream = pcg_setseq_64_xsh_rr_32_random_r_stream;
            Func<pcg_state_setseq_64, uint, IEnumerable<uint>> bounded = pcg_setseq_64_xsh_rr_32_boundedrand_r_stream;
            
            var rng = factory();
            init(rng, 42, 54);
            
            for(var round = 1; round <=5; round++)
            {
                print($"Round {round}:");
                
                print(FormatHexColumns(stream(rng).TakeSpan(6)));

                advance(rng, ~5ul);
                
                print(FormatHexColumns(stream(rng).TakeSpan(6)));

                var coins = bounded(rng,2).Take(65).Select(x => x == 1 ? 'H' : 'T').Concat();
                print(Labels.Label(coins, "Coins"));


                var rolls = bounded(rng,6).Take(33).Select(x =>  (x + 1)).ToCharacterDigits().Concat(' ');
                print(Labels.Label(rolls, "Rolls"));                

                advance(rng, 51ul);
                print("");
            }

        }


        public static void Demo3()
        {
            print();    
            print("pcg_unique_32_xsh_rs_16");
            print(new string('-',80));

            var rng = new pcg_state_32();            
            pcg_unique_32_srandom_r(rng,42);
            var stream = pcg_unique_32_xsh_rs_16_random_r_stream(rng);

            var batch1 = stream.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch1);
            
            pcg_unique_32_advance_r(rng, ~5u);            
            var batch2 = stream.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch2);            
            print(new string('-',80));
            
        }

        public static void Demo4()
        {
            var x = 27ul;
            var result = pcg_output_rxs_m_64_32(x);
            print($"pcg_output_rxs_m_64_32({x}) = {result}");

        }

        public static void Demos()
        {
            test_pcg_setseq_64_xsh_rr_32();
            test_pcg_mcg_64_rxs_m_32();
        }



    }

}