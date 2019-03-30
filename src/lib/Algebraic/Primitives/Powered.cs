//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an exponentiation operation
    /// </summary>
    /// <typeparam name="B">The base type</typeparam>
    /// <typeparam name="E">The exponent type</typeparam>
    public interface Powered<B,E> : Operational<B>
    {
        B pow(B b, E exp);
    }
    

    partial class Structure
    {
        /// <summary>
        /// Characterizes an exponential structure
        /// </summary>
        /// <typeparam name="B">The base type</typeparam>
        /// <typeparam name="E">The exponent type</typeparam>
        public interface Powered<S,B,E> : Structural<S,B>
            where S : Powered<S,B,E>, new()
        {
            B pow(E exp);
        }

    }
}