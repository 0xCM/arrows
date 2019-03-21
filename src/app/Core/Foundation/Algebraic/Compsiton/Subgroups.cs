//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    
    partial class Class
    {        


        /// <summary>
        /// Characterizes normal subgroup operations
        /// </summary>
        /// <typeparam name="T">The type over which operations are defined</typeparam>
        public interface NormalSubgroup<T> : Group<T>
            where T : NormalSubgroup<T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a coset
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Coset<T>
            where T : Group<T>, new()
        {
            /// <summary>
            /// The distinguished group element with which to compose each subgroup element
            /// </summary>
            /// <returns></returns>
            T actor {get;}

            /// <summary>
            /// The subgroup to be acted upon
            /// </summary>
            /// <returns></returns>
            Group<T> subgroup {get;}

        }


        /// <summary>
        /// Characterizes a coset formed by a left-action
        /// </summary>
        public interface LeftCoset<T> : Coset<T>
            where T : Group<T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a coset formed by a right-action
        /// </summary>
        public interface RightCoset<T> : Coset<T>
            where T : Group<T>, new()
        {
            
        }

    }

}