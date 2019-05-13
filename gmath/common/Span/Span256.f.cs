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
    /// Returns a reference to the first element of a span
    /// </summary>
    /// <param name="src">The span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T first<T>(Span256<T> src)
        where T : struct, IEquatable<T>
            =>  ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Returns a readonly refrence to the first element of a readonly span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T first<T>(ReadOnlySpan256<T> src)
        where T : struct, IEquatable<T>
            =>  ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Reimagines a span of one element type as a span of another element type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    public static Span256<T> cast<S,T>(Span256<S> src)                
        where S : struct, IEquatable<S>
        where T : struct, IEquatable<T>
            => (Span256<T>)MemoryMarshal.Cast<S,T>(src);

    /// <summary>
    /// Reimagines a readonly span of one element type as a readonly span of another element type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan256<T> cast<S,T>(ReadOnlySpan256<S> src)                
        where S : struct, IEquatable<S>
        where T : struct, IEquatable<T>
            => (ReadOnlySpan256<T>)MemoryMarshal.Cast<S,T>(src);


    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        where T : struct, IEquatable<T>
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length,rhs.Length,file,line);
 
    [MethodImpl(Inline)]   
    public static int length<T>(Span256<T> lhs, Span256<T> rhs, [CallerFilePath] string file = null, 
        [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T>
                => lhs.Length == rhs.Length ? lhs.Length 
                    : throw Errors.LengthMismatch(lhs.Length, rhs.Length, file, line);

    /// <summary>
    /// Returns the common number of 256-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(Span256<T> lhs, Span256<T> rhs, [CallerFilePath] string file = null, 
        [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T>
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, file,line);

    /// <summary>
    /// Returns the common number of 256-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, [CallerFilePath] string file = null, 
        [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T>
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, file,line);



}