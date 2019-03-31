//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    
    partial class Operative
    {

        /// <summary>
        /// Characterizes operations over (ordered) values that 
        /// exist between upper and lower bounds
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface BoundReal<T> : RealNumber<T>
        {

        }

    }

    partial class Structure
    {
        public interface BoundReal<S> :  RealNumber<S>
        {

        }
        /// <summary>
        /// Characterizes a bounded structural number
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underling primitive</typeparam>
        public interface BoundReal<S,T> :  RealNumber<S,T>
            where S : BoundReal<S,T>, new()
        {


        }

    }
}