//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;


    public class App
    {                

        void Analyze(MethodDisassembly d)
        {
            magenta(d);
        }

        void Disassemble()
        {

            typeof(CommonIntrinsicScenarios).Deconstruct();
            typeof(CommonPrimalScenarios).Deconstruct();
            GenericScenarios.GInX();
            GenericScenarios.GMath();


        }

        void Run()
        {

            try
            {
                Disassemble();
            }
            catch(Exception e)
            {
                print(errorMsg(e));
            }
        }

        public static void Main(params string[] args)
            => new App().Run();

    }

}