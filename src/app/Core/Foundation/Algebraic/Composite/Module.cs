//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using static Traits;

    partial class Traits
    {
        /// <summary>
        /// Characterizes a left module over a commtative unital ring
        /// </summary>
        /// <typeparam name="G">The group individual type</typeparam>
        /// <typeparam name="R">The ring individual type</typeparam>
        public interface LeftModule<R,G> 
            where R : Ring<R>, new()
            where G : GroupA<G>, new()
        {
            /// <summary>
            /// Effects left scalar multiplication
            /// </summary>
            /// <param name="r">The ring individual type, i.e., the scalar type</param>
            /// <param name="m">The group individual type</param>
            /// <returns></returns>
            G scale(R r, G m);
        }

        /// <summary>
        /// Characterizes a right module over a commtative unital ring
        /// </summary>
        /// <typeparam name="G">The group individual type</typeparam>
        /// <typeparam name="R">The ring individual type</typeparam>
        public interface RightModule<G,R> 
            where G : GroupA<G>, new()
            where R : Ring<R>, new()
        {
            /// <summary>
            /// Effects right scalar multiplication
            /// </summary>
            /// <param name="m">The group individual type</param>
            /// <param name="r">The ring individual type, i.e., the scalar type</param>
            /// <returns></returns>
            G scale(G m, R r);
        }
    }
}