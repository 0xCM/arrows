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

    
    using static zfunc;
    using static As;
    using static AsInX;

    public static partial class ginxs
    {



        [MethodImpl(Inline)]
        public static bool cmpf<T>(in Num128<T> lhs, in Num128<T> rhs, FloatComparisonMode mode)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            var x = rhs;
            var y = lhs;
            
            if(kind == PrimalKind.float32)
                return dinx.cmpf(in float32(in x), in float32(in y), mode);
            
            if(kind == PrimalKind.float64)
                return dinx.cmpf(in float64(in x), in float64(in y), mode);
                
            throw unsupported(kind);
        }




        [MethodImpl(Inline)]
        public static bool ngt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.ngt(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return dinx.ngt(in float32(in lhs), in float32(in rhs));
            else throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static bool nlt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.nlt(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return dinx.nlt(in float32(in lhs), in float32(in rhs));
            else throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.lteq(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return dinx.lteq(in float32(in lhs), in float32(in rhs));
            else throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Num128<T> mul<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.mul(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dinx.mul(in float32(in lhs), in float32(in rhs)).As<T>();
            else throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Num128<T> div<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.div(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dinx.div(in float32(in lhs), in float32(in rhs)).As<T>();
            else throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Num128<T> max<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.max(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dinx.max(in float32(in lhs), in float32(in rhs)).As<T>();
            else throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Num128<T> min<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.min(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dinx.min(in float32(in lhs), in float32(in rhs)).As<T>();
            else throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Num128<T> muladd<T>(ref Num128<T> x, in Num128<T> y, in Num128<T> z)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return dinx.mulAdd(in float64(in x), in float64(in y), in float64(in z)).As<T>();                
            else if(kind == PrimalKind.float64)
                return dinx.mulAdd(in float64(in x), in float64(in y), in float64(in z)).As<T>();
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Num128<T> recip<T>(in Num128<T> src)
            where T : struct
                => throw unsupported(PrimalKinds.kind<T>());

        [MethodImpl(Inline)]
        public static Num128<T> sqrt<T>(in Num128<T> src)
            where T : struct
                => throw unsupported(PrimalKinds.kind<T>());

        [MethodImpl(Inline)]
        public static Num128<T> recipsqrt<T>(in Num128<T> src)
            where T : struct
                => throw unsupported(PrimalKinds.kind<T>());

        [MethodImpl(Inline)]
        public static Num128<T> ceiling<T>(in Num128<T> src)
            where T : struct
                => throw unsupported(PrimalKinds.kind<T>());

        [MethodImpl(Inline)]
        public static Num128<T> floor<T>(in Num128<T> src)
            where T : struct
                => throw unsupported(PrimalKinds.kind<T>());
    }
}