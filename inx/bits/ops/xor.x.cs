//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;
    using static dinx;
    using static As;
    using static AsInX;

    partial class BitsX
    {
        /// <summary>
        /// Computes the bitwise xor of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> XOr<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => gbits.xor(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise xor of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> XOr<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => gbits.xor(in lhs,in rhs);

        [MethodImpl(Inline)]
        public static void XOr<T>(this Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
                => gbits.xor(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void XOr<T>(this Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
                => gbits.xor(in lhs, in rhs, ref dst);

         [MethodImpl(Inline)]
         public static Span128<T> XOr<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
                => gbits.xor(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span256<T> XOr<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
                => gbits.xor(lhs,rhs,dst);
        
        
        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref sbyte XOr(this ref sbyte lhs, sbyte rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref byte XOr(this ref byte lhs, byte rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref ushort XOr(this ref ushort lhs, ushort rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref short XOr(this ref short lhs, short rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref int XOr(this ref int lhs, int rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref uint XOr(this ref uint lhs, uint rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref long XOr(this ref long lhs, long rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref ulong XOr(this ref ulong lhs, ulong rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }
 
        [MethodImpl(Inline)]
        public static Span<byte> XOr(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => Bits.xor(lhs, rhs, span<byte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<sbyte> XOr(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => Bits.xor(lhs, rhs, span<sbyte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<short> XOr(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => Bits.xor(lhs, rhs, span<short>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ushort> XOr(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => Bits.xor(lhs, rhs, span<ushort>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<int> XOr(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => Bits.xor(lhs, rhs, span<int>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<uint> XOr(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => Bits.xor(lhs, rhs, span<uint>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<long> XOr(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => Bits.xor(lhs, rhs, span<long>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ulong> XOr(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => Bits.xor(lhs, rhs, span<ulong>(length(lhs,rhs)));
 
        [MethodImpl(Inline)]
        public static Span<byte> XOr(this ref Span<byte> lhs, ReadOnlySpan<byte> rhs)
            => Bits.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<sbyte> XOr(this ref Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => Bits.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<short> XOr(this ref Span<short> lhs, ReadOnlySpan<short> rhs)
            => Bits.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<ushort> XOr(this ref Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => Bits.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<int> XOr(this ref Span<int> lhs, ReadOnlySpan<int> rhs)
            => Bits.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<uint> XOr(this ref Span<uint> lhs, ReadOnlySpan<uint> rhs)
            => Bits.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<long> XOr(this ref Span<long> lhs, ReadOnlySpan<long> rhs)
            => Bits.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<ulong> XOr(this ref Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => Bits.xor(lhs, rhs);

   }
}