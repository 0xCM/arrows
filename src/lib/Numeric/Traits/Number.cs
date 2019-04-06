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
        /// Defines the minimal aspects for a value to be considered a "real number"
        /// The dual contract, that subsumes every possible aspect of number, is 
        /// defined via the Real trait. Note that every Number can be parameterized 
        /// by any underlying primitive numeric type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Number<T> : Subtractive<T>, Absolutive<T>, GroupA<T>,  SemigroupM<T>, Semiring<T>, Divisive<T>, Powered<T,int>, BitSource<T> 
        {                                
            NumberInfo<T> numinfo {get;}
        }

    }
    partial class Structures
    {
 
        /// <summary>
        /// Characterizes a structral number
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying operand type</typeparam>
        public interface Number<S> : Subtractive<S>, Absolitive<S>, Equatable<S>, GroupA<S>, SemigroupM<S>, Semiring<S>, Divisive<S>, NaturallyPowered<S>, BitSource<S>
            where S : Number<S>, new()
        {
            


        }
         
    }
}