//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    public class UInt4Test : UnitTest<UInt4Test>
    {

        public void uint4_create()
        {
            var x0 = (UInt4)0;
            byte y0 = x0;
            var z0 = (byte)0;
            Claim.eq(y0,z0);

            var x1 = (UInt4)5;
            byte y1 = x1;
            var z1 = (byte)5;
            Claim.eq(y1,z1);

            var x2 = UInt4.FromBits(1,0,1,1);
            byte y2 = x2;
            var z2 = (byte)0b1101;
            Claim.eq(y2,z2);

            UInt4 x3 = span<Bit>(Bit.On, Bit.Off, Bit.On, Bit.On);
            byte y3 = x3;
            var z3 = (byte)0b1101;
            Claim.eq(y3,z3);

            UInt4 x4 = UInt4.FromByte(0);
            Claim.eq(x4,(byte)0);

            byte y4 = x4;
            var z4 = (byte)0;
            Claim.eq(y4,z4);

            var x5 = UInt4.FromBitSeq(gbits.bitseq((byte)5));
            var y5 = (UInt4)5;
            Claim.eq(x5,y5);
        }

        public void uint4_format()
        {
            var x0 = (UInt4)0;
            var x1 = (UInt4)1;
            var x2 = (UInt4)2;
            var x3 = (UInt4)3;
            Claim.eq(x0.Format(), "0");
            Claim.eq(x1.Format(), "1");
            Claim.eq(x2.Format(), "2");
            Claim.eq(x3.Format(), "3");

        }

        public void uint4_inc()
        {
            var x = (UInt4)7;
            for(var i=0; i< 3; i++)
                x++;
            
            Claim.eq((UInt4)10,x);

            for(var i=0; i< 3; i++)
                x++;

            Claim.eq((UInt4)13,x);

            for(var i=0; i< 3; i++)
                x++;

            Claim.eq((UInt4)0,x);

        }

        public void uint4_dec()
        {
            var x = (UInt4)7;
            for(var i=0; i< 3; i++)
                x--;
            
            Claim.eq((UInt4)4,x);

            for(var i=0; i< 3; i++)
                x--;

            Claim.eq((UInt4)1,x);

            for(var i=0; i< 3; i++)
                x--;

            Claim.eq((UInt4)14,x);

        }

        public void uint4_flip()
        {
            var x0 = (UInt4)0b1011;
            var y0 = ~x0;
            var z0 = (UInt4)0b0100;
            Claim.eq(y0,z0);
        }
       
        public void uint4_add()
        {
            var x1 = (UInt4)3;
            var x2 = (UInt4)4;
            var y0 = (UInt4)7;
            var z0 = (UInt4)10;
            var z1 = (UInt4)1;
            Claim.eq(y0, x1 + x2);
            Claim.eq(z0, y0 + x1);
            Claim.eq(z1, z0 + y0);
        
        }

        public void uint4_hilo()
        {
            Claim.eq((UInt4)0b11, ((UInt4)0b1011).Lo);
            Claim.eq((UInt4)0b10, ((UInt4)0b1011).Hi);

            var x0 = (UInt4)0b1011;
            x0.Lo = (UInt4)0b01;
            x0.Hi = (UInt4)0b01;
            var y0 = (UInt4)0b0101;
            Claim.eq(y0,x0);
            
        }

        public void uint4_bitstring()
        {
            var x0 = ((UInt4)0b0111).ToBitString().Format(true);
            Claim.eq("111",x0);

            var x1 = ((UInt4)0b1101).ToBitString().Format(true);
            Claim.eq("1101",x1);

        }


    }

}