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

        void Run(Type host, params string[] filters)
        {        
            var hostpath = host.DisplayName();
            var execTime = Duration.Zero;
            var runtimer = stopwatch();

            if(filters.Length != 0)
            {
                if(!(filters.Length == 1 && String.IsNullOrEmpty(filters[0])))                        
                    if(!hostpath.ContainsAny(filters))
                        return;
            }

            try
            {
                Trace(AppMsg.Define($"Creating unint {host.Name}", SeverityLevel.Babble));
                var instance = host.CreateInstance<IUnitTest>();
                instance.Configure(Config);
                if(instance.Enabled)
                    iter(Tests(host), t =>  execTime += Run(instance, hostpath, t));
                print(AppMsg.Define($"{host.Name} exectime {execTime.Ms} ms, runtime = {snapshot(runtimer).Ms} ms", SeverityLevel.Info));

            }
            catch(Exception e)
            {
                error($"Host execution failed: {e}", this);
            }  
            finally
            {
            }      
        }

        void Run(bool concurrent, params string[] filters)
            => iter(Hosts(), h =>  Run(h,filters), concurrent);

        protected virtual bool PersistResults
            =>false;
        IEnumerable<MethodInfo> Tests(Type host)
            =>  host.DeclaredMethods().Public().NonGeneric().WithParameterCount(0);

        Duration Run(IUnitTest unit, string hostpath, MethodInfo test)
        {
            var exectime = Duration.Zero;
            var messages = new List<AppMsg>();
            var testName = $"{hostpath}/{test.DisplayName()}";
            try
            {
                messages.Add(AppMsg.Define($"{testName} executing", SeverityLevel.HiliteBL));                
                var sw = stopwatch();
                test.Invoke(unit,null);                    
                exectime = snapshot(sw);
                messages.AddRange(unit.DequeueMessages());
                messages.Add(AppMsg.Define($"{testName} executed. {exectime.Ms}ms", SeverityLevel.Info));
            }
            catch(Exception e)
            {                
                messages.AddRange(unit.DequeueMessages());                
                
                if(e.InnerException is ClaimException claim)
                    messages.Add(claim.Message);
                else if(e.InnerException is AppException app)
                    messages.Add(app.Message);
                else
                    messages.Add(ErrorMessages.Unanticipated(e ?? e.InnerException));

                messages.Add(AppMsg.Define($"{testName} failed", SeverityLevel.Error));                
            }
            finally
            {            
                print(messages);
                if(PersistResults)
                    log(messages, LogArea.Test);
            }
            return exectime;
        }            

        protected TestApp()
        {
            Configure(Config.WithTrace());   
        }

        protected TestApp(ITestConfig config, IRandomSource random)
            : base(config,random)
        {

        }

        protected virtual void RunTests(params string[] filters)
        {
            try
            {            
                Run(false,filters);
            }
            catch (Exception e)
            {
                NotifyError(e);
            }
        }

        protected static void Run(params string[] args)
            => new A().RunTests();
    }
}