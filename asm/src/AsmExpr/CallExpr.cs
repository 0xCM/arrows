//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Represents a function call with an argument count of natural type
    /// </summary>
    /// <typeparam name="N">The count type</typeparam>
    /// <remarks>
    /// A function call should be interpreted as follows:
    /// For a function with up to 6 integer or pointer parameters, the argument values should be 
    /// moved respectively to the registers RDI, RSI, RDX, RCX, R8, and R9; Additional parameters 
    /// or parameters of width > 64 bits should be pushed onto the stack, with the first argument at the top. 
    /// The call instruction should the be exectued, that pushes the return address onto the stack 
    /// and jump to the start of the specified function. If the function returns a value, it will
    /// be placed in RAX after the call completes
    /// </remarks>
    public abstract class CallExpr<N> : AsmExpr
        where N : ITypeNat, new()
    {
        public readonly int ArgCount
            = (int)new N().value;

        /// <summary>
        /// Specfies the function identifier
        /// </summary>
        public string Function {get;}

        protected CallExpr(string Function)
        {
            this.Function = Function;
        }
    }

    public abstract class CallExpr<N,R> : CallExpr<N>
        where N : ITypeNat, new()
    {
        protected CallExpr(string Function)
            : base(Function)
        {

        }

    }

    public sealed class Call<R> : CallExpr<N0>
    {
        public Call(string Function)
            : base(Function)
        {
            
        }

    }

    public sealed class Call<A0,R> : CallExpr<N1,R>
        where A0 : struct
        where R : struct
    {
        public Call(string function, A0 arg0)   
            : base(function)
        {
            this.Arg0 = arg0;
        }

        public A0 Arg0 {get;}
    }

    public sealed class Call<A0,A1,R> : CallExpr<N2,R>
        where A0 : struct
        where A1 : struct
        where R : struct
    {
        public Call(string function, A0 arg0, A1 arg1)   
            : base(function)
        {
            this.Arg0 = arg0;
            this.Arg1 = arg1;
        }

        public A0 Arg0 {get;}

        public A1 Arg1 {get;}

    }

    public sealed class Call<A0,A1,A2,R> : CallExpr<N3,R>
        where A0 : struct
        where A1 : struct
        where A2 : struct
        where R : struct
    {
        public Call(string function, A0 arg0, A1 arg1, A2 arg2)   
            : base(function)
        {
            this.Arg0 = arg0;
            this.Arg1 = arg1;
            this.Arg2 = arg2;
        }

        public A0 Arg0 {get;}

        public A1 Arg1 {get;}
        
        public A2 Arg2 {get;}
        
    }


}