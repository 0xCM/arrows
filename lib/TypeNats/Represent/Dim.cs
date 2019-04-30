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

        public static implicit operator ulong(Dim<K> x)
            => x.i;
    
        /// <summary>
        /// Specifies the value of the dimension component
        /// </summary>
        public intg<ulong> i 
            => u(natval<K>());

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
    public readonly struct Dim<K1,K2> : Traits.Dim
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
    {
        public static readonly Dim<K1,K2> Rep = default;

        public static implicit operator (ulong i, ulong j)(Dim<K1,K2> x)
            => Nat.pair<K1,K2>();
    
       /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public intg<ulong> i 
            => natg<K1>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public intg<ulong> j 
            => natg<K2>();

        public ulong volume()
            => i*j;


        public string format()
            => xsv(times, i, j);
 
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
    public readonly struct Dim<M,N,P> : Traits.Dim
        where M : TypeNat, new()
        where N : TypeNat, new()
        where P : TypeNat, new()
    {
        public static readonly Dim<M,N,P> Rep = default;

        /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public intg<ulong> i 
            => natg<M>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public intg<ulong> j 
            => natg<N>();

        /// <summary>
        /// Specifies the third component of the dimension
        /// </summary>
        public intg<ulong> k 
            => natg<P>();

        public intg<ulong> volume()
            => i*j*k;

        public string format()
            => xsv(times, i, j, k);

        public override string  ToString()
            => format();
    }
}