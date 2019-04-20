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
    
    using static zcore;



    public static class Span
    {
        [MethodImpl(Inline)]
        public static Span<N,T> define<N,T>(T[] src, int startpos = 0)
            where N : TypeNat, new()
            where T : struct, IEquatable<T>
                => new Span<N,T>(src,startpos);

        [MethodImpl(Inline)]
        public static Span<N,T> define<N,T>(Span<T> src)
            where N : TypeNat, new()
            where T : struct, IEquatable<T>
                => new Span<N,T>(src);

        [MethodImpl(Inline)]
        public static Span<N,T> define<N,T>(Array<N,T> src)
            where N : TypeNat, new()
            where T : struct, IEquatable<T>
                => new Span<N,T>(src);

    }



}