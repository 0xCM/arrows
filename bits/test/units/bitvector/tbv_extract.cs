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
                var v1 = BitVector.FromCells(src[i]);
                var v2 = BitVector64.FromScalar(src[i]);
                Claim.eq(v1.ToBitVector64(), v2);

                var r1 = v1.Between(lower[i], upper[i]);
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
                var v1 = BitVector.FromCells(src[i]);
                var v2 = BitVector32.FromScalar(src[i]);
                Claim.eq(v1.ToBitVector32(),v2);

                var r1 = v1.Between(lower[i], upper[i]);
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
                var v1 = BitVector.FromCells(src[i]);
                var v2 = BitVector16.FromScalar(src[i]);
                Claim.eq(v1.ToBitVector16(),v2);

                var r1 = v1.Between(lower[i], upper[i]);
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
            var bvx = BitVector.FromCells(x0,x1,x2,x3,x4);
            Claim.eq(40, bvx.Length);

            byte y0 = 0b0110;
            byte y1 = 0b1101;
            var y01 = gbits.or(y0, gbits.shiftl(y1, 4));
            byte y2 = 0b0101;
            byte y3 = 0b1001;
            var y23 = gbits.or(y2, gbits.shiftl(y3, 4));
            byte y4 = 0b0011;
            byte y5 = 0b1010;
            var y45 = gbits.or(y4, gbits.shiftl(y5, 4));
            byte y6 = 0b1101;
            byte y7 = 0b1001;
            var y67 = gbits.or(y6, gbits.shiftl(y7, 4));
            byte y8 = 0b1000;
            byte y9 = 0b0101;
            var y89 = gbits.or(y8, gbits.shiftl(y9, 4));
            var bvy = BitVector.FromCells(y01,y23,y45,y67,y89);            
            Claim.eq(40, bvy.Length);

            ulong z = 0b0101100010011101101000111001010111010110;           
            var bvz = BitVector.FromCells(40,z);
            Claim.eq(40, bvz.Length);

            var bsy = bvy.ToBitString().Format(true);
            var bsx = bvx.ToBitString().Format(true);
            var bsz = bvz.ToBitString().Format(true);
            Claim.eq(bsx, "101100010011101101000111001010111010110");
            Claim.eq(bsx, bsy);
            Claim.eq(bsx, bsz);

            Claim.eq(y0, bvx.Between(0,3));
            Claim.eq(y1, bvx.Between(4,7));
            Claim.eq(y2, bvx.Between(8,11));
            Claim.eq(y3, bvx.Between(12,15));
            Claim.eq(y4, bvx.Between(16,19));
            Claim.eq(y5, bvx.Between(20,23));
            Claim.eq(y6, bvx.Between(24,27));
            Claim.eq(y7, bvx.Between(28,31));
            Claim.eq(y8, bvx.Between(32,35));
            Claim.eq(y9, bvx.Between(36,39));

            Claim.eq(y0, (byte)bvz.Between(0,3));
            Claim.eq(y1, bvz.Between(4,7));
            Claim.eq(y2, bvz.Between(8,11));
            Claim.eq(y3, bvz.Between(12,15));
            Claim.eq(y4, bvz.Between(16,19));
            Claim.eq(y5, bvz.Between(20,23));
            Claim.eq(y6, bvz.Between(24,27));
            Claim.eq(y7, bvz.Between(28,31));
            Claim.eq(y8, bvz.Between(32,35));
            Claim.eq(y9, bvz.Between(36,39));    
        }

        public void extractarb()
        {

            ulong z = 0b01011_00010_01110_11010_00111_00101_01110_10110;           
            var bvz = BitVector.FromCells(40,z);
            Span<byte> xSrc =  ByteSpan.FromValue(z);
            Span<ushort> ySrc = xSrc.AsUInt16();
            Claim.eq(ySrc.Length*2, xSrc.Length);

            var bvx = BitVector.FromCells(xSrc.Slice(0,5).ToArray());
            var bvy = BitVector.FromCells(ySrc.Slice(0,2).ToArray());            
            var bsx = bvx.ToBitString().Format(true);
            var bsz = bvz.ToBitString().Format(true);
            Claim.eq(bsx, bsz);

            Claim.eq((byte)0b10110, bvx.Between(0, 4));
            Claim.eq((byte)0b01110, bvx.Between(5, 9));
            Claim.eq((byte)0b00101, bvx.Between(10, 14));
            Claim.eq((byte)0b00111, bvx.Between(15, 19));
            Claim.eq((byte)0b11010, bvx.Between(20, 24));
            Claim.eq((byte)0b01110, bvx.Between(25, 29));

            Claim.eq((ushort)0b10110, bvy.Between(0, 4));
            Claim.eq((ushort)0b01110, bvy.Between(5, 9));
            Claim.eq((ushort)0b00101, bvy.Between(10, 14));
            Claim.eq((ushort)0b00111, bvy.Between(15, 19));
            Claim.eq((ushort)0b11010, bvy.Between(20, 24));
            Claim.eq((ushort)0b01110, bvy.Between(25, 29));

            Claim.eq((ulong)0b10110, bvz.Between(0, 4));
            Claim.eq((ulong)0b01110, bvz.Between(5, 9));
            Claim.eq((ulong)0b00101, bvz.Between(10, 14));
            Claim.eq((ulong)0b00111, bvz.Between(15, 19));
            Claim.eq((ulong)0b11010, bvz.Between(20, 24));
            Claim.eq((ulong)0b01110, bvz.Between(25, 29));

        }



    }

}