//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static zfunc;

    partial class Operative
    {
        /// <summary>
        /// Defines the minimal aspects for a value to be considered a "real number"
        /// The dual contract, that subsumes every possible aspect of number, is 
        /// defined via the Real trait. Note that every Number can be parameterized 
        /// by any underlying primitive numeric type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Number<T> : 
                Subtractive<T>, 
                Absolutive<T>, 
                GroupA<T>,  
                SemigroupM<T>, 
                Semiring<T>, 
                Divisive<T>, 
                Powered<T,int>, 
                BitSource<T>, 
                Formattable 
            where T : struct, IEquatable<T>

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
        public interface Number<S> : 
                Subtractive<S>, 
                Absolitive<S>, 
                Equatable<S>, 
                GroupA<S>, 
                SemigroupM<S>, 
                Semiring<S>, 
                Divisive<S>, 
                NaturallyPowered<S>, 
                BitSource<S>, 
                Formattable
            where S : Number<S>, new()
        {            

        }
         
    }

    partial class C
    {
        /// <summary>
        /// Characterizes a structural number in the C adaptation context
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        public interface Number<S>  
            :   
                Structures.Additive<S>, 
                Structures.Subtractive<S>, 
                Structures.Multiplicative<S>, 
                Structures.Divisive<S>,
                Structures.Unital<S>, 
                Structures.Nullary<S>,
                Structures.NaturallyPowered<S>
            where S : Number<S>, new()
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
        public interface Number<S,T> : Number<S>
            where S : Number<S,T>, new()
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

}