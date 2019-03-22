//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Traits
    {
        public interface Infinity<T>
        {
            /// <summary>
            /// Specifies whether the infinity is positive
            /// </summary>
            bool positive {get;}

            /// <summary>
            /// Specifies whether the infinity is negative
            /// </summary>
            bool negative {get;}
        }

    }
}