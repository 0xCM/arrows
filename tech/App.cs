//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Linq;
    using System.Threading;
    using static zfunc;
    using Z0.Asm;

    class App : Context<App>
    {


        public App()
            : base(RNG.XOrShift1024())
        {

        }
    


        public void Run(params string[] args)
        {
                        

            //Z3Examples.BvExamples();
            Z3Examples.EnumExamples();
            
        }

        static void Main(string[] args)
            => new App().Run();
    }
    
}
