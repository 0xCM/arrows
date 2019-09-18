//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
    using static BitParts;

    public class ts_partition : UnitTest<ts_partition>
    {
        protected override int CycleCount => Pow2.T14;
        
        public void bitpart_32x8()
        {
            var count = (int)Part32x8.Count;
            var width = (int)Part32x8.Width;
            bitpart_check<uint,byte>(Bits.part32x8, count,width);
        }

        public void bitpart_21x3()
        {                 
            var count = (int)Part21x3.Count;
            var width = (int)Part21x3.Width;
            bitpart_check<uint,byte>(Bits.part21x3, count,width);
        }

        public void bitpart_24x3()
        {                 
            var count = (int)Part24x3.Count;
            var width = (int)Part24x3.Width;
            bitpart_check<uint,byte>(Bits.part24x3, count,width);
        }

        public void bitpart_32x4()
        {
            var count = (int)Part32x4.Count;
            var width = (int)Part32x4.Width;
            Span<byte> dst = stackalloc byte[count];

            for(var sample = 0; sample < SampleSize; sample++)
            {
                var x = Random.Next<uint>();
                Bits.part32x4(x, dst);
                Span<byte> dstRef = stackalloc byte[count];
                part32x4_ref(x, dstRef);
                var xbs = x.ToBitString();   
                var bsparts = xbs.Partition(width).Map(bs => bs.ToBitVector8());
                for(var i=0; i<count; i++)  
                {          
                    Claim.eq(bsparts[i], dst[i].ToBitVector());
                    Claim.eq(bsparts[i], dstRef[i].ToBitVector());
                }
            }
        }


        public void bitpart_32x4_bench()
        {
            var opcount = RoundCount*CycleCount;
            var sw = stopwatch(false);
            var opname = $"bitpart_32x4";
            var count = (int)Part32x4.Count;
            Span<byte> dst = stackalloc byte[count];

            for(var k = 0; k < opcount; k++)
            {
                var x = Random.Next<uint>();
                sw.Start();
                Bits.part32x4(x, dst);
                sw.Stop();
            }

            Collect((opcount,sw,opname));
        }

        public void bitpart_32x8_bench()
        {
            var opcount = RoundCount*CycleCount;
            var sw = stopwatch(false);
            var opname = $"bitpart_32x8";
            var count = (int)Part32x8.Count;
            Span<byte> dst = stackalloc byte[count];

            for(var k = 0; k < opcount; k++)
            {
                var x = Random.Next<uint>();
                sw.Start();
                Bits.part32x8(x, dst);
                sw.Stop();
            }

            Collect((opcount,sw,opname));
        }

        public void bitpart_32x4_ref_bench()
        {
            var opcount = RoundCount*CycleCount;
            var sw = stopwatch(false);
            var opname = $"bitpart_32x4_ref";
            var count = (int)Part32x4.Count;
            Span<byte> dst = stackalloc byte[count];

            for(var k = 0; k < opcount; k++)
            {
                var x = Random.Next<uint>();
                sw.Start();
                part32x4_ref(x, dst);
                sw.Stop();
            }

            Collect((opcount,sw,opname));

        }

        void bitpart_check<S,T>(Partitioner<S,T> part, int count, int width)
            where S : unmanaged
            where T : unmanaged
        {
            Span<T> dst = stackalloc T[count];

            for(var sample = 0; sample < SampleSize; sample++)
            {
                var x = Random.Next<S>();
                
                part(x, dst);
                var y = BitString.FromScalar(x).Partition(width).Map(bs => bs.ToBitVector8());
                for(var i=0; i<count; i++)  
                    Claim.eq(y[i], BitString.FromScalar(dst[i]).ToBitVector8());
            }
        }

        // The algorithms for the functions below were taken from https://github.com/lemire/SIMDCompressionAndIntersection/blob/master/src/bitpacking.cpp
        public static unsafe void part32x4_ref(uint src, Span<byte> dst)
        {
            for(int i = 0, j=0; i < 32; i +=4, j++)
                dst[j] = (byte)(((src) >> i) % (1u << 4));
        }

        static unsafe void unpack32x4(uint* pSrc, uint* pDst)
        {
            for(var inner = 0; inner < 32; inner +=4)
                *(pDst++) = ((*pSrc) >> inner) % (1u << 4);
        }
        
        static unsafe void fastunpack4(uint* pSrc, uint* pDst)
        {
           for(var outer = 0; outer < 4; ++outer) 
                unpack32x4(pSrc++,pDst);
        }

    }

}