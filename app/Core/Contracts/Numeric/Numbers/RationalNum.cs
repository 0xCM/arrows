//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Charactrizes a rational number
    /// </summary>
    /// <typeparam name="I">The underlying integral type</typeparam>
    public interface Rational<S,T> : Number<S,(T over,T under)>
        where S : Rational<S,T>, new()
        where T : new()
    {
        /// <summary>
        /// The dividend
        /// </summary>
        /// <value></value>
        T over {get;}

        /// <summary>
        /// The divisor
        /// </summary>
        /// <value></value>
        T under {get;}
    }
}