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

    public class BitParseTest : UnitTest<BitParseTest>
    {
        void ParseBits<T>(int count)
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(count);
            foreach(var x in src)
            {
                var y = BitString.From(x);
                var z = y.ToPrimalValue<T>();
                Claim.eq(x,z);

            }
            TypeCaseEnd<T>();            
        }

        public void ParseBits0()
        {
            var x = BitString.From("01010111");
            var y = x.ToPrimalValue<byte>();
            Claim.eq((byte)0b01010111, y);

        }
        public void ParseBits1()
        {
            var x =  0b111010010110011010111001110000100001101ul;
            var xbs = BitString.From("111010010110011010111001110000100001101");
            var ybs = x.ToBitString();
            Claim.eq(xbs, ybs);                

            var y = xbs.ToPrimalValue<ulong>();
            Claim.eq(x, y);

            var z = ybs.ToPrimalValue<ulong>();
            Claim.eq(x, z);

            var byx = BitConverter.GetBytes(x).ToSpan();
            Bytes.write(x, out Span<byte> byy);
            Claim.eq(byx,byy);
        }

        public void ParseBits2()
        {               
            ParseBits<byte>(Pow2.T08);
            ParseBits<ushort>(Pow2.T08);
            ParseBits<uint>(Pow2.T08);
            ParseBits<ulong>(Pow2.T08);
        }

        public void BlockBitString()
        {
            var src = Random.Span<ulong>(Pow2.T08);

            foreach(var x in src)
            {
                var bsX = x.ToBitString();
                Claim.eq(64, bsX.Length);
                var blocks = bsX.Blocks(8);
                Claim.eq(8, blocks.Length);   

                var bsY = BitString.Assemble(blocks.Select(x => x.Format()).ToArray());
                Claim.eq(bsX, bsY);
                
                var bytes = span<byte>(8);
                for(var i=0; i<8; i++)         
                    bytes[i] = blocks[i].ToPrimalValue<byte>();
                
                var j = 0;
                var y = Bits.pack(
                    bytes[j++], bytes[j++], bytes[j++], bytes[j++], 
                    bytes[j++], bytes[j++], bytes[j++], bytes[j++]);
                Claim.eq(x,y);                
            }

        }
    }

}