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
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    
    using static zcore;

    [DisplayName("testrunner")]
    public class TestRunner
    {
        public static void RunTests(string filter, bool pll)
            => new TestRunner().Run(filter,pll);

        IEnumerable<Type> CandidateTypes()
            => ZTest.DefiningAssembly.Types().Realizes<IUnitTest>().Where(t => t.ContainsGenericParameters == false);        
        
        IEnumerable<Type> Hosts()
            => CandidateTypes().Concrete().OrderBy(t => t.DisplayName());

        void Run(string filter, bool concurrent)
            => iter(Hosts(), h =>  Run(h,filter), concurrent);

        IEnumerable<MethodInfo> Tests(Type host)
            =>  host.DeclaredMethods().Public().WithParameterCount(0);

        void Run(Type host, string filter)
        {        
            var hostpath = host.DisplayName();
            if(!string.IsNullOrWhiteSpace(filter) && !hostpath.Contains(filter))
                return;

            try
            {
                babble($"Creating host type {host.Name}", this);
                var instance = host.CreateInstance<IUnitTest>();
                iter(Tests(host), t =>  Run(instance, hostpath, t));
            }
            catch(Exception e)
            {
                error($"Host execution failed: {e}", this);
            }        
        }
    
        TestRunner()
        {
        
        }            

        void Run(IUnitTest host, string hostpath, MethodInfo test)
        {
            var messages = new List<AppMsg>();
            try
            {
                test.DisplayName();
                var testName = $"{hostpath}{test.DisplayName()}";
                messages.Add(AppMsg.Define("executing", SeverityLevel.HiliteBL, testName));
                
                var reps = RepeatAttribute.Repetitions(test);                               
                var sw = stopwatch();
                for(var i = 0; i<reps; i++)
                    test.Invoke(host,null);                    
                var ms = sw.ElapsedMilliseconds;
                
                messages.AddRange(host.Flush(
                    AppMsg.Define(reps == 1 ?$"succeeded {ms}ms" : $"succeeded {ms}ms | {reps} reps", SeverityLevel.Info, testName))
                    );

                print(messages);
                log(messages, LogTarget.TestLog);
            }
            catch(Exception e)
            {
                print(messages);
                log(messages, LogTarget.TestLog);
                error($"{test.Name}: test failed - {e.ToString()}");
            }            
        }
    }
}