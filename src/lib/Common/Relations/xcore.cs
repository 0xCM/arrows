//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    partial class xcore
    {
        /// <summary>
        /// Constructs a finite set from the (presumeably) finite source sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The set member type</typeparam>
        /// <returns></returns>
        public static FiniteSet<T> ToFiniteSet<T>(this IEnumerable<T> src)
            => new FiniteSet<T>(src);
    }

}