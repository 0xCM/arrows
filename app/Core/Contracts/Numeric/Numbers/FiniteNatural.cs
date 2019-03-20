//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    partial class Class
    {
        /// <summary>
        /// Characterizes an operation provider for bounded natural types
        /// </summary>
        /// <typeparam name="T">The type over which operations are defined</typeparam>
        public interface FiniteNatural<T> : Natural<T>, Finite<T>
        {
            
        }

        public interface FiniteNatural<H,T> : TypeClass<H>, FiniteNatural<T>
            where H : FiniteNatural<H,T>, new()
        {
            
        }

    }

    partial class Struct
    {
        /// <summary>
        /// Characterizes a natural number, i.e. one of {0,1,...} subject to the maximum
        /// value of the underlying type
        /// </summary>
        /// <typeparam name="S">The realizing type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface FiniteNatural<S,T> : Natural<S,T>, Finite<S,T>
            where S : FiniteNatural<S,T>, new()
            where T : new()
        {
            
        }


    }



    

}