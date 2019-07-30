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
        static void Disassemble(bool asm, bool cil, params Type[] types)
        {
            foreach(var t in types)
            {
                var name = $"{t.DisplayName()}";
                if(asm)
                {
                    t.DistillAsm().Emit(name);
                }

                if(cil)
                    t.Deconstruct().EmitCil(name);
            }

        }

        static void Disassemble<T>(IDeconstructable<T> src)
        {
            var deconstructed = typeof(T).Deconstruct();
            deconstructed.EmitAsm(src.AsmTargetPath);
            deconstructed.EmitCil(src.CilTargetPath);
            
        }

        void Disassemble(bool asm, bool cil)
        {

            // Disassemble(asm, cil, 
            //     typeof(InlineScenarios) 
            //     );

            Disassemble(new IntrinsicScenarios());
            Disassemble(new PrimalScenarios());
            Disassemble(new SysMathCases());
            Disassemble(new CompositeScenarios());

            // Dump(asm,cil, "ginx", GenericScenarios.GInX());
            // Dump(asm,cil, "gmath", GenericScenarios.GMath());

        }

        void Run()
        {

            try
            {
                Disassemble(true,true);
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