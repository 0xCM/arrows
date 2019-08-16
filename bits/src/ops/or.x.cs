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
        /// Computes the bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Or<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => gbits.or(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Or<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => gbits.or(in lhs,in rhs);

        [MethodImpl(Inline)]
        public static void Or<T>(this Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
                => gbits.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or<T>(this Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
                => gbits.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static Span128<T> Or<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
                => gbits.or(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span256<T> Or<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
                => gbits.or(lhs,rhs,dst);
 
        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref sbyte Or(this ref sbyte lhs, sbyte rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref byte Or(this ref byte lhs, byte rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref ushort Or(this ref ushort lhs, ushort rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref short Or(this ref short lhs, short rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref int Or(this ref int lhs, int rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref uint Or(this ref uint lhs, uint rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref long Or(this ref long lhs, long rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref ulong Or(this ref ulong lhs, ulong rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }
 
 
   }
}