//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Traits
    {
        /// <summary>
        ///  Conceptually subsumes all aspects of real numbers, 
        ///  and may parameterized by any numeric type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Real<T> : Integer<T>, Floating<T>
        {

        }

        /// <summary>
        /// Characterizes an extended structual real
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Real<S,T> : Integer<S,T>, Floating<S,T>
            where S : Real<S,T>, Floating<S,T>, new()
            
        {
            bool infinite {get;}

        }


    }


}