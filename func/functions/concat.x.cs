//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Text;

    using static zfunc;

    partial class xfunc
    {

        /// <summary>
        /// Concatenates a sequence of strings, placing separators between adjacent items
        /// </summary>
        /// <param name="items">The items to concatenate</param>
        /// <param name="separator">The separator</param>
        public static string Concat(this IEnumerable<object> items, string separator)
            => string.Join(separator, items);



    }

}