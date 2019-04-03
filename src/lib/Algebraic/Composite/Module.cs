//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Traits;

    partial class Structures
    {
        public interface LeftModule<R,G>  : GroupA<G>
            where R : Ring<R>, new()
            where G : GroupA<G>, new()
        {

            /// <summary>
            /// Effects scalar multiplication from the left
            /// </summary>
            /// <param name="r">The ring individual type, i.e., the scalar type</param>
            /// <param name="m">The group individual type</param>
            G scale(R r);

        }

        public interface RightModule<G,R>  : GroupA<G>
            where R : Ring<R>, new()
            where G : GroupA<G>, new()
        {

            /// <summary>
            /// Effects scalar multiplication from the right
            /// </summary>
            /// <param name="r">The ring individual type, i.e., the scalar type</param>
            /// <param name="m">The group individual type</param>
            G scale(R r);

        }

        public interface LeftModule<S,R,G> : LeftModule<R,G>
            where S : LeftModule<S,R,G>, new()
            where R : CommutativeRing<R>, new()
            where G : GroupA<G>, new()
        {

        }

        public interface RightModule<S,G,R> : RightModule<G,R>
            where S : RightModule<S,G,R>, new()
            where R : CommutativeRing<R>, new()
            where G : GroupA<G>, new()
        {

        }

    }

    partial class Operative
    {
        /// <summary>
        /// Characterizes a group action on a set
        /// </summary>
        /// <typeparam name="G">The type of the acting group</typeparam>
        /// <typeparam name="R">The type of the target set</typeparam>
        /// <remarks>
        /// For an instance to be law-abiding, the act function must satisfy g(act(h,t)) = act(hg,t) and
        /// act(1,t) = t for all g,h in G and t in T
        /// Also, see https://en.wikipedia.org/wiki/Group_with_operators
        /// </remarks>
        public interface GroupAction<G,R>
            where G : Group<G>, new()

        {
            /// <summary>
            /// Applies a G-element to a T-element
            /// </summary>
            /// <param name="g">The group element</param>
            /// <param name="t">The target element</param>
            /// <returns></returns>
            R act(G g, R t);
        }

 
        /// <summary>
        /// Characterizes a left module over a commtative unital ring
        /// </summary>
        /// <typeparam name="G">The group individual type</typeparam>
        /// <typeparam name="R">The ring individual type</typeparam>
        public interface LeftModule<R,G> : GroupA<G>
            where R : CommutativeRing<R>, new()
            
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
        public interface RightModule<G,R> : GroupA<G>
            where R : CommutativeRing<R>, new()
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