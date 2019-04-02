//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Operative
    {

    
        /// <summary>
        /// Characterizes an exponentiation operation
        /// </summary>
        /// <typeparam name="B">The base type</typeparam>
        /// <typeparam name="E">The exponent type</typeparam>
        public interface Powered<B,E> 
        {
            B pow(B b, E exp);
        }
    
    }

    partial class Structure
    {
        public interface Powered<S> : Equatable<S>
        {
            S pow(int exp);
        }

        public interface Powered<S,T> : Powered<S>
            where S : Powered<S,T>, new()
        {

        }
    }

}