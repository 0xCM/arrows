//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes a type that defines an additive unit
    /// </summary>
    /// <typeparam name="T">The unit type</typeparam>
    public interface Nullary<T> 
    {
        T zero {get;}
    }



}