//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitRef
    {
        public static BitMatrix8 bmm(BitMatrix8 lhs, BitMatrix8 rhs)
        {
            var dst = BitMatrix8.Alloc();
            rhs = rhs.Transpose();
            for(var i=0; i< lhs.RowCount; i++)
            {
                var row = lhs.RowVector(i);
                for(var j =0; j< rhs.ColCount; j++)
                {
                    var col = rhs.RowVector(j);
                    dst[i,j] = ModProd(row,col);
                }
            }
            return dst;
        }

        public static BitMatrix16 bmm(BitMatrix16 lhs, BitMatrix16 rhs)
        {
            var dst = BitMatrix16.Alloc();
            rhs = rhs.Transpose();
            for(var i=0; i< lhs.RowCount; i++)
            {
                var row = lhs.RowVector(i);
                for(var j =0; j< rhs.ColCount; j++)
                {
                    var col = rhs.RowVector(j);
                    dst[i,j] = ModProd(row,col);
                }
            }
            return dst;
        }

        public static BitMatrix32 bmm(BitMatrix32 lhs, BitMatrix32 rhs)
        {
            var dst = BitMatrix32.Alloc();
            rhs = rhs.Transpose();
            for(var i=0; i< lhs.RowCount; i++)
            {
                var row = lhs.RowVec(i);
                for(var j =0; j< rhs.ColCount; j++)
                {
                    var col = rhs.RowVec(j);
                    dst[i,j] = ModProd(row,col);
                }
            }
            return dst;
        }

        public static BitMatrix64 bmm(BitMatrix64 lhs, BitMatrix64 rhs)
        {
            var dst = BitMatrix64.Alloc();
            rhs = rhs.Transpose();
            for(var i=0; i< lhs.RowCount; i++)
            {
                var row = lhs.RowVector(i);
                for(var j =0; j< rhs.ColCount; j++)
                {
                    var col = rhs.RowVector(j);
                    dst[i,j] = ModProd(row,col);
                }
            }
            return dst;
        }


    }
}