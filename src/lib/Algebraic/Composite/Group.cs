//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    
    partial class Operative
    {        


        /// <summary>
        /// Characterizes group operations over a type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Group<T> : Invertive<T>, Monoid<T>
        {
            
        }


        public interface GroupM<T> : Group<T>, MonoidM<T>, InvertiveM<T>
        {

        }

        /// <summary>
        /// Characterizes additive/abelian group operations
        /// </summary>
        public interface GroupA<T> : Group<T>, MonoidA<T>, Subtractive<T> 
        {

        }



    }

    partial class Structure
    {

        public interface Group<S> : Invertive<S>, Monoid<S>
        {

        }

        public interface GroupM<S> : Group<S>, MonoidM<S>
        {
            
        }

        public interface GroupA<S> : Group<S>, MonoidA<S>
        {

        }
        /// <summary>
        /// Characterizes a group structure
        /// </summary>
        /// <typeparam name="T">The type over which the structure is defind</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface Group<S,T> : Invertive<S,T>, Monoid<S,T>
            where S : Group<S,T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a multiplicative group structure
        /// </summary>
        /// <typeparam name="T">The type over which the structure is defind</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface GroupM<S,T> : GroupM<S>, Group<S,T>, MonoidM<S,T>
            where S : GroupM<S,T>, new()
        {
            
        }


        /// <summary>
        /// Characterizes an additive group structure
        /// </summary>
        /// <typeparam name="T">The type over which the structure is defind</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface GroupA<S,T> : GroupA<S>, Group<S,T>, MonoidA<S,T>
            where S : GroupA<S,T>, new()
        {
            
        }

    }
}