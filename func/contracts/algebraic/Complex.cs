//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;


    /// <summary>
    /// Characterizes a structure that represents a complex number
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The underlying numeric component type</typeparam>
    /// <typeparam name="C">The complex number type</typeparam>
    public interface IComplex<S,T,C> : INumber<S>
        where S : struct, IComplex<S,T,C>
    {
        /// <summary>
        /// The real part
        /// </summary>
        T Re {get;}

        /// <summary>
        /// The imaginary part
        /// </summary>
        T Im {get;}


    }

}