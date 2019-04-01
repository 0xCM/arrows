//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
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

        static void success(string member, long ms)
            => inform($"succeeded {ms}ms",member);

        public TestRunner()
        {
        
        }            

        public IEnumerable<Type> Hosts()
            => from t in assembly<Initalizer>().GetTypes()
               where t.Namespace == typeof(Tests.TestInfo).Namespace
                select t;
    
        public IEnumerable<MethodInfo> Tests(Type host)
            => from m in host.GetDeclaredStaticMethods()
            where m.GetParameters().Length == 0
            select m;

        public IEnumerable<MethodInfo> Tests()
            => from h in Hosts() from m in Tests(h) select m;

        public void Run(MethodInfo test)
        {
            try
            {
                var name = $"{test.DeclaringType.DisplayName()}/{test.Name}";
                hilite("executing",  name);
                var sw = stopwatch();
                test.Invoke(null,null);                    
                success(name,sw.ElapsedMilliseconds);
            }
            catch(Exception e)
            {
                failure(e.ToString(), test.Name);                    
            }
            
        }

        public void Run(Type host)
            => iter(Tests(host), Run);
    
        public void Run()
            => iter(Tests(),Run);
    }
}