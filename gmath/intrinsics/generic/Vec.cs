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
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static mfunc;

    public static class Vec128X
    {

        [MethodImpl(Inline)]
        public static T Component<T>(this Vec128<T> src, int idx)
            where T : struct
        {
            ref T e0 = ref Unsafe.As<Vec128<T>, T>(ref src);
            return Unsafe.Add(ref e0, idx);
        }


        [MethodImpl(Inline)]
        public static Vec128<T> ToVec128<T>(this Vector128<T> src)
            where T : struct            
                => src;

        [MethodImpl(Inline)]
        public static Vector128<T> ToVector128<T>(this Vec128<T> src)
            where T : struct
                => src;

        [MethodImpl(Inline)]
        public static ref Span<T> Extract<T>(this Vec128<T> src, ref Span<T> dst)
            where T : struct
        {
            for(var i = 0; i< Vec128<T>.Length; i++)
                dst[i] = src.Component(i);
            return ref dst;
        }
                
    }
}