//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using Z0.Test;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static Cpu;
    using static Asm;

    public class t_xmm_reg : UnitTest<t_xmm_reg>
    {

        public void t_vpxor()
        {
            var cpu = Cpu.Init();
            xmm0(ref cpu) = Random.Xmm<uint>();
            xmm1(ref cpu) = Random.Xmm<uint>();
            xmm2(ref cpu) = pxor(xmm0(ref cpu), xmm1(ref cpu)); 

            ref readonly var v0 = ref xmm0(ref cpu);
            ref readonly var v1 = ref xmm1(ref cpu);
            ref readonly var v2 = ref xmm2(ref cpu);

            Claim.eq(v2.Cell<ulong>(0), v0.Cell<ulong>(0) ^ v1.Cell<ulong>(0));
            Claim.eq(v2.Cell<ulong>(1), v0.Cell<ulong>(1) ^ v1.Cell<ulong>(1));

                 
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
            var cpu = Cpu.Init();
            xmm(ref cpu, 4) = XMM.FromCells(5ul,10ul);
            Claim.eq(xmm(ref cpu, 4).Cell<ulong>(0), 5ul);
            Claim.eq(xmm(ref cpu, 4).Cell<ulong>(1), 10ul);
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