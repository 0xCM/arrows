//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    /// <summary>
    /// Characterizes a type that exists to encapsulate and define 
    /// a specific presentation of the encapsulated value
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The underlying data type</typeparam>
    public interface Structural<S,T>
        where S : Structural<S,T>, new()
        where T : new()
    {
        /// <summary>
        /// Specifies the data encapsulated by the structure
        /// </summary>
        /// <value></value>
        T data {get;}        
    }    



}