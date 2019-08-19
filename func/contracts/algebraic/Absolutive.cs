//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    public interface IAbsolutiveOps<T> 
    {
        T Abs(T x);
    }

    public interface Absolitive<S> : IStructure<S>
        where S : Absolitive<S>,new()
    {
        S Abs();
    }

}