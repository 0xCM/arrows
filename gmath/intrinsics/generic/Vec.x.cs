//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static mfunc;

    partial class ginxx
    {

        [MethodImpl(Inline)]
        public static ref Num128<T> Add<T>(this ref Num128<T> lhs, in Num128<T> rhs)
            where T : struct
                => ref ginx.add(ref lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<T> Add<T>(this in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => ginx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec256<T> Add<T>(this in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => ginx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T>  LoScalar<T>(this in Vec128<T> src)
            where T : struct
                => src[0];

        [MethodImpl(Inline)]
        public static Num128<T>  HiScalar<T>(this in Vec128<T> src)
            where T : struct
                => src[Vec128<T>.Length -1];
        
        [MethodImpl(Inline)]
        public static Num128<T> Scalar<T>(this in Vec128<T> src, int index)
            where T : struct            
                => Num128.define(src[index]);

        /// <summary>
        /// Specifies the length, i.e. the number of components, of an
        /// intrnsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this in Vec128<T> src)
            where T : struct            
                => Vec128<T>.Length;

        /// <summary>
        /// Specifies the length, i.e. the number of components, of an
        /// intrnsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this in Vec256<T> src)
            where T : struct            
                => Vec256<T>.Length;    

        /// <summary>
        /// Loads a single intrinsic vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Vector<T>(this in Span128<T> src, int block = 0)            
            where T : struct            
                => Vec128.single(src,block);

        /// <summary>
        /// Loads a single intrinsic vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Vector<T>(this in ReadOnlySpan128<T> src, int block = 0)            
            where T : struct            
                => Vec128.single(src,block);

        /// <summary>
        /// Loads a single intrinsic vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Vector<T>(this in Span256<T> src, int block = 0)            
            where T : struct            
                => Vec256.single(src,block);

        /// <summary>
        /// Loads a single intrinsic vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Vector<T>(this in ReadOnlySpan256<T> src, int block = 0)            
            where T : struct            
                => Vec256.single(src,block);

        /// <summary>
        /// Sends the components of the vector to a blocked span that is 
        /// returned to the caller
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ToSpan<T>(this in Vec128<T> src)
            where T : struct            
                => Vec128.store(in src, Span128.alloc<T>(1));

        /// <summary>
        /// Sends the components of the vector to a blocked span that is 
        /// returned to the caller
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan<T>(this in Vec256<T> src)
            where T : struct            
                => Vec256.store(in src, Span256.alloc<T>(1));    
 
        [MethodImpl(Inline)]
        public static Vector128<T> ToVector128<T>(this Vec128<T> src)
            where T : struct
                => src;

        [MethodImpl(Inline)]
        public static T Component<T>(this Vec128<T> src, int index)
            where T : struct
        {
            ref T e0 = ref Unsafe.As<Vec128<T>, T>(ref src);
            return Unsafe.Add(ref e0, index);
        }

        [MethodImpl(Inline)]
        public static T Component<T>(this Vec256<T> src, int index)
            where T : struct
        {
            ref T e0 = ref Unsafe.As<Vec256<T>, T>(ref src);
            return Unsafe.Add(ref e0, index);
        }

        [MethodImpl(Inline)]
        public static ref Span<T> ExtractTo<T>(this Vec256<T> src, ref Span<T> dst, int offset = 0)
            where T : struct
        {
            var block = dst.Slice(offset, Vec256<T>.Length).ToSpan256();
            Vec256.store(src, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> ExtractTo<T>(this Vec128<T> src, Span<T> dst, int offset = 0)
            where T : struct
        {
            var block = dst.Slice(offset, Vec128<T>.Length).ToSpan128();
            Vec128.store(src, block);
            return  dst;
        }

    }
}