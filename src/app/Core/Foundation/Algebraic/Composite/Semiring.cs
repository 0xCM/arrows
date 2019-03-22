//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    partial class Traits
    {
         /// <summary>
        /// Characterizes semiring operations
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Semiring<T> : MonoidA<T>, MonoidM<T>, Distributive<T>
        {        
            
        }

        /// <summary>
        /// Characterizes semiring structure
        /// </summary>
        /// <typeparam name="S">The classified structure</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
         public interface Semiring<S,T> : MonoidA<S,T>, MonoidM<S,T>, Distributive<S,T>
            where S : Semiring<S,T>, new()
        {
            
        }            

    }

}