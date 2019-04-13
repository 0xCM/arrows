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

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using X86 = System.Runtime.Intrinsics.X86;
    using NumVec = System.Numerics.Vector;

    using static zcore;

    

    public static class x86
    {
        [MethodImpl(Inline)]
        public static unsafe void copy<T>(IReadOnlyList<T> src, byte* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (byte)(object)(src[i]);                            
        }

        [MethodImpl(Inline)]
        public static unsafe void copy<T>(IReadOnlyList<T> src, sbyte* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (sbyte)(object)(src[i]);                            
        }        

        [MethodImpl(Inline)]
        public static unsafe void copy<T>(IReadOnlyList<T> src, short* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (short)(object)(src[i]);                            
        }

        [MethodImpl(Inline)]
        public static unsafe void copy<T>(IReadOnlyList<T> src, ushort* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (ushort)(object)(src[i]);                            
        }

        [MethodImpl(Inline)]
        public static unsafe void copy<T>(IReadOnlyList<T> src, int* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (int)(object)(src[i]);                            
        }

        [MethodImpl(Inline)]
        public static unsafe void copy<T>(IReadOnlyList<T> src, uint* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (uint)(object)(src[i]);                            
        }

        [MethodImpl(Inline)]
        public static unsafe void copy<T>(IReadOnlyList<T> src, long* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (long)(object)(src[i]);                            
        }

        [MethodImpl(Inline)]
        public static unsafe void copy<T>(IReadOnlyList<T> src, ulong* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (ulong)(object)(src[i]);                            
        }

        [MethodImpl(Inline)]
        public static unsafe void copy<T>(IReadOnlyList<T> src, float* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (float)(object)(src[i]);                            
        }

        [MethodImpl(Inline)]
        public static unsafe void copy<T>(IReadOnlyList<T> src, double* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (double)(object)(src[i]);                            
        }


    }
}