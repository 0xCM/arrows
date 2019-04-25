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
    using static inxfunc;

    partial class InXX    
    {

        [MethodImpl(Inline)]
        public static T Component<T>(this Vec128<T> src, int idx)
            where T : struct, IEquatable<T>
        {
            ref T e0 = ref Unsafe.As<Vec128<T>, T>(ref src);
            return Unsafe.Add(ref e0, idx);
        }

        [MethodImpl(Inline)]
        public static Vec128<byte> AsByte<T>(this Vec128<T> src)
            where T : struct, IEquatable<T>
                => src.As<byte>();

        [MethodImpl(Inline)]
        public static Vec128<double> AsDouble<T>(this Vec128<T> src)
            where T : struct, IEquatable<T>
                => src.As<double>();

        [MethodImpl(Inline)]
        public static Vec128<float> AsSingle<T>(this Vec128<T> src)
            where T : struct, IEquatable<T>
                => src.As<float>();

        [MethodImpl(Inline)]
        public static Vec128<ulong> AsUInt64<T>(this Vec128<T> src)
            where T : struct, IEquatable<T>
                => src.As<ulong>();        


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
        
        [MethodImpl(Inline)]
        public static Vec128<sbyte> NextVec128(this IEnumerable<sbyte> src)
            => Vec128.single(src.Freeze(Vec128<sbyte>.Length));

        [MethodImpl(Inline)]
        public static Vec128<short> NextVec128(this IEnumerable<short> src)
                => Vec128.single(src.Freeze(Vec128<short>.Length));

        [MethodImpl(Inline)]
        public static Vec128<ushort> NextVec128(this IEnumerable<ushort> src)
                => Vec128.single(src.Freeze(Vec128<ushort>.Length));

        [MethodImpl(Inline)]
        public static Vec128<int> NextVec128(this IEnumerable<int> src)
                => Vec128.single(src.Freeze(Vec128<int>.Length));

        [MethodImpl(Inline)]
        public static Vec128<int> ToVec128(this int[] src)
                => Vec128.single<int>(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> NextVec128(this IEnumerable<uint> src)
                => Vec128.single(src.Freeze(Vec128<uint>.Length));

        [MethodImpl(Inline)]
        public static Vec128<uint> ToVec128(this uint[] src)
                => Vec128.single<uint>(src);

        [MethodImpl(Inline)]
        public static Vec128<long> NextVec128(this IEnumerable<long> src)
                => Vec128.single(src.Freeze(Vec128<long>.Length));

        [MethodImpl(Inline)]
        public static Vec128<ulong> NextVec128(this IEnumerable<ulong> src)
                => Vec128.single(src.Freeze(Vec128<ulong>.Length));

        [MethodImpl(Inline)]
        public static Vec128<ulong> ToVec128(this ulong[] src)
                => Vec128.single<ulong>(src);

        [MethodImpl(Inline)]
        public static Vec128<float> NextVec128(this IEnumerable<float> src)
                => Vec128.single(src.Freeze(Vec128<float>.Length));

        [MethodImpl(Inline)]
        public static Vec128<double> NextVec128(this IEnumerable<double> src)
                => Vec128.single(src.Freeze(Vec128<double>.Length));
    }
}