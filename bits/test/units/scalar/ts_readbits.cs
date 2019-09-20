//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class ts_readbits : ScalarBitTest<ts_readbits>
    {

        public void readbits16u()
        {
            var src = Random.Stream<ushort>().TakeSpan(SampleSize);            
            for(var i=0; i< src.Length; i++)
            {
                var x = src[i];
                var x0 = (ushort)x.ReadBits(0, 2)[0];
                var x1 = (ushort)(((ushort)x.ReadBits(3, 5)[0]) << 3);
                var x2 = (ushort)(((ushort)x.ReadBits(6, 8)[0]) << 6);
                var x3 = (ushort)(((ushort)x.ReadBits(9, 11)[0]) << 9);
                var x4 = (ushort)(((ushort)x.ReadBits(12, 14)[0]) << 12);
                var x5 = (ushort)(((ushort)x.ReadBits(15, 15)[0]) << 15);

                var y = x0;
                y |= x1;
                y |= x2;
                y |= x3;
                y |= x4;
                y |= x5;
                Claim.eq(x,y);
            }
        }
 

    }

}