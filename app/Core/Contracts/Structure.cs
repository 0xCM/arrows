//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    /// <summary>
    /// Characterizes a type that exists to define a presentation of an
    /// underlying/primive value
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The underlying data type</typeparam>
    public interface Structure<S,T>
        where S : Structure<S,T>, new()
        where T : new()
    {
        /// <summary>
        /// Specifies the data encapsulated by the structure
        /// </summary>
        /// <value></value>
        T data {get;}        
    }    



}