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
    using static Bit;

    public class BitToggleTest : UnitTest<BitToggleTest>
    {
        public void ToggleBits()
        {
            ToggleBits<sbyte>(Pow2.T11);
            ToggleBits<byte>(Pow2.T11);
            ToggleBits<short>(Pow2.T11);
            ToggleBits<ushort>(Pow2.T11);
            ToggleBits<int>(Pow2.T11);
            ToggleBits<uint>(Pow2.T11);
            ToggleBits<long>(Pow2.T11);
            ToggleBits<ulong>(Pow2.T11);
            ToggleBits<float>(Pow2.T11);
            ToggleBits<double>(Pow2.T11);        
        }

        void ToggleBits<T>(int count)
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(count).ReadOnly();
            var tLen = SizeOf<T>.BitSize;
            var srcLen = src.Length;
            for(var i = 0; i< srcLen; i++)
            {
                var x = src[i];
                for(var j =0; j< tLen; j++)
                {
                    var before = gbits.test(in x, j);
                    gbits.toggle(ref x, j);
                    var after = gbits.test(in x, j);
                    Claim.neq(before, after);
                    gbits.toggle(ref x, j);
                    Claim.eq(x, src[i]);
                }
            }
            TypeCaseEnd<T>();

        }
        

        public void BitTest()
        {
            Claim.yea(gbits.test(0b00000101, 0));
            Claim.nea(gbits.test(0b00000101, 1));
            Claim.yea(gbits.test(0b00000101, 2));
            
            Claim.yea(gbits.test(0b00000111, 0));
            Claim.yea(gbits.test(0b00000111, 1));
            Claim.yea(gbits.test(0b00000111, 2));
        }


        public void BitSize()
        {
            Claim.eq(8, gmath.bitsize<byte>());
            Claim.eq(8, gmath.bitsize<sbyte>());
            Claim.eq(16, gmath.bitsize<short>());
            Claim.eq(16, gmath.bitsize<ushort>());
            Claim.eq(32, gmath.bitsize<int>());
            Claim.eq(32, gmath.bitsize<uint>());
            Claim.eq(64, gmath.bitsize<long>());
            Claim.eq(64, gmath.bitsize<ulong>());
            Claim.eq(32, gmath.bitsize<float>());
            Claim.eq(64, gmath.bitsize<double>());
        }

        public void EnableBits()
        {
            var x1 = (sbyte)0;
            var y1 = Bits.enable(ref x1, 7);
            Claim.eq(SByte.MinValue, y1);
            Claim.eq("10000000", y1.ToBitString());


            var x2 = (byte)0;
            var y2 = Bits.enable(ref x2, 7);
            Claim.eq(SByte.MinValue, (sbyte)y1);
            Claim.eq("10000000", y1.ToBitString());

            var x3 = -1;
            Claim.eq(x3 >> 10, -1);
            
        }

        public void BitConvert()
        {

            Claim.eq((byte)0, (byte)Off);
            Claim.eq((byte)1, (byte)On);

            Claim.eq((ushort)0, (ushort)Off);
            Claim.eq((ushort)1, (ushort)On);

            Claim.eq(0u, (uint)Off);
            Claim.eq(1u, (uint)On);

            Claim.eq(0ul, (ulong)Off);
            Claim.eq(1ul, (ulong)On);

            Claim.eq(BinaryDigit.Zed, Off);
            Claim.eq(BinaryDigit.One, On);

        }


        public void BitOps()
        {

            //parse
            Claim.eq(Off, Z0.Bit.Parse('0'));
            Claim.eq(On, Z0.Bit.Parse('1'));

            //flip
            Claim.eq(On, ~ Off);
            Claim.eq(Off, ~ On);

            //and
            Claim.eq(On, On & On);
            Claim.eq(Off, On & Off);
            Claim.eq(Off, Off & On);
            Claim.eq(Off, Off & Off);

            //or
            Claim.eq(On, Off | On);
            Claim.eq(On, On | Off);
            Claim.eq(Off, Off | Off);
            Claim.eq(On, On | On);
            
            
            //xor
            Claim.eq(On, Off ^ On);
            Claim.eq(On, On ^ Off);
            Claim.eq(Off, Off ^ Off);
            Claim.eq(Off, On ^ On);
        }

        public void Convert()
        {
            static T toInt<T>(Bit b)
                where T : struct
                    => convert<int,T>((int)b); 

            Claim.eq(1, toInt<int>(Bit.On)); 
            Claim.eq(0, toInt<int>(Bit.Off)); 
            Claim.eq(1u, toInt<uint>(Bit.On)); 
            Claim.eq(0u, toInt<uint>(Bit.Off)); 
        }

    }

}