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
        void GenericNaturalCreate<N,T>(int samples)
            where N : ITypeNat, new()
            where T : struct
        {
            TypeCaseStart<N,T>();
            var dim = default(N);
            var segcount = BitGridLayout.MinSegmentCount<T>(dim.value);
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

        void GenericCreate<T>(BitSize dim, int samples)
            where T : struct
        {
            TypeCaseStart<T>();
            var segcount = BitGridLayout.MinSegmentCount<T>(dim);
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
            var segcount = dim / (int)gbits.width<uint>();
            var src = Random.Span<uint>(samples);
            for(var i=0; i<src.Length - segcount; i++)
            {
                var bvSrc = src.Slice(i, segcount);
                var bv = bvSrc.ToBitVector(dim);
                var x = Bits.pack(bvSrc[0], bvSrc[1]);
                for(var j = 0; j < dim; j++)
                    Claim.eq(BitMask.test(x,j).ToBit(), bv[j]);                
            }
            TypeCaseEnd<N64,uint>();
        }

        void BvCreate<T>(uint dim, int samples)
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Memory<T>(samples);
            var segCapacity = BitGridLayout.SegmentCapacity<T>();
            Claim.eq(segCapacity, gbits.width<T>());

            var segcount = BitGridLayout.MinSegmentCount<T>(dim);
            for(var i=0; i<samples; i += segcount)
            {
                var bvSrc = src.Slice(i, segcount);
                Claim.eq(bvSrc.Length, segcount);
                var bv = bvSrc.ToBitVector(dim);
                Claim.eq((uint)bv.Length, dim);

                byte segOffset = 0;
                var segIndex = 0;
                var bs = BitString.FromScalars(bvSrc);

                for(int n = 0; n < dim; n++, segOffset++)
                {                    
                    if(segOffset == segCapacity - 1)
                    {
                        segOffset = 0;
                        segIndex++;
                    }            

                    if(bv[n] !=  bs[n])
                    {
                        var bsAlt = string.Empty;
                        for(var m = 0; m < bv.Length; m++)
                            bsAlt += bv[m];

                        Trace($"BitPos   = {BitPos<T>.FromIndex(n)}, Segment = {segIndex}, Component = {n}, Offset = {segOffset}");
                        Trace($"BvSource = {bvSrc.ToBitString()}");
                        Trace($"Bv       = {bv.ToBitString()}");                        
                        Trace($"Bv (alt) = {bsAlt}");

                    }
                    Claim.eq(bv[n], bs[n]);                                  
                }
            }

            TypeCaseEnd<T>();
        }


        public void GenericCreate()
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

            GenericCreate<ulong>(63, samples);
            GenericCreate<ushort>(13, samples);
            GenericCreate<uint>(32, samples);            

        }

        public void GenericNaturalCreate()
        {
            var samples = Pow2.T08;
            BitVectorCreateU64();
            GenericNaturalCreate<N63,ulong>(samples);
            GenericNaturalCreate<N13,ushort>(samples);
            GenericNaturalCreate<N32,uint>(samples);
        }

        public void TestSpanBits()
        {
            var src = Random.Span<byte>(Pow2.T03);
            var bvSrc = BitVector64.FromScalar(BitConverter.ToUInt64(src));

            for(var i=0; i<src.Length; i++)
            {
                ref var x = ref src[i];
                for(var j = 0; j < 8; j++)
                    Claim.eq(gbits.test(x,j), bvSrc.TestBit(i*8 + j));
            }
        }

        public void AbsoluteIndexer()
        {
            ulong z = 0b01011_00010_01110_11010_00111_00101_01110_10110;           
            var bvz = BitVector.FromSegments(40,z);
            Span<byte> xSrc =  BitConverter.GetBytes(z);
            var bvx = BitVector.FromSegments(xSrc.Slice(0,5).ToArray());
            Claim.eq(gbits.pop(z), bvz.Pop());
            Claim.eq(gbits.pop(z), bvx.Pop());

            for(var i=0; i<40; i++)
                Claim.eq(bvz[i], bvx[i]);
        }

        public void BitVector12Test()
        {
            var bv = BitVector.FromScalar(0b101110001110,new N12());
            Claim.eq(bv[0], Bit.Off);
            Claim.eq(bv[1], Bit.On);
            Claim.eq(bv[11], Bit.On);

        }

        public void Lsb64()
        {
            for(var i=0; i< DefaltCycleCount; i++)            
            {
                var bv = Random.BitVector64();
                var n = Random.Next(1, bv.Length);
                var result = bv.Lsb(n).ToBitString();
                var expect = bv.ToBitString()[0, n - 1];
                Claim.eq(expect, result);
            }
        }

        public void Msb64()
        {
            for(var i=0; i< DefaltCycleCount; i++)            
            {
                var bv = Random.BitVector64();
                var n = Random.Next(1, bv.Length);
                var result = bv.Msb(n).ToBitString();
                var expect = bv.ToBitString().Reversed()[0, n - 1].Reversed();
                Claim.eq(expect, result);
            }
        }

    }

}


