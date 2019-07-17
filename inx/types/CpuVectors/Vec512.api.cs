//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static zfunc;    

    public static class Vec512
    {
        [MethodImpl(Inline)]
        public static Vec512<T> FromSpan<T>(Span<T> src)
            where T : struct
                => Unsafe.As<FixedBuffers.F512,Vec512<T>>(ref FixedBuffers.F512.FromSpan(src));

        [MethodImpl(Inline)]
        public static Vec512<T> Define<T>(in Vec256<T> v0, in Vec256<T> v1)        
            where T : struct
                => new Vec512<T>(v0, v1);

        [MethodImpl(Inline)]
        public static Vec512<T> Define<T>(in Vector256<T> v0, in Vector256<T> v1)        
            where T : struct
                => new Vec512<T>(v0, v1);

        [MethodImpl(Inline)]
        public static ref Vec256<T> At<T>(this ref Vec512<T> src, int index)
            where T : struct
        {
            if(index == 0)
                return ref src.v0;
            else if(index == 1)
                return ref src.v1;
            else
                throw Errors.OutOfRange(index, 0, 1);
        }

        [MethodImpl(Inline)]
        public static ref readonly Vec256<T> Lo<T>(this in Vec512<T> src)
            where T : struct
                => ref src.v0;

        [MethodImpl(Inline)]
        public static ref readonly Vec256<T> Hi<T>(this in Vec512<T> src)
            where T : struct
                => ref src.v1;

        [MethodImpl(Inline)]
        public static unsafe Span<T> Segment<T>(this ref Vec512<T> src, int offset, int len)
            where T : struct
        {
            var askByteOffset = offset * Vec512<T>.CellSize;
            var askByteCount = len * Vec512<T>.CellSize;
            var haveByteCount = Vec512<T>.ByteCount - askByteOffset;
            if(askByteCount > haveByteCount)
                throw Errors.TooManyBytes(askByteCount, haveByteCount);
            ref var dst = ref Unsafe.Add(ref src, offset);
            var pDst = Unsafe.AsPointer(ref dst);
            return new Span<T>(pDst,len);
        }
    }
}