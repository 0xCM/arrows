//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zcore;

    public class TestManager
    {
        public void Run(bool pll = false)
            => Run(Hosts<TestManager>(),pll);
        
        public IEnumerable<ITestHost> Hosts<T>()
            => type<T>().Assembly.GetTypes().Concrete().Realize<ITestHost>().Select(x => (ITestHost)Activator.CreateInstance(x));

        public void Run(ITestHost host)
        {
            try
            {
                var hostname = host.GetType().DisplayName();
                foreach(var (testName,executor) in host.Runners())
                {
                    executor();

                    host.Emit(AppMsg.Define($"Executed {hostname}/{testName}"));
                }
            }
            catch(Exception e)
            {
                host.Emit(AppMsg.Define($"{e}", SeverityLevel.Error));
            }
        }
        public void Run(IEnumerable<ITestHost> src, bool pll = false)
        {
            if(pll)
                src.AsParallel().ForAll(host => Run(host));
            else
                foreach(var host in src)
                    Run(host);
        }
    }


}