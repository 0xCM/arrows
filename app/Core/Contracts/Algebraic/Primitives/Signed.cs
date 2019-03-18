//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    
    public interface Signed<T> : Operational<T>
        where T : new()
    {

    }
    
    /// <summary>
    /// Characterizes a structure that carries a sign
    /// </summary>
    /// <typeparam name="S">The type of the realizing structure</typeparam>
    /// <typeparam name="T">The type of the underling primitive</typeparam>
    public interface Signed<S,T> : Structural<S,T>
        where S : Signed<S,T>, new()
        where T : new()
    {
    }

}