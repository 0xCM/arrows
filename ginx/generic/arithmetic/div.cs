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
    using static AsInX;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vec128<T> div<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.div(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.div(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Vec256<T> div<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.div(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.div(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }

        public static Span128<T> div<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();        
            switch(kind)
            {
                case PrimalKind.float32:
                {
                    var xDst = float32(dst);
                    dinx.div(float32(lhs), float32(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.float64:
                {
                    var xDst = float64(dst);
                    dinx.div(float64(lhs), float64(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                
                default:
                    throw unsupported(kind);
            }
        }

        public static Span256<T> div<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();        
            switch(kind)
            {
                case PrimalKind.float32:
                {
                    var xDst = float32(dst);
                    dinx.div(float32(lhs), float32(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                case PrimalKind.float64:
                {
                    var xDst = float64(dst);
                    dinx.div(float64(lhs), float64(rhs), ref xDst);
                    return generic<T>(xDst);
                }
                
                default:
                    throw unsupported(kind);
            }
        }

    }
}