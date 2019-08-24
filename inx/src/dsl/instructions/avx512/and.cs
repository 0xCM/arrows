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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static As;
    using static zfunc;

    partial class Avx512
    {
        [MethodImpl(Inline)]
        public static Vec512<T> and<T>(in Vec512<T> lhs, in Vec512<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(and(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(and(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(and(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(and(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(and(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(and(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(and(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(and(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(and(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(and(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vec512<byte> and(in Vec512<byte> lhs, in Vec512<byte> rhs)        
            => Vec512.FromParts(And(lhs.Lo(), rhs.Lo()), And(lhs.Hi(), rhs.Hi()));
                
        [MethodImpl(Inline)]
        public static Vec512<short> and(in Vec512<short> lhs, in Vec512<short> rhs)
            => Vec512.FromParts(And(lhs.Lo(), rhs.Lo()), And(lhs.Hi(), rhs.Hi()));

        [MethodImpl(Inline)]
        public static Vec512<sbyte> and(in Vec512<sbyte> lhs, in Vec512<sbyte> rhs)
            => Vec512.FromParts(And(lhs.Lo(), rhs.Lo()), And(lhs.Hi(), rhs.Hi()));

        [MethodImpl(Inline)]
        public static Vec512<ushort> and(in Vec512<ushort> lhs, in Vec512<ushort> rhs)
            => Vec512.FromParts(And(lhs.Lo(), rhs.Lo()), And(lhs.Hi(), rhs.Hi()));

        [MethodImpl(Inline)]
        public static Vec512<int> and(in Vec512<int> lhs, in Vec512<int> rhs)
            => Vec512.FromParts(And(lhs.Lo(), rhs.Lo()), And(lhs.Hi(), rhs.Hi()));

        [MethodImpl(Inline)]
        public static Vec512<uint> and(in Vec512<uint> lhs, in Vec512<uint> rhs)
            => Vec512.FromParts(And(lhs.Lo(), rhs.Lo()), And(lhs.Hi(), rhs.Hi()));

        [MethodImpl(Inline)]
        public static Vec512<long> and(in Vec512<long> lhs, in Vec512<long> rhs)
            => Vec512.FromParts(And(lhs.Lo(), rhs.Lo()), And(lhs.Hi(), rhs.Hi()));

        [MethodImpl(Inline)]
        public static Vec512<ulong> and(in Vec512<ulong> lhs, in Vec512<ulong> rhs)
            => Vec512.FromParts(And(lhs.Lo(), rhs.Lo()), And(lhs.Hi(), rhs.Hi()));

        [MethodImpl(Inline)]
        public static Vec512<float> and(in Vec512<float> lhs, in Vec512<float> rhs)
            => Vec512.FromParts(And(lhs.Lo(), rhs.Lo()), And(lhs.Hi(), rhs.Hi()));

        [MethodImpl(Inline)]
        public static Vec512<double> and(in Vec512<double> lhs, in Vec512<double> rhs)
            => Vec512.FromParts(And(lhs.Lo(), rhs.Lo()), And(lhs.Hi(), rhs.Hi()));

    }
}