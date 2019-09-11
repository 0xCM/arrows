//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{       
    using System.Linq;
    using static zfunc;

    public class App : TestApp<App>
    {           
        
        
        protected override void RunTests(params string[] filters)
        {            
            
            base.RunTests(filters);
            
        
        } 
        public static void Main(params string[] args)
            => Run(args);
    }
}