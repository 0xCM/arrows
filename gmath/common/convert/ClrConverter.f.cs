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
    /// <summary>
    /// Converts from one value to another, provided the 
    /// required conversion operation is defined; otherwise,
    /// raises an error
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src)
        where T : struct, IEquatable<T>
        where S : struct, IEquatable<S>
            => ClrConverter.convert<S,T>(src);

    /// <summary>
    /// Vectorized conversion
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    /// <param name="src">The source array</param>
    [MethodImpl(Inline)]   
    public static T[] convert<S,T>(S[] src)
        => ClrConverter.convert<S,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(int src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<int,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(uint src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<uint,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(long src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<long,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(ulong src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<ulong,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(float src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<float,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(double src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<double,T>(src);
}