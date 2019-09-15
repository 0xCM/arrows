//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public class tbv_extract : UnitTest<tbv_extract>
    {
        public void extract64()
        {
            var src = Random.Stream<ulong>().Take(Pow2.T12).ToArray();
            var lower = Random.Stream(leftclosed<byte>(0,32)).Take(Pow2.T12).ToArray();
            var upper = Random.Stream(leftclosed<byte>(32,64)).Take(Pow2.T12).ToArray();
            for(var i=0; i< Pow2.T12; i++)
            {
                var v1 = BitVector.Load(src[i]);
                var v2 = BitVector64.FromScalar(src[i]);
                Claim.eq(v1.ToBitVector64(), v2);

                var r1 = v1.SliceCell(lower[i], upper[i]);
                var r2 = v2.Between(lower[i], upper[i]);

                if(r1 != r2)
                {
                    Trace($"v1 = {v1.ToBitString()}");
                    Trace($"v2 = {v2.ToBitString()}");

                    Trace($"v1[{lower[i]}, {upper[i]}] = {r1.ToBitString()}");
                    Trace($"v2[{lower[i]}, {upper[i]}] = {r2.ToBitString()}");
                }
                Claim.eq(r1,r2);                
            }

        }

        public void extract32()
        {
            var src = Random.Stream<uint>().Take(Pow2.T12).ToArray();
            var lower = Random.Stream(leftclosed<byte>(0,16)).Take(Pow2.T12).ToArray();
            var upper = Random.Stream(leftclosed<byte>(16,32)).Take(Pow2.T12).ToArray();
            for(var i=0; i< Pow2.T12; i++)
            {
                var v1 = BitVector.Load(src[i]);
                var v2 = BitVector32.FromScalar(src[i]);
                Claim.eq(v1.ToBitVector32(),v2);

                var r1 = v1.SliceCell(lower[i], upper[i]);
                var r2 = v2.Between(lower[i], upper[i]);
                Claim.eq(r1,r2);                
            }
        }

        public void extract16()
        {
            var src = Random.Stream<ushort>().Take(Pow2.T12).ToArray();
            var lower = Random.Stream(leftclosed<byte>(0,8)).Take(Pow2.T12).ToArray();
            var upper = Random.Stream(leftclosed<byte>(8,16)).Take(Pow2.T12).ToArray();
            for(var i=0; i< Pow2.T12; i++)
            {
                var v1 = BitVector.Load(src[i]);
                var v2 = BitVector16.FromScalar(src[i]);
                Claim.eq(v1.ToBitVector16(),v2);

                var r1 = v1.SliceCell(lower[i], upper[i]);
                var r2 = v2.Between(lower[i], upper[i]);
                Claim.eq(r1,r2);                
            }
        }

        public void extractaligned()
        {
            byte x0 = 0b11010110;
            byte x1 = 0b10010101;
            byte x2 = 0b10100011;
            byte x3 = 0b10011101;
            byte x4 = 0b01011000;
            var bvx = BitVector.Load(x0,x1,x2,x3,x4);
            Claim.eq(40, bvx.Length);

            byte y0 = 0b0110;
            byte y1 = 0b1101;
            var y01 = gbits.or(y0, gbits.sal(y1, 4));
            byte y2 = 0b0101;
            byte y3 = 0b1001;
            var y23 = gbits.or(y2, gbits.sal(y3, 4));
            byte y4 = 0b0011;
            byte y5 = 0b1010;
            var y45 = gbits.or(y4, gbits.sal(y5, 4));
            byte y6 = 0b1101;
            byte y7 = 0b1001;
            var y67 = gbits.or(y6, gbits.sal(y7, 4));
            byte y8 = 0b1000;
            byte y9 = 0b0101;
            var y89 = gbits.or(y8, gbits.sal(y9, 4));
            var bvy = BitVector.Load(y01,y23,y45,y67,y89);            
            Claim.eq(40, bvy.Length);

            ulong z = 0b0101100010011101101000111001010111010110;           
            var bvz = BitVector.FromCell(z,40);
            Claim.eq(40, bvz.Length);

            var bsy = bvy.ToBitString().Format(true);
            var bsx = bvx.ToBitString().Format(true);
            var bsz = bvz.ToBitString().Format(true);
            Claim.eq(bsx, "101100010011101101000111001010111010110");
            Claim.eq(bsx, bsy);
            Claim.eq(bsx, bsz);

            Claim.eq(y0, bvx.SliceCell(0,3));
            Claim.eq(y1, bvx.SliceCell(4,7));
            Claim.eq(y2, bvx.SliceCell(8,11));
            Claim.eq(y3, bvx.SliceCell(12,15));
            Claim.eq(y4, bvx.SliceCell(16,19));
            Claim.eq(y5, bvx.SliceCell(20,23));
            Claim.eq(y6, bvx.SliceCell(24,27));
            Claim.eq(y7, bvx.SliceCell(28,31));
            Claim.eq(y8, bvx.SliceCell(32,35));
            Claim.eq(y9, bvx.SliceCell(36,39));

            Claim.eq(y0, (byte)bvz.SliceCell(0,3));
            Claim.eq(y1, bvz.SliceCell(4,7));
            Claim.eq(y2, bvz.SliceCell(8,11));
            Claim.eq(y3, bvz.SliceCell(12,15));
            Claim.eq(y4, bvz.SliceCell(16,19));
            Claim.eq(y5, bvz.SliceCell(20,23));
            Claim.eq(y6, bvz.SliceCell(24,27));
            Claim.eq(y7, bvz.SliceCell(28,31));
            Claim.eq(y8, bvz.SliceCell(32,35));
            Claim.eq(y9, bvz.SliceCell(36,39));    
        }

        public void extractarb()
        {

            ulong z = 0b01011_00010_01110_11010_00111_00101_01110_10110;           
            var bvz = BitVector.FromCell(z,40);
            Span<byte> xSrc =  ByteSpan.FromValue(z);
            Span<ushort> ySrc = xSrc.AsUInt16();
            Claim.eq(ySrc.Length*2, xSrc.Length);

            var bvx = BitVector.Load(xSrc.Slice(0,5).ToArray());
            var bvy = BitVector.Load(ySrc.Slice(0,2).ToArray());            
            var bsx = bvx.ToBitString().Format(true);
            var bsz = bvz.ToBitString().Format(true);
            Claim.eq(bsx, bsz);

            Claim.eq((byte)0b10110, bvx.SliceCell(0, 4));
            Claim.eq((byte)0b01110, bvx.SliceCell(5, 9));
            Claim.eq((byte)0b00101, bvx.SliceCell(10, 14));
            Claim.eq((byte)0b00111, bvx.SliceCell(15, 19));
            Claim.eq((byte)0b11010, bvx.SliceCell(20, 24));
            Claim.eq((byte)0b01110, bvx.SliceCell(25, 29));

            Claim.eq((ushort)0b10110, bvy.SliceCell(0, 4));
            Claim.eq((ushort)0b01110, bvy.SliceCell(5, 9));
            Claim.eq((ushort)0b00101, bvy.SliceCell(10, 14));
            Claim.eq((ushort)0b00111, bvy.SliceCell(15, 19));
            Claim.eq((ushort)0b11010, bvy.SliceCell(20, 24));
            Claim.eq((ushort)0b01110, bvy.SliceCell(25, 29));

            Claim.eq((ulong)0b10110, bvz.SliceCell(0, 4));
            Claim.eq((ulong)0b01110, bvz.SliceCell(5, 9));
            Claim.eq((ulong)0b00101, bvz.SliceCell(10, 14));
            Claim.eq((ulong)0b00111, bvz.SliceCell(15, 19));
            Claim.eq((ulong)0b11010, bvz.SliceCell(20, 24));
            Claim.eq((ulong)0b01110, bvz.SliceCell(25, 29));

        }



    }

}