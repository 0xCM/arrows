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
                var part = BitString.Parse(parts[i]);
                var x = part.TakePrimalValue<T>();
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
                var bs = BitString.FromScalar(src[i]);
                var y = bs.TakePrimalValue<T>();
                Claim.eq(x,y);                
            }

            TypeCaseEnd<T>();                

        }

        public void VerifyPow2Bitstrings()
        {
            for(var i=0; i<=231; i++)
            {
                var bs = BitString.FromPow2(i);
                Claim.eq((int)bs.Length, i + 1);
                for(var j=0; j<bs.Length; j++)
                {
                    if(j != bs.Length - 1)
                        Claim.eq(bs[j], Bit.Off);
                    else
                        Claim.eq(bs[j], Bit.On);
                }
                
                if(i <= 63)
                {
                    var val1 = Pow2.pow((ulong)i);
                    var val2 = bs.TakePrimalValue<ulong>();
                    Claim.eq(val1,val2);
                }    
            }

        }

        public void BitStringToValueU32()
        {
            var x0 = 0b_01011000_00001000_11111010_01100101u;
            var x1 = x0.ToBitString();
            var x2 = x1.TakePrimalValue<uint>();
            Claim.eq(x0,x2);            

        }

        public void BitStringToValueU8()
        {
            var x = (byte)0b10110110;
            var y = x.ToBitString();
            Claim.eq("10110110", y);
            Claim.eq(5, y.PopCount());
            
            var z = y.PackedBits();
            Claim.eq(1,z.Length);
            

            Claim.eq(x, z[0]);
        }

        public void BitStringToValue()
        {
            BitStringToValue<byte>();
            BitStringToValue<ushort>();
            BitStringToValue<uint>();
            BitStringToValue<ulong>();

        }

        void TestBsTypes()
        {
            TestBsType<byte>();
            TestBsType<ushort>();
            TestBsType<uint>();
            TestBsType<ulong>();
        }


        public void TestBsEquality()
        {
            var bs1Source = "0000010100001100101010001";
            var bs2Source = BitString.Parse(bs1Source).Format();

            Claim.eq(bs1Source.Length, bs2Source.Length);
            
            for(var i=bs1Source.Length - 1; i>=0; i--)
                Claim.eq(bs2Source[i], bs1Source[i]);

            var bs1 = BitString.Parse(bs1Source);
            var bs2 = BitString.Parse(bs2Source);
            Claim.yea(bs1.Eq(bs2));

        }

        public void TestBsVariations()
        {
            var x = 0b10100001100101010001u;
            var bsSrc = "0000010100001100101010001";
            var bs1 = BitString.Parse(bsSrc);
            Claim.eq((int)bs1.Length, bsSrc.Length);

            var bs2 = BitString.FromScalar(0b10100001100101010001u);
            var y = bs1.TakePrimalValue<uint>();
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
            
            for(var i=0u; i<wordCount; i++)
            {
                var w = words[i];
                var value = w.TakePrimalValue<byte>();
                Claim.eq(i, value);
            }
        }

        public void TestBlockage()
        {
            var src = "0000010100001100101010001";
            var bs = BitString.Parse(src);
            Claim.eq(bs.Length, 25);
            
            var b1 = bs.Blocks(1);
            Claim.eq(src.Length, b1.Length);
            
            var b5 = bs.Blocks(5);
            Claim.eq(5,b5.Length);

            var b3 = bs.Blocks(3);
            Claim.eq(9,b3.Length);

        }
    }

}