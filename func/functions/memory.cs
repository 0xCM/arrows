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
    /// <summary>
    /// Computes the size, in bytes of a source value of specified type
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static ByteSize size<T>()
        where T : struct
            => Unsafe.SizeOf<T>();

    /// <summary>
    /// Computes the size, in bits of a source value of specified type
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static BitSize bitsize<T>()
        where T :struct
            => Unsafe.SizeOf<T>()*8;

    /// <summary>
    /// The canonical swap function
    /// </summary>
    /// <param name="lhs">The left value</param>
    /// <param name="rhs">The right value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static void swap<T>(ref T lhs, ref T rhs)
    {
        var temp = lhs;
        lhs = rhs;
        rhs = temp;
    }

    /// <summary>
    /// Presents a source reference as a byte reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref byte byteref<T>(ref T src)
        where T : struct
            => ref Unsafe.As<T,byte>(ref src);

    /// <summary>
    /// Enumerates the content of a readonly memory segment
    /// </summary>
    /// <param name="src">The source memory</param>
    /// <typeparam name="T">The memory cell type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> enumerate<T>(ReadOnlyMemory<T> src)
        =>  MemoryMarshal.ToEnumerable(src);

    /// <summary>
    ///  Constructs a memory segment from the content of the (hopefully finite) stream (allocating)
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static Memory<T> memory<T>(IEnumerable<T> src)
        => src.ToArray();

    /// <summary>
    /// Constructs a memory segment of specified length from a stream (allocating)
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <param name="length">The length of the index</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static Memory<T> memory<T>(IEnumerable<T> src, int length)
        => memory(src.Take(length));

    /// <summary>
    /// Constructs a mutable memory segment from a readonly memory segment
    /// </summary>
    /// <param name="src">The source memory</param>
    /// <typeparam name="T">The memory cell type</typeparam>
    [MethodImpl(Inline)]
    public static Memory<T> memory<T>(ReadOnlyMemory<T> src)
        => MemoryMarshal.AsMemory(src);

    /// <summary>
    ///  Constructs a memory segment from a parameter array (non-allocating)
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The memory cell type</typeparam>
    [MethodImpl(Inline)]
    public static Memory<T> memory<T>(params T[] src)
        => src;

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlyMemory<T> lhs, ReadOnlyMemory<T> rhs,  [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);
}

