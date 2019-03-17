//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes a structral number
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The structure subect</typeparam>
    public interface Number<S,T> : Structure<S,T>, Equatable<S,T>
        where S : Number<S,T>, new()
        where T : new()
    {
        
                
    }
}