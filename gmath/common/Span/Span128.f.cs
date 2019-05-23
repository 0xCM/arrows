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
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T first<T>(Span128<T> src)
        where T : struct
            =>  ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Returns a readonly refrence to the first element of a readonly span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T first<T>(ReadOnlySpan128<T> src)
        where T : struct
            =>  ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Reimagines a span of one element type as a span of another element type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    public static Span128<T> cast<S,T>(Span128<S> src)                
        where S : struct
        where T : struct
            =>  Span128.load(MemoryMarshal.Cast<S,T>(src));

    /// <summary>
    /// Reimagines a readonly span of one element type as a readonly span of another element type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan128<T> cast<S,T>(ReadOnlySpan128<S> src)                
        where S : struct
        where T : struct
            => (ReadOnlySpan128<T>)MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> rhs, [CallerFilePath] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)        
        where T : struct
        where S : struct
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);


    [MethodImpl(Inline)]   
    public static int length<S,T>(Span128<S> lhs, Span128<T> rhs, [CallerFilePath] string caller = null,
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : struct
            where T : struct
                => lhs.Length == rhs.Length ? lhs.Length 
                    : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);
                    
    /// <summary>
    /// Returns the common number of 128-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, [CallerFilePath] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        where T : struct
            => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file,line);

    /// <summary>
    /// Returns the common number of 128-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(Span128<T> lhs, Span128<T> rhs, [CallerFilePath] string caller = null,
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file,line);
}