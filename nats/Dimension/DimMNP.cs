//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static nfunc;
 
     /// <summary>
    /// Specifies a cubical dimension
    /// </summary>
    public readonly struct Dim3 : IDim
    {
        public readonly ulong I;

        public readonly ulong J;

        public readonly ulong K;

        public static implicit operator DimInfo(Dim3 src)
            => new DimInfo(src.Order, new ulong[]{src.I, src.J, src.K}, src.Volume);

        public Dim3(ulong I, ulong J, ulong K)
        {
            this.I = I;
            this.J = J;
            this.K = K;
        }

        public ulong Volume
            => I * J * K;

        public ulong this[int axis]            
            => axis == 0 ? I 
            :  axis == 1 ? J
            :  axis == 2 ? K
            :  0;

        public int Order 
            => 3;
    }


    /// <summary>
    /// Defines a cubical dimension
    /// </summary>
    /// <typeparam name="M">The type of the first dimension</typeparam>
    /// <typeparam name="N">The type of the second dimension</typeparam>
    /// <typeparam name="P">The type of the third dimension</typeparam>
    public readonly struct Dim<M,N,P> : IDim
        where M : ITypeNat, new()
        where N : ITypeNat, new()
        where P : ITypeNat, new()
    {
        public static readonly Dim<M,N,P> Rep = default;

        public static implicit operator DimInfo(Dim<M,N,P> src)
            => new DimInfo(3, new ulong[]{natu<M>(), natu<N>(), natu<P>()}, natu<M>() * natu<N>()* natu<P>());

        public static implicit operator Dim3(Dim<M,N,P> x)
            => new Dim3(x.I, x.J, x.K);

        public static implicit operator DimK(Dim<M,N,P> x)
            => new DimK(x.I, x.J, x.J);

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

        /// <summary>
        /// Specifies the third component of the dimension
        /// </summary>
        public ulong K 
            => natu<P>();

        public ulong Volume
            => I*J*K;

        public ulong this[int axis]            
            => axis == 0 ? I 
            :  axis == 1 ? J
            :  axis == 2 ? K
            :  0;

        public int Order 
            => 3;

        public string Format()
            => $"{I}×{J}×{K}";

        public override string  ToString()
            => Format();
    }


}