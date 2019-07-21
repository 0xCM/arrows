//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public class BitStringTest : UnitTest<BitStringTest>
    {
        void TestBsType<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            
            var partlen = (int)SizeOf<T>.BitSize;
            var v1 = Random.Vec128<T>();
            var bs = v1.ToBitString().Format(blockWidth:partlen, blocksep:' ');
            var parts = bs.Split(' ');

            parts.ForEach(part => Claim.eq(partlen, part.Length));
            
            for(var i = 0; i < parts.Length; i++)
            {
                var part = BitString.From(parts[i]);
                var x = part.ToPrimalValue<T>();
                var y = v1[i];
                Claim.eq(x,y);
            }
                
            TypeCaseEnd<T>();                

        }

        void BitStringToValue<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(Pow2.T08);
            for(var i=0; i<src.Length; i++)
            {
                var x = src[i];
                var bs = BitString.From(src[i]);
                var y = bs.ToPrimalValue<T>();
                Claim.eq(x,y);                
            }

            TypeCaseEnd<T>();                
        }

        public void SpanToBitString()
        {
            var src0 = 0b_01011000_00001000_11111010_01100101u;
            var bc0 = gbits.bitchars(src0).Reverse();
            var bs0 = bc0.ToBitString();
            var fmt0 = bc0.Format();
            Claim.eq(bs0.ToPrimalValue<uint>(), src0);

            Span<byte> src1 = new byte[]{101,250,8,88};
            Span<uint> src2 = new uint[]{BitConverter.ToUInt32(src1)};
            var src3 = BitConverter.ToUInt32(src1);
            
            Claim.eq(fmt0, src3.ToBitString().Format());

        }
        public void BitStringToValue()
        {
            BitStringToValue<byte>();
            BitStringToValue<sbyte>();
            BitStringToValue<short>();
            BitStringToValue<ushort>();
            BitStringToValue<int>();
            BitStringToValue<uint>();
            BitStringToValue<long>();
            BitStringToValue<ulong>();
        }

        public void TestBsTypes()
        {
            TestBsType<byte>();
            TestBsType<sbyte>();
            TestBsType<short>();
            TestBsType<ushort>();
            TestBsType<int>();
            TestBsType<uint>();
            TestBsType<long>();
            TestBsType<ulong>();
        }

        public void TestBsEquality()
        {
            var bs1Source = "0000010100001100101010001";
            var bs2Source = BitString.From(bs1Source).Content;

            Claim.eq(bs1Source.Length, bs2Source.Length);
            for(var i=bs1Source.Length - 1; i>=0; i--)
                Claim.eq(bs2Source[i], bs1Source[i]);

            var bs1 = BitString.From(bs1Source);
            var bs2 = BitString.From(bs2Source);
            Claim.yea(bs1.Eq(bs2));

        }

        public void TestBsVariations()
        {
            var x = 0b10100001100101010001u;
            var bsSrc = "0000010100001100101010001";
            var bs1 = BitString.From(bsSrc);
            var bs2 = BitString.From(0b10100001100101010001u);
            var y = bs1.ToPrimalValue<uint>();
            Claim.eq(x,y);
            Claim.yea(bs1.Eq(bs2));
        }

        public void BitViewBitString()
        {
            var x = Random.Vec256<int>();
            var y = x.ToBitView();
            var ys = y.ToSpan().ToBitString();
            var xs = x.ToBitString();
            Claim.eq(ys,xs);
        }

        public void GenerateWords()
        {            
            var wordLen = 8;
            var wordCount = (int)Pow2.pow(wordLen);
            var words = BinaryLanguage.Get().Words(wordLen).ToArray();
            Claim.eq(wordCount, words.Length);
            iter(words, w => Claim.eq(wordLen, w.Format().Length));
            for(var i=0; i<wordCount; i++)
            {
                var wi = BitString.From(words[i].Content);
                var value = wi.ToPrimalValue<int>();
                Claim.eq(i, value);
            }
        }

        public void TestBlockage()
        {
            var src = "0000010100001100101010001";
            var bs = BitString.From(src);
            Claim.eq(bs.Length, 25);
            
            var b1 = bs.Blocks2(1);
            Claim.eq(src.Length, b1.Length);
            
            var b5 = bs.Blocks(5);
            Claim.eq(5,b5.Length);

            var b3 = bs.Blocks(3);
            Claim.eq(9,b3.Length);

        }
    }

}