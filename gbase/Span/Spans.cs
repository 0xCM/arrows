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
    using System.Runtime.InteropServices;    
    using System.Diagnostics;    
    
    using static zfunc;

    public static class Spans
    {
        /// <summary>
        /// Loads a natural span from a reference
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="N">The natural length of the loaded span</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]   
        public static Span<N,T> load<N,T>(ref T src)    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(ref src);

        /// <summary>
        ///  Injects a readonly source span into a readonly natural span without replication
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural lenght</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static ReadOnlySpan<N,T> transfer<N,T>(ref ReadOnlySpan<T> src)    
            where N : ITypeNat, new()
            where T : struct
                => new ReadOnlySpan<N,T>(ref src);
 
        /// <summary>
        ///  Injects a readonly source span into a readonly natural span without replication
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural lenght</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> transfer<N,T>(ref Span<T> src)    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(ref src);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(ReadOnlySpan256<S> lhs, ReadOnlySpan256<T> rhs, [CallerFilePath] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)        
            where T : struct
            where S : struct
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
                    => lhs.Length == rhs.Length ? lhs.Length 
                        : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> rhs, [CallerFilePath] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)        
            where T : struct
            where S : struct
                => lhs.Length == rhs.Length ? lhs.Length 
                    : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(Span128<S> lhs, Span128<T> rhs, [CallerFilePath] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where S : struct
                where T : struct
                    => lhs.Length == rhs.Length ? lhs.Length 
                        : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns a reference to the first element of a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(in Span128<T> src)
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src);

        [MethodImpl(Inline)]
        public static ref T offset<T>(in Span128<T> src, int index)
            where T : struct
        {
            ref var first = ref head(in src);
            return ref Unsafe.Add(ref first, index);
        }


        [MethodImpl(Inline)]
        public static ref T blockedOffset<T>(in Span128<T> src, int blocks)
            where T : struct
        {
            ref var first = ref head(in src);
            var index = blocks * Span128<T>.BlockLength;
            return ref Unsafe.Add(ref first, index);
        }

        [MethodImpl(Inline)]
        public static ref T offset<T>(in Span256<T> src, int index)
            where T : struct
        {
            ref var first = ref head(in src);
            return ref Unsafe.Add(ref first, index);
        }


        [MethodImpl(Inline)]
        public static ref T blockedOffset<T>(in Span256<T> src, int blocks)
            where T : struct
        {
            ref var first = ref head(in src);
            var index = blocks * Span256<T>.BlockLength;
            return ref Unsafe.Add(ref first, index);
        }

        /// <summary>
        /// Returns a readonly reference to the first element of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T head<T>(in ReadOnlySpan128<T> src)
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a reference to the first element of a span
        /// </summary>
        /// <param name="src">The span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(in Span256<T> src)
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a readonly reference to the first element of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T head<T>(in ReadOnlySpan256<T> src)
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src);
                        
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

        /// <summary>
        /// Returns the common number of 256-bit blocks in the supplied spans, if possible. Otherwise,
        /// raises an exception
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int blocks<T>(Span256<T> lhs, Span256<T> rhs, [CallerMemberName] string caller = null,  
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where T : struct
                    => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                        : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

        /// <summary>
        /// Returns the common number of 256-bit blocks in the supplied spans, if possible. Otherwise,
        /// raises an exception
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int blocks<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where T : struct
                    => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                        : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

        [MethodImpl(Inline)]   
        public static Span<N,T> alloc<N,T>(T value = default(T)) 
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(value);


        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> replicate<N,T>(ReadOnlySpan<T> src)    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(src);

        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> replicate<N,T>(Span<N,T> src)    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(src);

        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> replicate<N,T>(ReadOnlySpan<N,T> src)    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(src);



    }
}