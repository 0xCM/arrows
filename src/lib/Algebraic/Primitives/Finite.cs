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
        public interface Finite<T>
        {
            /// <summary>
            /// The count providing evidence that the reification is finite
            /// </summary>
            int count {get;}
        }


        public interface Bound<T>
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

    }

}