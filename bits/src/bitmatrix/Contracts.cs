//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public interface IBitMatrix
    {
        int RowCount {get;}

        int ColCount {get;}
        
        /// <summary>
        /// Queries/manipulates a bit in an identified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        Bit this[int row, int col] {get;set;}         
    }

    public interface IBitMatrix<A,T> : IBitMatrix, IEquatable<A>
        where T : unmanaged
        where A : struct, IBitMatrix
    {
        ref T RowData(int row);
    }


    public interface IBitMatrix<A,M,N,T> : IBitMatrix<A,T>
        where T : unmanaged
        where M : ITypeNat, new()
        where N : ITypeNat, new()
        where A : struct, IBitMatrix
    {

    }

    public interface IBitMatrix<A,N,T> : IBitMatrix<A,N,N,T>
        where T : unmanaged
        where N : ITypeNat, new()
        where A : struct, IBitMatrix 
    {

    }

}