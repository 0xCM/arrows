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
    using static Z0.Tests.ztest;

    public class TestRunner
    {
        public static void RunTests()
        {
            new TestRunner().Run();
        }


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
                    .InNamespace(typeof(Z0.Tests.TestInfo).Namespace)
                    .Concrete();
    
        public IEnumerable<MethodInfo> Tests(Type host)
            =>  host.DeclaredMethods()
                    .Public()
                    .WithParameterCount(0);

        public void Run(object host, MethodInfo test)
        {
            try
            {
                var name = $"{test.DeclaringType.DisplayName()}/{test.Name}";
                hilite("executing",  name); 
                var reps = RepeatAttribute.Repetitions(test);                               
                var sw = stopwatch();
                for(var i = 0; i<reps; i++)
                    test.Invoke(host,null);                    
                success(name,sw.ElapsedMilliseconds,reps);
            }
            catch(Exception e)
            {
                failure(e.ToString(), test.Name);                    
            }            
        }

        public void Run(Type host)
        {
            if(!host.ContainsGenericParameters)
            {
                var instance = host.CreateInstance<object>();
                iter(Tests(host), t =>  Run(instance, t));
            }
        }
    
        public void Run()
            => iter(Hosts(), Run);
    }
}