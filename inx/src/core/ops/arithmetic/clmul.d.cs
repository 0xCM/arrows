//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
 
    using static zfunc;
    
    partial class dinx
    {                

        /// <summary>
        /// _mm_clmulepi64_si128
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort clmul(ushort lhs, ushort rhs)
            => (ushort)clmul((ulong)lhs, (ulong)rhs);

        /// <summary>
        /// _mm_clmulepi64_si128
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static uint clmul(uint lhs, uint rhs)
            => (uint)clmul((ulong)lhs, (ulong)rhs);

        /// <summary>
        /// _mm_clmulepi64_si128
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static long clmul(long lhs, long rhs)
            => extract(CarrylessMultiply(Vector128.Create(lhs, 0L), Vector128.Create(rhs, 0L), 0x00), 0);

        /// <summary>
        /// _mm_clmulepi64_si128
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong clmul(ulong lhs, ulong rhs)
            => extract(CarrylessMultiply(Vector128.Create(lhs, 0ul), Vector128.Create(rhs, 0ul), 0x00), 0);

        /// <summary>
        /// _mm_clmulepi64_si128
        /// Effects carryless multiplication on selected components
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="control">?</param>
        [MethodImpl(Inline)]
        public static Vec128<long> clmul(in Vec128<long> lhs, in Vec128<long> rhs, byte control)
            =>  CarrylessMultiply(lhs, rhs, control);

        /// <summary>
        /// _mm_clmulepi64_si128
        /// Effects carryless multiplication on selected components
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="control">?</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, byte control)
            =>  CarrylessMultiply(lhs, rhs,control);
    
        /// <summary>
        /// Computes carry-less product variations for two source vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">Receives the results</param>
        [MethodImpl(Inline)]
        public static ref Vec512<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec512<ulong> dst)
        {
            dst = Vec512.FromParts(
                clmul(lhs, rhs, 0x00), 
                clmul(lhs, rhs, 0x01), 
                clmul(lhs, rhs, 0x10), 
                clmul(lhs, rhs, 0x11)
                );
            return ref dst;
        }


    }

}