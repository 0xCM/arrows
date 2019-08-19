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
    /// Characterizes operational multiplication
    /// </summary>
    /// <typeparam name="T">The type subject to multiplication</typeparam>
    public interface IMultiplicativeOps<T>
    {
        T Mul(T lhs, T rhs);
    }    

    public interface IMultiplicative<S>
        where S : IMultiplicative<S>, new()
    {
        S Mul(S rhs);
    }

    /// <summary>
    /// Characterizes structural multiplication
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The individual type</typeparam>
    public interface IMultiplicative<S,T> : IMultiplicative<S>
        where S : IMultiplicative<S,T>, new()
    {
        
    }


}