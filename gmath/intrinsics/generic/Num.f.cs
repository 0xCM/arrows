//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    using static mfunc;
    using static As;

    public static partial class ginx
    {
        [MethodImpl(Inline)]
        public static bool eq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.float32:
                    return dinx.eq(float32(lhs), float32(rhs));
                case PrimalKind.float64:
                    return dinx.eq(float64(lhs), float64(rhs));
                default:
                    throw errors.unsupported(kind);
            }

        }

        [MethodImpl(Inline)]
        public static bool cmpf<T>(in Num128<T> lhs, in Num128<T> rhs, FloatCompareKind mode)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.float32:
                    return dinx.cmpf(float32(lhs), float32(rhs),mode);
                case PrimalKind.float64:
                    return dinx.cmpf(float64(lhs), float64(rhs),mode);
                default:
                    throw errors.unsupported(kind);
            }

        }


        [MethodImpl(Inline)]
        public static bool neq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.float32:
                    return dinx.neq(float32(lhs), float32(rhs));
                case PrimalKind.float64:
                    return dinx.neq(float64(lhs), float64(rhs));
                default:
                    throw errors.unsupported(kind);
            }

        }

        [MethodImpl(Inline)]
        public static bool gt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.float32:
                    return dinx.gt(float32(lhs), float32(rhs));
                case PrimalKind.float64:
                    return dinx.gt(float64(lhs), float64(rhs));
                default:
                    throw errors.unsupported(kind);
            }

        }

        [MethodImpl(Inline)]
        public static bool ngt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.float32:
                    return dinx.ngt(float32(lhs), float32(rhs));
                case PrimalKind.float64:
                    return dinx.ngt(float64(lhs), float64(rhs));
                default:
                    throw errors.unsupported(kind);
            }

        }


        [MethodImpl(Inline)]
        public static bool gteq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.float32:
                    return dinx.gteq(float32(lhs), float32(rhs));
                case PrimalKind.float64:
                    return dinx.gteq(float64(lhs), float64(rhs));
                default:
                    throw errors.unsupported(kind);
            }

        }

        [MethodImpl(Inline)]
        public static bool lt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.float32:
                    return dinx.lt(float32(lhs), float32(rhs));
                case PrimalKind.float64:
                    return dinx.lt(float64(lhs), float64(rhs));
                default:
                    throw errors.unsupported(kind);
            }

        }

        [MethodImpl(Inline)]
        public static bool nlt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.float32:
                    return dinx.nlt(float32(lhs), float32(rhs));
                case PrimalKind.float64:
                    return dinx.nlt(float64(lhs), float64(rhs));
                default:
                    throw errors.unsupported(kind);
            }

        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.float32:
                    return dinx.lteq(float32(lhs), float32(rhs));
                case PrimalKind.float64:
                    return dinx.lteq(float64(lhs), float64(rhs));
                default:
                    throw errors.unsupported(kind);
            }

        }

        [MethodImpl(Inline)]
        public static Num128<T> add<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(Avx2.AddScalar(float32(lhs), float32(rhs)));

            if(kind == PrimalKind.float64)
                return generic<T>(Avx2.AddScalar(float64(lhs), float64(rhs)));

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Num128<T> sub<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.add(float32(lhs), float32(rhs)));

            if(kind == PrimalKind.float64)
                return generic<T>(dinx.add(float64(lhs), float64(rhs)));

            throw errors.unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static Num128<T> mul<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.mul(float32(lhs), float32(rhs)));

            if(kind == PrimalKind.float64)
                return generic<T>(dinx.mul(float64(lhs), float64(rhs)));

            throw errors.unsupported(kind);
        }



        [MethodImpl(Inline)]
        public static Num128<T> div<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.div(float32(lhs), float32(rhs)));

            if(kind == PrimalKind.float64)
                return generic<T>(dinx.div(float64(lhs), float64(rhs)));

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Num128<T> max<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.max(float32(lhs), float32(rhs)));

            if(kind == PrimalKind.float64)
                return generic<T>(dinx.max(float64(lhs), float64(rhs)));

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Num128<T> min<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.min(float32(lhs), float32(rhs)));

            if(kind == PrimalKind.float64)
                return generic<T>(dinx.min(float64(lhs), float64(rhs)));

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Num128<T> muladd<T>(Num128<T> x, Num128<T> y, Num128<T> z)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.mulAdd(float32(x), float32(y), float32(z)));

            if(kind == PrimalKind.float64)
                return generic<T>(dinx.mulAdd(float64(x), float64(y), float64(z)));

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Num128<T> recip<T>(in Num128<T> src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.recip(float32(src)));

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Num128<T> recipsqrt<T>(in Num128<T> src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.recipsqrt(float32(src)));

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Num128<T> sqrt<T>(in Num128<T> src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.sqrt(float32(src)));

            if(kind == PrimalKind.float64)
                return generic<T>(dinx.sqrt(float64(src)));

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Num128<T> ceiling<T>(in Num128<T> src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.ceiling(float32(src)));

            if(kind == PrimalKind.float64)
                return generic<T>(dinx.ceiling(float64(src)));

            throw errors.unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static Num128<T> floor<T>(in Num128<T> src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return generic<T>(dinx.floor(float32(src)));

            if(kind == PrimalKind.float64)
                return generic<T>(dinx.floor(float64(src)));

            throw errors.unsupported(kind);
        }

    }
}