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
            Disassemble(new IntrinsicScenarios());
            Disassemble(new PrimalScenarios());

            Disassemble(true,true, typeof(Bits));
            Disassemble(true,true, typeof(BitParts));
            Disassemble(true,true, typeof(math));
            Disassemble(true,true, typeof(Asm));
            Disassemble(true,true, typeof(AsmRef));
            Disassemble(true,true,typeof(bitvector));
            // Disassemble(true,true, typeof(BitRef));
            // Disassemble(new PrimalScenarios());
            // Disassemble(new SysMathCases());
            // Disassemble(new CompositeScenarios());


        }

        public unsafe static void ListMethods(Type t)
        {
            var methods = (from m in t.DeclaredMethods()
                          let loc = (long)m.MethodHandle.GetFunctionPointer()
                          select (m, loc)).OrderBy(x => x.loc).ToArray();
            if(methods.Length == 0)
                return;

            methods.Iterate(x => x.m.JitMethod());
            var first = methods[0].loc;
            var last = 0L;
            foreach(var m in methods)
            {                
                var length = last != 0 ? m.loc - last : 0;
                last = m.loc;
                print($"{m.loc.FormatHex(false)} {m.m.Name.PadRight(15)} {length}");
            }


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