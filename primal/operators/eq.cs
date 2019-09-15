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

    using static zfunc;        

    partial class math
    {
        [MethodImpl(Inline)]
        public static bool eq(sbyte lhs, sbyte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(byte lhs, byte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(short lhs, short rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(ushort lhs, ushort rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(int lhs, int rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(uint lhs, uint rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(long lhs, long rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(ulong lhs, ulong rhs)
            => lhs == rhs;
  
        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool eq(ReadOnlySpan<sbyte> src, sbyte target)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i] != target)
                    return false;
            return true;
        }

        /// <summary>
        /// Returns true if all supplied items are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The </param>
        /// <param name="target">The value to match</param>
        public static bool eq(ReadOnlySpan<byte> src, byte target)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i] != target)
                    return false;
            return true;
        }

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool eq(ReadOnlySpan<short> src, short target)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i] != target)
                    return false;
            return true;
        }

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool eq(ReadOnlySpan<ushort> src, ushort target)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i] != target)
                    return false;
            return true;
        }

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool eq(ReadOnlySpan<int> src, int target)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i] != target)
                    return false;
            return true;
        }

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool eq(ReadOnlySpan<uint> src, uint target)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i] != target)
                    return false;
            return true;
        }

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool eq(ReadOnlySpan<long> src, long target)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i] != target)
                    return false;
            return true;
        }

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool eq(ReadOnlySpan<ulong> src, ulong target)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i] != target)
                    return false;
            return true;
        }

    }
}