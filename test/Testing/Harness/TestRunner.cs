//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Nats;
    using static zcore;

    public class TestRunner
    {
        public static void RunTests(string filter = "", bool pll = true)
            => new TestRunner().Run(filter,pll);

        static void failure(string info, string member)
            => error($"{member}: test failed - {info}");

            


        public TestRunner()
        {
        
        }            

        IEnumerable<Type> CandidateTypes()
            => ZTest.DefiningAssembly.Types().Realizes<IUnitTest>();        
        
        public IEnumerable<Type> Hosts()
            => CandidateTypes().Concrete().OrderBy(t => t.DisplayName());
                    
        IEnumerable<MethodInfo> Tests(Type host)
            =>  host.DeclaredMethods()
                    .Public()
                    .WithParameterCount(0);

        void Run(IUnitTest host, string hostpath, MethodInfo test)
        {
            var messages = new List<AppMsg>();
            try
            {
                var testName = $"{hostpath}{test.Name}";
                messages.Add(AppMsg.Define("executing", SeverityLevel.HiliteBL, testName));
                
                var reps = RepeatAttribute.Repetitions(test);                               
                var sw = stopwatch();
                for(var i = 0; i<reps; i++)
                    test.Invoke(host,null);                    
                var ms = sw.ElapsedMilliseconds;
                messages.AddRange(host.DequeueMessages());
                messages.Add(AppMsg.Define(reps == 1 ?$"succeeded {ms}ms" : $"succeeded {ms}ms | {reps} reps", SeverityLevel.Info, testName));

                print(messages);

            }
            catch(Exception e)
            {
                print(messages);
                failure(e.ToString(), test.Name);                    
            }            
        }

        public void Run(Type host, string filter = "")
        {
            var hostpath = host.DisplayName();
            if(!string.IsNullOrWhiteSpace(filter) && !hostpath.Contains(filter))
                return;

            var instance = host.CreateInstance<IUnitTest>();
            iter(Tests(host), t =>  Run(instance, hostpath, t));
        }
    
        public void Run(string filter = "", bool concurrent = true)
            => iter(Hosts(), h =>  Run(h,filter), concurrent);
    }
}