//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using static zcore;
    using static mathops;


    partial class gmath
    {

        [MethodImpl(Inline)]
        public static void apply<T>(OpKind op, T[] src, T[] dst)
            where T : struct, IEquatable<T>
        {
            if(op == OpKind.Abs)
            {
                abs(src,dst);
            }

            if(op == OpKind.Flip)
            {
                flip(src,dst);
            }

            throw new Exception($"Operator {op} not supported");

        }

        [MethodImpl(Inline)]
        public static void apply<T>(OpKind op, T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            if(op == OpKind.Add)
            {
                add(lhs,rhs,dst);
                return;
            }

            if(op == OpKind.Sub)
            {
                sub(lhs,rhs,dst);
                return;
            }

            if(op == OpKind.Mul)
            {
                mul(lhs,rhs,dst);
                return;
            }

            if(op == OpKind.Div)
            {
                div(lhs,rhs,dst);
                return;
            }

            if(op == OpKind.Mod)
            {
                mod(lhs,rhs,dst);
                return;
            }

            if(op == OpKind.And)
            {
                and(lhs,rhs,dst);
                return;
            }

            if(op == OpKind.Or)
            {
                or(lhs,rhs,dst);
                return;
            }

            if(op == OpKind.XOr)
            {
                xor(lhs,rhs,dst);
                return;
            }

            throw new Exception($"Operator {op} not supported");
         }

        /// <summary>
        /// Applies an identified binary operator to supplied operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        /// <returns>The operator application result</returns>
        [MethodImpl(Inline)]
        public static T apply<T>(OpKind op, T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            if(op == OpKind.Add)
                return add(lhs,rhs);

            if(op == OpKind.Sub)
                return sub(lhs,rhs);

            if(op == OpKind.Mul)
                return mul(lhs,rhs);

            if(op == OpKind.Div)
                return div(lhs,rhs);

            if(op == OpKind.Mod)
                return mod(lhs,rhs);

            if(op == OpKind.And)
                return mul(lhs,rhs);

            if(op == OpKind.Or)
                return div(lhs,rhs);

            if(op == OpKind.XOr)
                return mod(lhs,rhs);

            throw new Exception($"Operator {op} not supported");
         }


        /// <summary>
        /// Applies an identified unary operator to a supplied operand
        /// </summary>
        /// <param name="src">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        /// <returns>The operator application result</returns>
        [MethodImpl(Inline)]
        public static T apply<T>(OpKind op, T src)
            where T : struct, IEquatable<T>
        {
            if(op == OpKind.Abs)
                return abs(src);

            if(op == OpKind.Flip)
                return flip(src);

            throw new Exception($"Operator {op} not supported");
        }

        public static long applyT<T>(OpKind op, T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.apply(op,lhs,rhs,dst);
            return elapsed(sw);
        }

        public static long applyT<T>(OpKind op, T[] src,  T[] dst)
            where T : struct, IEquatable<T>
        {
            var sw = stopwatch();
            gmath.apply(op,src, dst);
            return elapsed(sw);
        }

    }
}