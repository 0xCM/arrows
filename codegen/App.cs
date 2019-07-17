//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Bench;

    using static zfunc;    


    class App : Context
    {

        public App()
            :base(Z0.XOrShift256.define(Seed256.BenchSeed))
        {
            
        }
        
        void Run(params string[] args)
        {
            var b256 = new Byte256();
            print(b256.GenerateSourceInt8().Format());


        }
            


        static void Main(params string[] args)
            => new App().Run();
    }
}