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

    public class t_bitpart8 : BitPartTest<t_bitpart8>
    {                    

        public void bitpart_32x8()
        {
            bitpart_check<uint,byte>(BitParts.part32x8, (int)Part32x8.Count,(int)Part32x8.Width);
        }


        public void bitpart_32x8_bench()
        {
            var opcount = RoundCount*CycleCount;
            var sw = stopwatch(false);
            var opname = $"bitpart_32x8";
            var count = (int)Part32x8.Count;
            Span<byte> dst = stackalloc byte[count];

            for(var k = 0; k < opcount; k++)
            {
                var x = Random.Next<uint>();
                sw.Start();
                BitParts.part32x8(x, dst);
                sw.Stop();
            }

            Collect((opcount,sw,opname));
        }

    }

}