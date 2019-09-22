//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;
    using static Registers;

    public static class MMx
    {

        [MethodImpl(Inline)]
        public static ref T As<T>(this ref XMM src)
            where T : unmanaged
                => ref Unsafe.As<XMM, T>(ref src);


        [MethodImpl(Inline)]
        public static ref T As<T>(this ref YMM src)
            where T : unmanaged
                => ref Unsafe.As<YMM, T>(ref src);

        /// <summary>
        /// Gets the value of an index-identified memory cell
        /// </summary>
        /// <param name="index">The zero-based cell index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Cell<T>(this ref XMM src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref src.As<T>(), index);

        /// <summary>
        /// Gets the value of an index-identified memory cell
        /// </summary>
        /// <param name="index">The zero-based cell index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Cell<T>(this ref YMM src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref src.As<T>(), index);

        [MethodImpl(Inline)]
        public static ref T Head<T>(this ref YMM src)
            where T : unmanaged
                => ref src.As<T>();

    }


}