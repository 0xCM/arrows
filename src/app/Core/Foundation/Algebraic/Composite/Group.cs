//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    
    partial class Traits
    {        


        /// <summary>
        /// Characterizes group operations over a type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Group<T> : Invertive<T>, Monoid<T>
        {
            
        }

        /// <summary>
        /// Characterizes a group structure
        /// </summary>
        /// <typeparam name="T">The type over which the structure is defind</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface Group<S,T> : Invertive<S,T>, Monoid<S,T>
            where S : Group<S,T>, new()
        {
            
        }

        public interface GroupM<T> : Group<T>, MonoidM<T>, InvertiveM<T>
        {

        }

        /// <summary>
        /// Characterizes a multiplicative group structure
        /// </summary>
        /// <typeparam name="T">The type over which the structure is defind</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface GroupM<S,T> : Group<S,T>, Monoid<S,T>
            where S : GroupM<S,T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes additive/abelian group operations
        /// </summary>
        public interface GroupA<T> : Group<T>, MonoidA<T>, Negatable<T> 
        {

        }

        /// <summary>
        /// Characterizes an additive group structure
        /// </summary>
        /// <typeparam name="T">The type over which the structure is defind</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface GroupA<S,T> : Group<S,T>, Monoid<S,T>
            where S : GroupA<S,T>, new()
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