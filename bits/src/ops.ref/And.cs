//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitRef
    {
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static Span<T> and<T>(in ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
                => and(lhs,in rhs, span<T>(length(lhs,rhs)));

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static Span<T> and<T>(Span<T> lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitRef.and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                BitRef.and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                BitRef.and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                BitRef.and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                BitRef.and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                BitRef.and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                BitRef.and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                BitRef.and(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return  lhs;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> and<T>(ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs, in Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                and(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                and(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                and(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                and(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                and(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                and(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                and(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                and(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                and(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                and(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Span<T> and<T>(in Span<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                and(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                and(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                and(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Memory<T> and<T>(in Memory<T> lhs, in ReadOnlyMemory<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                and(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                and(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                and(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        static Span<sbyte> and(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<byte> and(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        static Span<short> and(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        static Span<ushort> and(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        static Span<int> and(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        static Span<uint> and(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        static Span<long> and(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        static Span<ulong> and(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        static Span<float> and(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        static Span<double> and(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        static Span<sbyte> and(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        static Span<byte> and(Span<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        static Span<short> and(Span<short> lhs, ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        static Span<ushort> and(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        static Span<int> and(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        static Span<uint> and(Span<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        static Span<long> and(Span<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        static Span<ulong> and(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        static Span<sbyte> and(Span<sbyte> lhs, sbyte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        static Span<byte> and(Span<byte> lhs, byte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        static Span<short> and(Span<short> lhs, short rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        static Span<ushort> and(Span<ushort> lhs, ushort rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        static Span<int> and(Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        static Span<uint> and(Span<uint> lhs, uint rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        static Span<long> and(Span<long> lhs, long rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        static Span<ulong> and(Span<ulong> lhs, ulong rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }
 
        [MethodImpl(Inline)]
        static Span<byte> And(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => and(lhs, rhs, span<byte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<sbyte> And(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => and(lhs, rhs, span<sbyte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<short> And(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => and(lhs, rhs, span<short>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<ushort> And(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => and(lhs, rhs, span<ushort>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<int> And(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => and(lhs, rhs, span<int>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<uint> And(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => and(lhs, rhs, span<uint>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<long> And(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => and(lhs, rhs, span<long>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<ulong> And(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => and(lhs, rhs, span<ulong>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static Span<byte> And(this Span<byte> lhs, ReadOnlySpan<byte> rhs)
            => and(lhs, rhs);

        [MethodImpl(Inline)]
        static Span<sbyte> And(this Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => and(lhs, rhs);

        [MethodImpl(Inline)]
        static Span<short> And(this Span<short> lhs, ReadOnlySpan<short> rhs)
            => and(lhs, rhs);

        [MethodImpl(Inline)]
        static Span<ushort> And(this Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => and(lhs, rhs);

        [MethodImpl(Inline)]
        static Span<int> And(this Span<int> lhs, ReadOnlySpan<int> rhs)
            => and(lhs, rhs);

        [MethodImpl(Inline)]
        static Span<uint> And(this Span<uint> lhs, ReadOnlySpan<uint> rhs)
            => and(lhs, rhs);

        [MethodImpl(Inline)]
        static Span<long> And(this Span<long> lhs, ReadOnlySpan<long> rhs)
            => and(lhs, rhs);

        [MethodImpl(Inline)]
        static Span<ulong> And(this Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => and(lhs, rhs);

    }


}