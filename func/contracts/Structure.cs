//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    


    /// <summary>
    /// Characterizes a structure which is, by definition,
    /// a reifiable abstraction
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface IStructure<S> : IEquatable<S>
        where S : IStructure<S>, new()
    {


    }    


}