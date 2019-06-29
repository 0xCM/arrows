//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using static zfunc;


    class App : Context<App>
    {
        public App()
            : base(RNG.XOrShift1024())
        {

        }

        void DisassembleExample()
        {
            
            var methods = typeof(math).DeclaredMethods(nameof(math.mul)).ToArray();
            print($"# Generated at {now().ToLexicalString()}"); 
            var decon = Deconstructor.Disassemble(methods).Transform(x => x.ToString());
            iter(decon, print);

            //iter(Deconstructor.Disassemble(methods), x => print(x.ToString()));

        }

        static IEnumerable<MethodDisassembly> Disassemble(IEnumerable<MethodInfo> methods)
            => Deconstructor.Disassemble(methods.ToArray());

        void Analyze(MethodDisassembly d)
        {
            cyan(d);

        }


        static readonly Type[] PrimalUIntTypes = 
            array(
                typeof(byte),  typeof(ushort), 
                typeof(uint), typeof(ulong)
                );

        static readonly Type[] PrimalSIntTypes = 
            array(
                typeof(sbyte), typeof(short), 
                typeof(int),  typeof(long)
                );

        static readonly Type[] PrimalIntTypes = 
            array(
                typeof(byte), typeof(sbyte), typeof(short), typeof(ushort), 
                typeof(int), typeof(uint), typeof(long), typeof(ulong)
                );

        static readonly Type[] PrimalFloatTypes = 
            array(typeof(float),typeof(double));

        static readonly Type[] PrimalTypes = 
            concat(PrimalUIntTypes, PrimalSIntTypes, PrimalFloatTypes);

        IEnumerable<MethodDisassembly> DisassembleGInX()
        {
            var opnames = set
            (
                nameof(ginx.add),
                nameof(ginx.sub),
                nameof(ginx.and),
                nameof(ginx.or),
                nameof(ginx.xor)
            );
            var open = typeof(ginx).Methods().Public().OpenGeneric().Where(m => opnames.Contains(m.Name));
            var closed = from om in open
                        from t in PrimalTypes
                         let def = om.GetGenericMethodDefinition()
                         let gm = def.MakeGenericMethod(t)
                         select gm;
            return Disassemble(closed);
        }
        IEnumerable<MethodDisassembly> DisassembleGMath()
        {
            var opnames = set(
                nameof(gmath.add), 
                nameof(gmath.sub), 
                nameof(gmath.mul), 
                nameof(gmath.div), 
                nameof(gmath.mod)
                );

            var open = gmath.BinOps().Where(m => opnames.Contains(m.Name));
            var closed = from om in open
                        from t in PrimalTypes
                         let def = om.GetGenericMethodDefinition()
                         let gm = def.MakeGenericMethod(t)
                         select gm;

            return Disassemble(closed);
        }

        void Disassemble()
        {
            //iter(DisassembleGMath(), Analyze);

            iter(DisassembleGInX(), Analyze);

        }

        void PrintRegisters()
        {
            for(var i=0; i< 31; i++)
            {
                var reg = RegId.xmm(i);
                print(reg.ToString());
                
            }

        }

        public void Run(params string[] args)
        {
            //iter(Deconstructor.Disassemble(typeof(UseCases).DeclaredMethods().ToArray()), Analyze);
            Disassemble();
        }

        static void Main(string[] args)
            => new App().Run();
    }

    
}
