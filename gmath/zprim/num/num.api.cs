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

    public static class Num
    {
        [MethodImpl(Inline)]
        public static num<T>[] alloc<T>(int len)
            where T : struct
                => new num<T>[len];

        [MethodImpl(Inline)]
        public static num<T> single<T>(T src)
            where T : struct
                => Unsafe.As<T,num<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref num<T> single<T>(ref T src)
            where T : struct
                => ref Unsafe.As<T,num<T>>(ref src);


        [MethodImpl(Inline)]
        public static num<T>[] many<T>(params T[] src)
            where T : struct
        {
            var dst = alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = single(ref src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<num<T>> many<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var dst = span<num<T>>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = single(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<num<T>> many<T>(Span<T> src)
            where T : struct
        {
            var dst = alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = single(ref src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static num<T> zero<T>()
                where T : struct
            => single(gmath.zero<T>());

        [MethodImpl(Inline)]
        public static num<T> one<T>()
                where T : struct
            => single(gmath.one<T>());

        [MethodImpl(Inline)]
        public static ref T scalar<T>(ref num<T> src)
            where T : struct
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        public static ref readonly T immutable<T>(ref num<T> src)
            where T : struct
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        public static num<T> abs<T>(num<T> lhs)
            where T : struct
                =>  lhs.Abs();

        [MethodImpl(Inline)]
        public static ref num<T> add<T>(ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref num(ref gmath.add(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> sub<T>(ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref num(ref gmath.sub(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> mul<T>(ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref num(ref gmath.mul(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> div<T>(ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref num(ref gmath.div(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));
    }
}