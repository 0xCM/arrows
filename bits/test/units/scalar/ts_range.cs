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

    public class ts_range : ScalarBitTest<ts_range>
    {


        public void range8u()
        {
            const ulong U64_00 = 0b00001001_11110000_11001001_10011111_00010001_10111100_00111000_11110000;
            
            const uint U32_01 = 0b00001001_11110000_11001001_10011111;

            Span<byte> dst = stackalloc byte[8];
            
            BitPos pos1 = 0;
            BitPos pos7 = 7;
            var width = pos7 - pos1;
            Claim.eq(8,width);
            
            var r1 = Bits.range(U64_00, 0, 7);
            Claim.eq((byte)0b11110000, r1);

            gbits.range(U64_00, 0, 7, dst, 0);
            Claim.eq((byte)0b11110000, dst[0]);

            gbits.range(U64_00, 8, 15, dst, 0);
            Claim.eq((byte)0b00111000, dst[0]);

            gbits.range(U64_00, 4, 7, dst, 0);
            Claim.eq((byte)0b1111, dst[0]);

            gbits.range(U64_00, 4, 6, dst, 1);
            Claim.eq((byte)0b111, dst[1]);

            gbits.range(U32_01, 7, 8, dst, 2);
            Claim.eq((byte)0b11, dst[2]);                    
        }

        public void range32u()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<uint>();
                (var x0, var x1) = Bits.split(x);

                var y0 = gbits.range(x, 0, 15);
                var y1 = gbits.range(x, 16, 31);

                Claim.eq(y0,x0);
                Claim.eq(y1,x1);
            }
        }

        public void range64u()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<ulong>();
                (var x0, var x1) = Bits.split(x);
                var y0 = gbits.range(x, 0, 31);
                var y1 = gbits.range(x, 32, 63);

                Claim.eq(y0,x0);
                Claim.eq(y1,x1);
            }
        }


    }
}