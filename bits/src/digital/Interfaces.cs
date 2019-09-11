//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using static zfunc;

    public interface ILogicGate
    {

    }

    public interface IUnaryBitGate : ILogicGate
    {
        Bit Send(Bit a);
    }

    public interface IBinaryBitGate : ILogicGate
    {
        Bit Send(Bit a, Bit b);
    }

    public interface ITernaryBitGate : ILogicGate
    {
        Bit Send(Bit a, Bit b, Bit control);
    }

    /// <summary>
    /// Characterizes a logic gate that accepts a finite number of binary values and produces a single binary output
    /// </summary>
    /// <typeparam name="G">The reifying type</typeparam>
    /// <typeparam name="X">The input type, which must be isomorphic with a finte-length bitstring</typeparam>
    public interface ILogicGate<in X> : ILogicGate
    {
        Bit Send(X x1);
    }

    /// <summary>
    /// A PLL logic gate where input/output type values are bistring isomorphic
    /// </summary>
    /// <typeparam name="X"></typeparam>
    /// <typeparam name="Y"></typeparam>
    public interface ILogicGate<in X, out Y> : ILogicGate
        where X : struct
        where Y : struct
    {
        Y Send(X a);

    }

    public interface ILogicGate<in X1, in X2, out Y> : ILogicGate
        where X1 : struct
        where X2 : struct
        where Y : struct
    {
        Y Send(X1 a, X2 b);

    }

    public interface ILogicGate<in X1, in X2, in X3, out Y> : ILogicGate
        where X1 : struct
        where X2 : struct
        where Y : struct
    {
        Y Send(X1 a, X2 b, X3 c);

    }    


    public interface ITernaryGate<T> : ILogicGate<T,T,T,T>
        where T : struct
    {

    }

    public interface IUnaryGate<T> : ILogicGate<T,T>
        where T : struct
    {

    }

    public interface IBinaryGate<T> : ILogicGate<T,T,T>
        where T : struct
    {

    }


    public interface ICircuit<in A, out B>
    {
        B Send(A a);
    }
    
    public interface ICircuit<in A, in B, out C>
    {
        C Send(A a, B b);
    }



}