//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Traits;

    partial class Traits
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

}