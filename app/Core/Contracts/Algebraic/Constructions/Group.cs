//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    
    partial class Class
    {        

        public interface Reciprocative<T> 
        {
            /// <summary>
            /// Calculates the inverse of a given element
            /// </summary>
            /// <param name="x">The individual for which an inverse will be calculated</param>
            /// <returns></returns>
            T reciprocal(T x);
            
        }

        /// <summary>
        /// Characterizes an algebraic group
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Group<T> : Monoid<T>
        {
            
        }

        public interface GroupM<T> : Group<T>, MonoidM<T>, Reciprocative<T>
        {

        }

        /// <summary>
        /// Characterizes an abelian group
        /// </summary>
        public interface GroupA<T> : Group<T>, MonoidA<T>, Negatable<T> 
        {

        }

        public interface GroupA<H,T> : TypeClass<H>, GroupA<T>
            where H : GroupA<H,T>, new()
        {


        }


        /// <summary>
        /// Characterizes a group action on a set
        /// </summary>
        /// <typeparam name="G">The type of the acting group</typeparam>
        /// <typeparam name="T">The type of the target set</typeparam>
        /// <remarks>
        /// For an instance to be law-abiding, the act function must satisfy g(act(h,t)) = act(hg,t) and
        /// act(1,t) = t for all g,h in G and t in T
        /// </remarks>
        public interface GroupAction<G,T>
            where G : Group<G>, new()

        {
            /// <summary>
            /// Applies a G-element to a T-element
            /// </summary>
            /// <param name="g">The group element</param>
            /// <param name="t">The target element</param>
            /// <returns></returns>
            T act(G g, T t);
        }
    }
}