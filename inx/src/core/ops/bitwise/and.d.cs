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
        [MethodImpl(Inline)]
        public static UInt128 and(in UInt128 lhs, in UInt128 rhs)
            => and(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();

        [MethodImpl(Inline)]
        public static ref UInt128 and(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = and(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();
            return ref dst;            
        }

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> and(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> and(in Vec128<short> lhs, in Vec128<short> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> and(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> and(in Vec128<int> lhs, in Vec128<int> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> and(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> and(in Vec128<long> lhs, in Vec128<long> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_si128:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> and(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm_and_ps:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> and(in Vec128<float> lhs, in Vec128<float> rhs)
            => And(lhs, rhs);
        
        /// <summary>
        /// _mm_and_pd:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> and(in Vec128<double> lhs, in Vec128<double> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> and(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> and(in Vec256<short> lhs, in Vec256<short> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> and(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> and(in Vec256<int> lhs, in Vec256<int> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> and(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> and(in Vec256<long> lhs, in Vec256<long> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_si256, avx2:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> and(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => And(lhs, rhs);

        /// <summary>
        /// _mm256_and_ps, avx:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> and(in Vec256<float> lhs, in Vec256<float> rhs)
            => And(lhs, rhs);
        
        /// <summary>
        /// _mm256_and_pd, avx:
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> and(in Vec256<double> lhs, in Vec256<double> rhs)
            => And(lhs, rhs);
     }
}