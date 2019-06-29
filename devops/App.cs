//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;



    class App
    {

        public void Run(params string[] args)
        {
            Console.WriteLine(CommonProps.CreateGroup());
        }
        static void Main(params string[] args)
            => new App().Run(args);

    }
}