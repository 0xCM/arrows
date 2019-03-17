//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    
    public interface Signed<T>
        where T : new()
    {
        Sign sign(T x);
        
        T abs(T x);
    }
    
    /// <summary>
    /// Characterizes a structural signed number
    /// </summary>
    /// <typeparam name="S">The type of the realizing structure</typeparam>
    /// <typeparam name="T">The type of the underling primitive</typeparam>
    public interface Signed<S,T> : Number<S,T>
        where S : Signed<S,T>, new()
        where T : new()
    {
        /// <summary>
        /// Calculates the number's absolute value
        /// </summary>
        /// <returns></returns>
        S abs();

        /// <summary>
        /// Calculates the number's sign
        /// </summary>
        Sign sign();
    }

}