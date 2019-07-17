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
    
    partial class MathX
    {
        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool AllEqual(this ReadOnlySpan<sbyte> src, sbyte target)
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
        public static bool AllEqual(this ReadOnlySpan<byte> src, byte target)
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
        public static bool AllEqual(this ReadOnlySpan<short> src, short target)
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
        public static bool AllEqual(this ReadOnlySpan<ushort> src, ushort target)
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
        public static bool AllEqual(this ReadOnlySpan<int> src, int target)
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
        public static bool AllEqual(this ReadOnlySpan<uint> src, uint target)
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
        public static bool AllEqual(this ReadOnlySpan<long> src, long target)
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
        public static bool AllEqual(this ReadOnlySpan<ulong> src, ulong target)
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
        public static bool AllEqual(this ReadOnlySpan<float> src, float target)
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
       public static bool AllEqual(this ReadOnlySpan<double> src, double target)
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
        [MethodImpl(Inline)]
        public static bool AllEqual(this Span<sbyte> src, sbyte target)
            => src.ReadOnly().AllEqual(target);        

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this Span<byte> src, byte target)
            => src.ReadOnly().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this Span<short> src, short target)
            => src.ReadOnly().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this Span<ushort> src, ushort target)
            => src.ReadOnly().AllEqual(target);


        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this Span<int> src, int target)
            => src.ReadOnly().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this Span<uint> src, uint target)
            => src.ReadOnly().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this Span<long> src, long target)
            => src.ReadOnly().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this Span<ulong> src, ulong target)
            => src.ReadOnly().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this Span<float> src, float target)
            => src.ReadOnly().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this Span<double> src, double target)
            => src.ReadOnly().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this sbyte[] src, sbyte target)
            => src.ToSpan().AllEqual(target);        

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this byte[] src, byte target)
            => src.ToSpan().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this short[] src, short target)
            => src.ToSpan().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this ushort[] src, ushort target)
            => src.ToSpan().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this int[] src, int target)
            => src.ToSpan().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this uint[] src, uint target)
            => src.ToSpan().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this long[] src, long target)
            => src.ToSpan().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this ulong[] src, ulong target)
            => src.ToSpan().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this float[] src, float target)
            => src.ToSpan().AllEqual(target);

        /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        [MethodImpl(Inline)]
        public static bool AllEqual(this double[] src, double target)
            => src.ToSpan().AllEqual(target);

    }

}