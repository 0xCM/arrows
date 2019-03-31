using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Z0;


partial class zcore
{

    [MethodImpl(Inline)]   
    public static Z0.Slice<T> slice<T>(params T[] src)
        where T : Equality<T>, new()
            => new Slice<T>(src);

    [MethodImpl(Inline)]   
    public static Z0.Slice<T> slice<T>(IEnumerable<T> src)
        where T : Equality<T>, new()
            => new Slice<T>(src);

    [MethodImpl(Inline)]   
    public static Z0.Slice<N,T> slice<N,T>(IEnumerable<T> src)
        where N : TypeNat, new()
        where T : Equality<T>, new()
            => new Slice<N,T>(src);

    [MethodImpl(Inline)]   
    public static Z0.Slice<N,T> slice<N,T>(params T[] src)
        where N : TypeNat, new()
        where T : Equality<T>, new()
            => new Slice<N,T>(src);

}