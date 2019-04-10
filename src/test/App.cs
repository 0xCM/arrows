namespace Z0
{
    using Testing;
    using Tests;

    public sealed class ZTest : ZTest<ZTest>
    {
        
    }

    public static class App
    {
        static void Main(string[] args)
        {     
            //TestRunner.RunTests(Paths.structures);
            //TestRunner.RunTests(Paths.primops);
            TestRunner.RunTests(Paths.bits);


            
        }
    }

}