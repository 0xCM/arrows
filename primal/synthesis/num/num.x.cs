//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    public static class NumX
    {        
        [MethodImpl(Inline)]
        public static ref num<T> Abs<T>(this ref num<T> src)
            where T : unmanaged
                =>  ref Num.num(ref gmath.abs(ref Num.scalar(ref src)));


        [MethodImpl(Inline)]
        public static ref num<T> Square<T>(this ref num<T> src)
            where T : unmanaged
                =>  ref Num.num(ref gmath.square(ref Num.scalar(ref src))); 

        [MethodImpl(NotInline)]
        public static num<T> Sum<T>(this ReadOnlySpan<num<T>> src)        
            where T : unmanaged
        {
            var result = num<T>.Zero;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                result += it.Current;
            return result;            
        }

        [MethodImpl(Inline)]
        public static num<T> Sum<T>(this Span<num<T>> src)        
            where T : unmanaged
                => src.ReadOnly().Sum();

        [MethodImpl(NotInline)]
        public static ref Span<num<T>> ScaleBy<T>(this ref Span<num<T>> io, num<T> factor)        
            where T : unmanaged
        {
            for(var i = 0; i< io.Length; i++)
            {
                ref var x = ref io[i];
                x = x*factor;
            }
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T Scalar<T>(this ref num<T> src)
            where T : unmanaged
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        public static Span<T> Scalars<T>(this Span<num<T>> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<num<T>,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Scalars<T>(this ReadOnlySpan<num<T>> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<num<T>,T>(src);

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static ReadOnlySpan<BinaryDigit> ToBinaryDigits<T>(this num<T> src)
            where T : unmanaged    
                =>  BitString.FromScalar(src.Scalar()).ToDigits();

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<DeciDigit> ToDecimalDigits<T>(this num<T> src)
            where T : unmanaged    
                => DeciDigits.Parse(src.Abs().ToString());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
         [MethodImpl(Inline)]   
        public static Span<HexDigit> ToHexDigits<T>(this num<T> src)
            where T : unmanaged    
                =>  HexDigits.Parse(src.ToString());
    }
}