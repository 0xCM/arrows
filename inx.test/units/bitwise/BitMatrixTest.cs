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

    public class BitMatrixTest : UnitTest<BitMatrixTest>
    {
        void VerifyIdentity<N,T>()
            where N : ITypeNat, new()
            where T : struct
        {
            TypeCaseStart<N>();
            var identity = BitMatrix.Identity<N,T>();
            for(var i=0; i< identity.RowCount; i++)
            for(var j=0; j< identity.ColCount; j++)
                Claim.eq(identity[i,j], i==j ? Bit.On : Bit.Off);            
            TypeCaseEnd<N>();
        }

        public void Verify9x4Layout()
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

        public void Verify16x16Layout()
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

        public void VerifyGenericIdentities()
        {   
            VerifyIdentity<N8,byte>();
            VerifyIdentity<N8,short>();
            VerifyIdentity<N16,byte>();
            VerifyIdentity<N18,byte>();
            VerifyIdentity<N19,byte>();

            
            
        }

        public void VerifyIdentity()
        {
            var m8 = BitMatrix8.Identity;
            for(byte i=0; i < m8.RowDim; i++)
                Claim.eq(m8[i,i],Bit.On);
            Claim.yea(m8.Diagonal().AllOnes());
        
            var m16 = BitMatrix16.Identity;
            for(byte i=0; i < m16.RowDim; i++)
                Claim.eq(m16[i,i],Bit.On);
            Claim.yea(m16.Diagonal().AllOnes());

            var m32 = BitMatrix32.Identity;
            for(byte i=0; i < m32.RowDim; i++)
                Claim.eq(m32[i,i],Bit.On);
            Claim.yea(m32.Diagonal().AllOnes());

            var m64 = BitMatrix64.Identity;
            for(byte i=0; i < m64.RowDim; i++)
                Claim.eq(m64[i,i],Bit.On);
            Claim.yea(m64.Diagonal().AllOnes());

        }

        public void And4()
        {
            var x = Random.BitMatrix4();
            var y = Random.BitMatrix4();
            var z = x.And(y);

            var xBytes = x.Bytes().Replicate();
            var yBytes = y.Bytes().Replicate();
            var zBytes = xBytes.And(yBytes);

        }

        public void And64()
        {
            var lhs = BitMatrix64.Identity;
            var rhs = BitMatrix64.Identity;
            var result = lhs.And(rhs);
            for(var row=0; row<result.RowDim; row++)
            for(var col=0; col<result.ColDim; col++)    
                Claim.eq(result[row,col], rhs[row,col]);
            
            for(var i=0; i<Pow2.T08; i++)
            {
                var x = Random.BitMatrix64();
                var y = Random.BitMatrix64();

                var xBytes = x.Bytes().Replicate();
                var yBytes = y.Bytes().Replicate();
                var zBytes = xBytes.And(yBytes);
                var expect = BitMatrix64.Define(zBytes);

                var actual = x.And(y);
                Claim.yea(expect == actual);                
            }
        }

        public void And8()
        {
            var lhs = BitMatrix8.Identity;
            var rhs = BitMatrix8.Identity;
            var result = lhs.And(rhs);
            for(var row=0; row< result.RowDim; row++)
            for(var col=0; col< result.ColDim; col++)    
                Claim.eq(result[row,col], rhs[row,col]);
        }

        public void AndNot8()
        {
            var lhs = Random.BitMatrix8();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void AndNot16()
        {
            var lhs = Random.BitMatrix16();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void AndNot32()
        {
            var lhs = Random.BitMatrix32();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void AndNot64()
        {
            var lhs = Random.BitMatrix64();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void IsZero()
        {
            Claim.yea(BitMatrix8.Zero.IsZero());
            Claim.nea(BitMatrix8.Identity.IsZero());
            Claim.nea(Random.BitMatrix8().IsZero());

            Claim.yea(BitMatrix16.Zero.IsZero());
            Claim.nea(BitMatrix16.Identity.IsZero());
            Claim.nea(Random.BitMatrix16().IsZero());

            Claim.yea(BitMatrix32.Zero.IsZero());
            Claim.nea(BitMatrix32.Identity.IsZero());
            Claim.nea(Random.BitMatrix32().IsZero());

            Claim.yea(BitMatrix64.Zero.IsZero());
            Claim.nea(BitMatrix64.Identity.IsZero());
            Claim.nea(Random.BitMatrix64().IsZero());
        }

        public void Eq32()
        {
            var x = Random.BitMatrix32();
            var y = Random.BitMatrix32();
            Claim.nea(x.Eq(y));
            Claim.yea(x.Eq(x));
            Claim.yea(y.Eq(y));
        }

        public void Eq64()
        {
            var x = Random.BitMatrix64();
            var y = Random.BitMatrix64();
            Claim.nea(x.Eq(y));
            Claim.nea(x == y);
            Claim.yea(x != y);

            Claim.yea(x.Eq(x));
            Claim.yea(x == x);

            Claim.yea(y.Eq(y));
            Claim.yea(y == y);
        }

        public void Flip64()
        {
            
            var x = Random.BitMatrix64();
            var y = x.Replicate();
            var xff = x.Flip().Flip();
            Claim.yea(xff == y);

            var c = Random.BitMatrix64();
            var a = span<ulong>(64);
            for(var i = 0; i<64; i++)
                a[i] = ~ c.Row(i);
            var b = BitMatrix64.Define(a);
            Claim.yea(b == c.Flip());        
        }

        void VerifyExtract<M,N,T>(BitMatrix<M,N,T> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            for(var row=0; row< src.RowCount; row++)
            {
                var vector = src.Row(row);
                for(var col=0; col<vector.Length; col++)
                    Claim.eq(vector[col], src[row,col]);
            }

        }

        public void VectorExtract()
        {
            VerifyExtract(Random.BitMatrix<N9,N9,byte>());
            VerifyExtract(Random.BitMatrix<N9,N9,ushort>());
            VerifyExtract(Random.BitMatrix<N128,N128,uint>());
            VerifyExtract(Random.BitMatrix<N16,N128,uint>());
            VerifyExtract(Random.BitMatrix<N5,N7,uint>());
            
        }

        void Transpose<M,N,T>(int count)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            for(var c = 0; c <count; c++)
            {
                var src = Random.BitMatrix<M, N,T>();
                var tSrc = src.Transpose();
                for(var i=0; i<tSrc.RowCount; i++)
                for(var j=0; j<tSrc.ColCount; j++)
                    Claim.eq(tSrc[i,j], src[j,i]);

            }
        }

        public void Transpose()
        {
            Transpose<N12,N14,short>(Pow2.T07);
            Transpose<N32,N32,byte>(Pow2.T07);
        }

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
    }


}