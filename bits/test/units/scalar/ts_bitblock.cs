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

    public class ts_bitblock : ScalarBitTest<ts_bitblock>
    {


        public void bitblock32_spans()
        {
            var x = BitBlock32.Alloc();
            x.Bit0 = 1;
            x.Bit5 = 1;
            x.Bit19 = 1;
            var y = BitBlock.AsSpan(ref x);
            Claim.eq(y[0], x.Bit0);
            Claim.eq(y[5], x.Bit19);

            Claim.eq(x[0], (byte)1);
            Claim.eq(x[5], (byte)1);
            Claim.eq(x[19], (byte)1);

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.Span<byte>(Pow2.T05);
                var dstBlock = BitBlock32.FromSpan(src);
                for(var j = 0; j<src.Length; j++)
                    Claim.eq(src[j],dstBlock[j]);
                
                var dstSpan = BitBlock.AsSpan(ref dstBlock);
                for(var j=0; j<dstSpan.Length; j++)                
                {
                    Bits.toggle(ref dstSpan[j],0);
                    Claim.neq(dstBlock[j], src[j]);
                }                            
            }

        }

        public void bitblock32_pack()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.Next<uint>();
                var block = BitBlock32.Alloc();
                var dst = 0u;
                BitParts.part32x1(src, ref block);                
                BitParts.pack32x1(in block, ref dst);
                Claim.eq(dst,src);
            }

        }

        public void bitblock_bitstring()
        {
            var src = Random.BitString(n8);
            var block = src.ToBitBlock(n8);
            var u = src.ToBitVector(n8);
            for(var i=0; i< 8; i++)
                Claim.yea(block[i] == u[i]);
        }

        
        public void bitblock_generic()
        {
            var srcA = Random.BitString(16).BitSeq;
            var srcB = Random.BitString(16).BitSeq;
            ref var x = ref BitBlock.FromSpan(srcA, out BitBlock16 _);
            ref var xG = ref BitBlock.AsGeneric(ref x);            
            for(var i=0; i<xG.Length; i++)
            {
                Claim.eq(srcA[i], xG[i]);
                xG[i] = srcB[i];
            }

            Claim.eq(x.Bit0, srcB[0]);
            Claim.eq(x.Bit1, srcB[1]);
            Claim.eq(x.Bit2, srcB[2]);
            Claim.eq(x.Bit3, srcB[3]);
            Claim.eq(x.Bit4, srcB[4]);
            Claim.eq(x.Bit5, srcB[5]);
            Claim.eq(x.Bit6, srcB[6]);
            Claim.eq(x.Bit7, srcB[7]);            
        }


        public static ref uint pack32x1_ref(in BitBlock32 src, ref uint dst)
        {            
            
            dst |= Bits.project(src.Bit0, Part32x1.Part0);
            dst |= Bits.project(src.Bit1, Part32x1.Part1);
            dst |= Bits.project(src.Bit2, Part32x1.Part2);
            dst |= Bits.project(src.Bit3, Part32x1.Part3);
            dst |= Bits.project(src.Bit4, Part32x1.Part4);
            dst |= Bits.project(src.Bit5, Part32x1.Part5);
            dst |= Bits.project(src.Bit6, Part32x1.Part6);
            dst |= Bits.project(src.Bit7, Part32x1.Part7);
            dst |= Bits.project(src.Bit8, Part32x1.Part8);
            dst |= Bits.project(src.Bit9, Part32x1.Part9);
            dst |= Bits.project(src.Bit10, Part32x1.Part10);
            dst |= Bits.project(src.Bit11, Part32x1.Part11);
            dst |= Bits.project(src.Bit12, Part32x1.Part12);
            dst |= Bits.project(src.Bit13, Part32x1.Part13);
            dst |= Bits.project(src.Bit14, Part32x1.Part14);
            dst |= Bits.project(src.Bit15, Part32x1.Part15);
            dst |= Bits.project(src.Bit16, Part32x1.Part16);
            dst |= Bits.project(src.Bit17, Part32x1.Part17);
            dst |= Bits.project(src.Bit18, Part32x1.Part18);
            dst |= Bits.project(src.Bit19, Part32x1.Part19);
            dst |= Bits.project(src.Bit20, Part32x1.Part20);
            dst |= Bits.project(src.Bit21, Part32x1.Part21);
            dst |= Bits.project(src.Bit22, Part32x1.Part22);
            dst |= Bits.project(src.Bit23, Part32x1.Part23);
            dst |= Bits.project(src.Bit24, Part32x1.Part24);
            dst |= Bits.project(src.Bit25, Part32x1.Part25);
            dst |= Bits.project(src.Bit26, Part32x1.Part26);
            dst |= Bits.project(src.Bit27, Part32x1.Part27);
            dst |= Bits.project(src.Bit28, Part32x1.Part28);
            dst |= Bits.project(src.Bit29, Part32x1.Part29);
            dst |= Bits.project(src.Bit30, Part32x1.Part30);
            dst |= Bits.project(src.Bit31, Part32x1.Part31);
            return ref dst;
        }
    }

}