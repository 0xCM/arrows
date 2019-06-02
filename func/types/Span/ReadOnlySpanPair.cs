//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public readonly ref struct ReadOnlySpanPair<T>
    {
        public ReadOnlySpanPair(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
        {
            this.Left = lhs;
            this.Right = rhs;
        }
        public readonly ReadOnlySpan<T> Left;

        public readonly ReadOnlySpan<T> Right;
    }

}