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

        public static void test_pcg_mcg_64_rxs_m_32()
        {
            print();    
            print($"{MethodBase.GetCurrentMethod().Name}");
            print(new string('-',80));

            var rng = new pcg_state_64();
            pcg_mcg_64_srandom_r(rng,42);
            var stream = pcg_mcg_64_rxs_m_32_random_r_stream(rng);
            Func<pcg_state_64, uint, IEnumerable<uint>> bounded = pcg_mcg_64_rxs_m_32_boundedrand_r_stream;
            
            var batch1 = stream.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch1);
            
            pcg_mcg_64_advance_r(rng, ~5ul);
            var batch2 = stream.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch2);
            
            var coins = bounded(rng,2).Take(65).Select(x => x == 1 ? 'H' : 'T').Concat();
            print(Labels.Label(coins, "Coins"));

            var rolls = bounded(rng,6).Take(33).Select(x =>  (x + 1)).ToCharacterDigits().Concat(' ');
            print(Labels.Label(rolls, "Rolls"));
            
            print(new string('-',80));


        }


    }
}