//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static zcore;

    partial class Traits
    {
        /// <summary>
        /// Characterizes an operator over a specified type
        /// </summary>
        /// <typeparam name="T">The operand</typeparam>
        public interface Operator<T>
        {
            
        }

        public interface Apply<T> : Operator<T>
        {

        }

    
    }

}