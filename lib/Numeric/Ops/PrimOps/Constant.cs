//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a constant value
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    public interface Constant<T>
        where T : struct
    {
        T Value {get;}
    }
}