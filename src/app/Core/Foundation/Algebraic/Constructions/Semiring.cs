//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    partial class Class
    {
        /// <summary>
        /// Characterizes a type that defines an internal law over composition over its values
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Semiring<T> : MonoidA<T>, MonoidM<T>, Distributive<T>
        {        
            
        }

    }

    partial class Struct
    {

        public interface Semiring<S,T> : MonoidA<S,T>, MonoidM<S,T>, Distributive<S,T>
            where S : Semiring<S,T>, new()
        {
            
        }            

    }


}