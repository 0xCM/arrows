//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Traits
    {
        /// <summary>
        /// Characterizes a uniform distribution
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface Uniform<T> : Distribution<T>
            where T : new()
        {
            /// <summary>
            /// The minimum potential value
            /// </summary>
            T min {get;}

            /// <summary>
            /// The maximum potential value
            /// </summary>
            T max {get;}
        }
    }
}