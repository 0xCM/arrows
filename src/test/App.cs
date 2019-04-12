namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using Testing;
    using Tests;
    using System.IO;
    using static zcore;
    using static primops;
    using static algorithms;
    public sealed class ZTest : ZTest<ZTest>
    {
        
    }

    public static class App
    {

        static void SaveDivisors()
        {
            var sw = stopwatch();
            var step = 50000UL;
            var interval = Interval.closed(0UL,UInt32.MaxValue - step);
            foreach(var d in divisors(interval,step))
            {
                print($"{d.Range}, count = {d.Lists.Count()} {sw.ElapsedMilliseconds}ms");
                NumberFile.save(d, FolderPath.Define(@"C:\temp"));
                sw.Restart();
            }

        }

        static void Main(string[] args)
        {     
            //TestRunner.RunTests();
            //TestRunner.RunTests(Paths.nla);
            //TestRunner.RunTests(Paths.structures);
            TestRunner.RunTests(Paths.primops);
            //TestRunner.RunTests(Paths.bits);
            //TestRunner.RunTests(Paths.digits);


            SaveDivisors();

        }
    }

}