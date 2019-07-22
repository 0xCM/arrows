//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;

    using static nfunc;
    using static zfunc;


    /// <summary>
    /// Defines a span of natural length MxN which is presented as a logical grid/matrix
    /// </summary>
    public ref struct Span<M,N,T>
        where M : ITypeNat, new()
        where N : ITypeNat, new()
    {
        Span<T> data;

        /// <summary>
        /// The number of rows in the structure
        /// </summary>
        public static readonly int RowCount = nati<M>();

        /// <summary>
        /// The number of columns in the structure
        /// </summary>
        public static readonly int ColCount = nati<N>();

        /// <summary>
        /// The number of cells in each row
        /// </summary>
        public static readonly int RowLenth = ColCount;

        /// <summary>
        /// The number of cells in each column
        /// </summary>
        public static readonly int ColLength = RowCount;

        /// <summary>
        /// The total number of allocated elements
        /// </summary>
        public static readonly int CellCount = RowLenth * ColLength;

        /// <summary>
        /// The Row dimension representative
        /// </summary>
        public static M RowRep = default;

        /// <summary>
        /// The Column dimension representative
        /// </summary>
        public static N ColRep = default;


        public static implicit operator Span<M,N,T>(T[] src)
            => new Span<M, N, T>(src);


        public static implicit operator Span<M,N,T>(Span<T> src)
            => new Span<M, N, T>(src);

        public static implicit operator Span<T>(Span<M,N,T> src)
            => src.data;

        public static implicit operator ReadOnlySpan<T> (Span<M,N,T> src)
            => src.data;

        public static implicit operator ReadOnlySpan<M,N,T> (Span<M,N,T> src)
            => new ReadOnlySpan<M, N, T>(src);


        [MethodImpl(Inline)]
        public Span(ref T src)
        {
            data = MemoryMarshal.CreateSpan(ref src, CellCount);
        }

        [MethodImpl(Inline)]        
        public Span(Span<T> src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            data = src;
        }

        [MethodImpl(Inline)]        
        public Span(T[] src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            data = src;
        }

        [MethodImpl(Inline)]
        public Span(T value)
        {         
            this.data = new Span<T>(new T[CellCount]);
            this.data.Fill(value);
        }

        [MethodImpl(Inline)]
        public Span(ReadOnlySpan<T> src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            data = src.ToArray();
            src.CopyTo(data);
        }

        [MethodImpl(Inline)]        
        public ref T Cell(int r, int c)
        {
            if(r >= RowCount)
                throw new Exception($"Out of range: The row index {r} was outside the range [{0},{RowCount - 1}]");
            if(c >= ColCount)
                throw new Exception($"Out of range: The col index {c} was outside the range [{0},{ColCount - 1}]");
                     
            return ref data[RowLenth*r + c];
        }

        [MethodImpl(Inline)]        
        public ref T Cell(uint i, uint j)
            => ref Cell((int)i, (int)j);

        public ref T this[int i, int j]
        {
            [MethodImpl(Inline)]        
            get => ref Cell(i,j);
        }

        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        public Dim<M,N> Dim 
            => default;    

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        [MethodImpl(Inline)]
        public void Fill(T value)
            => data.Fill(value);

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo (Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo (Span<T> dst)
            => data.TryCopyTo(dst);

        [MethodImpl(Inline)]
        public Span<T> Unsize()
            => data;

        [MethodImpl(Inline)]
        public Span<M,N,T> Replicate()        
            => new Span<M, N, T>(data.ToArray());


        [MethodImpl(Inline)]
        public ReadOnlySpan<M,N,T> ReadOnly()        
            => this;

        [MethodImpl(Inline)]
        bool IsRowHead(int index)
            => index == 0 || index % RowLenth == 0;

        public Span<I,J,T> SubSpan<I,J>((uint r, uint c) origin, Dim<I,J> dim = default)
            where I : ITypeNat, new()
            where J : ITypeNat, new()
        {            
            var  dst = NatSpan.alloc<I,J,T>();
            var curidx = 0;
            for(var i = origin.r; i < (origin.r + dim.i); i++)
            for(var j = origin.c; j < (origin.c + dim.j); j++)
                dst[curidx++] = this[(int)i,(int)j];

            return dst;
        }

        [MethodImpl(Inline)]
        public Span<M,T> Col(int col)
        {
            if(col < 0 || col >= ColCount)
                throw OutOfRange(col, 0, ColCount - 1);
            
            var v = NatSpan.alloc<M,T>();
            for(var r = 0; r < ColLength; r++)
                v[r] = data[r + col];
            return v;
        }

        [MethodImpl(Inline)]
        public Span<N,T> Row(int row)
        {
            if(row < 0 || row >= RowCount)
                throw OutOfRange(row, 0, RowCount - 1);
            
            return data.Slice(row * RowLenth, RowLenth);
        }

        [MethodImpl(Inline)]
        public Span<N,T> Row<I>()
            where I : ITypeNat, new()
                => Row(nati<I>());

        [MethodImpl(Inline)]
        public Span<M,T> Col<J>()
            where J : ITypeNat, new()
                => Col(nati<J>());

        public Span<N,M,T> Transpose()
        {
            var dst = NatSpan.alloc<N,M,T>();                
            for(var r = 0; r < RowCount; r++)
            for(var c = 0; c < ColCount; c++)
                dst[c, r] = this[r, c];
            return dst;            
        }

        public string Format(char cellsep = ',', char rowsep = '\n', int? zpad = null)
        {
            var sb = new StringBuilder("\r\n");
            var lastIx = CellCount - 1;
            for(var i=0; i< CellCount; i++)
            {
                if(i != 0)
                {
                    if(IsRowHead(i))
                        sb.Append($"{rowsep}");
                    else
                        sb.Append($"{cellsep} ");
                }
                if(zpad == null)
                    sb.Append($"{data[i]}");
                else
                    sb.Append(data[i].ToString().PadLeft(zpad.Value, '0'));
             
            }

            return sb.ToString();            
        }

       public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        

    }

}
