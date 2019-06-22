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
    
    using static zfunc;    
    using static As;
    using static AsInX;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vec128<S> shiftr<S,T>(in Vec128<S> lhs, in Vec128<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(dinx.shiftr(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(dinx.shiftr(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(dinx.shiftr(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(dinx.shiftr(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static Vec256<S> shiftr<S,T>(in Vec256<S> lhs, in Vec256<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(dinx.shiftr(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(dinx.shiftr(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(dinx.shiftr(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(dinx.shiftr(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static Span128<S> shiftr<S,T>(in ReadOnlySpan128<S> lhs, in ReadOnlySpan128<T> shifts, in Span128<S> dst)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                dinx.shiftr(int32(in lhs), uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                dinx.shiftr(uint32(in lhs), uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                dinx.shiftr(int64(in lhs), uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                dinx.shiftr(uint64(in lhs), uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }

        public static Span256<T> shiftr<S,T>(in ReadOnlySpan256<T> lhs, in ReadOnlySpan256<S> shifts, in Span256<T> dst)
            where T : struct
            where S : struct
        {
            if(typeof(S) == typeof(int))
                dinx.shiftr(int32(in lhs), uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                dinx.shiftr(uint32(in lhs), uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                dinx.shiftr(int64(in lhs), uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                dinx.shiftr(uint64(in lhs), uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }


    }

}