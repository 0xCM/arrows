//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
 
    using static zfunc;
    using static nfunc;

    /// <summary>
    /// mkl + u = Unsafe, Unsized, Unchecked and Unblocked
    /// </summary>
    public static partial class mklu
    {

    }

    public static partial class mkl
    {
        const BlasTrans NoTranspose = BlasTrans.None;
        
        const BlasLayout RowMajor = BlasLayout.RowMajor;

        [MethodImpl(Inline)]
        static int checkx(int exit)
        {
            if(exit < 0)
                throw MklException.Define(exit);
            return exit;
        }


        /// <summary>
        /// Returns a reference to the location of the first span element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(Vector<T> src)
            where T : struct
            =>  ref MemoryMarshal.GetReference<T>(src.Unblocked);

        /// <summary>
        /// Returns a reference to the location of the first \element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<N,T>(Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src.Unsized);

        /// <summary>
        /// Returns a reference to the location of the first \element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<N,T>(Matrix<N,T> src)
            where N : ITypeNat, new()
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src.Unsized);

        /// <summary>
        /// Returns a reference to the location of the first \element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<M,N,T>(Matrix<M,N,T> src)
            where N : ITypeNat, new()
            where M : ITypeNat, new()
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src.Unsized);

        /// <summary>
        /// Returns a reference to the location of the first span element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<T>(Span<T> src)
            =>  ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a reference to the location of the first span element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static ref T head<N,T>(Span<N,T> src)
            where T : struct
            where N : ITypeNat, new()
            =>  ref MemoryMarshal.GetReference<T>(src.Unsized);


        [MethodImpl(Inline)]   
        static int length<S,T>(Span<S> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct
            where S : struct
                => zfunc.length(lhs,rhs);

        [MethodImpl(Inline)]   
        static int length<S,T>(Vector<S> lhs, Vector<T> rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct
            where S : struct
                => lhs.Length == rhs.Length ? lhs.Length 
                    : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    }

}