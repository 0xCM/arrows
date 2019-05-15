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
        public static num<T>[] many<T>(params T[] src)
            where T : struct
        {
            var dst = alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<num<T>> many<T>(Span<T> src)
            where T : struct
        {
            var dst = alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        public static num<T> zero<T>()
                where T : struct
            => gmath.zero<T>();

        public static num<T> one<T>()
                where T : struct
            => gmath.one<T>();

        [MethodImpl(Inline)]
        public static ref num<T> single<T>(ref T src)
            where T : struct
                => ref Unsafe.As<T,num<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref T scalar<T>(ref num<T> src)
            where T : struct
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        public static ref readonly T immutable<T>(ref num<T> src)
            where T : struct
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        public static ref num<T> add<T>(ref num<T> lhs, in num<T> rhs)
            where T : struct
                => ref lhs.Add(rhs);

        [MethodImpl(Inline)]
        public static ref num<T> sub<T>(ref num<T> lhs, in num<T> rhs)
            where T : struct
                => ref lhs.Sub(rhs);

        [MethodImpl(Inline)]
        public static ref num<T> mul<T>(ref num<T> lhs, in num<T> rhs)
            where T : struct
                => ref lhs.Mul(rhs);

        [MethodImpl(Inline)]
        public static ref num<T> div<T>(ref num<T> lhs, in num<T> rhs)
            where T : struct
                => ref lhs.Div(rhs);

        [MethodImpl(Inline)]
        public static ref num<T> inc<T>(ref num<T> src)
            where T : struct
                => ref src.Inc();

        [MethodImpl(Inline)]
        public static ref num<T> dec<T>(ref num<T> src)
            where T : struct
                => ref src.Inc();

        [MethodImpl(Inline)]
        public static ref num<T> abs<T>(ref num<T> src)
            where T : struct
            => ref src.Abs();

        [MethodImpl(Inline)]
        public static ref num<T> negate<T>(ref num<T> src)
            where T : struct 
                => ref src.Negate();

        [MethodImpl(Inline)]
        public static num<T> abs<T>(num<T> src)
            where T : struct
                => src.Abs();

        [MethodImpl(Inline)]
        public static num<T> sqrt<T>(num<T> src)
            where T : struct
                => src.Sqrt();
    }
}