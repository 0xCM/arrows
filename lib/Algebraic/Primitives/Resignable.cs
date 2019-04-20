//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Operative
    {    

        /// <summary>
        /// Characterizes a sign-reversal operation
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Resignable<T> : Signable<T>, Negatable<T>
        {
            /// <summary>
            /// Aligns the value with a specified sign
            /// </summary>
            T resign(T x, Sign s);

        }



    }

    partial class Structures
    {


        /// <summary>
        /// Characterizes a structure whose sign can be reversed
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Resignable<S> : Signable<S>, Negatable<S>
            where S : Resignable<S>, new()
        {
            /// <summary>
            /// Aligns the structure with a specified sign
            /// </summary>
            S resign(Sign sign);

        }


    }
}