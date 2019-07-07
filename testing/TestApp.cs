//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;    
    using static math;
    using static ansi;

    public abstract class TestApp<A> : TestContext<A>
        where A : TestApp<A>, new()
    {
        IEnumerable<Type> CandidateTypes()
            => typeof(A).Assembly.Types().Realize<IUnitTest>().Where(t => t.ContainsGenericParameters == false);        
        
        IEnumerable<Type> Hosts()
            => CandidateTypes().Concrete().OrderBy(t => t.DisplayName());

        void Run(Type host, string filter)
        {        
            var hostpath = host.DisplayName();
            if(!string.IsNullOrWhiteSpace(filter) && !hostpath.Contains(filter))
                return;

            try
            {
                Trace(AppMsg.Define($"Creating unint {host.Name}", SeverityLevel.Babble));
                var instance = host.CreateInstance<IUnitTest>();
                instance.Configure(Config);
                if(instance.Enabled)
                    iter(Tests(host), t =>  Run(instance, hostpath, t));
            }
            catch(Exception e)
            {
                error($"Host execution failed: {e}", this);
            }        
        }

        void Run(string filter, bool concurrent)
            => iter(Hosts(), h =>  Run(h,filter), concurrent);

        IEnumerable<MethodInfo> Tests(Type host)
            =>  host.DeclaredMethods().Public().NonGeneric().WithParameterCount(0);

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
                messages.AddRange(unit.DequeueMessages());
                messages.Add(AppMsg.Define($"{testName} executed. Runtime {ms}ms", SeverityLevel.Info));
            }
            catch(Exception e)
            {                
                messages.AddRange(unit.DequeueMessages());                
                
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

        protected TestApp()
        {
            Configure(Config.WithTrace());   
        }

        protected TestApp(ITestConfig config, IRandomSource random)
            : base(config,random)
        {

        }

        protected virtual void RunTests(string filter)
        {
            try
            {            
                Run(filter, false);
            }
            catch (Exception e)
            {
                NotifyError(e);
            }
        }

        protected static void Run(params string[] args)
            => new A().RunTests(string.Empty);
    }
}