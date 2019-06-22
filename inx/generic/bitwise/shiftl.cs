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
        public static Vec128<S> shiftl<S,T>(in Vec128<S> lhs, in Vec128<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(dinx.shiftl(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(dinx.shiftl(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(dinx.shiftl(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(dinx.shiftl(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static Vec256<S> shiftl<S,T>(in Vec256<S> lhs, in Vec256<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(dinx.shiftl(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(dinx.shiftl(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(dinx.shiftl(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(dinx.shiftl(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static Vec128<T> shiftlw<T>(in Vec128<T> lhs, byte count)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                return generic<T>(dinx.shiftlw(in int16(in lhs), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.shiftlw(in uint16(in lhs), count));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.shiftlw(in int32(in lhs), count));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.shiftlw(in uint32(in lhs), count));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.shiftlw(in int64(in lhs), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.shiftlw(in uint64(in lhs), count));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> shiftlw<T>(in Vec256<T> lhs, byte count)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                return generic<T>(dinx.shiftlw(in int16(in lhs), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.shiftlw(in uint16(in lhs), count));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.shiftlw(in int32(in lhs), count));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.shiftlw(in uint32(in lhs), count));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.shiftlw(in int64(in lhs), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.shiftlw(in uint64(in lhs), count));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Span128<S> shiftl<S,T>(in ReadOnlySpan128<S> lhs, in ReadOnlySpan128<T> shifts, in Span128<S> dst)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                dinxx.shiftl(int32(in lhs), uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                dinxx.shiftl(uint32(in lhs), uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                dinxx.shiftl(int64(in lhs), uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                dinxx.shiftl(uint64(in lhs), uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }

        public static Span256<T> shiftl<S,T>(in ReadOnlySpan256<T> lhs, in ReadOnlySpan256<S> shifts, in Span256<T> dst)
            where T : struct
            where S : struct
        {
            if(typeof(S) == typeof(int))
                dinxx.shiftl(int32(in lhs), uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                dinxx.shiftl(uint32(in lhs), uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                dinxx.shiftl(int64(in lhs), uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                dinxx.shiftl(uint64(in lhs), uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }
    }
}