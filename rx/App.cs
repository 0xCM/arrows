//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public class App
    {            
    
        static void Disassemble()
        {
            var methods = typeof(math).DeclaredMethods(nameof(math.mul)).ToArray();
            print($"# Generated at {now().ToLexicalString()}"); 
            var decon = Deconstructor.Disassemble(methods).Transform(x => x.ToString());
            iter(decon, print);

            //iter(Deconstructor.Disassemble(methods), x => print(x.ToString()));

        }

        void Run()
        {
            Disassemble();
        }

        public static void Main(params string[] args)
            => new App().Run();

    }

}