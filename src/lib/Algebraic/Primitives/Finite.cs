//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Traits;

    partial class Operative
    {
        /// <summary>
        /// Characterizes something for which a fininte count can be defined
        /// </summary>
        /// <typeparam name="T">The type for which a finite number of instances exist
        /// within a reification context</typeparam>
        public interface Finite<T> : Operational<T>
        {
            /// <summary>
            /// The count providing evidence that the reification is finite
            /// </summary>
            int count {get;}
        }


        public interface Bound<T> : Operational<T>
        {

        }
    }

    partial class Structure
    {
        public interface Finite<S> 
        {

            /// <summary>
            /// The count providing evidence that the reification is finite
            /// </summary>
            uint count {get;}

        }        

        /// <summary>
        /// Characterizes a structure S comprised of a finite number of elements T
        /// </summary>
        /// <typeparam name="S">The reifying structure</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public interface Finite<S,T> : Finite<S>
            where S : Finite<S,T>, new()
        {

        }        
    }

}