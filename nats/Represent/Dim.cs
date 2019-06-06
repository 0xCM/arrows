//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static nfunc;
    using static nconst;



    /// <summary>
    /// Specifies a single dimension
    /// </summary>
    /// <typeparam name="K">The dimension type</typeparam>
    public readonly struct Dim<K> : IDim
        where K : ITypeNat, new()
    {
        public static readonly Dim<K> Rep = default;

        public static implicit operator ulong(Dim<K> x)
            => x.i;
    
        /// <summary>
        /// Specifies the value of the dimension component
        /// </summary>
        public ulong i 
            => natu<K>();

        public ulong volume()
            => i;

        public string format()
            => $"{i}";
 
        public override string  ToString()
            => format();

        public T[] alloc<T>()
            => new T[volume()];

    }


    /// <summary>
    /// Specifies a rectangular dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first dimension</typeparam>
    /// <typeparam name="K2">The type of the second dimension</typeparam>
    public readonly struct Dim<K1,K2> : IDim
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
    {
        public static readonly Dim<K1,K2> Rep = default;

        public static implicit operator (ulong i, ulong j)(Dim<K1,K2> x)
            => Nat.pair<K1,K2>();
    
       /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public ulong i 
            => natu<K1>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public ulong j 
            => natu<K2>();

        public ulong volume()
            => i*j;

        public string format()
            => zfunc.xsv("×", i, j);
 
        public override string  ToString()
            => format();

        public T[] alloc<T>()
            => new T[volume()];
    }


    /// <summary>
    /// Specifies a rectangular dimension
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

        /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public ulong i 
            => natu<M>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public ulong j 
            => natu<N>();

        /// <summary>
        /// Specifies the third component of the dimension
        /// </summary>
        public ulong k 
            => natu<P>();

        public ulong volume()
            => i*j*k;

        public string format()
            => zfunc.xsv("×", i, j, k);

        public override string  ToString()
            => format();
    }
}