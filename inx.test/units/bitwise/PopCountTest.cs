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
    
    public class PopCountTest : UnitTest<PopCountTest>
    {
        public void PopCount1()
        {
            var src = (ushort)3209;
            src.Unpack(out Span<Bit> bits);
            var bitsPC = bits.PopCount();
            src.Unpack(out Span<byte> bytes);
            var bytesPC = bytes.PopCount();
            Claim.eq(bitsPC, bytesPC);
        }

        public void PopCount2()
        {
            var src = 32093283484328432ul;
            src.Unpack(out Span<Bit> bits);
            var bitsPC = bits.PopCount();
            src.Unpack(out Span<byte> bytes);
            var bytesPC = bytes.PopCount();
            Claim.eq(bitsPC, bytesPC);

        }

        public void PopCount3()
        {
            var src = 39238923;
            src.Unpack(out Span<Bit> bits);
            var bitsPC = bits.PopCount();
            src.Unpack(out Span<byte> bytes);
            var bytesPC = bytes.PopCount();
            Claim.eq(bitsPC, bytesPC);

        }

        public void PopCount4()
        {
            var x =  0b111010010110011010111001110000100001101ul;
            var xbs = BitString.Define("111010010110011010111001110000100001101");
            var y = xbs.ToValue<ulong>();
            Claim.eq(x, y);

            var pcx = Bits.pop(x);
            Claim.eq(pcx, 20);

            Claim.eq(Bits.pop(x), Bits.pop(y));
        }

        public void PopCount5()
        {
            var xBytes = BitConverter.GetBytes(0b111010010110011010111001110000100001101ul).ToSpan();
            xBytes.Unpack(out Span<Bit> xBits);
            var xBitsPC = xBits.PopCount();
            var xBytesPC = xBytes.PopCount();

            Claim.eq(xBitsPC, xBytesPC);

        }

        public void PopCount6()
        {
            var xBytes = Random.Span<byte>(5);
            var x = Bytes.read<ulong>(xBytes);
            var xPC = Bits.pop(x);
            xBytes.Unpack(out Span<Bit> xBits);
            var xBitsPC = xBits.PopCount();
            var xBytesPC = xBytes.PopCount();

            Claim.eq(xPC, xBitsPC);
            Claim.eq(xPC, xBytesPC);
        }

        public void PopCount7()
        {
            var xBytes = Random.Span<byte>(Pow2.T10 - 3);
            var xBytesPC = xBytes.PopCount();
            var xBitsPC = xBytes.Unpack(out Span<Bit> bits).PopCount();
            Claim.eq(xBitsPC, xBytesPC);
        }

        void PopCounts<N,T>()
            where T : struct
            where N : INatPow2, new()
        {
            var src = Random.Span<T>((int)new N().value);

            var pc1 = 0ul;
            for(var i = 0; i<src.Length; i++)
            {
                var bv = BitVector<N,T>.Define(src[i]);
                pc1 += bv.Pop();
            }

            for(var i = 0; i<src.Length; i++)
            {
                var bs = BitStringConvert.FromValue(in src[i]);
            }

        }


    }

}