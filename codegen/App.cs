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
            :base(Z0.XOrStarStar256.define(Seed256.BenchSeed))
        {
            
        }
        
        void Run(params string[] args)
        {
            
        }


        static void Main(params string[] args)
            => new App().Run();
    }
}