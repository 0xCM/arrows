//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Traits
    {
        public interface Unsigned<T>
        {
            
        }

        /// <summary>
        /// Characterizes a structural unsigned number
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underling primitive</typeparam>
        public interface Unsigned<S,T> : Unsigned<T>,  Structure<S,T>
            where S : Unsigned<S,T>, new()
        {

        }
    }

}