//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;
using System.Diagnostics;

using Z0;
using static zfunc;

partial class mfunc
{


    [MethodImpl(Inline)]
    public static num<T> num<T>(T src)
        where T : struct
            => Unsafe.As<T,num<T>>(ref src);


    [MethodImpl(Inline)]
    public static num<T> abs<T>(num<T> src)
        where T : struct
            => src.Abs();

    [MethodImpl(Inline)]
    public static num<T> sqrt<T>(num<T> src)
        where T : struct
            => src.Sqrt();

    [MethodImpl(Inline)]
    public static num<T> add<T>(num<T> lhs, num<T> rhs)
        where T : struct
            => lhs.Add(rhs);
    
    [MethodImpl(Inline)]
    public static num<T> mul<T>(num<T> lhs, num<T> rhs)
        where T : struct
            => lhs.Mul(rhs);

    [MethodImpl(Inline)]
    public static num<T> div<T>(num<T> lhs, num<T> rhs)
        where T : struct
            => lhs.Div(rhs);
   
    [MethodImpl(Inline)]
    public static num<T> mod<T>(num<T> lhs, num<T> rhs)
        where T : struct
            => lhs.Mod(rhs);

    [MethodImpl(Inline)]
    public static num<T> and<T>(num<T> lhs, num<T> rhs)
        where T : struct
            => lhs.And(rhs);

    [MethodImpl(Inline)]
    public static num<T> or<T>(num<T> lhs, num<T> rhs)
        where T : struct
            => lhs.Or(rhs);

    [MethodImpl(Inline)]
    public static num<T> xor<T>(num<T> lhs, num<T> rhs)
        where T : struct
            => lhs.XOr(rhs);


}