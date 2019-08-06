//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static nfunc;
 
    /// <summary>
    /// Specifies a rectangular dimension
    /// </summary>
    public readonly struct Dim2 : IDim
    {
        public readonly ulong I;

        public readonly ulong J;

        public static implicit operator DimInfo(Dim2 src)
            => new DimInfo(src.Order, new ulong[]{src.I, src.J}, src.Volume);

        public Dim2(ulong I, ulong J)
        {
            this.I = I;
            this.J = J;
        }

        public ulong Volume
            => I * J;

        public ulong this[int axis]            
            => axis == 0 ? I 
            :  axis == 1 ? J
            :  0;

        public int Order 
            => 2;

    }


    /// <summary>
    /// Defines a rectangular dimension
    /// </summary>
    /// <typeparam name="M">The type of the first dimension</typeparam>
    /// <typeparam name="N">The type of the second dimension</typeparam>
    public readonly struct Dim<M,N> : IDim
        where M : ITypeNat, new()
        where N : ITypeNat, new()
    {
        public static readonly Dim<M,N> Rep = default;

        public static implicit operator (ulong i, ulong j)(Dim<M,N> x)
            => Nat.pair<M,N>();

        public static implicit operator (int i, int j)(Dim<M,N> x)
            => Nat.pairi<M,N>();

        public static implicit operator DimInfo(Dim<M,N> src)
            => new DimInfo(2, new ulong[]{natu<M>(), natu<N>()}, natu<M>() * natu<N>());

        public static implicit operator Dim2(Dim<M,N> x)
            => new Dim2(x.I, x.J);

        public static implicit operator DimK(Dim<M,N> x)
            => new DimK(x.I, x.J);

        /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public ulong I 
            => natu<M>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public ulong J 
            => natu<N>();

        public ulong Volume
            => I*J;

        public ulong this[int axis]            
            => axis == 0 ? I 
            :  axis == 1 ? J
            :  0;

        public int Order 
            => 2;

        public string Format()
            => $"{I}×{J}";
 
        public override string  ToString()
            => Format();

        public T[] alloc<T>()
            => new T[Volume];
    }




}