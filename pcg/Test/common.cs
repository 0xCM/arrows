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

    public static partial class PCGTest
    {

        static string FormatHexColumns<T>(this Span<T> src)
            where T : struct                   
            => src.MapRange(0, src.Length, x => gmath.hexstring(x)).Concat(" | ");
            
        static void PrintFooter()
        {
            print(new string('-',80));
        }        

        static string PrintHeader([CallerMemberName] string caller = null)
        {
            print();    
            print(caller);
            print(new string('-',80));
            return caller;
        }

        static void Cycles(int count, Action<int> f)
        {
            for(var cycle=1; cycle<= count; cycle++)
            {
                print($"Round {cycle}:");             
                f(cycle);
                print("");
            }
        }

        public enum TestStep
        {
            Sample,

            Resample,

            Coins,


            Rolls

        }

        public static class TestConfig
        {
            public static TestConfig<S,T> Define<S,T>(S BatchSize, S Seed, S? TossCount = null, S? RollCount = null, T? CoinLimit = null, T? DiceLimit = null)            
                where S : struct
                where T : struct
                    => new TestConfig<S, T>
                    {
                        BatchSize = BatchSize,
                        Seed = new S[]{Seed},
                        TossCount = TossCount ?? convert<int,S>(64),
                        RollCount = RollCount ?? convert<int,S>(33),
                        CoinLimit = CoinLimit ?? convert<int,T>(2),
                        DiceLimit = DiceLimit ?? convert<int,T>(6)
                    };
        }

        public class TestConfig<S,T>
            where S : struct
            where T : struct
        {
            public S BatchSize {get; set;}

            public S[] Seed {get; set;}

            public S TossCount {get;set;}

            public S RollCount {get;set;}

            public T CoinLimit {get;set;}

            public T DiceLimit {get;set;}

            public int Cycles {get;}
                = 5;

            public LabelFormatSpec FormatSpec {get;}
                = new LabelFormatSpec{LeftPadWidth = 10};
        }

    }
}