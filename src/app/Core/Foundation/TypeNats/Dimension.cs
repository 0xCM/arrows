//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using static corefunc;

    /// <summary>
    /// Defines utilities for manipulating natural dimensions
    /// </summary>
    public static class Dimension
    {
        public static Dimenson<M,N> define<M,N>()
            where M : TypeNat, new()
            where N : TypeNat, new()
                => Dimenson<M,N>.Inhabitant;

        public static Dimenson<M,N,P> define<M,N,P>()
            where M : TypeNat, new()
            where N : TypeNat, new()
            where P : TypeNat, new()
                => Dimenson<M,N,P>.Inhabitant;
    }

    /// <summary>
    /// Specifies a rectangular dimension
    /// </summary>
    /// <typeparam name="M">The type of the first dimension</typeparam>
    /// <typeparam name="N">The type of the second dimension</typeparam>
    public readonly struct Dimenson<M,N> : Singleton<Dimenson<M,N>>
        where M : TypeNat, new()
        where N : TypeNat, new()
    {
        public static readonly Dimenson<M,N> Inhabitant = default;

        public static implicit operator (uint m, uint n)(Dimenson<M,N> x)
            => natvals<M,N>();
    
       /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public uint m => natval<M>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public uint n => natval<N>();

        public Dimenson<M, N> inhabitant 
            => Inhabitant;
    }


    /// <summary>
    /// Specifies a rectangular dimension
    /// </summary>
    /// <typeparam name="M">The type of the first dimension</typeparam>
    /// <typeparam name="N">The type of the second dimension</typeparam>
    /// <typeparam name="P">The type of the third dimension</typeparam>
    public readonly struct Dimenson<M,N,P> : Singleton<Dimenson<M,N,P>>
        where M : TypeNat, new()
        where N : TypeNat, new()
        where P : TypeNat, new()
    {
        public static readonly Dimenson<M,N,P> Inhabitant = default;

        public static implicit operator (uint m, uint n, uint p)(Dimenson<M,N,P> x)
            => natvals<M,N,P>();
    
        /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public uint m => natval<M>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public uint n => natval<N>();

        /// <summary>
        /// Specifies the third component of the dimension
        /// </summary>
        public uint p => natval<P>();

        /// <summary>
        /// Specifies the singleton inhabitant of the type
        /// </summary>
        public Dimenson<M, N, P> inhabitant 
            => Inhabitant;
    }


}