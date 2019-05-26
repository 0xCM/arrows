//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Spans;
    using static zfunc;
    using static As;

    public static class corex
    {
        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<DeciDigit> ToDecimalDigits<T>(this num<T> src)
            where T : struct    
                =>  DeciDigits.Parse(src.Abs().ToString());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
         [MethodImpl(Inline)]   
        public static Span<HexDigit> ToHexDigits<T>(this num<T> src)
            where T : struct    
                =>  HexDigits.Parse(src.ToString());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<BinaryDigit> ToBinaryDigits<T>(this num<T> src)
            where T : struct    
                =>  BinaryDigits.Parse(src.ToBitString());

        /// <summary>
        /// Determines whether the point lies within the interval
        /// </summary>
        /// <param name="src">The interval</param>
        /// <param name="point">The test point</param>
        /// <typeparam name="T">The domain of the point</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this ITimeInterval<T> src, T point)
            where T : struct 
                => src.Contains(point);

        [MethodImpl(Inline)]
        public static bool Contains<T>(this IInterval<T> interval, T point)
            where T : struct
                => interval.Kind switch {
                        IntervalKind.Closed 
                            => gmath.gteq(point,interval.Left) && gmath.lteq(point, interval.Right),
                        IntervalKind.Open 
                            => gmath.gt(point, interval.Left) && gmath.lt(point, interval.Right),
                        IntervalKind.LeftClosed 
                            => gmath.gteq(point, interval.Left) && gmath.lt(point, interval.Right),
                        IntervalKind.RightClosed 
                            => gmath.gt(point, interval.Left) && gmath.lteq(point, interval.Right),
                        _ => throw new ArgumentException()
                };


        [MethodImpl(Inline)]
        public static T[] Discretize<T>(this Interval<T> src, T? step = null)
            where T : struct 
                => DiscretizationStream(src, step).ToArray();

        static IEnumerable<T> DiscretizationStream<T>(this Interval<T> src, T? step = null)
            where T : struct
        {            

            var width = step ?? gmath.one<T>();            

            if(src.LeftClosed)
                yield return src.Left;
            
            var next = gmath.add(src.Left, width);
            while(gmath.lt(next,src.Right))
            {
                yield return next;
                next = gmath.add(next, width);
            }

            if(src.RightClosed)
                yield return src.Right;
        }

        //Prime numbers to use when generating a hash code. Taken from John Skeet's answer on SO:
        //http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
        const int P1 = 17;
        const int P2 = 23;

        /// <summary>
        /// Helper to compute hash code from a collection of items
        /// </summary>
        /// <typeparam name="S">The item type</typeparam>
        /// <param name="items">The items</param>
        public static int HashCode<S>(this IEnumerable<S> items)
        {
            if (items == null)
                return 0;

            unchecked
            {
                var hash = P1;
                foreach (var item in items)
                    hash = hash * P2 + item.GetHashCode();
                return hash;
            }
 
        }

        [MethodImpl(Inline)]
        public static bool ReallyEqual<T>(this Span<T> lhs, Span<T> rhs)  
            where T : struct       
        {
            if(lhs.Length != rhs.Length)
                return false;
            return SequenceEqual(ref lhs[0], ref rhs[0], lhs.Length);
        }

        [MethodImpl(Inline)]
        public static bool Contains<T>(this Span<T> lhs, T match)  
            where T : struct       
            => Contains(ref lhs[0], match, lhs.Length);

        [MethodImpl(Inline)]
        public static bool Contains<T>(this ReadOnlySpan<T> lhs, T match)  
            where T : struct       
            => Contains(ref asRef(in lhs[0]), match, lhs.Length);

        [MethodImpl(Inline)]
        public static bool ReallyEqual<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)  
            where T : struct       
        {
            if(lhs.Length != rhs.Length)
                return false;
            return SequenceEqual(ref asRef(in lhs[0]), ref asRef(in rhs[0]), lhs.Length);
        }

        //Adapted from corefx repo
        static bool SequenceEqual<T>(ref T first, ref T second, int length)
            where T : struct
        {

            if (Unsafe.AreSame(ref first, ref second))
                return true;

            IntPtr offset = (IntPtr)0; 
            T x;
            T y;
            while (length >= 8)
            {
                length -= 8;
                
                x = refAdd(ref first, offset + 0);
                y = refAdd(ref second, offset + 0);
                if(gmath.neq(x, y))
                    return false;                
                x = refAdd(ref first, offset + 1);
                y = refAdd(ref second, offset + 1);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 2);
                y = refAdd(ref second, offset + 2);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 3);
                y = refAdd(ref second, offset + 3);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 4);
                y = refAdd(ref second, offset + 4);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 5);
                y = refAdd(ref second, offset + 5);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 6);
                y = refAdd(ref second, offset + 6);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 7);
                y = refAdd(ref second, offset + 7);
                if(gmath.neq(x, y))
                    return false;

                offset += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                x = refAdd(ref first, offset);
                y = refAdd(ref second, offset);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 1);
                y = refAdd(ref second, offset + 1);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 2);
                y = refAdd(ref second, offset + 2);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 3);
                y = refAdd(ref second, offset + 3);
                if(gmath.neq(x, y))
                    return false;

                offset += 4;
            }

            while (length > 0)
            {
                x = refAdd(ref first, offset);
                y = refAdd(ref second, offset);
                if(gmath.neq(x, y))
                    return false;
                offset += 1;
                length--;
            }

            return true;
        }

        //Adapted from corefx repo
        unsafe static bool Contains<T>(ref T src, T match, int length)
            where T : struct
        {

            IntPtr index = (IntPtr)0;

            while (length >= 8)
            {
                length -= 8;

                if (gmath.eq(match, refAdd(ref src, index + 0)) ||
                    gmath.eq(match, refAdd(ref src, index + 1)) ||
                    gmath.eq(match, refAdd(ref src, index + 2)) ||
                    gmath.eq(match, refAdd(ref src, index + 3)) ||
                    gmath.eq(match, refAdd(ref src, index + 4)) ||
                    gmath.eq(match, refAdd(ref src, index + 5)) ||
                    gmath.eq(match, refAdd(ref src, index + 6)) ||
                    gmath.eq(match, refAdd(ref src, index + 7)))
                return true;
                
                index += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                if (gmath.eq(match, refAdd(ref src, index + 0)) ||
                    gmath.eq(match, refAdd(ref src, index + 1)) ||
                    gmath.eq(match, refAdd(ref src, index + 2)) ||
                    gmath.eq(match, refAdd(ref src, index + 3)))
                return true;

                index += 4;
            }

            while (length > 0)
            {
                length -= 1;

                if (gmath.eq(match, refAdd(ref src, index)))
                    return true;

                index += 1;
            }

            return false;        
        }

        public static bool Eq<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)        
                where T : struct        
            {
                for(var i = 0; i< length(lhs,rhs); i++)
                    if(gmath.neq(lhs[i],rhs[i]))
                        return false;
                return true;
            }

        public static bool Eq<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)        
            where T : struct        
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(gmath.neq(lhs[i],rhs[i]))
                    return false;
            return true;
        }

        public static bool Eq<T>(this Span256<T> lhs, Span256<T> rhs)        
            where T : struct        
                => lhs.ToReadOnlySpan().Eq(rhs);

        public static bool Eq<T>(this Span128<T> lhs, Span128<T> rhs)        
            where T : struct        
                => lhs.ToReadOnlySpan().Eq(rhs);
    }
}