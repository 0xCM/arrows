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
    public static unsafe void memcpy<S,T>(ref S src, ref T dst, ByteSize srclen)
        =>  Unsafe.CopyBlock(Unsafe.AsPointer(ref dst), Unsafe.AsPointer(ref src), srclen);

    [MethodImpl(Inline)]
    public static unsafe bool memcpy<S,T>(S[] src, T[] dst)
        where T : unmanaged
        where S : unmanaged
    {
        var srcLen = (uint)(size<S>() * src.Length);
        var dstLen = (uint)(size<T>() * dst.Length);
        if(srcLen != dstLen)
            return false;

        zfunc.memcpy(ref src[0], ref dst[0], srcLen);
        return true;
    }

    [MethodImpl(Inline)]   
    public static ref T imagine<S,T>(ref S src)
        => ref Unsafe.As<S,T>(ref src);

    [MethodImpl(Inline)]   
    public static ref T imagine<S,T>(ref S src, out T dst)
    {
        dst = Unsafe.As<S,T>(ref src);
        return ref dst;
    }

    /// <summary>
    /// Copies data from an unmanaged value to a target span
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target cell type</typeparam>
    [MethodImpl(Inline)]   
    public static void copy<S,T>(ref S src, Span<T> dst)
        where T : unmanaged
    {
        ref var dstBytes = ref Unsafe.As<T, byte>(ref head(dst));
        Unsafe.WriteUnaligned<S>(ref dstBytes, src);
    }

    /// <summary>
    /// Constructs an unpopulated span of a specified length
    /// </summary>
    /// <param name="length">The number of T-sized cells to allocate</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(int length)
        => new Span<T>(new T[length]);

    [MethodImpl(Inline)]
    public static Span<T> span<T>(uint length)
        => new Span<T>(new T[length]);

    /// <summary>
    /// Constructs a span from an array selection
    /// </summary>
    /// <param name="src">The source array</param>
    /// <param name="offset">The array index where the span is to begin</param>
    /// <param name="length">The number of elements to cover from the aray</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(T[] src, int offset, int length)
        => new Span<T>(src,offset, length);

    /// <summary>
    /// Constructs a span from the entireity of a sequence
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(IEnumerable<T> src)
        => src.TakeSpan();

    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
        where S : struct
        where T : struct
            => MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src, out ReadOnlySpan<T> dst)                
        where S : struct
        where T : struct
            => dst = MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static Span<T> cast<S,T>(Span<S> src)                
        where S : struct
        where T : struct
            => MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static Span<T> cast<S,T>(Span<S> src, out Span<T> dst)                
        where S : struct
        where T : struct
            => dst = MemoryMarshal.Cast<S,T>(src);

    /// <summary>
    /// Constructs a span from an array
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(params T[] src)
        => src;

    /// <summary>
    /// Loads a span from a memory reference
    /// </summary>
    /// <param name="src">The memory source</param>
    /// <param name="length">The memory length relative to the cell type</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<T> span<T>(ref T src, int length)
        => MemoryMarshal.CreateSpan(ref src, length);

    /// <summary>
    /// Creates a span of one type over a single element of another type
    /// </summary>
    /// <param name="src">The source element</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<T> span<S,T>(ref S src)
        where T :struct
        where S : struct
            => cast(span(ref src, 1), out Span<T> _);

    /// <summary>
    /// Presents a source reference as a span of bytes
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<byte> bytespan<T>(ref T src)
        where T : struct
            => MemoryMarshal.CreateSpan(ref byteref(ref src), size<T>()); 

    /// <summary>
    /// Converts the source span to a readonly bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<byte> bytespan<T>(ReadOnlySpan<T> src)
        where T : struct
            => MemoryMarshal.AsBytes(src);

    /// <summary>
    /// Converts the source span to a bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> bytespan<T>(Span<T> src)
        where T : struct
            => MemoryMarshal.AsBytes(src);

    /// <summary>
    /// Converts a source value of any value type to its bytespan representation
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<byte> bytes<T>(in T src)
        where T : struct
            => bytespan(MemoryMarshal.CreateReadOnlySpan(ref As.asRef(in src), 1));         

    /// <summary>
    /// Converts a source value of any value type to its bytespan representation
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static void bytes<T>(in T src, Span<byte> dst)
        where T : struct
            => As.generic<T>(ref dst[0]) = src;

    /// <summary>
    /// Converts the source value to a bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> bytes<T>(T src)
        where T : struct
            => MemoryMarshal.AsBytes(span(src));

    /// <summary>
    /// Constructs a span from a sequence selection
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="offset">The number of elements to skip from the head of the sequence</param>
    /// <param name="length">The number of elements to take from the sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(IEnumerable<T> src, int? offset = null, int? length = null)
        => span(length == null ? src.Skip(offset ?? 0) : src.Skip(offset ?? 0).Take(length.Value));

    /// <summary>
    /// Reconstitutes a value from a bytespan
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static T read<T>(ReadOnlySpan<byte> src)
        where T : struct
            =>  MemoryMarshal.Read<T>(src);

    /// <summary>
    /// Reconstitutes a value from a bytespan
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="dst">A reference to the target value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static ref T read<T>(ReadOnlySpan<byte> src, out T dst)
        where T : struct
    {
        dst = read<T>(src);
        return ref dst;
    }
            
    /// <summary>
    /// Serializes a value into a bytespan
    /// </summary>
    /// <param name="src">A reference to the source value</param>
    /// <param name="dst">The client-allocated destination span</param>
    /// <typeparam name="T"></typeparam>
    [MethodImpl(Inline)]
    public static void write<T>(ref T src, Span<byte> dst)
        where T : struct
            => MemoryMarshal.Write(dst, ref src);

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span<T> src)
        =>  ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Returns a reference to the location of the first element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(T[] src)
        =>  ref src[0];

    /// <summary>
    /// Returns a reference to a span at a specified offset
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="offset">The T-relative offset</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref T cellref<T>(Span<T> src, int offset)
        where T : unmanaged
            =>  ref Unsafe.Add(ref MemoryMarshal.GetReference<T>(src), offset);

    /// <summary>
    /// Returns a reference to the head of a readonly span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            =>  ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Returns a reference to a readonly span at a specified offset
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="offset">The T-relative offset</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref T cellref<T>(ReadOnlySpan<T> src, int offset)
        where T : unmanaged
            =>  ref Unsafe.Add(ref MemoryMarshal.GetReference<T>(src), offset);

    /// <summary>
    /// Returns a readonly reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span256<T> src)
        where T : struct
            =>  ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(Span<T> lhs, ReadOnlySpan<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(Span<T> lhs, IReadOnlyList<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Count ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Count, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(IReadOnlyList<T> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Count == rhs.Length ? lhs.Count
                : throw Errors.LengthMismatch(lhs.Count, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlySpan<T> lhs, IReadOnlyList<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Count ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Count, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(IReadOnlyList<T> lhs, ReadOnlySpan<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Count == rhs.Length ? lhs.Count
                : throw Errors.LengthMismatch(lhs.Count, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(Span<S> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan<S> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan<S> lhs, ReadOnlySpan<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(T[] lhs, T[] rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> rhs,  [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : struct
            where T : struct
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the length of spans of equal length; otherwise raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    [MethodImpl(Inline)]   
    public static int length<S,T>(Span256<S> lhs, Span256<T> rhs, [CallerMemberName] string caller = null,
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct
            where S : struct
                => lhs.Length == rhs.Length ? lhs.Length : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);



    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan256<S> lhs, ReadOnlySpan256<T> rhs,[CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct
            where S :struct
                =>  lhs.Length == rhs.Length ? lhs.Length : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);


    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(Span128<S> lhs, Span128<T> rhs, [CallerMemberName] string caller = null,  
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : struct
            where T : struct                
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : struct
            where T : struct
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(Span256<S> lhs, Span256<T> rhs, [CallerMemberName] string caller = null,  
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : struct
            where T : struct                
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(ReadOnlySpan256<S> lhs, ReadOnlySpan256<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : struct
            where T : struct
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

}
