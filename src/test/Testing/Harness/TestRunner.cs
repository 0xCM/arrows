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
        public static void RunTests(string filter = "")
            => new TestRunner().Run(filter);

        static void failure(string info, string member)
            => error($"{member}: test failed - {info}");

        static void success(string member, long ms, int reps)
        {
            if(reps == 1)
                inform($"succeeded {ms}ms",member);
            else
                inform($"succeeded {ms}ms | {reps} reps",member); 
        }
            
        public TestRunner()
        {
        
        }            

        public IEnumerable<Type> Hosts()
            => ZTest.DefiningAssembly.Types()
                    .InNamespace(typeof(Z0.Tests.Paths).Namespace)
                    .Concrete();    
        IEnumerable<MethodInfo> Tests(Type host)
            =>  host.DeclaredMethods()
                    .Public()
                    .WithParameterCount(0);

        void Run(object host, string hostpath, MethodInfo test)
        {
            try
            {
                var testName = $"{hostpath}{test.Name}";
                hilite("executing",  testName); 
                var reps = RepeatAttribute.Repetitions(test);                               
                var sw = stopwatch();
                for(var i = 0; i<reps; i++)
                    test.Invoke(host,null);                    
                success(testName,sw.ElapsedMilliseconds,reps);
            }
            catch(Exception e)
            {
                failure(e.ToString(), test.Name);                    
            }            
        }

        public void Run(Type host, string filter = "")
        {
            if(!host.ContainsGenericParameters)
            {
                var hostpath = host.DisplayName();
                if(!string.IsNullOrWhiteSpace(filter) && !hostpath.Contains(filter))
                    return;

                var instance = host.CreateInstance<object>();
                iter(Tests(host), t =>  Run(instance, hostpath, t));
            }
        }
    
        public void Run(string filter = "")
            => iter(Hosts(), h =>  Run(h,filter));
    }
}