//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static zfunc;    
    
    public static class gfpv
    {
        [MethodImpl(Inline)]
        public static Scalar128<T> add<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.add(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dfp.add(in float64(in lhs), in float64(in rhs)).As<T>();
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Scalar128<T> sub<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.sub(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dfp.sub(in float64(in lhs), in float64(in rhs)).As<T>();
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Scalar128<T> mul<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.mul(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dfp.mul(in float64(in lhs), in float64(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vec128<T> div<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.div(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.div(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Scalar128<T> div<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.div(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dfp.div(in float64(in lhs), in float64(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> div<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.div(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.div(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Scalar128<T> max<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.max(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dfp.max(in float64(in lhs), in float64(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Scalar128<T> min<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.min(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dfp.min(in float64(in lhs), in float64(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool eq<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.eq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dfp.eq(in float64(in lhs), in float64(in rhs));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool neq<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.cmpneq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dfp.cmpneq(in float64(in lhs), in float64(in rhs));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gt<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.gt(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dfp.gt(in float64(in lhs), in float64(in rhs));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.gteq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dfp.gteq(in float64(in lhs), in float64(in rhs));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lt<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.lt(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dfp.lt(in float64(in lhs), in float64(in rhs));
            throw unsupported<T>();
        }



        [MethodImpl(Inline)]
        public static bool ngt<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.ngt(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return dinx.ngt(in float32(in lhs), in float32(in rhs));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool nlt<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.nlt(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return dinx.nlt(in float32(in lhs), in float32(in rhs));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.lteq(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return dfp.lteq(in float32(in lhs), in float32(in rhs));
            else                
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static Scalar128<T> fmadd<T>(ref Scalar128<T> x, in Scalar128<T> y, in Scalar128<T> z)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dfp.fmadd(in float32(in x), in float32(in y), in float32(in z)).As<T>();                
            else if(typeof(T) == typeof(double))
                return dfp.fmadd(in float64(in x), in float64(in y), in float64(in z)).As<T>();
            else                
                throw unsupported<T>();
        }


    }
}