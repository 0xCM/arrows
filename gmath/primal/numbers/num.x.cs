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
        
    using static mfunc;
    using static zfunc;

    public static class NumX
    {
    
        [MethodImpl(Inline)]
        public static ref num<T> Abs<T>(this ref num<T> src)
            where T : struct
                => ref num(ref gmath.abs(ref scalar(ref src)));

        [MethodImpl(Inline)]
        public static ref num<T> Sqrt<T>(this ref num<T> src)
            where T : struct 
                => ref num(ref gmath.sqrt(ref scalar(ref src)));

        [MethodImpl(Inline)]
        public static ref num<T> Add<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                => ref num(ref gmath.add(ref scalar(ref lhs), scalar(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Sub<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                => ref num(ref gmath.sub(ref scalar(ref lhs), scalar(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Mul<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                => ref num(ref gmath.mul(ref scalar(ref lhs), scalar(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Div<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                => ref num(ref gmath.div(ref scalar(ref lhs), scalar(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Mod<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                => ref num(ref gmath.mod(ref scalar(ref lhs), scalar(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> And<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                => ref num(ref gmath.and(ref scalar(ref lhs), scalar(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Or<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                => ref num(ref gmath.or(ref scalar(ref lhs), scalar(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> XOr<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct
                => ref num(ref gmath.xor(ref scalar(ref lhs), scalar(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Flip<T>(this ref num<T> src)
            where T : struct
                => ref num(ref gmath.flip(ref scalar(ref src)));            

        [MethodImpl(Inline)]
        public static ref num<T> Inc<T>(this ref num<T> src)
            where T : struct
                => ref num(ref gmath.inc(ref scalar(ref src)));            

        [MethodImpl(Inline)]
        public static ref num<T> Dec<T>(this ref num<T> src)
            where T : struct
                => ref num(ref gmath.dec(ref scalar(ref src)));            

        [MethodImpl(Inline)]
        public static ref num<T> Square<T>(this ref num<T> src)
            where T : struct
                => ref num(ref gmath.square(ref scalar(ref src)));            

        [MethodImpl(Inline)]
        public static ref num<T> Negate<T>(this ref num<T> src)
            where T : struct
               => ref num(ref gmath.negate(ref scalar(ref src)));
 
        [MethodImpl(Inline)]
        public static PrimalKind PrimalKind<T>(this num<T> src)
            where T : struct
                => PrimalKinds.kind<T>();

        [MethodImpl(NotInline)]
        public static num<T> Sum<T>(this ReadOnlySpan<num<T>> src)        
            where T : struct
        {
            var result = gmath.zero<T>();
            var it = src.GetEnumerator();
            while(it.MoveNext())
                result += it.Current;
            return result;            
        }

        [MethodImpl(Inline)]
        public static num<T> Sum<T>(this Span<num<T>> src)        
            where T : struct
            => src.ToReadOnlySpan().Sum();

        [MethodImpl(NotInline)]
        public static ref Span<num<T>> ScaleBy<T>(this ref Span<num<T>> io, num<T> factor)        
            where T : struct
        {
            for(var i = 0; i< io.Length; i++)
            {
                ref var x = ref io[i];
                x = x*factor;
            }
            return ref io;
        }
 
        [MethodImpl(NotInline)]
        public static Span<T> Extract<T>(this num<T>[] src)
            where T : struct        
                => Unsafe.As<num<T>[], T[]>(ref src);

        [MethodImpl(NotInline)]
        public static Span<T> Extract<T>(this Span<num<T>> src)
            where T : struct        
        {
            var dst = span<T>(src.Length);
            for(var i=0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(NotInline)]
        public static numbers<T> RangeTo<T>(this num<T> first, num<T> last)
            where T : struct
                =>  new numbers<T>(range(first, last));
 
 
         // <summary>
        /// Partitions an interval into a specified number of pieces
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        public static IEnumerable<num<T>> Partition<T>(this IInterval<num<T>> src, num<T> parts)
            where T : struct, IEquatable<T>
        {
            
            if(parts != Num.zero<T>())
            {            
                var width = (src.Right - src.Left)/parts;
                var current = src.Left;
                
                yield return src.Left;

                var start = Num.zero<T>();
                var finish = parts - Num.one<T>();

                for(var i = start; i < finish; i++)
                {
                    current += width;
                    yield return current;
                }
                yield return src.Right;
            }
        }

        /// <summary>
        /// Partitions an interval into a specified number of pieces
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        [MethodImpl(Inline)]
        public static num<T>[] Discretize<T>(this Interval<num<T>> src, num<T> parts)   
            where T : struct, IEquatable<T>
                => src.Partition(parts).ToArray(); 
    }
}