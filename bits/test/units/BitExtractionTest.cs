//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class BitExtractionTest : UnitTest<BitExtractionTest>
    {        
        public void ExtractBits()
        {
            var src = 0b00001010110000101001_001_111_011_001u;
            var bsSrc = src.ToBitString().Format(true);
            Claim.eq("1010110000101001001111011001", bsSrc);
            
            var i=-3; 

            var x0 = gbits.extract(in src, (byte)(i += 3), 3);
            var bsx0 = x0.ToBitString();
            var y0 = bsx0.TakeValue<uint>();
            Claim.eq(x0,y0);

            var x1 = gbits.extract(in src, (byte)(i += 3), 3);
            var bsx1 = x1.ToBitString();
            var y1 = bsx1.TakeValue<uint>();
            Claim.eq(x1,y1);

            var x2 = gbits.extract(in src, (byte)(i += 3), 3);
            var bsx2 = x2.ToBitString();
            var y2 = bsx2.TakeValue<uint>();
            Claim.eq(x2,y2);
            
            var x3 = gbits.extract(in src, (byte)(i += 3), 3);
            var bsx3 = x3.ToBitString();
            var y3 = bsx3.TakeValue<uint>();
            Claim.eq(x3,y3);            
        }

        public void ExtractBits64()
        {
            var bv8 = BitVector8.FromScalar(0b10000000);
            var bv16 =bv8.Concat(bv8);
            var bv32 = bv16.Concat(bv16);
            var bv64 = bv32.Concat(bv32);

            var bs8 = bv8.ToBitString();
            var bs16 = bs8.Concat(bs8);
            var bs32 = bs16.Concat(bs16);
            var bs64 = bs32.Concat(bs32);

            Claim.eq(bv8.ToBitString(), bs8);
            Claim.eq(bv8, bs8.ToBitVector8());

            Claim.eq(bv16.ToBitString(), bs16);
            Claim.eq(bv16, bs16.ToBitVector16());

            Claim.eq(bv32.ToBitString(), bs32);
            Claim.eq(bv32, bs32.ToBitVector32());

            Claim.eq(bv64.ToBitString(), bs64);
            Claim.eq(bv64, bs64.ToBitVector64());

            var bv64x = Bits.extract(bv64, BitMask64.Msb8).ToBitVector();
            Claim.eq((byte)0xFF, bv64x.Byte(0));

            var x = BitConverter.ToUInt64(new byte[]{1,0,0,1,1,0,1,1},0);
            var y = Bits.extract(x, BitMask64.Lsb8).ToBitVector();
            var z = y.Byte(0);
            Claim.eq(x.ToBitVector().Byte(0),z);
        

            //11011001

        }
    }

}