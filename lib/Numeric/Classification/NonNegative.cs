//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {
        /// <summary>
        /// Characterizes operations over nonnegative operands
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface NonNegative<T>
        {
            
        }

    }

    partial class Structures
    {
        /// <summary>
        /// Characterizes a structure whose values are nonnegative
        /// </summary>
        /// <typeparam name="S">The reifying structure</typeparam>
        public interface NonNegative<S>            
            where S : NonNegative<S>, new()
        {

        }


    }

}