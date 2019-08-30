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
    using System.Numerics;
    
    using static zfunc;    
    

    partial class math
    {

       /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        public static sbyte dot(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(sbyte);
            for(var i = 0; i< len; i++)
                dst = fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        public static byte dot(ReadOnlySpan<byte> lhs,ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(byte);
            for(var i = 0; i< len; i++)
                dst = fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        public static short dot(ReadOnlySpan<short> lhs,ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(short);
            for(var i = 0; i< len; i++)
                dst = fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        public static ushort dot(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(ushort);
            for(var i = 0; i< len; i++)
                dst = fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        public static int dot(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(int);
            for(var i = 0; i< len; i++)
                dst = fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        public static uint dot(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(uint);
            for(var i = 0; i< len; i++)
                dst = fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        public static long dot(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(long);
            for(var i = 0; i< len; i++)
                dst = fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        public static ulong dot(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(ulong);
            for(var i = 0; i< len; i++)
                dst = fma(lhs[i], rhs[i], dst);
            return dst;                
        }
 

    }

}