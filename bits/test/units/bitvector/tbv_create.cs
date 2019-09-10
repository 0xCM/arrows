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

    using static zfunc;

    public class tbv_create : UnitTest<tbv_create>
    {

        public void create_primal()
        {
            create_primal_64_check();

        }

        public void create_gunfixed()
        {
            var dim = (uint)Pow2.T07;

            create_gunfixed_check<byte>(dim - 4u);
            create_gunfixed_check<ushort>(dim - 3u);
            create_gunfixed_check<uint>(dim - 2u);
            create_gunfixed_check<ulong>(dim - 1u);

            create_gunfixed_check<byte>(dim);
            create_gunfixed_check<ushort>(dim);
            create_gunfixed_check<uint>(dim);
            create_gunfixed_check<ulong>(dim);

            create_gunfixed_check<ulong>(63);
            create_gunfixed_check<ushort>(13);
            create_gunfixed_check<uint>(32);            

        }

        public void create_ngunfixed()
        {
            create_ngunfixed_check<N63,ulong>();
            create_ngunfixed_check<N13,ushort>();
            create_ngunfixed_check<N32,uint>();
        }

        public void span_bits()
        {
            var src = Random.Span<byte>(Pow2.T03);
            var bvSrc = BitVector64.FromScalar(BitConverter.ToUInt64(src));

            for(var i=0; i<src.Length; i++)
            {
                ref var x = ref src[i];
                for(var j = 0; j < Pow2.T03; j++)
                    Claim.eq(gbits.test(x,j), bvSrc.Test(i*Pow2.T03 + j));
            }
        }

        public void span_bits_check<T>()
            where T : unmanaged
        {
            var sizeT = size<T>();
            var src = Random.Span<byte>(sizeT);
            Bytes.read(src, 0, out T dst);
    
            // var bvSrc = BitVector64.FromScalar(BitConverter.ToUInt64(src));

            // for(var i=0; i<src.Length; i++)
            // {
            //     ref var x = ref src[i];
            //     for(var j = 0; j < sizeT; j++)
            //         Claim.eq(gbits.test(x,j), bvSrc.Test(i*Pow2.T03 + j));
            // }
        }

        public void absolute_index()
        {
            ulong z = 0b01011_00010_01110_11010_00111_00101_01110_10110;           
            var bvz = BitVector.FromCells(40,z);
            Span<byte> xSrc =  BitConverter.GetBytes(z);
            var bvx = BitVector.FromCells(xSrc.Slice(0,5).ToArray());
            Claim.eq(gbits.pop(z), bvz.Pop());
            Claim.eq(gbits.pop(z), bvx.Pop());

            for(var i=0; i<40; i++)
                Claim.eq(bvz[i], bvx[i]);
        }

        public void create_N12i32()
        {
            var bv = BitVector.FromCell(0b101110001110,new N12());
            Claim.eq(bv[0], Bit.Off);
            Claim.eq(bv[1], Bit.On);
            Claim.eq(bv[11], Bit.On);

        }

        public void lsb64()
        {
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector64();
                var n = Random.Next(1, bv.Length);
                var result = bv.Lsb(n).ToBitString();
                var expect = bv.ToBitString()[0, n - 1];
                Claim.eq(expect, result);
            }
        }

        public void msb64()
        {
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector64();
                var n = Random.Next(1, bv.Length);
                var result = bv.Msb(n).ToBitString();
                var expect = bv.ToBitString().Reverse()[0, n - 1].Reverse();
                Claim.eq(expect, result);
            }
        }

        void rot8()
        {
            var x = BitVector8.Zero;
            var offset = 3;
            while(++x)
            {
                var y = x.Replicate();
                Trace($"rotl({y}:{offset}) = {y.Rol((byte)offset)}"); 
            }
        }

        public void powers()
        {
            var x = Random.BitVector8();
            var expect2 = x * x;
            var actual2 = x^2;
            Claim.eq(expect2, actual2);

            var expect4 = expect2 * expect2;
            var actual4 = x^4;
            Claim.eq(expect4, actual4);

            var expect8 = expect4 * expect4;
            var actual8 = x^8;
            Claim.eq(expect8, actual8);

            var expect16 = expect8 * expect8;
            var actual16 = x^16;
            Claim.eq(expect16, actual16);
        }

        public void powers2()
        {

            var max = 0;
            var vectors = BitVector8.All.ToArray();
            const int MaxCount = 256;
            Claim.yea(vectors.Length == MaxCount);
            Claim.eq(vectors.ToSet().Count, MaxCount);

            for(var i=0; i< MaxCount; i++)
            {
                var v = vectors[i];
                if(v.Empty)
                    continue;

                for(var j=2; j<MaxCount; j++)                
                {
                    
                    var p = v^j;
                    if(p == BitVector8.One)
                    {
                        if(j > max)
                            max = j;
                        break;
                    }
                }

            }

        }

        void create_ngunfixed_check<N,T>()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            TypeCaseStart<N,T>();
            var dim = default(N);
            var segcount = BitGrid.MinSegmentCount<T>(dim.value);
            var src = Random.Span<T>(SampleSize);
            for(var i=0; i<SampleSize; i+= segcount)
            {
                var bvSrc = src.Slice(i,segcount);
                var bv = bvSrc.ToBitVector(dim);
                var x = src[i];
                for(byte j = 0; j < (int)dim.value; j++)
                    Claim.eq(gbits.test(x,j).ToBit(), bv[j]);                

            }
            TypeCaseEnd<N,T>();
        }

        void create_gunfixed_check<T>(BitSize dim)
            where T : unmanaged
        {
            TypeCaseStart<T>();
            var segcount = BitGrid.MinSegmentCount<T>(dim);
            var src = Random.Span<T>(SampleSize);
            for(var i=0; i<SampleSize; i += segcount)
            {
                var bvSrc = src.Slice(i,segcount);
                var bv = bvSrc.ToBitVector(dim);
                for(var j = 0; j < dim; j++)
                    Claim.eq(gbits.test(src[i],j).ToBit(), bv[j]);                

            }
            TypeCaseEnd<T>();
        }

        void create_primal_64_check()
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

        void create_gunfixed_check<T>(uint dim, int ignored = 0)
            where T : unmanaged
        {
            TypeCaseStart<T>();
            var src = Random.MemorySpan<T>(SampleSize);
            var segCapacity = BitGrid.SegmentCapacity<T>();
            Claim.eq(segCapacity, gbits.width<T>());

            var segcount = BitGrid.MinSegmentCount<T>(dim);
            for(var i=0; i<SampleSize; i += segcount)
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

                        Trace($"BitPos   = {CellIndex<T>.FromIndex(n)}, Segment = {segIndex}, Component = {n}, Offset = {segOffset}");
                        Trace($"BvSource = {bvSrc.ToBitString()}");
                        Trace($"Bv       = {bv.ToBitString()}");                        
                        Trace($"Bv (alt) = {bsAlt}");

                    }
                    Claim.eq(bv[n], bs[n]);                                  
                }
            }

            TypeCaseEnd<T>();
        }

    }

}


