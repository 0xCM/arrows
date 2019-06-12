//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Bench;

    using static zfunc;    

    public enum RunKind
    {
        All,
        Bench,
        Test
    }

    class Runner : Context
    {

        public Runner()
            :base(Z0.XOrStarStar256.define(Seed256.BenchSeed))
        {
            
        }
        

         // Converts an array of bytes into a long.  
        static long ToInt64(byte[] value, int startIndex)
        {
            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }


        void RunTests()
            => TestRunner.Run();

        void RunBench()
            => BenchRunner.Run();

        public static void Run(RunKind kind = RunKind.All)
        {
            var app = new Runner();
            try
            {
                gmath.init();
                if (kind == RunKind.Test)
                    app.RunTests();
                else if (kind == RunKind.Bench)
                    app.RunBench();
                else
                {
                    app.RunTests();
                    app.RunBench();
                }

            }
            catch (Exception e)
            {
                app.NotifyError(e);
            }
        }

        static void Dispatch(params string[] args)
        {
            if(args.Length == 0)
                Run(RunKind.All);
            else
                foreach (var arg in args)
                    Run(parseEnum<RunKind>(arg));
        }

        static void Main(params string[] args)
        {
            Dispatch(args);
        }

    }

}