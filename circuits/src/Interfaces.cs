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

    /// <summary>
    /// Characterizes a logic gate, a device of sorts that receives one or more input
    /// values and emits a single value
    /// </summary>
    public interface ILogicGate
    {

    }

    /// <summary>
    /// Characterizes a logic gate that receives 1 bit
    /// </summary>
    public interface IUnaryBitGate : ILogicGate
    {
        Bit Send(Bit a);
    }

    /// <summary>
    /// Characterizes a logic gate that receives 2 bits
    /// </summary>
    public interface IBinaryBitGate : ILogicGate
    {
        Bit Send(Bit a, Bit b);
    }

    /// <summary>
    /// Characterizes a logic gate that receives 3 bits
    /// </summary>
    public interface ITernaryBitGate : ILogicGate
    {
        Bit Send(Bit a, Bit b, Bit c);
    }


    /// <summary>
    /// Characterizes a logic gate that accepts one parametric input
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface IUnaryGate<T> : IUnaryBitGate
        where T : unmanaged
    {
        T Send(in T a);
    }

    /// <summary>
    /// Characterizes a logic gate that accepts two parametric inputs 
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface IBinaryGate<T> : IBinaryBitGate
        where T : unmanaged
    {
        T Send(in T a, in T b);
    }

    /// <summary>
    /// Characterizes a logic gate that accepts three parametric inputs 
    /// </summary>
    /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
    public interface ITernaryGate<T> : ITernaryBitGate
        where T : unmanaged
    {
        T Send(in T a, in T b, in T c);

    }

    public interface ICircuit<A, out B>
    {
        B Send(in A a);
    }
    
    public interface ICircuit<A, B, out C>
    {
        C Send(in A a, in B b);
    }



}