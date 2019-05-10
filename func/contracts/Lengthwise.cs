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
    public interface ILengthwise
    {
        uint Length {get;}
    }

    /// <summary>
    /// Characterizes  a type that  exhibits a notion of length
    /// </summary>
    public interface ILengthwise<S> : ILengthwise
        where S : ILengthwise<S>, new()
    {

    }

}