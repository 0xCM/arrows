using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Core;


partial class corefunc
{

    [MethodImpl(Inline)]   
    public static Core.Slice<N,T> slice<N,T>(IEnumerable<T> src)
        where N : TypeNat, new()
            => new Core.Slice<N,T>(src);

    [MethodImpl(Inline)]   
    public static Core.Slice<N,T> slice<N,T>(params T[] src)
        where N : TypeNat, new()
            => new Core.Slice<N,T>(src);

}