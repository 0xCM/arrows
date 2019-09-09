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
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    
    using static zfunc;    

    public static class Vec1024
    {
        [MethodImpl(Inline)]
        public static Vec1024<T> Define<T>(in Vec256<T> v0, in Vec256<T> v1, in Vec256<T> v2, in Vec256<T> v3)        
            where T : struct
                => new Vec1024<T>(v0, v1, v2, v3);        

        [MethodImpl(Inline)]
        public static unsafe Span<T> Segment<T>(this ref Vec1024<T> src, int offset, int len)
            where T : struct
        {
            var askByteOffset = offset * Vec1024<T>.CellSize;
            var askByteCount = len * Vec1024<T>.CellSize;
            var haveByteCount = Pow2.T07 - askByteOffset;
            if(askByteCount > haveByteCount)
                throw Errors.TooManyBytes(askByteCount, haveByteCount);
            ref var dst = ref Unsafe.Add(ref src, offset);
            var pDst = Unsafe.AsPointer(ref dst);
            return new Span<T>(pDst,len);
        }
    }
}