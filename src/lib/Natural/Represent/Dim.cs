//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zcore;
    using static Latex.Math;

    partial class Traits
    {
        public interface Dim : Formattable
        {
            Z0.Slice<uint> components {get;}
        }

    }

    public static class Dim
    {
        /// <summary>
        /// Constructs a 1-component natural dimension
        /// </summary>
        /// <typeparam name="K">The natural type</typeparam>
        public static Dim<K> define<K>()
            where K : TypeNat, new()
                => Dim<K>.Rep;

        /// <summary>
        /// Constructs a 2-component natural dimension
        /// </summary>
        /// <typeparam name="K1">The type of the first component</typeparam>
        /// <typeparam name="K2">The type of the second component</typeparam>
        public static Dim<K1,K2> define<K1,K2>()
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
                => Dim<K1,K2>.Rep;

        /// <summary>
        /// Constructs a 3-component natural dimension
        /// </summary>
        /// <typeparam name="K1">The type of the first component</typeparam>
        /// <typeparam name="K2">The type of the second component</typeparam>
        /// <typeparam name="K3">The type of the third component</typeparam>
        public static Dim<K1,K2,K3> define<K1,K2,K3>()
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
                => Dim<K1,K2,K3>.Rep;
    }

    /// <summary>
    /// Specifies a single dimension
    /// </summary>
    /// <typeparam name="K">The dimension type</typeparam>
    public readonly struct Dim<K> : Traits.Dim
        where K : TypeNat, new()
    {
        public static readonly Dim<K> Rep = default;

        public static implicit operator uint(Dim<K> x)
            => x.n;
    
        /// <summary>
        /// Specifies the value of the dimension component
        /// </summary>
        public uint n 
            => natval<K>();

        public Slice<uint> components 
            => slice(n);

        public string format()
            => $"i{times}j{times}k";
 
        public override string  ToString()
            => format();
    }


    /// <summary>
    /// Specifies a rectangular dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first dimension</typeparam>
    /// <typeparam name="K2">The type of the second dimension</typeparam>
    public readonly struct Dim<K1,K2> : Traits.Dim
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
    {
        public static readonly Dim<K1,K2> Rep = default;

        public static implicit operator (uint i, uint j)(Dim<K1,K2> x)
            => Nat.pair<K1,K2>();
    
       /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public uint i 
            => natval<K1>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public uint j 
            => natval<K2>();

        public Slice<uint> components 
            => slice(i,j);

        public string format()
            => $"i{times}j{times}k";
 
        public override string  ToString()
            => format();
    }


    /// <summary>
    /// Specifies a rectangular dimension
    /// </summary>
    /// <typeparam name="M">The type of the first dimension</typeparam>
    /// <typeparam name="N">The type of the second dimension</typeparam>
    /// <typeparam name="P">The type of the third dimension</typeparam>
    public readonly struct Dim<M,N,P> : Traits.Dim
        where M : TypeNat, new()
        where N : TypeNat, new()
        where P : TypeNat, new()
    {
        public static readonly Dim<M,N,P> Rep = default;

        public static implicit operator (uint i, uint j, uint k)(Dim<M,N,P> x)
            => Nat.triple<M,N,P>();

        /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public uint i 
            => natval<M>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public uint j 
            => natval<N>();

        /// <summary>
        /// Specifies the third component of the dimension
        /// </summary>
        public uint k 
            => natval<P>();

        public Slice<uint> components 
            => slice(i,j,k);

        public string format()
            => $"i{times}j{times}k";
 
        public override string  ToString()
            => format();
    }
}