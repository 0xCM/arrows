//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    public interface Unsigned<T> : Operational<T>
        where T : new()
    {
        
    }

    /// <summary>
    /// Characterizes a structural unsigned number
    /// </summary>
    /// <typeparam name="S">The type of the realizing structure</typeparam>
    /// <typeparam name="T">The type of the underling primitive</typeparam>
    public interface Unsigned<S,T> : Structural<S,T>
        where S : Unsigned<S,T>, new()
        where T : new()
    {

    }


}