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
    using static Nats;
    using static zfunc;
    #pragma warning disable 1718

    public class tbm_create : UnitTest<tbm_create>
    {
        public void create8x8()
        {
            var src = Random.Stream<ulong>().Take(Pow2.T07).GetEnumerator();
            while(src.MoveNext())
            {
                var m1 = BitMatrix8.Load(src.Current);
                var n = new N8();
                var m2 = BitMatrix.Load(n,n, src.Current.ToByteArray());
                for(var i=0; i<8; i++)
                for(var j=0; j<8; j++)
                    Claim.eq(m1[i,j], m2[i,j]);
            }
        }

        public void create9x4()
        {
            var grid = BitGrid.Specify<N9,N4,byte>();    
            Claim.eq(9, grid.RowCount);
            Claim.eq(4, grid.ColCount);

            var layout = grid.CalcLayout();
            Claim.eq(36, layout.BitCount);
            Claim.eq(9, layout.RowCount);
            Claim.eq(4, layout.ColCount);
            Claim.eq(1, layout.RowCellCount);
            Claim.eq(9, layout.TotalCellCount);
            var row0 = layout.Row(0);
            
            Claim.eq(4, row0.Length);            
            Claim.eq(0, row0[0].Col);
            Claim.eq(3, row0[3].Col);
            Claim.eq(0, (int)row0[3].Segment);

            var row8 = layout.Row(8);
            Claim.eq(4, row8.Length);
            Claim.eq(8, (int)row8[3].Segment);

            var m = BitMatrix.Ones<N9,N4,byte>();
            Claim.eq(9,m.RowCount);
            Claim.eq(4,m.ColCount);
            for(var i=0; i< m.RowCount; i++)
            {
                for(var j=0; j<m.ColCount; j++)
                    Claim.eq(m[i,j], Bit.On);
            }
            
        }

        public void create7x9()
        {
            var m1 = BitMatrix.Alloc<N7,N9,byte>();
            m1.Fill(Bit.On);
            var fmt = m1.Format().RemoveWhitespace();
            Claim.eq(BitMatrix<N7,N9,byte>.TotalBitCount, fmt.Length);    

        }
        public void create7x7()
        {
            var m1 = BitMatrix.Alloc<N7,byte>();
            m1.Fill(Bit.On);
            var fmt = m1.Format().RemoveWhitespace();
            Claim.eq(7*7, fmt.Length);
            var d = m1.Diagonal();
            var x = BitVector.Alloc<N7,byte>();
            x.Fill(Bit.On);

            Claim.yea(d == x);                        
        }
        public void create16x16()
        {
            var spec = BitGrid.Specify<N16,N16,byte>();    
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

                    Claim.eq(bitpos, cell.LinearIndex);
                    Claim.eq(row, cell.Row);
                    Claim.eq(col, cell.Col);
                }
            }
            Claim.eq(256, bitpos);
            Claim.eq(256, layout.BitCount);
            
            Claim.eq(16, layout.RowCount);
            Claim.eq(16, rowCount);
            
            Claim.eq(16, layout.ColCount);
            Claim.eq(2, layout.RowCellCount);
            Claim.eq(32, layout.TotalCellCount);

            var row0 = layout.Row(0);
            
            Claim.eq(16, row0.Length);            
            Claim.eq(0, row0[0].Col);
            Claim.eq(3, row0[3].Col);
            Claim.eq(1, (int)row0[9].Segment);

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