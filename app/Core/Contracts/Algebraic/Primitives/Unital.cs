//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

   /// <summary>
    /// Characterizes a type for which a multiplicative unit exists
    /// </summary>
    /// <typeparam name="I">The characterized type</typeparam>
    public interface Unital<I>
    {
        /// <summary>
        /// The unital value
        /// </summary>
        I one {get;}
    }



}