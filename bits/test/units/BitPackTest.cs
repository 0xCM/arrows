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

    public class BitPackTest : UnitTest<BitPackTest>
    {

        public void Pack2x16()
        {
            var src = Random.Span<ushort>(Pow2.T11);
            foreach(var x in src)
            {
                (var x0, var x1) = Bits.split(x);
                var y = Bits.pack(x0, x1);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt16(new byte[]{x0, x1}));
            }
        }

        public void Pack4x32()
        {
            var src = Random.Span<uint>(Pow2.T11);
            foreach(var x in src)
            {
                (var x0, var x1, var x2, var x3) = Bits.split(x, new N4());
                var y = Bits.pack(x0, x1, x2, x3);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt32(new byte[]{x0, x1, x2, x3}));
            }

            {
                var xval = 0b10100111001110001110010110101000;
                var x0 = (byte)0b10101000;
                var x1 = (byte)0b11100101;
                var x2 = (byte)0b00111000;
                var x3 = (byte)0b10100111;
                Claim.eq(xval, Bits.pack(x0, x1, x2,x3));

                var bsExpect = "10100111001110001110010110101000";
                var bsActual = xval.ToBitString().Format();
                Claim.eq(bsExpect, bsActual);

                var bsAssembly = BitString.Assemble("10101000", "11100101", "00111000","10100111").Format();
                Claim.eq(bsExpect, bsAssembly);
            }
        }

        public void Pack8x64()
        {
            var src = Random.Span<ulong>(Pow2.T11);
            foreach(var x in src)
            {
                (var x0, var x1, var x2, var x3, var x4, var x5, var x6, var x7) = Bits.split(x, new N8());
                var y = Bits.pack(x0, x1, x2, x3, x4, x5, x6, x7);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt64(new byte[]{x0, x1, x2, x3, x4, x5, x6, x7}));
            }
        }

        public void PackBools()
        {                
            var r1 = Bits.pack(false,true, true, false);
            var e1 = (byte)0b0110;
            Claim.eq(1,r1.Length);
            Claim.eq(e1, r1[0]);

            var r2 = Bits.pack(false, true, true, true);
            var e2 = (byte)0b1110;
            Claim.eq(1,r2.Length);
            Claim.eq(e2, r2[0]);

            var r3 = Bits.pack(false, true, true, true, true, false);
            var e3 = (byte)0b011110;
            Claim.eq(1,r3.Length);
            Claim.eq(e3, r3[0]);
        }

        public void PackSlices()
        {
            var src = Random.Span<ulong>(Pow2.T11);
            foreach(var x in src)
            {
                (var x0, var x1, var x2, var x3, var x4, var x5, var x6, var x7) = Bits.split(x, new N8());

                for(var i=0; i<8; i++)
                {
                    var dst = (byte)0;
                    var pos = (byte)(Pow2.pow(i) - 1);
                    Bits.pack(in x0, in x1, in x2, in x3, in x4, in x5, in x6, in x7, pos, ref dst);
                    
                    var j = 0;
                    Claim.yea(gbits.match(dst, j++, x0, pos));
                    Claim.yea(gbits.match(dst, j++, x1, pos));
                    Claim.yea(gbits.match(dst, j++, x2, pos));
                    Claim.yea(gbits.match(dst, j++, x3, pos));
                    Claim.yea(gbits.match(dst, j++, x4, pos));
                    Claim.yea(gbits.match(dst, j++, x5, pos));
                    Claim.yea(gbits.match(dst, j++, x6, pos));
                    Claim.yea(gbits.match(dst, j++, x7, pos));                    
                }
            }
        }

        public void PackBytesIntoU32Span()
        {
            var x0 = BitVector32.Define(0b00001010110000101001001111011001u);
            var x1 = BitVector32.Define(0b00001010110110101001001111000001u);
            var src = Random.Span<byte>(Pow2.T04).ReadOnly();
            var packed = span<uint>(src.Length / 4);
            gbits.pack(src, packed);

            for(var i = 0; i<packed.Length; i++)
            {
                 var x = BitVector32.Define(BitConverter.ToUInt32(src.Slice(4*i)));
                 var y = BitVector32.Define(packed[i]);
                Claim.eq(x, y, AppMsg.Error($"{x.ToBitString()} != {y.ToBitString()}"));
            }        
        }

        public void PackBytesIntoU64Span()
        {
            var x0 = BitVector32.Define(0b00001010110000101001001111011001u);
            var x1 = BitVector32.Define(0b00001010110110101001001111000001u);
            var src = Random.Span<byte>(Pow2.T04).ReadOnly();
            var packed = span<ulong>(src.Length / 8);
            gbits.pack(src, packed);

            for(var i = 0; i<packed.Length; i++)
            {
                 var x = BitVector64.Define(BitConverter.ToUInt64(src.Slice(8*i)));
                 var y = BitVector64.Define(packed[i]);
                Claim.eq(x, y, AppMsg.Error($"{x.ToBitString()} != {y.ToBitString()}"));
            }
        
        }

        void PackSplitPackU16()
        {
            var len = Pow2.T08;
            var lhs = Random.Bytes().Take(len).Freeze();
            var rhs = Random.Bytes().Take(len).Freeze();
            for(var i=0; i<len; i++)
            {
                var dst = Bits.pack(lhs[i],rhs[i]);
                (var x0, var x1) = Bits.split(dst);
                Claim.eq(x0, lhs[i]);
                Claim.eq(x1, rhs[i]);

            }        
        }
        
        public void PackSplitPack()
        {
            PackSplitPackU16();
        }


        public void ReverseBits()
        {
            var x0 = Random.Next<byte>();
            var y0 = x0.ToReversedBitString().PackedBits().First();
            var z0 = Bits.rev(x0);
            Claim.eq(y0,z0);

            var x1 = Random.Next<ushort>();
            var y1 = x1.ToReversedBitString().PackedBits().TakeUInt16();
            var z1 = Bits.rev(x1);
            Claim.eq(y1,z1);

            var x2 = Random.Next<uint>();
            var y2 = x2.ToReversedBitString().PackedBits().TakeUInt32();
            var z2 = Bits.rev(x2);
            Claim.eq(y2,z2);

            var x3 = Random.Next<ulong>();
            var y3 = x3.ToReversedBitString().PackedBits().TakeUInt64();
            var z3 = Bits.rev(x3);
            Claim.eq(y3,z3);

        }

    }
}