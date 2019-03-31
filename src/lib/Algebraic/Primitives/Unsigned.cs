//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {
        /// <summary>
        /// Characterizes operations over unsigned numbers
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Unsigned<T> : Operational<T>
        {
            
        }

    }

    partial class Structure
    {
        public interface Unsigned<S>
        {

        }

        /// <summary>
        /// Characterizes a structural unsigned number
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underling primitive</typeparam>
        public interface Unsigned<S,T> : Unsigned<S>, Structural<S,T>
            where S : Unsigned<S,T>, new()
        {

        }

    }

}