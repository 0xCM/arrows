//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static zfunc;
    using static Asm;
    using static Reg;


    public class t_xmm_reg : t_cpu<t_xmm_reg>
    {
        public void t_vpxor()
        {            
            cpu.xmm0 = Random.Xmm<uint>();
            cpu.xmm1 = Random.Xmm<uint>();
            cpu.xmm2 = pxor(in cpu.xmm0, in cpu.xmm1); 

            Claim.eq(cpu.xmm2.uint64(0), cpu.xmm0.uint64(0) ^ cpu.xmm1.uint64(0));
            Claim.eq(cpu.xmm2.uint64(1), cpu.xmm0.uint64(1) ^ cpu.xmm1.uint64(1));                 

            cpu.xmm(0) = Random.Xmm<uint>();
            cpu.xmm(1) = Random.Xmm<uint>();
            cpu.xmm(2) = pxor(in cpu.xmm(0), in cpu.xmm(1)); 

            Claim.eq(cpu.xmm(2).uint64(0), cpu.xmm(0).uint64(0) ^ cpu.xmm(1).uint64(0));
            Claim.eq(cpu.xmm(2).uint64(1), cpu.xmm(0).uint64(1) ^ cpu.xmm(1).uint64(1));                 
        }

        public void xmm_create()
        {
            xmm_create<sbyte>();
            xmm_create<byte>();
            xmm_create<short>();
            xmm_create<ushort>();
            xmm_create<int>();
            xmm_create<uint>();
            xmm_create<long>();
            xmm_create<ulong>();
            xmm_create<float>();
            xmm_create<double>();
        }

        public void xmm_cpu()
        {
            
            xmm(4) = XMM.FromCells(5ul,10ul);
            Claim.eq(xmm(4).Cell<ulong>(0), 5ul);
            Claim.eq(xmm(4).Cell<ulong>(1), 10ul);
        }

        void xmm_create<T>()
            where T: unmanaged
        {
            var cellcount = XMM.CellCount<T>();
            Claim.eq(cellcount, Vec128<T>.Length);

            var xmmWidth = XMM.BitWidth;
            Claim.eq(xmmWidth, Vec128<T>.ByteCount*8);

            var cellwidth = XMM.CellWidth<T>();
            Claim.eq(cellwidth, bitsize<T>());

            var celldata = Random.Array<T>(cellcount);
            var xmm = XMM.FromCells(celldata);

            for(var i=0; i<cellcount; i++)
                Claim.eq(xmm.Cell<T>(i), celldata[i]);  

            var bitmap =XMM.BitMap<T>();
            Claim.eq(bitmap.CellCount, cellcount);
            Claim.eq(bitmap.CellWidth, cellwidth);
            check_bitmap(bitmap);

            for(int i=0, k=0;  i<bitmap.CellCount; i++)
            {
                ref readonly var index = ref bitmap.Cell(i*bitmap.CellWidth);
                ref var cell = ref xmm.Cell<T>(index);
                Claim.eq(cell, celldata[i]);
                
                for(var j=0; j<bitmap.CellWidth; j++,k++)
                {
                    ref readonly var offset = ref bitmap.Offset(k);
                    var bit1 = xmm[k]; 
                    Bit bit2 = gbits.test(cell, offset);
                    Claim.eq(bit1, bit2);
                }
            }                      
        }

        void check_bitmap(BitMap src)
        {
            for(int i=0, k=0; i< src.CellCount; i++)
            {
                for(var j=0; j < src.CellWidth; j++, k++)
                {
                    var index = src[k];
                    Claim.eq(index.CellIndex, (uint)i);
                    Claim.eq(index.CellOffset, j);
                }
            }

        }
    }

}