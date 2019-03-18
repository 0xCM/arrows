//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes a type that defines an additive unit
    /// </summary>
    /// <typeparam name="T">The unit type</typeparam>
    public interface Nullary<T> : Operational<T>
    {
        T zero {get;}
    }

    /// <summary>
    /// Characterizes a nullary structure, that is, a structure
    /// that defines a zero that is an instance of itself
    /// </summary>
    /// <typeparam name="T">The unit type</typeparam>
    public interface Nullary<S,T> : Structural<S,T>
        where S : Nullary<S,T>, new()
        where T : new()
    {
        S zero {get;}
    }


}