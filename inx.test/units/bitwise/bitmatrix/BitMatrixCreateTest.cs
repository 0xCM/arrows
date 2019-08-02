//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    #pragma warning disable 1718

    public class BitMatrixCreateTest : UnitTest<BitMatrixCreateTest>
    {

        public void Create8x8()
        {
            var src = Random.Stream<ulong>().Take(Pow2.T07).GetEnumerator();
            while(src.MoveNext())
            {
                var m1 = BitMatrix.Define(src.Current);
                var n = new N8();
                var m2 = BitMatrix.Define(n,n, src.Current.ToByteArray());
                for(var i=0; i<8; i++)
                for(var j=0; j<8; j++)
                    Claim.eq(m1[i,j], m2[i,j]);
            }
        }

        public void Create9x4()
        {
            var grid = BitLayout.Grid<N9,N4,byte>();    
            Claim.eq(9, grid.RowCount);
            Claim.eq(4, grid.ColCount);

            var layout = grid.CalcLayout();
            Claim.eq(36, layout.CellCount);
            Claim.eq(9, layout.RowCount);
            Claim.eq(4, layout.ColCount);
            Claim.eq(1, layout.RowSegments);
            Claim.eq(9, layout.TotalSegments);
            var row0 = layout.Row(0);
            
            Claim.eq(4, row0.Length);            
            Claim.eq(0, row0[0].Col);
            Claim.eq(3, row0[3].Col);
            Claim.eq(0, (int)row0[3].BitPos.SegIdx);

            var row8 = layout.Row(8);
            Claim.eq(4, row8.Length);
            Claim.eq(8, (int)row8[3].BitPos.SegIdx);

            var m = BitMatrix.Ones<N9,N4,byte>();
            Claim.eq(9,m.RowCount);
            Claim.eq(4,m.ColCount);
            for(var i=0; i< m.RowCount; i++)
            {
                for(var j=0; j<m.ColCount; j++)
                    Claim.eq(m[i,j], Bit.On);
            }
            
        }

        public void Create16x16()
        {
            var spec = BitLayout.Grid<N16,N16,byte>();    
            Claim.eq(16, spec.RowCount);
            Claim.eq(16, spec.ColCount);

            var layout = spec.CalcLayout();

            int rowCount = 0, bitpos = 0;
            for(var row=0; row < layout.RowCount; row++)
            {
                rowCount++;
                var cells = layout.Row(row);
                for(var col=0; col< layout.ColCount; col++, bitpos++)
                {

                    var cell = cells[col];

                    Claim.eq(bitpos, cell.BitPos.LinearIndex);
                    Claim.eq(row, cell.Row);
                    Claim.eq(col, cell.Col);
                }
            }
            Claim.eq(256, bitpos);
            Claim.eq(256, layout.CellCount);
            
            Claim.eq(16, layout.RowCount);
            Claim.eq(16, rowCount);
            
            Claim.eq(16, layout.ColCount);
            Claim.eq(2, layout.RowSegments);
            Claim.eq(32, layout.TotalSegments);

            var row0 = layout.Row(0);
            
            Claim.eq(16, row0.Length);            
            Claim.eq(0, row0[0].Col);
            Claim.eq(3, row0[3].Col);
            Claim.eq(1, (int)row0[9].BitPos.SegIdx);

            var m = BitMatrix.Ones<N16,byte>();
            Claim.eq(16,m.RowCount);
            Claim.eq(16,m.ColCount);
            Claim.eq(2, m.RowSegCount);

            for(var i=0; i< m.RowCount; i++)
                for(var j=0; j<m.ColCount; j++)
                    Claim.eq(Bit.On, m[i,j]);
        }

    }

}
