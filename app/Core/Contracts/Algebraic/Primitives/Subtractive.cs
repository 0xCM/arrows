//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes external subtraction
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Subtractive<T> : Operational<T>
    {
        T sub(T x, T y);
    }

    /// <summary>
    /// Characterizes intrinsic subtraction
    /// </summary>
    /// <typeparam name="T">The structure type</typeparam>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Subtractive<S,T> : Structural<S,T>
        where S : Subtractive<S,T>, new()
        where T : new()
    {
        S sub(S rhs);
    }
}