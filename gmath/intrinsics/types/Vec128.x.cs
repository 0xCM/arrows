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

    using static zcore;

    public static class Vec128X
    {

        [MethodImpl(Inline)]
        public static T Component<T>(this Vec128<T> src, int idx)
            where T : struct, IEquatable<T>
        {
            ref T e0 = ref Unsafe.As<Vec128<T>, T>(ref src);
            return Unsafe.Add(ref e0, idx);
        }


        [MethodImpl(Inline)]
        public static Vec128<T> ToVec128<T>(this Vector128<T> src)
            where T : struct, IEquatable<T>            
                => src;

        [MethodImpl(Inline)]
        public static Vector128<T> ToVector128<T>(this Vec128<T> src)
            where T : struct, IEquatable<T>
                => src;

        [MethodImpl(Inline)]
        public unsafe static T[] ToArray<T>(this Vec128<T> src)
                where T : struct, IEquatable<T>
        {      
            var dst = new T[Vec128<T>.Length];
            for(var i = 0; i < Vec128<T>.Length; i++)
                dst[i] = src.Component(i);
            return dst;

        } 
    }
}