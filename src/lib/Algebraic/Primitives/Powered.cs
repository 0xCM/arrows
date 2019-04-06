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

    partial class Structures
    {
        public interface Powered<B,E>
            where B : Powered<B,E>, new()
        {
            B pow(E exp);
            
        }

        public interface NaturallyPowered<S> : Powered<S, int>
            where S : NaturallyPowered<S>, new()
        {
        }

    }

}