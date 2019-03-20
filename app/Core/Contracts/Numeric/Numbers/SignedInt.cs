//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Class
    {
        public interface SignedInt<T> : Integer<T>, Signed<T>, Negatable<T>
        {

        }

        public interface SignedInt<H,T> : TypeClass<H>,  SignedInt<T>
            where H: SignedInt<H,T>, new()
        {
        
        }
    }

    partial class Struct
    {

        /// <summary>
        /// Characterizes an structural integer that spans both positive and negative
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface SignedInt<S,T> : Integer<S,T>, Signed<S,T>, Negatable<S,T>
            where S : SignedInt<S,T>, new()
            where T : new()
        {
        }
    }
}