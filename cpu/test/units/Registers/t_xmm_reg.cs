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
    using Reg = Registers;

    public class t_xmm_reg : UnitTest<t_xmm_reg>
    {

        public void create32i()
        {
            var cellcount = Reg.XMM.CellCount<int>();
            Claim.eq(cellcount, 4);

            var xmmWidth = Reg.XMM.BitWidth;
            Claim.eq(xmmWidth, 128);

            var cellwidth = Reg.XMM.CellWidth<int>();
            Claim.eq(cellwidth, 32);

            var celldata = Random.Array<int>(cellcount);
            var xmm = Reg.XMM.FromCells(celldata);
            Claim.eq(xmm.x00s, celldata[0]);
            Claim.eq(xmm.x01s, celldata[1]);
            Claim.eq(xmm.x02s, celldata[2]);
            Claim.eq(xmm.x03s, celldata[3]);

            for(var i=0; i<cellcount; i++)
                Claim.eq(xmm.Cell<int>(i), celldata[i]);  

            var bitmap = Reg.XMM.BitMap<int>();
            Claim.eq(bitmap.CellCount, 4);
            Claim.eq(bitmap.CellWidth, 32);
            check_bitmap(bitmap);

            for(int i=0, k=0;  i<bitmap.CellCount; i++)
            {
                ref readonly var index = ref bitmap.Cell(i*bitmap.CellWidth);
                ref var cell = ref xmm.Cell<int>(index);
                Claim.eq(cell, celldata[i]);
                
                for(var j=0; j<bitmap.CellWidth; j++,k++)
                {
                    ref readonly var offset = ref bitmap.Offset(k);
                    var bit1 = xmm[k]; 
                    Bit bit2 = BitMask.test(cell, offset);
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