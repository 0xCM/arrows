//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.InX.Test
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
            : base(RNG.XOrShift1024(Seed1024.TestSeed))
        {
            
        }

        public static void Run(params string[] args)
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


        public static void Main(params string[] args)
            => Run(args);

    }
}