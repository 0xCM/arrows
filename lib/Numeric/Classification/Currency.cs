namespace Z0
{
    using System;
    using System.Numerics;

    using static Structures;
    
    using Currency = ICurrencyOps<decimal>;
    /// <summary>
    /// Characterizes a bounded fractional operation provider
    /// </summary>
    /// <typeparam name="T">The primitive type</typeparam>
    public interface ICurrencyOps<T> : IBoundRealOps<T>, Operative.IFractionalOps<T> 
        where T : struct, IEquatable<T>

    {

    }

    /// <summary>
    /// Characterizes structural reifications of Currency 
    /// </summary>
    /// <typeparam name="S">The structural reification type</typeparam>
    public interface ICurrency<S> : IBoundReal<S>, IFractional<S>
        where S : ICurrency<S>, new()
    {

    }


}