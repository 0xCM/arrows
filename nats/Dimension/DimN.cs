//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static nfunc;

    /// <summary>
    /// Specifies a dimension with one axis
    /// </summary>
    public readonly struct Dim1 : IDim
    {
        public readonly ulong I;


        public static implicit operator DimInfo(Dim1 src)
            => new DimInfo(src.Order, new ulong[]{src.I}, src.Volume);

        public Dim1(ulong I)
        {
            this.I = I;
        }

        public ulong Volume
            => I;

        public ulong this[int axis]            
            => axis == 0 ? I : 0;
        
        public int Order 
            => 1;
    }

    /// <summary>
    /// Defines a dimension axis which may represent the dimension of a vector of length N
    /// or the dimensions of a square matrix that contains N vectors of dimension N
    /// </summary>
    /// <typeparam name="N">The dimension type</typeparam>
    public readonly struct Dim<N> : IDim
        where N : ITypeNat, new()
    {
        public static readonly Dim<N> Rep = default;

        public static implicit operator ulong(Dim<N> x)
            => x.I;
    
        public static implicit operator Dim1(Dim<N> x)
            => new Dim1(x.I);

        public static implicit operator DimK(Dim<N> x)
            => new DimK(x.I);

        public static implicit operator DimInfo(Dim<N> src)
            => new DimInfo(1, new ulong[]{natu<N>()}, natu<N>());

        /// <summary>
        /// Specifies the value of the dimension component
        /// </summary>
        public ulong I 
            => natu<N>();

        public ulong Volume
            => I;


        public ulong this[int axis]            
            => axis == 0 ? I : 0;
        
        public int Order 
            => 1;

        public string Format()
            => $"{I}";
 
        public override string ToString()
            => Format();

    }


}