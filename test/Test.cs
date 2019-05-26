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
    using static mfunc;    
    using static math;
    using static ansi;


    partial class TestMain : Context
    {

        public TestMain()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
        }


        void RunTests()
        {
            TestRunner.RunTests(string.Empty, false);
        }




        

         // Converts an array of bytes into a long.  
        public static long ToInt64(byte[] value, int startIndex)
        {

            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }


        static void Main(params string[] args)
        {            
            var app = new TestMain();
            gmath.one<byte>();
            try
            {     
                app.RunTests();
                
        
            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
        }

    }

}