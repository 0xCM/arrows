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

    public interface IGate
    {

    }

    /// <summary>
    /// Characterizes a logic gate that accepts a finite number of binary values and produces a single binary output
    /// </summary>
    /// <typeparam name="G">The reifying type</typeparam>
    /// <typeparam name="X">The input type, which must be isomorphic with a finte-length bitstring</typeparam>
    public interface IGate<in X> : IGate
    {
        Bit Send(X x1);
    }
    



    /// <summary>
    /// A PLL logic gate where input/output type values are bistring isomorphic
    /// </summary>
    /// <typeparam name="X"></typeparam>
    /// <typeparam name="Y"></typeparam>
    public interface IGate<in X, out Y> : IGate
        where X : struct
        where Y : struct
    {
        Y Send(X x);

    }

    public interface IGate<in X1, in X2, out Y> : IGate
        where X1 : struct
        where X2 : struct
        where Y : struct
    {
        Y Send(X1 x1, X2 x2);

    }

    public interface IGate<in X1, in X2, in X3, out Y> : IGate
        where X1 : struct
        where X2 : struct
        where Y : struct
    {
        Y Send(X1 x1, X2 x2, X3 x3);

    }    

    public interface IUnaryGate : IGate<Bit, Bit>
    {

    }

    public interface IBinaryGate : IGate<Bit, Bit, Bit>
    {

    }

    public interface ITernaryGate : IGate<Bit,Bit,Bit,Bit>
    {

    }

    public interface ITernaryGate<T> : IGate<T,T,T,T>
        where T : struct
    {

    }

    public interface IUnaryGate<T> : IGate<T,T>
        where T : struct
    {

    }

    public interface IBinaryGate<T> : IGate<T,T,T>
        where T : struct
    {

    }


    public interface ICircuit<C, in I, out O>
        where C : struct, ICircuit<C,I,O>
    {
        O Send(I input);
    }

}