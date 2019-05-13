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

    public static class NumberX
    {
    
        [MethodImpl(Inline)]
        public static ref num<T> Abs<T>(this ref num<T> src)
            where T : struct, IEquatable<T>
            => ref num(ref gmath.abs(ref value(ref src)));            

        [MethodImpl(Inline)]
        public static ref num<T> Sqrt<T>(this ref num<T> src)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.sqrt(ref value(ref src)));            

        [MethodImpl(Inline)]
        public static ref num<T> Add<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.add(ref value(ref lhs), value(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Sub<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.sub(ref value(ref lhs), value(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Mul<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.mul(ref value(ref lhs), value(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Div<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.div(ref value(ref lhs), value(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Mod<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.mod(ref value(ref lhs), value(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> And<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.and(ref value(ref lhs), value(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Or<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.or(ref value(ref lhs), value(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> XOr<T>(this ref num<T> lhs, num<T> rhs)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.xor(ref value(ref lhs), value(ref rhs)));            

        [MethodImpl(Inline)]
        public static ref num<T> Flip<T>(this ref num<T> src)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.flip(ref value(ref src)));            

        [MethodImpl(Inline)]
        public static ref num<T> Inc<T>(this ref num<T> src)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.inc(ref value(ref src)));            

        [MethodImpl(Inline)]
        public static ref num<T> Dec<T>(this ref num<T> src)
            where T : struct, IEquatable<T>
                => ref num(ref gmath.dec(ref value(ref src)));            

        [MethodImpl(Inline)]
        public static PrimalKind PrimalKind<T>(this num<T> src)
            where T : struct, IEquatable<T>
                => PrimalKinds.kind<T>();

        [MethodImpl(NotInline)]
        public static num<T> Sum<T>(this ReadOnlySpan<num<T>> src)        
            where T : struct, IEquatable<T>
        {
            var result = num<T>.Zero;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                result += it.Current;
            return result;            
        }

        [MethodImpl(Inline)]
        public static num<T> Sum<T>(this Span<num<T>> src)        
            where T : struct, IEquatable<T>
            => src.ToReadOnlySpan().Sum();

        [MethodImpl(NotInline)]
        public static ref Span<num<T>> ScaleBy<T>(this ref Span<num<T>> io, num<T> factor)        
            where T : struct, IEquatable<T>
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
            where T : struct, IEquatable<T>        
                => Unsafe.As<num<T>[], T[]>(ref src);

        [MethodImpl(NotInline)]
        public static Span<T> Extract<T>(this Span<num<T>> src)
            where T : struct, IEquatable<T>        
        {
            var dst = span<T>(src.Length);
            for(var i=0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(NotInline)]
        public static numbers<T> RangeTo<T>(this num<T> first, num<T> last)
            where T : struct, IEquatable<T>
                =>  new numbers<T>(range(first, last));
    }
}