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


    public class BitVectorTest : UnitTest<BitVectorTest>
    {
        void BitVectorCreate<N,T>(int samples)
            where N : ITypeNat, new()
            where T : struct
        {
            TypeCaseStart<N,T>();
            var dim = default(N);
            var capacity = BitLayout.SegmentCapacity<T>();
            var segcount = BitLayout.MinSegmentCount<T>(dim.value);
            var src = Random.Span<T>(samples);
            for(var i=0; i<samples; i+= segcount)
            {
                var bvSrc = src.Slice(i,segcount);
                var bv = bvSrc.ToBitVector(dim);
                var x = src[i];
                for(byte j = 0; j < (int)dim.value; j++)
                    Claim.eq(gbits.test(x,j).ToBit(), bv[j]);                

            }
            TypeCaseEnd<N,T>();
        }

        void BitVectorCreate<T>(BitSize dim, int samples)
            where T : struct
        {
            TypeCaseStart<T>();
            var capacity = BitLayout.SegmentCapacity<T>();
            var segcount = BitLayout.MinSegmentCount<T>(dim);
            var src = Random.Span<T>(samples);
            for(var i=0; i<samples; i += segcount)
            {
                var bvSrc = src.Slice(i,segcount);
                var bv = bvSrc.ToBitVector(dim);
                for(var j = 0; j < dim; j++)
                    Claim.eq(gbits.test(src[i],j).ToBit(), bv[j]);                

            }
            TypeCaseEnd<T>();
        }

        void BitVectorCreateU64()
        {
            TypeCaseStart<N64,uint>();
            var samples = Pow2.T08;
            var dim = new N64();
            var segcount = dim / (int)SizeOf<uint>.BitSize;
            var src = Random.Span<uint>(samples);
            for(var i=0; i<src.Length - segcount; i++)
            {
                var bvSrc = src.Slice(i, segcount);
                var bv = bvSrc.ToBitVector(dim);
                var x = Bits.pack(bvSrc[0], bvSrc[1]);
                for(var j = 0; j < dim; j++)
                    Claim.eq(Bits.test(x,j).ToBit(), bv[j]);                
            }
            TypeCaseEnd<N64,uint>();
        }

        void BvCreate<T>(uint dim, int samples)
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(samples);
            var segCapacity = BitLayout.SegmentCapacity<T>();
            Claim.eq(segCapacity, SizeOf<T>.BitSize);

            var segcount = BitLayout.MinSegmentCount<T>(dim);
            for(var i=0; i<samples; i += segcount)
            {
                var bvSrc = src.Slice(i, segcount);
                Claim.eq(bvSrc.Length, segcount);
                var bv = bvSrc.ToBitVector(dim);
                Claim.eq((uint)bv.Length, dim);

                byte segOffset = 0;
                var segIndex = 0;
                for(int n = 0; n < dim; n++, segOffset++)
                {                    
                    if(segOffset == segCapacity - 1)
                    {
                        segOffset = 0;
                        segIndex++;
                    }

                    var bsSrc = bvSrc.ToBitChars();
                    var bsBv = bv.ToBitChars();
            
                    Claim.eq(bvSrc.ToBitString(), bv.ToBitString());

                    if(bv[n] !=  Bit.Parse(bsSrc[n]))
                    {
                        var bsAlt = string.Empty;
                        for(var m = 0; m < bv.Length; m++)
                            bsAlt += bv[m];

                        Trace($"BitPos   = {bv.GetPos(n)}, Segment = {segIndex}, Component = {n}, Offset = {segOffset}");
                        Trace($"BvSource = {bvSrc.ToBitString()}");
                        Trace($"Bv       = {bv.ToBitString()}");                        
                        Trace($"Bv (alt) = {bsAlt}");

                    }
                    Claim.eq(bv[n], Bit.Parse(bsSrc[n]));
                                  
                }

            }

            TypeCaseEnd<T>();
        }


        public void BvCreate()
        {
            var samples = Pow2.T09;
            var dim = (uint)Pow2.T07;

            BvCreate<byte>(dim - 4u, samples);
            BvCreate<ushort>(dim - 3u, samples);
            BvCreate<uint>(dim - 2u, samples);
            BvCreate<ulong>(dim - 1u, samples);

            BvCreate<byte>(dim, samples);
            BvCreate<ushort>(dim, samples);
            BvCreate<uint>(dim, samples);
            BvCreate<ulong>(dim, samples);


        }

        public void BitVectorCreate()
        {
            var samples = Pow2.T08;
            BitVectorCreateU64();
            BitVectorCreate<N63,ulong>(samples);
            BitVectorCreate<N13,ushort>(samples);
            BitVectorCreate<N32,uint>(samples);

            BitVectorCreate<ulong>(63, samples);
            BitVectorCreate<ushort>(13, samples);
            BitVectorCreate<uint>(32, samples);
            

        }

        public void TestSpanBits()
        {
            var src = Random.Span<byte>(Pow2.T03);
            var bvSrc = BitVector64.Define(BitConverter.ToUInt64(src));

            for(byte i=0; i< Pow2.T03*8; i++)
                Claim.eq(src.TestBit(i), bvSrc.TestBit(i));
        }

        public void ScalarProduct1()
        {
            var x = Random.BitMatrix<N5,N5,byte>();
            var y = x.Transpose();
            var z = BitMatrix.Zeros<N5,byte>();
            for(var i = 0; i<x.RowCount; i++)
            {
                var rowX = x.Row(i);
                for(var j=0; j<y.RowCount; j++)
                {
                    var rowY = y.Row(j);
                    z[i,j] = rowX * rowY;
                }
            }
            
        }

        public void ScalarProduct2()
        {
            byte xr0 = 0b10101;
            byte xr1 = 0b00101;
            byte xr2 = 0b11000;
            byte xr3 = 0b00111;
            byte xr4 = 0b01011;
            var x = BitMatrix.Define(N5.Rep, N5.Rep, xr0,xr1,xr2, xr3,xr4);
            var y = x.Transpose();
            var z = BitMatrix.Zeros<N5,byte>();            
            for(var i = 0; i<x.RowCount; i++)
            {
                var rowX = x.Row(i);
                for(var j=0; j<y.RowCount; j++)
                {
                    var rowY = y.Row(j);
                    z[i,j] = rowX * rowY;
                }
            }
            Claim.eq(Bit.On,z[0,0]);

        }

        public void ExtractAlignedRanges()
        {
            byte x0 = 0b11010110;
            byte x1 = 0b10010101;
            byte x2 = 0b10100011;
            byte x3 = 0b10011101;
            byte x4 = 0b01011000;
            var bvx = BitVector.Define(x0,x1,x2,x3,x4);
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
            var bvy = BitVector.Define(y01,y23,y45,y67,y89);            
            Claim.eq(40, bvy.Length);

            ulong z = 0b0101100010011101101000111001010111010110;           
            var bvz = BitVector.Counted(40,z);
            Claim.eq(40, bvz.Length);

            var bsy = bvy.ToBitString().Format2(true);
            var bsx = bvx.ToBitString().Format2(true);
            var bsz = bvz.ToBitString().Format2(true);
            Claim.eq(bsx, "101100010011101101000111001010111010110");
            Claim.eq(bsx, bsy);
            Claim.eq(bsx, bsz);

            Claim.eq(y0, bvx.Extract(0,3));
            Claim.eq(y1, bvx.Extract(4,7));
            Claim.eq(y2, bvx.Extract(8,11));
            Claim.eq(y3, bvx.Extract(12,15));
            Claim.eq(y4, bvx.Extract(16,19));
            Claim.eq(y5, bvx.Extract(20,23));
            Claim.eq(y6, bvx.Extract(24,27));
            Claim.eq(y7, bvx.Extract(28,31));
            Claim.eq(y8, bvx.Extract(32,35));
            Claim.eq(y9, bvx.Extract(36,39));

            Claim.eq(y0, (byte)bvz.Extract(0,3));
            Claim.eq(y1, bvz.Extract(4,7));
            Claim.eq(y2, bvz.Extract(8,11));
            Claim.eq(y3, bvz.Extract(12,15));
            Claim.eq(y4, bvz.Extract(16,19));
            Claim.eq(y5, bvz.Extract(20,23));
            Claim.eq(y6, bvz.Extract(24,27));
            Claim.eq(y7, bvz.Extract(28,31));
            Claim.eq(y8, bvz.Extract(32,35));
            Claim.eq(y9, bvz.Extract(36,39));
    
        }

        public void AbsoluteIndexer()
        {
            ulong z = 0b01011_00010_01110_11010_00111_00101_01110_10110;           
            var bvz = BitVector.Counted(40,z);
            Span<byte> xSrc =  BitConverter.GetBytes(z);
            var bvx = BitVector.Define(xSrc.Slice(0,5).ToArray());
            Claim.eq(gbits.pop(z), bvz.Pop());
            Claim.eq(gbits.pop(z), bvx.Pop());

            for(var i=0; i<40; i++)
                Claim.eq(bvz[i], bvx[i]);
        }

        public void ExtractArbitraryRanges()
        {

            ulong z = 0b01011_00010_01110_11010_00111_00101_01110_10110;           
            var bvz = BitVector.Counted(40,z);
            Span<byte> xSrc =  z.ToBytes();
            Span<ushort> ySrc = xSrc.AsUInt16();
            Claim.eq(ySrc.Length*2, xSrc.Length);

            var bvx = BitVector.Define(xSrc.Slice(0,5).ToArray());
            var bvy = BitVector.Define(ySrc.Slice(0,2).ToArray());            
            var bsx = bvx.ToBitString().Format2(true);
            var bsz = bvz.ToBitString().Format2(true);
            Claim.eq(bsx, bsz);

            Claim.eq((byte)0b10110, bvx.Extract(0, 4));
            Claim.eq((byte)0b01110, bvx.Extract(5, 9));
            Claim.eq((byte)0b00101, bvx.Extract(10, 14));
            Claim.eq((byte)0b00111, bvx.Extract(15, 19));
            Claim.eq((byte)0b11010, bvx.Extract(20, 24));
            Claim.eq((byte)0b01110, bvx.Extract(25, 29));

            Claim.eq((ushort)0b10110, bvy.Extract(0, 4));
            Claim.eq((ushort)0b01110, bvy.Extract(5, 9));
            Claim.eq((ushort)0b00101, bvy.Extract(10, 14));
            Claim.eq((ushort)0b00111, bvy.Extract(15, 19));
            Claim.eq((ushort)0b11010, bvy.Extract(20, 24));
            Claim.eq((ushort)0b01110, bvy.Extract(25, 29));

            Claim.eq((ulong)0b10110, bvz.Extract(0, 4));
            Claim.eq((ulong)0b01110, bvz.Extract(5, 9));
            Claim.eq((ulong)0b00101, bvz.Extract(10, 14));
            Claim.eq((ulong)0b00111, bvz.Extract(15, 19));
            Claim.eq((ulong)0b11010, bvz.Extract(20, 24));
            Claim.eq((ulong)0b01110, bvz.Extract(25, 29));


        }

    }

}


