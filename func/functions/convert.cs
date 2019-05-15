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

partial class zfunc
{

    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src, out T dst)
        where T : struct
        where S : struct
            => dst = Converter.convert(src, out T target);  
           
    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src)
        where T : struct
        where S : struct
           => Converter.convert(src, out T dst);  
    
    [MethodImpl(Inline)]   
    public static T convert<T>(sbyte src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(byte src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(short src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(ushort src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(int src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(uint src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(long src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(ulong src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(float src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(double src)
        where T : struct
            => Converter.convert(src, out T dst);
}