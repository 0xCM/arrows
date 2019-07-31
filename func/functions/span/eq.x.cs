//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;
    using static As;

    partial class xfunc
    {
        /// <summary>
        /// Evaluates whether two spans have identical content
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The value type</typeparam>
        public static bool Eq<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct, IEquatable<T>
        {
            if(lhs.Length != rhs.Length)
                return false;
            for(var i=0; i< lhs.Length; i++)
                if(!lhs[i].Equals(rhs[i]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public static bool Eq<T>(this Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct, IEquatable<T>
                => lhs.ReadOnly().Eq(rhs);
        

    }
}