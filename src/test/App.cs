namespace Z0
{
    using Testing;

    public sealed class ZTest : ZTest<ZTest>
    {
        
    }

    public static class App
    {
        static void Main(string[] args)
        {     
            //SysInit.initialize<Program>();
            TestRunner.RunTests();

            // var input = Rand.primal(-50,50).Freeze((int)Pow2.T21);
            // var pos = (double)input.Where(x => x > 0).Count();
            // var neg = (double)input.Where(x => x < 0).Count();
            // var quo = pos/neg;

            // var h = Histogram.define(-50, 50, 1);
            // h.distribute(input.ToReal());
            // printeach(h.ratios());

            // var i = Interval.closed(float64(1),float64(100));
            // var parts = i.Partition(50);
            // printeach(parts);
        
            // var bits = Rand.bits().Take(Pow2.T21).Freeze();
            // var count = bits.Count;
            // print(count);
            // var on = (double)bits.Where(b => b).Count();
            // var off = (double)bits.Where(b => !b).Count();
            // print($"on::off = {on/off}");

            //PrimSpeed(Pow2.T21);        

            //
            
        }
    }

}