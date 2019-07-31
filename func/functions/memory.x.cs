//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Diagnostics;
    
    using static zfunc;
    
    partial class xfunc
    {

        [MethodImpl(Inline)]
        public static Memory<T> ToMemory<T>(this IEnumerable<T> src)
            => src.ToArray();


        /// <summary>
        /// Uses the (void*) explicit operator defined by the source type to
        /// present said source as a void*
        /// </summary>
        /// <param name="src">The source pointer representative</param>
        [MethodImpl(Inline)]
        public static unsafe void* ToVoid(this IntPtr src)
            => (void*)src;

        /// <summary>
        /// Gets the void* for the identified field
        /// </summary>
        /// <param name="src">The runtime field handle</param>
        [MethodImpl(Inline)]
        public static unsafe void* ToVoid(this RuntimeFieldHandle src)
            => src.Value.ToVoid();
    }

}