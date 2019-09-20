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

    public class ts_toggle : ScalarBitTest<ts_toggle>
    {
        public void toggle8i()
        {
            check_toggle<sbyte>();
            
        }

        public void toggle8u()
        {
            check_toggle<byte>();
        }

        public void toggle16i()
        {
            check_toggle<short>();
            
        }

        public void toggle16u()
        {
            check_toggle<ushort>();

        }


        public void toggle32i()
        {
            check_toggle<int>();
            
        }

        public void toggle32u()
        {
            check_toggle<uint>();

        }

        public void toggle64i()
        {
            check_toggle<long>();            
        }


        public void toggle64u()
        {
            check_toggle<ulong>();

        }

        public void toggle32f()
        {
            check_toggle<float>();
        }

        public void toggle64f()
        {
            check_toggle<double>();        

        }
        

        public void testbits()
        {
            Claim.yea(gbits.test(0b00000101, (byte)0));
            Claim.nea(gbits.test(0b00000101, (byte)1));
            Claim.yea(gbits.test(0b00000101, (byte)2));
            
            Claim.yea(gbits.test(0b00000111, (byte)0));
            Claim.yea(gbits.test(0b00000111, (byte)1));
            Claim.yea(gbits.test(0b00000111, (byte)2));
        }


        public void bitsizes()
        {
            Claim.eq(8, BitSize.Size<byte>());
            Claim.eq(8, BitSize.Size<sbyte>());
            Claim.eq(16, BitSize.Size<short>());
            Claim.eq(16, BitSize.Size<ushort>());
            Claim.eq(32, BitSize.Size<int>());
            Claim.eq(32, BitSize.Size<uint>());
            Claim.eq(64, BitSize.Size<long>());
            Claim.eq(64, BitSize.Size<ulong>());
            Claim.eq(32, BitSize.Size<float>());
            Claim.eq(64, BitSize.Size<double>());
        }

        public void enablebits()
        {
            var x1 = (sbyte)0;
            var y1 = BitMask.enable(ref x1, 7);
            Claim.eq(SByte.MinValue, y1);
            Claim.eq("10000000", y1.ToBitString());


            var x2 = (byte)0;
            var y2 = BitMask.enable(ref x2, 7);
            Claim.eq(SByte.MinValue, (sbyte)y1);
            Claim.eq("10000000", y1.ToBitString());

            var x3 = -1;
            Claim.eq(x3 >> 10, -1);
            
        }

        void check_toggle<T>(int count = DefaultSampleSize)
            where T : struct
        {
            var src = Random.Span<T>(count).ReadOnly();
            var tLen = bitsize<T>();
            var srcLen = src.Length;
            for(var i = 0; i< srcLen; i++)
            {
                var x = src[i];
                for(byte j =0; j< tLen; j++)
                {
                    var before = gbits.test(in x, j);
                    BitMaskG.toggle(ref x, j);
                    var after = gbits.test(in x, j);
                    Claim.neq(before, after);
                    BitMaskG.toggle(ref x, j);
                    Claim.eq(x, src[i]);
                }
            }
        }

    }

}