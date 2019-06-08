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
    using static PCG;
    using static PCGTest.TestStep;

    partial class PCGTest
    {
        public static void mcg_16_rxs_m_8_test(TestConfig<ushort,byte> config)
        {
            var testName = PrintHeader();
            var fs = config.FormatSpec;

            var rng = new pcg_state_16();
            pcg_mcg_16_srandom_r(rng, config.Seed[0]);            
            var unbound = pcg_mcg_16_rxs_m_8_random_r_stream(rng);
            var coinSrc =  pcg_mcg_16_rxs_m_8_boundedrand_r_stream(rng, config.CoinLimit);
            var diceSrc = pcg_mcg_16_rxs_m_8_boundedrand_r_stream(rng, config.DiceLimit);

            void Cycle(int cycle)
            {
                var step = Sample;
                var batch1 = unbound.Take(config.BatchSize).Freeze();
                var batch1Format = batch1.ToHexStrings().Concat(" | ");
                print(Labels.Label(batch1Format, $"{step}", fs));
                
                step = Resample;
                var revert = math.negate(config.BatchSize);
                pcg_mcg_16_advance_r(rng, revert);                

                var batch2 = unbound.Take(config.BatchSize).Freeze();
                var batch2Format = batch2.ToHexStrings().Concat(" | ");
                print(Labels.Label(batch2Format, $"{step}", fs));
                
                step = Coins;
                var coins = coinSrc.Take(config.TossCount).Freeze();
                var coinsFormat = coins.Select(x => x == 1 ? 'H' : 'T').Concat();
                print(Labels.Label(coinsFormat, $"{step}", fs));

                step = Rolls;
                var rolls = diceSrc.Take(config.RollCount).Freeze();
                var rollsFormat = rolls.Select(x =>  (x + 1)).ToCharDigits().Concat(' ');
                print(Labels.Label(rollsFormat, $"{step}", fs));
            }

            Cycles(config.Cycles, Cycle);            
            PrintFooter();
        }

    }

}