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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static As;
    using static zfunc;

    partial class dinx
    {

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> and(Vector128<byte> lhs, Vector128<byte> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> and(Vector128<short> lhs, Vector128<short> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> and(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> and(Vector128<ushort> lhs, Vector128<ushort> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> and(Vector128<int> lhs, Vector128<int> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> and(Vector128<uint> lhs, Vector128<uint> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> and(Vector128<long> lhs, Vector128<long> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> and(Vector128<ulong> lhs, Vector128<ulong> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_ps:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<float> and(Vector128<float> lhs, Vector128<float> rhs)
            => And(lhs, rhs);
        
        /// <summary>
        /// _mm_and_pd:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<double> and(Vector128<double> lhs, Vector128<double> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> and(Vector256<byte> lhs, Vector256<byte> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> and(Vector256<short> lhs, Vector256<short> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> and(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> and(Vector256<ushort> lhs, Vector256<ushort> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> and(Vector256<int> lhs, Vector256<int> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> and(Vector256<uint> lhs, Vector256<uint> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> and(Vector256<long> lhs, Vector256<long> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> and(Vector256<ulong> lhs, Vector256<ulong> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_ps, avx:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> and(Vector256<float> lhs, Vector256<float> rhs)
            => And(lhs, rhs);
        
        /// <summary>
        /// _mm256_and_pd, avx:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> and(Vector256<double> lhs, Vector256<double> rhs)
            => And(lhs, rhs);
     }
}