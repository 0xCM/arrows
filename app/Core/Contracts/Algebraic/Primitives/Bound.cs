//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    public interface Bound<T> : Ordered<T>
        where T : new()
    {
        /// <summary>
        /// The minimum value the number may obtain
        /// </summary>
        /// <value></value>
        T minval {get;}

        /// <summary>
        /// The maximum value the number may obtain
        /// </summary>
        /// <value></value>
        T maxval {get;}
        
    }

    /// <summary>
    /// Characterizes a bounded structural number
    /// </summary>
    /// <typeparam name="S">The type of the realizing structure</typeparam>
    /// <typeparam name="T">The type of the underling primitive</typeparam>
    public interface Bound<S,T> : Ordered<S,T>
        where S : Bound<S,T>, new()
        where T : new()
    {

        /// <summary>
        /// The minimum value the number may obtain
        /// </summary>
        /// <value></value>
        S minval {get;}

        /// <summary>
        /// The maximum value the number may obtain
        /// </summary>
        /// <value></value>
        S maxval {get;}

    }

}