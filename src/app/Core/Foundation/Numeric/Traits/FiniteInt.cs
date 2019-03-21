//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;


    partial class Class
    {

        public interface FiniteInt<T> : Integer<T>, Finite<T>
            where T: FiniteInt<T>, new()
        {

        }

        /// <summary>
        /// Characterizes a structure over a bound integral type
        /// </summary>
        public interface FiniteInt<S,T> : Integer<S,T>, Finite<S,T>
            where S : FiniteInt<S,T>, new()
            where T : new()
        {

        }

    }





}