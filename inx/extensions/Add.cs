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

    partial class ginxs
    {
        /// <summary>
        /// Computes the sum of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Add<T>(in this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => ginx.add(in lhs,in rhs);

        /// <summary>
        /// Computes the sum of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Add<T>(in this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => ginx.add(in lhs,in rhs);

        [MethodImpl(Inline)]
        public static Span128<T> Add<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).Add(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).Add(uint8(rhs), uint8(dst));
            else if (typeof(T) == typeof(short))
                int16(lhs).Add(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).Add(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Add(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Add(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Add(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Add(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Add(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Add(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;        
        }

        [MethodImpl(Inline)]
        public static Span256<T> Add<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).Add(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).Add(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).Add(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).Add(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Add(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Add(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Add(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Add(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Add(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).And(float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;        
        } 
    }
}