//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static zfunc;

    /// <summary>
    /// Defines the minimal aspects for a value to be considered a "real number"
    /// The dual contract, that subsumes every possible aspect of number, is 
    /// defined via the Real trait. Note that every Number can be parameterized 
    /// by any underlying primitive numeric type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface INumberOps<T> : 
            ISubtractiveOps<T>, 
            IAbsolutiveOps<T>, 
            IGroupAOps<T>,  
            ISemigroupMOps<T>, 
            ISemiringOps<T>, 
            IDivisiveOps<T>, 
            IPoweredOps<T,int> 
        where T : struct

    {                                
        PrimalInfo<T> numinfo {get;}
    }

    /// <summary>
    /// Characterizes a structral number
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The underlying operand type</typeparam>
    public interface INumber<S> : 
            ISubtractive<S>, 
            Absolitive<S>, 
            IGroupA<S>, 
            ISemigroupM<S>, 
            ISemiring<S>, 
            IDivisive<S>, 
            INaturallyPowered<S> 
        where S : INumber<S>, new()
    {            

    }

    /// <summary>
    /// Characterizes a structural number in the C adaptation context
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface ICNumber<S>  
        :   
            IAdditive<S>, 
            ISubtractive<S>, 
            IMultiplicative<S>, 
            IDivisive<S>,
            IUnital<S>, 
            INullary<S>,
            INaturallyPowered<S>
        where S : ICNumber<S>, new()
    {
        /// <summary>
        /// Specifies the (fixed) number of bits required to represent the numeric value
        /// </summary>
        int bitsize {get;}


    }

    /// <summary>
    /// Characterizes a structural number reification in the C adaptation context
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface ICNumber<S,T> : ICNumber<S>
        where S : ICNumber<S,T>, new()
    {
        S revalue(T src);
        
        /// <summary>
        /// Elevates a primitive to a structure
        /// </summary>
        /// <param name="src">The primitive source</param>
        IEnumerable<S> wrap(IEnumerable<T> src);

        /// <summary>
        /// Unwraps a lifted primitivie
        /// </summary>
        /// <param name="src">The lifted source</param>
        IEnumerable<T> unwrap(IEnumerable<S> src);
    }
}