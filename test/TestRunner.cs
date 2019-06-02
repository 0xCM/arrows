//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using Z0.Test;
    
    using static zfunc;    
    using static math;
    using static ansi;

    public class TestRunner : Context
    {

        public TestRunner()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
        }
       
         // Converts an array of bytes into a long.  
        static long ToInt64(byte[] value, int startIndex)
        {

            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }


        public static void Run()
        {
            var app = new TestRunner();
            gmath.one<byte>();
            try
            {
                TestTools.RunTests(string.Empty, false);

            }
            catch (Exception e)
            {
                app.NotifyError(e);
            }

        }

        static void Main(params string[] args)
                => Run();

    }

}