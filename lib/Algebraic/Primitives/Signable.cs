//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Operative
    {    
        /// <summary>
        /// Characterizes a sign adjudication operation
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Signable<T>
        {
            /// <summary>
            /// Determines the sign of the supplied value
            /// </summary>
            Sign sign(T x);

        }

    }

    partial class Structures
    {
        /// <summary>
        /// Characterizes a structure for which a sign can be adjudicated
        /// </summary>
        /// <typeparam name="S">The signed structure</typeparam>
        public interface Signable<S>
            where S : Signable<S>, new()
        {
            /// <summary>
            /// Specifies the sign of the structure
            /// </summary>
            Sign sign();

        }

    }
}