//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes  a type that  exhibits a notion of length
    /// </summary>
    public interface Lengthwise
    {
        uint length {get;}
    }

    /// <summary>
    /// Characterizes a structure over data
    /// </summary>
    /// <typeparam name="T">The data type</typeparam>
    public interface Wrapped<T>
    {
        T data {get;}

        
    }

}