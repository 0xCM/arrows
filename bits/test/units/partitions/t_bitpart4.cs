//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
    using static BitParts;

    public class t_bitpart4 : BitPartTest<t_bitpart4>
    {


        public void bitpart_32x4()
        {
            var count = (int)Part32x4.Count;
            var width = (int)Part32x4.Width;
            Span<byte> dst = stackalloc byte[count];

            for(var sample = 0; sample < SampleSize; sample++)
            {
                var x = Random.Next<uint>();
                BitParts.part32x4(x, dst);
                Span<byte> dstRef = stackalloc byte[count];
                part32x4_ref(x, dstRef);
                var xbs = x.ToBitString();   
                var bsparts = xbs.Partition(width).Map(bs => bs.ToBitVector(n8));
                for(var i=0; i<count; i++)  
                {          
                    Claim.eq(bsparts[i], dst[i].ToBitVector());
                    Claim.eq(bsparts[i], dstRef[i].ToBitVector());
                }
            }
        }

        public void bitpart_32x4_bench()
        {
            var opcount = RoundCount*CycleCount;
            var sw = stopwatch(false);
            var opname = $"bitpart_32x4";
            var count = (int)Part32x4.Count;
            Span<byte> dst = stackalloc byte[count];

            for(var k = 0; k < opcount; k++)
            {
                var x = Random.Next<uint>();
                sw.Start();
                BitParts.part32x4(x, dst);
                sw.Stop();
            }

            Collect((opcount,sw,opname));
        }

        public void bitpart_32x4_ref_bench()
        {
            var opcount = RoundCount*CycleCount;
            var sw = stopwatch(false);
            var opname = $"bitpart_32x4_ref";
            var count = (int)Part32x4.Count;
            Span<byte> dst = stackalloc byte[count];

            for(var k = 0; k < opcount; k++)
            {
                var x = Random.Next<uint>();
                sw.Start();
                part32x4_ref(x, dst);
                sw.Stop();
            }

            Collect((opcount,sw,opname));

        }


    }

}