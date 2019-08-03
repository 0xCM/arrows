//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;


    /// <summary>
    /// Defines a table with 1 column
    /// </summary>
    /// <typeparam name="C0">The column type</typeparam>
    public class Table<C0>
    {


    }


    /// <summary>
    /// Defines a table with 2 columns
    /// </summary>
    /// <typeparam name="C0">The first column type</typeparam>
    /// <typeparam name="C1">The second column type</typeparam>
    public class Table<C0,C1>
    {


    }

    public readonly struct TableRow<C0,C1,C2,C3>
    {
        public static implicit operator TableRow<C0,C1,C2,C3>((C0 c0, C1 c1, C2 c2, C3 c3) x)
            => new TableRow<C0,C1,C2,C3>(x.c0, x.c1, x.c2, x.c3);

        public static implicit operator (C0 c0, C1 c1, C2 c2, C3 c3)(TableRow<C0,C1,C2,C3> row)
            => (row.Cell0, row.Cell1, row.Cell2, row.Cell3);

        public TableRow(C0 c0, C1 c1, C2 c2, C3 c3)
        {
            this.Cell0 = c0;
            this.Cell1 = c1;
            this.Cell2 = c2;
            this.Cell3 = c3;
        }

        public readonly C0 Cell0;

        public readonly C1 Cell1;

        public readonly C2 Cell2;

        public readonly C3 Cell3;


        public (C0 c0, C1 c1, C2 c2, C3 c3) ToTuple()
            => this;
        
        public override string ToString()
            => ToTuple().Format();
    }

    public readonly struct TableRow<C0,C1,C2,C3,C4>
    {
        public static implicit operator TableRow<C0,C1,C2,C3,C4>((C0 c0, C1 c1, C2 c2, C3 c3, C4 c4) x)
            => new TableRow<C0,C1,C2,C3,C4>(x.c0, x.c1, x.c2, x.c3,x.c4);

        public static implicit operator (C0 c0, C1 c1, C2 c2, C3 c3, C4 c4)(TableRow<C0,C1,C2,C3,C4> row)
            => (row.Cell0, row.Cell1, row.Cell2, row.Cell3, row.Cell4);

        public TableRow(C0 c0, C1 c1, C2 c2, C3 c3, C4 c4)
        {
            this.Cell0 = c0;
            this.Cell1 = c1;
            this.Cell2 = c2;
            this.Cell3 = c3;
            this.Cell4 = c4;
        }

        public readonly C0 Cell0;

        public readonly C1 Cell1;

        public readonly C2 Cell2;

        public readonly C3 Cell3;

        public readonly C4 Cell4;

        public (C0 c0, C1 c1, C2 c2, C3 c3, C4 c4) ToTuple()
            => this;
        
        public override string ToString()
            => ToTuple().Format();
    }


    /// <summary>
    /// Defines a table with 5 columns
    /// </summary>
    /// <typeparam name="C0">The first column type</typeparam>
    /// <typeparam name="C1">The second column type</typeparam>
    /// <typeparam name="C2">The third column type</typeparam>
    /// <typeparam name="C3">The fourth column type</typeparam>
    /// <typeparam name="C4">The fifth column type</typeparam>
    public class Table<C0,C1,C2,C3,C4>
    {
        
        public Table(int Capacity)
        {
            this.Rows = new TableRow<C0, C1, C2, C3, C4>[Capacity];
        }

        public readonly TableRow<C0,C1,C2,C3,C4>[] Rows;

    }

}