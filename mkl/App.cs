//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;


    public class App
    {

        public void Run()
        {
            CBLASX.sasum();
            CBLASX.dzasum();
            CBLASX.saxpy();
            CBLASX.gemm();
        }

        static void Main(params string[] args)
            => new App().Run();
    }

}