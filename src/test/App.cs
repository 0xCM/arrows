namespace Z0
{
    using System;
    using Testing;
    using Tests;
    using static zcore;
    public sealed class ZTest : ZTest<ZTest>
    {
        
    }

    public static class App
    {
        static void Main(string[] args)
        {     
            TestRunner.RunTests();
            //TestRunner.RunTests(Paths.nla);
            //TestRunner.RunTests(Paths.structures);
            //TestRunner.RunTests(Paths.primops);
            //TestRunner.RunTests(Paths.bits);
            //TestRunner.RunTests(Paths.digits);
            
        }
    }

}