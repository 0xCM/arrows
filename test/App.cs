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

    public class App : Context
    {

        public App()
            : base(Z0.XOrStarStar256.define(Seed256.BenchSeed))
        {
            
        }
       
         // Converts an array of bytes into a long.  

        void TestBits()
        {


        }
 
        public static void Run()
        {
            
            var app = new App();
            try
            {
                TestTools.RunTests<App>(string.Empty, false);

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