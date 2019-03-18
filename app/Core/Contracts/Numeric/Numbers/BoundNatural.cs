//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes an operation provider for bounded natural types
    /// </summary>
    /// <typeparam name="T">The type over which operations are defined</typeparam>
    public interface BoundNatural<T> : Natural<T>, Bound<T>
        where T : new()
    {
        
    }

    /// <summary>
    /// Characterizes a natural number, i.e. one of {0,1,...} subject to the maximum
    /// value of the underlying type
    /// </summary>
    /// <typeparam name="S">The realizing type</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface BoundNatural<S,T> : Natural<S,T>, Bound<S,T>
        where S : BoundNatural<S,T>, new()
        where T : new()
    {
        
    }


}