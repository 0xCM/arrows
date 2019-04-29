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


        [MethodImpl(Inline)]
        public static void add<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void sub<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void mul<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void div<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void mod<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void and<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void or<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void xor<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
        }

        [MethodImpl(Inline)]
        public static void flip<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = flip(src[i]);
        }

        [MethodImpl(Inline)]
        public static void abs<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = abs(src[i]);
        }

    }


}