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

        void Disassemble<T>()
        {
            var t = typeof(T);
            var specs = t.SpecifyAsm();
            var name = $"{t.DisplayName()}.v2";
            specs.Dump(name);
        }

        void Dump(string name, IEnumerable<MethodDisassembly> methods)
        {
            var specs = methods.SpecifyAsm().ToArray();
            specs.Dump(name);        
        }
        
        void Disassemble()
        {

            // typeof(CommonIntrinsicScenarios).Deconstruct();
            // typeof(CommonPrimalScenarios).Deconstruct();
            //GenericScenarios.GInX();
            //GenericScenarios.GMath();

            Disassemble<CommonIntrinsicScenarios>();
            Disassemble<CommonPrimalScenarios>();
            Dump("ginx.v2", GenericScenarios.GInX());
            Dump("gmath.v2", GenericScenarios.GMath());


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