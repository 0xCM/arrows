//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Class
    {
        /// <summary>
        /// Characterizes an operation provider for bounded and signed integer types
        /// </summary>
        /// <typeparam name="T">The type over which operations are defined</typeparam>
        /// <remarks>
        /// Applies to, for instance, the types {sbyte, short, int, long}
        /// </remarks>
        public interface FiniteSignedInt<T> : SignedInt<T>, Finite<T>
        {

        }

        /// <summary>
        /// Characterizes a structural integer that is bounded and signed
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        /// <remarks>
        /// Applies to structures, for instance, with underlying types of {sbyte, short, int, long}
        /// </remarks>
        public interface FiniteSignedInt<S,T> : SignedInt<S,T>, Finite<S,T>
            where S : FiniteSignedInt<S,T>, new()
            where T:new()
        {

        }
    }

}