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
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    
    using static zfunc;

    [DisplayName("testrunner")]
    public class TestRunner
    {
        public static void RunTests(string filter, bool pll)
            => new TestRunner().Run(filter,pll);

        IEnumerable<Type> CandidateTypes()
            => typeof(TestRunner).Assembly.Types().Realize<IUnitTest>().Where(t => t.ContainsGenericParameters == false);        
        
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
                //var msg = AppMsg.Define($"Creating unint {host.Name}", SeverityLevel.Babble);
                //print(msg);
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

        void Run(IUnitTest unit, string hostpath, MethodInfo test)
        {
            var messages = new List<AppMsg>();
            var testName = $"{hostpath}/{test.DisplayName()}";
            try
            {
                messages.Add(AppMsg.Define($"{testName} executing", SeverityLevel.HiliteBL));                
                var sw = stopwatch();
                test.Invoke(unit,null);                    
                var ms = sw.ElapsedMilliseconds;
                messages.AddRange(unit.Flush());
                messages.Add(AppMsg.Define($"{testName} executed. Runtime {ms}ms", SeverityLevel.Info));
            }
            catch(Exception e)
            {                
                messages.AddRange(unit.Flush());                
                
                if(e.InnerException is ClaimException claim)
                    messages.Add(claim.Message);
                else if(e.InnerException is AppException app)
                    messages.Add(app.Message);
                else
                    messages.Add(ErrorMessages.Unanticipated(e.InnerException));

                messages.Add(AppMsg.Define($"{testName} failed", SeverityLevel.Error));                
            }
            finally
            {            
                print(messages);
                log(messages, LogArea.Test);
            }
        }            
    }
}
