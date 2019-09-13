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
    
    public class ts_pop : UnitTest<ts_pop>
    {
        public void pop1()
        {
            var src = (ushort)0b11001111;
            src.Unpack(out Span<Bit> bits);            
            var bitsPC = bits.PopCount();
            Claim.eq(6,bitsPC);

            src.Unpack(out Span<byte> bytes);
            Claim.eq(2, bytes.Length);
            
            var bytesPC = bytes.PopCount();
            Claim.eq(bitsPC, bytesPC);
        }


        public void pop5()
        {
            var xBytes = BitConverter.GetBytes(0b111010010110011010111001110000100001101ul).ToSpan();
            xBytes.Unpack(out Span<Bit> xBits);
            var xBitsPC = xBits.PopCount();
            var xBytesPC = xBytes.PopCount();

            Claim.eq(xBitsPC, xBytesPC);
        }

        public void pop6()
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

        public void pop7()
        {
            var xBytes = Random.Span<byte>(Pow2.T10 - 3);
            var xBytesPC = xBytes.PopCount();
            var xBitsPC = xBytes.Unpack(out Span<Bit> bits).PopCount();
            Claim.eq(xBitsPC, xBytesPC);
        }

        void PopCounts<N,T>()
            where T : unmanaged
            where N : INatPow2, new()
        {
            var src = Random.Span<T>((int)new N().value);

            var pc1 = 0ul;
            for(var i = 0; i<src.Length; i++)
            {
                var bv = BitVector<N,T>.From(src[i]);
                pc1 += bv.Pop();
            }

            for(var i = 0; i<src.Length; i++)
            {
                var bs = BitString.FromScalar(in src[i]);
            }
        }
    }
}